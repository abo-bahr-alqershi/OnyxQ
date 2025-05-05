using System.Text.RegularExpressions;
using ERP_Pro.Shared.Constants;

namespace ERP_Pro.Infrastructure.Shared.Validation.Rules;

public static class ValidationRules
{
    public static class Common
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                return Regex.IsMatch(email, GlobalConstants.Validation.EmailRegex,
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            try
            {
                return Regex.IsMatch(phoneNumber, GlobalConstants.Validation.PhoneRegex,
                    RegexOptions.None, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return name.Length >= GlobalConstants.Validation.MinNameLength &&
                   name.Length <= GlobalConstants.Validation.MaxNameLength;
        }

        public static bool IsValidDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return true; // Description can be empty

            return description.Length <= GlobalConstants.Validation.MaxDescriptionLength;
        }
    }

    public static class Security
    {
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            return password.Length >= GlobalConstants.Security.PasswordMinLength &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
    }

    public static class Business
    {
        public static bool IsValidAmount(decimal amount)
        {
            return amount >= 0 && amount <= decimal.MaxValue;
        }

        public static bool IsValidQuantity(int quantity)
        {
            return quantity >= 0 && quantity <= int.MaxValue;
        }

        public static bool IsValidPercentage(decimal percentage)
        {
            return percentage >= 0 && percentage <= 100;
        }

        public static bool IsValidDateRange(System.DateTime startDate, System.DateTime endDate)
        {
            return startDate <= endDate;
        }
    }

    public static class Documents
    {
        public static readonly string[] AllowedImageExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
        public static readonly string[] AllowedDocumentExtensions = { ".pdf", ".doc", ".docx", ".xls", ".xlsx" };
        public static readonly long MaxFileSize = 10 * 1024 * 1024; // 10MB

        public static bool IsValidFileExtension(string fileName, string[] allowedExtensions)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                return false;

            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            return allowedExtensions.Contains(extension);
        }

        public static bool IsValidFileSize(long fileSize)
        {
            return fileSize > 0 && fileSize <= MaxFileSize;
        }
    }
} 