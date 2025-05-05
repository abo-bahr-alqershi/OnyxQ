namespace ERP_Pro.Shared.Constants;

public static class CacheKeys
{
    private const string Prefix = "erp_pro";

    public static class Common
    {
        private const string Group = $"{Prefix}:common";
        public const string Lookups = $"{Group}:lookups";
        public const string Settings = $"{Group}:settings";
        public const string Permissions = $"{Group}:permissions";
    }

    public static class User
    {
        private const string Group = $"{Prefix}:user";
        public const string Info = $"{Group}:info";
        public const string Preferences = $"{Group}:preferences";
        public const string Permissions = $"{Group}:permissions";
    }

    public static class Tenant
    {
        private const string Group = $"{Prefix}:tenant";
        public const string Settings = $"{Group}:settings";
        public const string Features = $"{Group}:features";
    }

    public static string GetKey(string group, string key) => $"{Prefix}:{group}:{key}";
    
    public static string GetEntityKey<T>(string id) where T : class
        => $"{Prefix}:{typeof(T).Name.ToLower()}:{id}";
} 