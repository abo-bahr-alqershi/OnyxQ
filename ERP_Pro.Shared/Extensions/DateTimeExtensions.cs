// DateTimeExtensions.cs
// تم إنشاؤه تلقائيًا.

using ERP_Pro.Shared.Constants;

namespace ERP_Pro.Shared.Extensions;

public static class DateTimeExtensions
{
    public static string ToFormattedString(this DateTime dateTime, string format = null)
    {
        return dateTime.ToString(format ?? GlobalConstants.System.DateTimeFormat);
    }

    public static DateTime StartOfDay(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
    }

    public static DateTime EndOfDay(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);
    }

    public static DateTime StartOfMonth(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, 1);
    }

    public static DateTime EndOfMonth(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month))
            .EndOfDay();
    }

    public static bool IsWeekend(this DateTime date)
    {
        return date.DayOfWeek is DayOfWeek.Friday or DayOfWeek.Saturday;
    }

    public static bool IsWorkingDay(this DateTime date)
    {
        return !date.IsWeekend();
    }

    public static DateTime ToLocalTime(this DateTime utcDateTime, string timeZoneId = null)
    {
        var timeZone = TimeZoneInfo.FindSystemTimeZoneById(
            timeZoneId ?? GlobalConstants.System.DefaultTimeZone);
        return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZone);
    }
}