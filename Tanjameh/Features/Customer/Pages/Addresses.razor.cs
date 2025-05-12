using Microsoft.AspNetCore.Components;
using Tanjameh.Core.Entities;
using Tanjameh.Features.Customer.Services;

namespace Tanjameh.Features.Customer.Pages;

public partial class Addresses : ComponentBase
{
    
    [Inject]
    private CustomerService CustomerService { get; set; }
    
    private List<CustomerAddress> addresses;
    
    [SupplyParameterFromForm]
    private CustomerAddress currentAddress { get; set; }= new();
    
    private CustomerAddress? editingAddress;

    private bool showAddressModal = false;
    private bool showDeleteModal = false;
    
    protected override async Task OnInitializedAsync()
    {
        await LoadAddresses();
    }

    private async Task LoadAddresses()
    {
        try
        {
            addresses = await CustomerService.GetCustomerAddressesAsync();
        }
        catch (Exception)
        {
            // Handle error
            addresses = new List<CustomerAddress>();
        }
    }

    private async Task HandleSubmit()
    {
        try
        {
            if (editingAddress?.Id > 0)
            {
               await CustomerService.UpdateCustomerAddressAsync(currentAddress, editingAddress.Id);
            }
            else
            {
               await CustomerService.AddCustomerAddressAsync(currentAddress);
            }
            await LoadAddresses();
            
            showAddressModal = false;
            ResetForm();
        }
        catch (Exception)
        {
            // Handle error
        }
    }

    private async Task DeleteAddress(int id)
    {
        try
        {
           await CustomerService.DeleteCustomerAddressAsync(id);
            await LoadAddresses();
            
            showDeleteModal = false;
        }
        catch (Exception)
        {
            // Handle error
        }
    }

    private async Task SetDefaultAddress(int id)
    {
        try
        {
            await CustomerService.SetDefaultCustomerAddressAsync(id);
            await LoadAddresses();
        }
        catch (Exception)
        {
            // Handle error
        }
    }



    private void CancelEdit()
    {
        ResetForm();
    }

    private void ResetForm()
    {
        editingAddress = null;
        currentAddress = new CustomerAddress();
    }

    private void CloseModal()
    {
       showAddressModal = false;
    }

    private void CloseDeleteModal()
    {
        showDeleteModal = false;
    }



    private Task ShowEditModal(CustomerAddress address)
    {
        editingAddress = address;
        currentAddress = new CustomerAddress
        {
            Id = address.Id,
            Address = address.Address,
            City = address.City,
            Country = address.Country,
            ZipCode = address.ZipCode,
            LatinAddress = address.LatinAddress,
            LatinCity = address.LatinCity
        };
        showAddressModal = true;
        return Task.CompletedTask;
    }
    
    private Task ShowAddressModal()
    {
        showAddressModal = true;
        currentAddress = new CustomerAddress();
        return Task.CompletedTask;
    }

    private int deleteAddressId = 0;
    private Task ShowDeleteConfirm(int addressId)
    {
        deleteAddressId = addressId;
        showDeleteModal = true;
        return Task.CompletedTask;
    }
    
    private async Task ConfirmDelete()
    {
        await DeleteAddress(deleteAddressId);
    }


}