using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.StationsFuel.Entities;
using ERP_Pro.Domain.ERP.TaxFees.Entities;
using ERP_Pro.Domain.ERP.TemporaryTables.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// Account Entity
/// </summary>
public class Account : Entity<AccountId>
{

    private Account() { }

    public Account(AccountId id, string accountCode)
    {
        Id = id;
        AccountCode = accountCode;
    }

    /// <summary>
    /// The unique identifier for the Account
    /// المعرف الفريد لـ Account
    /// </summary>
    public AccountId Id { get; private set; }

    /// <summary>
    /// AccountCode of the Account
    /// AccountCode الخاص بـ Account
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountName of the Account
    /// AccountName الخاص بـ Account
    /// </summary>
    public string AccountName { get; private set; }

    /// <summary>
    /// AccountNameEnglishFull of the Account
    /// AccountNameEnglishFull الخاص بـ Account
    /// </summary>
    public string AccountNameEnglishFull { get; private set; }

    /// <summary>
    /// AccountLevel of the Account
    /// AccountLevel الخاص بـ Account
    /// </summary>
    public decimal? AccountLevel { get; private set; }

    /// <summary>
    /// ParentAccountCode of the Account
    /// ParentAccountCode الخاص بـ Account
    /// </summary>
    public string ParentAccountCode { get; private set; }

    /// <summary>
    /// AccountAnalysis of the Account
    /// AccountAnalysis الخاص بـ Account
    /// </summary>
    public decimal? AccountAnalysis { get; private set; }

    /// <summary>
    /// AccountCloseFlag of the Account
    /// AccountCloseFlag الخاص بـ Account
    /// </summary>
    public decimal? AccountCloseFlag { get; private set; }

    /// <summary>
    /// Dr of the Account
    /// Dr الخاص بـ Account
    /// </summary>
    public decimal? Dr { get; private set; }

    /// <summary>
    /// CurdifCode of the Account
    /// CurdifCode الخاص بـ Account
    /// </summary>
    public string CurdifCode { get; private set; }

    /// <summary>
    /// UseCostCenter of the Account
    /// UseCostCenter الخاص بـ Account
    /// </summary>
    public decimal? UseCostCenter { get; private set; }

    /// <summary>
    /// UseProject of the Account
    /// UseProject الخاص بـ Account
    /// </summary>
    public decimal? UseProject { get; private set; }

    /// <summary>
    /// ConnectionPeriod of the Account
    /// ConnectionPeriod الخاص بـ Account
    /// </summary>
    public decimal? ConnectionPeriod { get; private set; }

    /// <summary>
    /// FavoriteAccountFlag of the Account
    /// FavoriteAccountFlag الخاص بـ Account
    /// </summary>
    public decimal? FavoriteAccountFlag { get; private set; }

    /// <summary>
    /// FlowType of the Account
    /// FlowType الخاص بـ Account
    /// </summary>
    public decimal? FlowType { get; private set; }

    /// <summary>
    /// InactiveReason of the Account
    /// InactiveReason الخاص بـ Account
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the Account
    /// InactiveDate الخاص بـ Account
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// ConfigLastDate of the Account
    /// ConfigLastDate الخاص بـ Account
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// AccountOperationNumber of the Account
    /// AccountOperationNumber الخاص بـ Account
    /// </summary>
    public decimal? AccountOperationNumber { get; private set; }

    /// <summary>
    /// AccountExpenseType of the Account
    /// AccountExpenseType الخاص بـ Account
    /// </summary>
    public decimal? AccountExpenseType { get; private set; }

    /// <summary>
    /// UseExportBranch of the Account
    /// UseExportBranch الخاص بـ Account
    /// </summary>
    public decimal? UseExportBranch { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Account
    /// ImportExcelFlag الخاص بـ Account
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// AccountDetailType of the Account
    /// AccountDetailType الخاص بـ Account
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// UseActive of the Account
    /// UseActive الخاص بـ Account
    /// </summary>
    public decimal? UseActive { get; private set; }

    /// <summary>
    /// UseTdsFlag of the Account
    /// UseTdsFlag الخاص بـ Account
    /// </summary>
    public decimal? UseTdsFlag { get; private set; }

    /// <summary>
    /// AdvanceExpenseRevenueFlag of the Account
    /// AdvanceExpenseRevenueFlag الخاص بـ Account
    /// </summary>
    public decimal? AdvanceExpenseRevenueFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountClass AccountClass { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountGroup AccountGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountReportType AccountReportType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountType AccountType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
