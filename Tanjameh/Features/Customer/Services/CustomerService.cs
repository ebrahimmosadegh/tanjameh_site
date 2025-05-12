using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Tanjameh.Core.Entities;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.Features.Customer.Services;

public class CustomerService
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    private readonly AuthenticationStateProvider _authStateProvider;

    public CustomerService(IDbContextFactory<ApplicationDbContext> dbContextFactory,
        AuthenticationStateProvider authStateProvider)
    {
        _dbContextFactory = dbContextFactory;
        _authStateProvider = authStateProvider;
    }

    public async Task<Core.Entities.Customer> CreateCustomerAsync(Core.Entities.Customer customer)
    {
        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            context.Customers.Add(customer);
            await context.SaveChangesAsync();
            return customer;
        }
    }

    public async Task<Core.Entities.Customer?> GetCustomerByUserIdAsync(long userId)
    {
        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            return await context.Customers.FirstOrDefaultAsync(c => c.UserId == userId);
        }
    }

    public async Task<CustomerAddress> AddCustomerAddressAsync(CustomerAddress address, long? userId = null)
    {
        if (userId == null)
            userId = await GetUserId();

        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            var customer = await GetCustomerByUserIdAsync(userId.Value);
            if (customer == null)
                throw new Exception("Customer not found");

            address.CustomerId = customer.Id;
            context.CustomerAddress.Add(address);
            await context.SaveChangesAsync();
            return address;
        }
    }

    public async Task<CustomerAddress?> GetCustomerAddressAsync(long addressId, long? userId = null)
    {
        if (userId == null)
            userId = await GetUserId();
        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            return await context.CustomerAddress
                .FirstOrDefaultAsync(a => a.Id == addressId && a.Customer.UserId == userId);
        }
    }

    public async Task<List<CustomerAddress>> GetCustomerAddressesAsync(long? userId = null)
    {
        if (userId == null)
            userId = await GetUserId();
        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            return await context.CustomerAddress
                .Where(a => a.Customer.UserId == userId)
                .ToListAsync();
        }
    }

    public async Task<CustomerAddress> UpdateCustomerAddressAsync(CustomerAddress address, int edittingAddressId, long? userId = null)
    {
        if (userId == null)
            userId = await GetUserId();
        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            var existingAddress = await GetCustomerAddressAsync(edittingAddressId, userId);
            if (existingAddress == null)
                throw new Exception("Address not found or unauthorized");
            existingAddress.LastModify = DateTime.UtcNow;

            existingAddress.Address = address.Address;
            existingAddress.City = address.City;
            existingAddress.Country = address.Country;
            existingAddress.ZipCode = address.ZipCode;
            existingAddress.IsDefault = address.IsDefault;
            existingAddress.LatinCity = address.LatinCity;
            existingAddress.LatinAddress = address.LatinAddress;

            await context.SaveChangesAsync();
            return existingAddress;
        }
    }    public async Task<bool> DeleteCustomerAddressAsync(long addressId, long? userId = null)
    {
        if (userId == null)
            userId = await GetUserId();
        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            var address = await GetCustomerAddressAsync(addressId, userId);
            if (address == null)
                return false;

            context.CustomerAddress.Remove(address);
            await context.SaveChangesAsync();
            return true;
        }
    }
    
    public async Task<bool> SetDefaultCustomerAddressAsync(long addressId, long? userId = null)
    {
        if (userId == null)
            userId = await GetUserId();
        using (var context = await _dbContextFactory.CreateDbContextAsync())
        {
            var address = await GetCustomerAddressAsync(addressId, userId);
            if (address == null)
                return false;

            var defaultAddress = (await GetCustomerAddressesAsync()).FirstOrDefault(a => a.IsDefault);
            if (defaultAddress != null)
                defaultAddress.IsDefault = false;
            
            address.IsDefault = true;
            await context.SaveChangesAsync();
            return true;
        }
    }

    private async Task<long?> GetUserId()
    {
        var authState = await _authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            var userId = long.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            return userId;
        }

        return null;
    }
}