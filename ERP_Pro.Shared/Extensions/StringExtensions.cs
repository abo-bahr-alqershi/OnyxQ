// StringExtensions.cs
// تم إنشاؤه تلقائيًا.

using System.Text;
using System.Text.RegularExpressions;

namespace ERP_Pro.Shared.Extensions;

public static class StringExtensions
{
    public static string ToSnakeCase(this string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        var startUnderscores = Regex.Match(input, @"^_+");
        return startUnderscores + Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
    }

    public static string ToCamelCase(this string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        
        var words = input.Split(new[] { "_", " " }, StringSplitOptions.RemoveEmptyEntries);
        var result = words[0].ToLower();
        for (int i = 1; i < words.Length; i++)
        {
            result += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
        }
        return result;
    }

    public static string RemoveAccents(this string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        var normalizedString = input.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder();

        foreach (var c in normalizedString)
        {
            var unicodeCategory = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != System.Globalization.UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
    }

    public static string Truncate(this string value, int maxLength, string truncationSuffix = "...")
    {
        if (string.IsNullOrEmpty(value)) return value;
        return value.Length <= maxLength ? value : value.Substring(0, maxLength) + truncationSuffix;
    }

    public static bool IsValidEmail(this string email)
    {
        if (string.IsNullOrEmpty(email)) return false;
        
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    public static string ToBase64(this string text)
    {
        if (string.IsNullOrEmpty(text)) return text;
        
        byte[] textBytes = Encoding.UTF8.GetBytes(text);
        return Convert.ToBase64String(textBytes);
    }

    public static string FromBase64(this string base64)
    {
        if (string.IsNullOrEmpty(base64)) return base64;
        
        byte[] base64Bytes = Convert.FromBase64String(base64);
        return Encoding.UTF8.GetString(base64Bytes);
    }
}