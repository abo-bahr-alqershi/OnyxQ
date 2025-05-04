using System;

namespace ERP_Pro.Domain.ERP.Sales & Customers.ValueObjects
{
    public record DateRange
    {
    public int SalesDiscountPeriodic { get; }
    public int HolidayCalculationStartDate { get; }

        private DateRange()
        {
            // Required by EF Core
        }

        private DateRange(int salesdiscountperiodic, int holidaycalculationstartdate)
        {
        SalesDiscountPeriodic = salesdiscountperiodic;
        HolidayCalculationStartDate = holidaycalculationstartdate;
        }

        public static DateRange Create(int salesdiscountperiodic, int holidaycalculationstartdate)
        {
            // Add validation logic here
            return new DateRange(salesdiscountperiodic, holidaycalculationstartdate);
        }
    }
}