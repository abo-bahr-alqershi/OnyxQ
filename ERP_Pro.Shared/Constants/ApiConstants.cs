namespace ERP_Pro.Shared.Constants;

public static class ApiConstants
{
    public static class ContentTypes
    {
        public const string ApplicationJson = "application/json";
        public const string MultipartFormData = "multipart/form-data";
    }

    public static class Headers
    {
        public const string Authorization = "Authorization";
        public const string Bearer = "Bearer";
        public const string Accept = "Accept";
        public const string AcceptLanguage = "Accept-Language";
        public const string ContentType = "Content-Type";
    }

    public static class Versions
    {
        public const string V1 = "1.0";
        public const string V2 = "2.0";
        public const string Current = V1;
    }

    public static class Routes
    {
        public const string BaseApi = "api/v{version:apiVersion}/[controller]";
        public const string Id = "{id}";
    }

    public static class Patterns
    {
        public const string YearMonth = "yyyy-MM";
        public const string Date = "yyyy-MM-dd";
        public const string DateTime = "yyyy-MM-dd HH:mm:ss";
    }
} 