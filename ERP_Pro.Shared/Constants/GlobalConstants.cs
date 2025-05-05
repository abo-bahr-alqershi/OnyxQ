namespace ERP_Pro.Shared.Constants;

public static class GlobalConstants
{
    public static class System
    {
        public const string ApplicationName = "ERP Pro";
        public const string DefaultLanguage = "ar-SA";
        public const string DefaultCulture = "ar-SA";
        public const string DefaultTimeZone = "Arab Standard Time";
        public const string DateFormat = "dd/MM/yyyy";
        public const string TimeFormat = "HH:mm:ss";
        public const string DateTimeFormat = "dd/MM/yyyy HH:mm:ss";
    }

    public static class Security
    {
        public const string AdminRole = "Administrator";
        public const string DefaultPassword = "P@ssw0rd123";
        public const int PasswordMinLength = 8;
        public const int MaxLoginAttempts = 5;
        public const int LockoutDurationMinutes = 30;
    }

    public static class Validation
    {
        public const int MinNameLength = 3;
        public const int MaxNameLength = 100;
        public const int MaxDescriptionLength = 500;
        public const int MaxEmailLength = 256;
        public const int MaxPhoneLength = 20;
        public const string EmailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public const string PhoneRegex = @"^\+?[1-9]\d{1,14}$";
    }

    public static class Pagination
    {
        public const int DefaultPageSize = 10;
        public const int MaxPageSize = 100;
        public const int DefaultPage = 1;
    }

    public static class Cache
    {
        public const int DefaultExpirationMinutes = 60;
        public const int LongExpirationHours = 24;
        public const int ShortExpirationMinutes = 5;
    }
} 