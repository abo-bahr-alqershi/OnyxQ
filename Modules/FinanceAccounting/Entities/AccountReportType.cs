using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// AccountReportType Entity
/// </summary>
public class AccountReportType : Entity<AccountReportTypeId>
{
    private AccountReportType() { }

    /// <summary>
    /// The unique identifier for the AccountReportType
    /// المعرف الفريد لـ AccountReportType
    /// </summary>
    public AccountReportTypeId Id { get; private set; }

    /// <summary>
    /// ReportType of the AccountReportType
    /// ReportType الخاص بـ AccountReportType
    /// </summary>
    public decimal? ReportType { get; private set; }

    /// <summary>
    /// ReportName of the AccountReportType
    /// ReportName الخاص بـ AccountReportType
    /// </summary>
    public string ReportName { get; private set; }

    /// <summary>
    /// ReportNameEnglish of the AccountReportType
    /// ReportNameEnglish الخاص بـ AccountReportType
    /// </summary>
    public string ReportNameEnglish { get; private set; }

    /// <summary>
    /// ReportBalanceSheet of the AccountReportType
    /// ReportBalanceSheet الخاص بـ AccountReportType
    /// </summary>
    public decimal? ReportBalanceSheet { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AccountReportType to Account
    /// </summary>
    public IReadOnlyCollection<Account> Accounts { get; private set; }
    #endregion
}
}
