using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeBank Entity
/// </summary>
public class EmployeeBank : Entity<EmployeeBankId>
{

    private EmployeeBank() { }

    public EmployeeBank(EmployeeBankId id, decimal? bankNumberShort, string accountBankCode)
    {
        Id = id;
        BankNumberShort = bankNumberShort;
        AccountBankCode = accountBankCode;
    }

    /// <summary>
    /// The unique identifier for the EmployeeBank
    /// المعرف الفريد لـ EmployeeBank
    /// </summary>
    public EmployeeBankId Id { get; private set; }

    /// <summary>
    /// BankNumberShort of the EmployeeBank
    /// BankNumberShort الخاص بـ EmployeeBank
    /// </summary>
    public decimal? BankNumberShort { get; private set; }

    /// <summary>
    /// BankBranchNumber of the EmployeeBank
    /// BankBranchNumber الخاص بـ EmployeeBank
    /// </summary>
    public decimal? BankBranchNumber { get; private set; }

    /// <summary>
    /// BankAccountType of the EmployeeBank
    /// BankAccountType الخاص بـ EmployeeBank
    /// </summary>
    public decimal? BankAccountType { get; private set; }

    /// <summary>
    /// AccountBankCode of the EmployeeBank
    /// AccountBankCode الخاص بـ EmployeeBank
    /// </summary>
    public string AccountBankCode { get; private set; }

    /// <summary>
    /// SalaryFlagShort of the EmployeeBank
    /// SalaryFlagShort الخاص بـ EmployeeBank
    /// </summary>
    public decimal? SalaryFlagShort { get; private set; }

    /// <summary>
    /// InactiveFlag of the EmployeeBank
    /// InactiveFlag الخاص بـ EmployeeBank
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the EmployeeBank
    /// InactiveReason الخاص بـ EmployeeBank
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the EmployeeBank
    /// InactiveDate الخاص بـ EmployeeBank
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the EmployeeBank
    /// InactivatedByUserId الخاص بـ EmployeeBank
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

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
