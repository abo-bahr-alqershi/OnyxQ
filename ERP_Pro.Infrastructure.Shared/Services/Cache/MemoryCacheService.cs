using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using ERP_Pro.Shared.Constants;

namespace ERP_Pro.Infrastructure.Shared.Services.Cache;

public class MemoryCacheService : ICacheService
{
    private readonly IMemoryCache _cache;
    private readonly ILogger<MemoryCacheService> _logger;

    public MemoryCacheService(IMemoryCache cache, ILogger<MemoryCacheService> logger)
    {
        _cache = cache;
        _logger = logger;
    }

    public Task<T?> GetAsync<T>(string key)
    {
        try
        {
            var value = _cache.Get<T>(key);
            return Task.FromResult(value);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting value for key {Key} from cache", key);
            return Task.FromResult<T?>(default);
        }
    }

    public async Task<T> GetAsync<T>(string key, Func<Task<T>> factory, TimeSpan? expiration = null)
    {
        try
        {
            if (_cache.TryGetValue(key, out T? cachedValue))
                return cachedValue!;

            var value = await factory();
            await SetAsync(key, value, expiration);
            return value;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting or setting value for key {Key} from cache", key);
            return await factory();
        }
    }

    public Task SetAsync<T>(string key, T value, TimeSpan? expiration = null)
    {
        try
        {
            var options = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expiration ?? TimeSpan.FromMinutes(GlobalConstants.Cache.DefaultExpirationMinutes)
            };

            _cache.Set(key, value, options);
            return Task.CompletedTask;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error setting value for key {Key} in cache", key);
            return Task.CompletedTask;
        }
    }

    public Task RemoveAsync(string key)
    {
        try
        {
            _cache.Remove(key);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error removing key {Key} from cache", key);
        }
        return Task.CompletedTask;
    }

    public Task RemoveByPrefixAsync(string prefixKey)
    {
        // Note: This is a limitation of IMemoryCache, we can't easily remove by prefix
        _logger.LogWarning("RemoveByPrefix is not supported in MemoryCache");
        return Task.CompletedTask;
    }

    public Task<bool> ExistsAsync(string key)
    {
        return Task.FromResult(_cache.TryGetValue(key, out _));
    }

    public Task<long> IncrementAsync(string key)
    {
        try
        {
            long value = _cache.GetOrCreate(key, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(GlobalConstants.Cache.DefaultExpirationMinutes);
                return 0L;
            });

            value++;
            _cache.Set(key, value);
            return Task.FromResult(value);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error incrementing value for key {Key} in cache", key);
            return Task.FromResult(0L);
        }
    }

    public Task<long> DecrementAsync(string key)
    {
        try
        {
            long value = _cache.GetOrCreate(key, entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(GlobalConstants.Cache.DefaultExpirationMinutes);
                return 0L;
            });

            value--;
            _cache.Set(key, value);
            return Task.FromResult(value);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error decrementing value for key {Key} in cache", key);
            return Task.FromResult(0L);
        }
    }
} 