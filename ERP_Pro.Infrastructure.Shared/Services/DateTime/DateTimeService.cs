using ERP_Pro.Shared.Constants;

namespace ERP_Pro.Infrastructure.Shared.Services.DateTime;

public class DateTimeService : IDateTimeService
{
    private readonly TimeZoneInfo _timeZone;
    private readonly HashSet<System.DateTime> _holidays;

    public DateTimeService()
    {
        _timeZone = TimeZoneInfo.FindSystemTimeZoneById(GlobalConstants.System.DefaultTimeZone);
        _holidays = new HashSet<System.DateTime>();
        InitializeHolidays();
    }

    public System.DateTime Now => System.DateTime.Now;
    public System.DateTime UtcNow => System.DateTime.UtcNow;
    public System.DateTime Today => System.DateTime.Today;
    public System.DateTime LocalNow => TimeZoneInfo.ConvertTime(UtcNow, _timeZone);
    public DateOnly LocalToday => DateOnly.FromDateTime(LocalNow);
    public TimeOnly LocalTimeNow => TimeOnly.FromDateTime(LocalNow);
    public string CurrentTimeZone => _timeZone.Id;

    public System.DateTime ConvertToLocalTime(System.DateTime dateTime)
    {
        return TimeZoneInfo.ConvertTime(dateTime, _timeZone);
    }

    public System.DateTime ConvertToUtc(System.DateTime dateTime)
    {
        return TimeZoneInfo.ConvertTimeToUtc(dateTime, _timeZone);
    }

    public bool IsBusinessDay(System.DateTime date)
    {
        return !IsWeekend(date) && !IsHoliday(date);
    }

    public bool IsWeekend(System.DateTime date)
    {
        return date.DayOfWeek is DayOfWeek.Friday or DayOfWeek.Saturday;
    }

    public bool IsHoliday(System.DateTime date)
    {
        return _holidays.Contains(date.Date);
    }

    public System.DateTime GetNextBusinessDay(System.DateTime date)
    {
        var nextDay = date.AddDays(1);
        while (!IsBusinessDay(nextDay))
        {
            nextDay = nextDay.AddDays(1);
        }
        return nextDay;
    }

    public System.DateTime GetPreviousBusinessDay(System.DateTime date)
    {
        var previousDay = date.AddDays(-1);
        while (!IsBusinessDay(previousDay))
        {
            previousDay = previousDay.AddDays(-1);
        }
        return previousDay;
    }

    public int GetBusinessDaysInMonth(int year, int month)
    {
        var firstDay = new System.DateTime(year, month, 1);
        var lastDay = firstDay.AddMonths(1).AddDays(-1);
        return GetBusinessDaysBetween(firstDay, lastDay);
    }

    public int GetBusinessDaysBetween(System.DateTime startDate, System.DateTime endDate)
    {
        var businessDays = 0;
        var currentDate = startDate.Date;
        var lastDate = endDate.Date;

        while (currentDate <= lastDate)
        {
            if (IsBusinessDay(currentDate))
                businessDays++;

            currentDate = currentDate.AddDays(1);
        }

        return businessDays;
    }

    private void InitializeHolidays()
    {
        // TODO: Load holidays from configuration or database
        // This is just a sample implementation
        var currentYear = System.DateTime.Now.Year;
        
        // Add some sample holidays (these should be loaded from a configuration)
        _holidays.Add(new System.DateTime(currentYear, 1, 1));  // New Year
        _holidays.Add(new System.DateTime(currentYear, 5, 1));  // Labor Day
        _holidays.Add(new System.DateTime(currentYear, 9, 23)); // National Day
    }
} 