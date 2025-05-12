using Moq;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Infrastructure.Services;
using Xunit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tanjameh.Core.Enums;

namespace Tanjameh.UnitTests;

public class OrderServiceTests
{
    private readonly Mock<IDbContextFactory<ApplicationDbContext>> _mockContextFactory;
    private readonly Mock<ApplicationDbContext> _mockContext;
    private readonly Mock<IShippingService> _mockShippingService;
    private readonly Mock<IPaymentService> _mockPaymentService;
    private readonly OrderService _orderService;

    // Helper to mock DbSet
    private static Mock<DbSet<T>> CreateMockDbSet<T>(IQueryable<T> data) where T : class
    {
        var mockSet = new Mock<DbSet<T>>();
        mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
        mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
        mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
        mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
        mockSet.Setup(m => m.Add(It.IsAny<T>())).Callback<T>((s) => ((List<T>)data).Add(s));
        // Add other DbSet methods as needed (FindAsync, Remove, etc.)
        mockSet.Setup(m => m.FindAsync(It.IsAny<object[]>()))
               .ReturnsAsync((object[] ids) => data.FirstOrDefault(d => GetId(d) == (int)ids[0])); // Simple FindAsync mock assuming int ID

        return mockSet;
    }

    // Helper to get ID from entity (adjust based on BaseEntity or specific ID property)
    private static int GetId<T>(T entity) where T : class
    {
        // This is a simplification. You might need a more robust way based on your BaseEntity or conventions.
        var idProperty = typeof(T).GetProperty("Id");
        if (idProperty != null && idProperty.PropertyType == typeof(int))
        {
            return (int)idProperty.GetValue(entity);
        }
         if (idProperty != null && idProperty.PropertyType == typeof(long))
        {
            return (int)(long)idProperty.GetValue(entity); // Cast long to int for FindAsync mock
        }
        throw new NotSupportedException("Entity does not have an accessible 'Id' property of type int or long.");
    }


    public OrderServiceTests()
    {
        // Mock DbContext and Factory
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: $"TanjamehTestDb_{Guid.NewGuid()}") // Use unique name per test run
            .Options;
        _mockContext = new Mock<ApplicationDbContext>(options);
        _mockContextFactory = new Mock<IDbContextFactory<ApplicationDbContext>>();
        _mockContextFactory.Setup(f => f.CreateDbContextAsync(It.IsAny<CancellationToken>()))
                           .ReturnsAsync(_mockContext.Object);

        // Mock Services
        _mockShippingService = new Mock<IShippingService>();
        _mockPaymentService = new Mock<IPaymentService>();

        // Setup Mock DbSets (initially empty or with seed data)
        var orders = new List<Order>();
        // Corrected Address properties based on Address.cs
        var addresses = new List<Address> { new Address { Id = 1, UserId = 1, FullName = "Test User", StreetAddress = "123 Main St", City = "Testville", StateProvince = "TS", PostalCode = "12345", Country = "Testland", PhoneNumber = "555-1234" } };
        var mockOrdersSet = CreateMockDbSet(orders.AsQueryable());
        var mockAddressesSet = CreateMockDbSet(addresses.AsQueryable());

        _mockContext.Setup(c => c.Orders).Returns(mockOrdersSet.Object);
        _mockContext.Setup(c => c.Addresses).Returns(mockAddressesSet.Object);
        _mockContext.Setup(c => c.SaveChangesAsync(It.IsAny<CancellationToken>())).ReturnsAsync(1); // Simulate successful save


        // Instantiate the service under test
        _orderService = new OrderService(_mockContext.Object, _mockShippingService.Object, _mockPaymentService.Object);
    }

    [Fact]
    public async Task CreateOrderAsync_WithEmptyItemList_ShouldReturnNull()
    {
        // Arrange
        var userId = 1L;
        var shippingAddressId = 1;
        var items = new List<OrderItem>(); // Empty list

        // Act
        var result = await _orderService.CreateOrderAsync(userId, shippingAddressId, null, items);

        // Assert
        Assert.Null(result);
        _mockContext.Verify(c => c.Orders.Add(It.IsAny<Order>()), Times.Never); // Ensure order was not added
        _mockContext.Verify(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Never); // Ensure SaveChanges was not called
    }

    [Fact]
    public async Task CreateOrderAsync_WithValidInput_ShouldCreateOrderAndPaymentIntent()
    {
        // Arrange
        var userId = 1L;
        var shippingAddressId = 1;
        // Corrected OrderItem property: Assuming ProductVariantId exists
        var items = new List<OrderItem>
        {
            new OrderItem { ProductId = 1, ProductVariantId = 1, Quantity = 1, PriceAtTimeOfOrder = 10.0m }
        };
        var shippingMethods = new List<ShippingMethod>
        {
            new ShippingMethod { Id = 1, Name = "Standard", Cost = 5.0m }
        };
        var expectedShippingCost = 5.0m;
        var expectedSubtotal = 10.0m;
        var expectedTotal = expectedSubtotal + expectedShippingCost;
        var paymentIntent = new Stripe.PaymentIntent { Id = "pi_test_123", ClientSecret = "pi_test_123_secret" };

        _mockShippingService.Setup(s => s.GetAvailableShippingMethodsAsync(It.IsAny<Address>(), It.IsAny<List<OrderItem>>()))
                            .ReturnsAsync(shippingMethods);
        _mockShippingService.Setup(s => s.CalculateShippingCostAsync(It.IsAny<ShippingMethod>(), It.IsAny<Address>(), It.IsAny<List<OrderItem>>()))
                            .ReturnsAsync(expectedShippingCost);
        _mockPaymentService.Setup(p => p.CreateOrUpdatePaymentIntent(It.IsAny<Order>()))
                           .ReturnsAsync(paymentIntent);

        // Act
        var result = await _orderService.CreateOrderAsync(userId, shippingAddressId, null, items);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(userId, result.UserId);
        Assert.Equal(shippingAddressId, result.ShippingAddressId);
        Assert.Equal(expectedSubtotal, result.Subtotal);
        Assert.Equal(expectedShippingCost, result.ShippingCost);
        Assert.Equal(expectedTotal, result.TotalAmount);
        Assert.Equal(OrderStatus.Pending, result.Status);
        Assert.Single(result.OrderItems);
        Assert.Equal(paymentIntent.Id, result.PaymentIntentId);

        _mockContext.Verify(c => c.Orders.Add(It.IsAny<Order>()), Times.Once); // Ensure order was added
        _mockContext.Verify(c => c.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once); // Ensure SaveChanges was called
        _mockPaymentService.Verify(p => p.CreateOrUpdatePaymentIntent(It.IsAny<Order>()), Times.Once); // Ensure payment intent was created
    }

    // TODO: Add more tests for GetOrderByIdAsync, GetOrdersForUserAsync
    // TODO: Add tests for edge cases (invalid address ID, no shipping methods, payment intent failure, DB save failure)
}

