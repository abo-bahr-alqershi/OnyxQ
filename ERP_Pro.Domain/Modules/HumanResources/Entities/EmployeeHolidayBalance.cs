using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeHolidayBalance Entity
/// </summary>
public class EmployeeHolidayBalance : Entity<EmployeeHolidayBalanceId>
{

    private EmployeeHolidayBalance() { }

    public EmployeeHolidayBalance(EmployeeHolidayBalanceId id, decimal? holidayNumber)
    {
        Id = id;
        HolidayNumber = holidayNumber;
    }

    /// <summary>
    /// The unique identifier for the EmployeeHolidayBalance
    /// المعرف الفريد لـ EmployeeHolidayBalance
    /// </summary>
    public EmployeeHolidayBalanceId Id { get; private set; }

    /// <summary>
    /// HolidayNumber of the EmployeeHolidayBalance
    /// HolidayNumber الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? HolidayNumber { get; private set; }

    /// <summary>
    /// HolidayBalance of the EmployeeHolidayBalance
    /// HolidayBalance الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? HolidayBalance { get; private set; }

    /// <summary>
    /// HolidayLawBalance of the EmployeeHolidayBalance
    /// HolidayLawBalance الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? HolidayLawBalance { get; private set; }

    /// <summary>
    /// LastHolidayDate of the EmployeeHolidayBalance
    /// LastHolidayDate الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public DateTime? LastHolidayDate { get; private set; }

    /// <summary>
    /// OpenHolidayBalance of the EmployeeHolidayBalance
    /// OpenHolidayBalance الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? OpenHolidayBalance { get; private set; }

    /// <summary>
    /// HolidayBalanceRenewal of the EmployeeHolidayBalance
    /// HolidayBalanceRenewal الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? HolidayBalanceRenewal { get; private set; }

    /// <summary>
    /// HolidayBalanceMax of the EmployeeHolidayBalance
    /// HolidayBalanceMax الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? HolidayBalanceMax { get; private set; }

    /// <summary>
    /// BalanceMovementPrevious of the EmployeeHolidayBalance
    /// BalanceMovementPrevious الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? BalanceMovementPrevious { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeHolidayBalance
    /// InactiveFlag الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeHolidayBalance
    /// InactiveReason الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeHolidayBalance
    /// InactiveDate الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeHolidayBalance
    /// InactivatedByUserId الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// HolidayCalculationStartDate of the EmployeeHolidayBalance
    /// HolidayCalculationStartDate الخاص بـ EmployeeHolidayBalance
    /// </summary>
    public DateTime? HolidayCalculationStartDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

