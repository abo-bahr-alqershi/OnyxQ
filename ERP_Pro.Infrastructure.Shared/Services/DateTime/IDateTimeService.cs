namespace ERP_Pro.Infrastructure.Shared.Services.DateTime;

public interface IDateTimeService
{
    System.DateTime Now { get; }
    System.DateTime UtcNow { get; }
    System.DateTime Today { get; }
    System.DateTime LocalNow { get; }
    DateOnly LocalToday { get; }
    TimeOnly LocalTimeNow { get; }
    string CurrentTimeZone { get; }
    System.DateTime ConvertToLocalTime(System.DateTime dateTime);
    System.DateTime ConvertToUtc(System.DateTime dateTime);
    bool IsBusinessDay(System.DateTime date);
    bool IsWeekend(System.DateTime date);
    bool IsHoliday(System.DateTime date);
    System.DateTime GetNextBusinessDay(System.DateTime date);
    System.DateTime GetPreviousBusinessDay(System.DateTime date);
    int GetBusinessDaysInMonth(int year, int month);
    int GetBusinessDaysBetween(System.DateTime startDate, System.DateTime endDate);
} 