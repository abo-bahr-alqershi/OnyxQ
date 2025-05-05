// EnumExtensions.cs
// تم إنشاؤه تلقائيًا.

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ERP_Pro.Shared.Extensions;

public static class EnumExtensions
{
    public static string GetDescription(this Enum enumValue)
    {
        var field = enumValue.GetType().GetField(enumValue.ToString());
        if (field == null) return enumValue.ToString();
        
        var attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? enumValue.ToString();
    }

    public static string GetDisplayName(this Enum enumValue)
    {
        var field = enumValue.GetType().GetField(enumValue.ToString());
        if (field == null) return enumValue.ToString();
        
        var attribute = field.GetCustomAttribute<DisplayAttribute>();
        return attribute?.Name ?? enumValue.ToString();
    }

    public static T ToEnum<T>(this string value) where T : struct
    {
        if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
        return (T)Enum.Parse(typeof(T), value, true);
    }

    public static T? ToEnumOrNull<T>(this string value) where T : struct
    {
        if (string.IsNullOrEmpty(value)) return null;
        return Enum.TryParse<T>(value, true, out var result) ? result : null;
    }

    public static IEnumerable<T> GetValues<T>() where T : Enum
    {
        return Enum.GetValues(typeof(T)).Cast<T>();
    }

    public static IDictionary<int, string> ToDictionary<T>() where T : Enum
    {
        return GetValues<T>().ToDictionary(t => Convert.ToInt32(t), t => t.GetDescription());
    }
}