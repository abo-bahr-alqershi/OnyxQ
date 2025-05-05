namespace ERP_Pro.Infrastructure.Shared.Services.Cache;

public interface ICacheService
{
    Task<T?> GetAsync<T>(string key);
    Task<T> GetAsync<T>(string key, Func<Task<T>> factory, TimeSpan? expiration = null);
    Task SetAsync<T>(string key, T value, TimeSpan? expiration = null);
    Task RemoveAsync(string key);
    Task RemoveByPrefixAsync(string prefixKey);
    Task<bool> ExistsAsync(string key);
    Task<long> IncrementAsync(string key);
    Task<long> DecrementAsync(string key);
} 