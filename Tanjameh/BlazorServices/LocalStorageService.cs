namespace Tanjameh.BlazorServices;

using Microsoft.JSInterop;
using System.Text.Json;

public interface ILocalStorageService
{
    Task<T> GetItemAsync<T>(string key);
    Task SetItemAsync<T>(string key, T value);
    Task RemoveItemAsync(string key);
}

public class LocalStorageService : ILocalStorageService
{
    private readonly IJSRuntime _jsRuntime;
    private readonly bool _isServer;

    public LocalStorageService(IJSRuntime jsRuntime, bool isServer)
    {
        _jsRuntime = jsRuntime;
        _isServer = isServer;
    }

    public async Task<T> GetItemAsync<T>(string key)
    {
        if (_isServer) return default;

        var json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);

        if (json == null)
            return default;

        return JsonSerializer.Deserialize<T>(json);
    }

    public async Task SetItemAsync<T>(string key, T value)
    {
        if (_isServer) return;

        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));
    }

    public async Task RemoveItemAsync(string key)
    {
        if (_isServer) return;

        await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
    }
}