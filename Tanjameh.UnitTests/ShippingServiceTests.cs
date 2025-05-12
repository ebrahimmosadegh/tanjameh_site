using Moq;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Core.Interfaces;
using Tanjameh.Infrastructure.Data;
using Tanjameh.Infrastructure.Services;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace Tanjameh.UnitTests;

// Simplified MockDbSetHelper for InMemory provider
public static class MockDbSetHelper
{
    public static Mock<DbSet<T>> CreateMockDbSet<T>(IQueryable<T> data) where T : class
    {
        var mockSet = new Mock<DbSet<T>>();
        mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
        mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
        mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
        mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());

        // Mock FindAsync based on primary key (assuming int Id)
        // This basic mock works for simple cases. For more complex scenarios, consider a real InMemory database.
        mockSet.Setup(m => m.FindAsync(It.IsAny<object[]>()))
               .ReturnsAsync((object[] ids) => data.FirstOrDefault(d => GetId(d) == (int)ids[0]));

        // Mock AddRange, RemoveRange etc. if needed
        mockSet.Setup(m => m.Add(It.IsAny<T>())).Callback<T>((s) => ((List<T>)data).Add(s));

        return mockSet;
    }

    private static int GetId<T>(T entity) where T : class
    {
        var idProperty = typeof(T).GetProperty("Id");
        if (idProperty != null && idProperty.PropertyType == typeof(int))
        {
            return (int)idProperty.GetValue(entity);
        }
        // Add long support if needed
        if (idProperty != null && idProperty.PropertyType == typeof(long))
        {
            return (int)(long)idProperty.GetValue(entity);
        }
        throw new NotSupportedException("Entity does not have an accessible Id property of type int or long.");
    }
}

// Removed TestAsyncQueryProvider, TestAsyncEnumerable, TestAsyncEnumerator as they are often not needed with InMemory provider
// and were causing compilation errors with missing IDbAsync interfaces.

public class ShippingServiceTests
{
    private readonly Mock<ApplicationDbContext> _mockContext;
    private readonly ShippingService _shippingService;
    private readonly Mock<DbSet<ShippingMethod>> _mockShippingMethodsSet;
    private readonly List<ShippingMethod> _shippingMethodsData; // Hold data for manipulation

    public ShippingServiceTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: $"TanjamehShippingTestDb_{Guid.NewGuid()}")
            .Options;
        _mockContext = new Mock<ApplicationDbContext>(options);

        // Seed data
        _shippingMethodsData = new List<ShippingMethod>
        {
            new ShippingMethod { Id = 1, Name = "Standard", Cost = 5.0m, IsEnabled = true },
            new ShippingMethod { Id = 2, Name = "Express", Cost = 15.0m, IsEnabled = true },
            new ShippingMethod { Id = 3, Name = "Disabled", Cost = 10.0m, IsEnabled = false }
        };

        _mockShippingMethodsSet = MockDbSetHelper.CreateMockDbSet(_shippingMethodsData.AsQueryable());
        _mockContext.Setup(c => c.ShippingMethods).Returns(_mockShippingMethodsSet.Object);

        // Mock FirstOrDefaultAsync behavior for CalculateShippingCostAsync
        // This requires mocking the extension method, which is complex.
        // A simpler way for testing is to use the actual InMemory database context directly
        // instead of mocking ApplicationDbContext and DbSet when using UseInMemoryDatabase.

        // Let's switch to using a real InMemory context for simplicity and better testing of async LINQ.
        var realContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: $"TanjamehShippingTestDb_Real_{Guid.NewGuid()}")
            .Options;
        var realContext = new ApplicationDbContext(realContextOptions);
        realContext.ShippingMethods.AddRange(_shippingMethodsData);
        realContext.SaveChanges();

        // Use the real context instance for the service
        _shippingService = new ShippingService(realContext);
    }

    [Fact]
    public async Task GetAvailableShippingMethodsAsync_ShouldReturnOnlyEnabledMethods()
    {
        // Arrange
        var dummyAddress = new Address();
        var dummyItems = new List<OrderItem>();

        // Act
        // Service now uses the real InMemory context
        var result = await _shippingService.GetAvailableShippingMethodsAsync(dummyAddress, dummyItems);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(2, result.Count);
        Assert.Contains(result, sm => sm.Name == "Standard");
        Assert.Contains(result, sm => sm.Name == "Express");
        Assert.DoesNotContain(result, sm => sm.Name == "Disabled");
    }

    [Fact]
    public async Task CalculateShippingCostAsync_WithValidEnabledMethod_ShouldReturnCorrectCost()
    {
        // Arrange
        // Fetch the method from the actual data used by the context
        var selectedMethod = _shippingMethodsData.First(sm => sm.Id == 1);
        var dummyAddress = new Address();
        var dummyItems = new List<OrderItem>();

        // Act
        var cost = await _shippingService.CalculateShippingCostAsync(selectedMethod, dummyAddress, dummyItems);

        // Assert
        Assert.Equal(5.0m, cost);
    }

    [Fact]
    public async Task CalculateShippingCostAsync_WithValidDisabledMethod_ShouldThrowArgumentException()
    {
        // Arrange
        var selectedMethod = _shippingMethodsData.First(sm => sm.Id == 3); // Disabled method
        var dummyAddress = new Address();
        var dummyItems = new List<OrderItem>();

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(() =>
            _shippingService.CalculateShippingCostAsync(selectedMethod, dummyAddress, dummyItems));
    }

    [Fact]
    public async Task CalculateShippingCostAsync_WithInvalidMethodId_ShouldThrowArgumentException()
    {
        // Arrange
        var selectedMethod = new ShippingMethod { Id = 99, Name = "NonExistent", Cost = 0m }; // Does not exist in context
        var dummyAddress = new Address();
        var dummyItems = new List<OrderItem>();

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(() =>
            _shippingService.CalculateShippingCostAsync(selectedMethod, dummyAddress, dummyItems));
    }
}

