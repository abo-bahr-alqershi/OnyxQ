using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;
namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeAccount Entity
/// </summary>
public class GuaranteeAccount : Entity<GuaranteeAccountId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<Account> _account = new List<Account>();
    private readonly List<GuaranteeIssue> _guaranteeIssue = new List<GuaranteeIssue>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private GuaranteeAccount() { }

    public GuaranteeAccount(GuaranteeAccountId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GuaranteeAccount
    /// المعرف الفريد لـ GuaranteeAccount
    /// </summary>
    public GuaranteeAccountId Id { get; private set; }

    /// <summary>
    /// GroupTransactionType of the GuaranteeAccount
    /// GroupTransactionType الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? GroupTransactionType { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GuaranteeAccount
    /// GroupNumberFull الخاص بـ GuaranteeAccount
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GuaranteeAccount
    /// AccountDetailCode الخاص بـ GuaranteeAccount
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GuaranteeAccount
    /// AccountDetailType الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the GuaranteeAccount
    /// AccountCurrency الخاص بـ GuaranteeAccount
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountAmount of the GuaranteeAccount
    /// AccountAmount الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// AccountAmountForeign of the GuaranteeAccount
    /// AccountAmountForeign الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// ProjectNumber of the GuaranteeAccount
    /// ProjectNumber الخاص بـ GuaranteeAccount
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// CCode of the GuaranteeAccount
    /// CCode الخاص بـ GuaranteeAccount
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the GuaranteeAccount
    /// VendorCode الخاص بـ GuaranteeAccount
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CashBankNumber of the GuaranteeAccount
    /// CashBankNumber الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the GuaranteeAccount
    /// RecordNumber الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ExchangeRate of the GuaranteeAccount
    /// ExchangeRate الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// AccountDescription of the GuaranteeAccount
    /// AccountDescription الخاص بـ GuaranteeAccount
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// DocPy of the GuaranteeAccount
    /// DocPy الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? DocPy { get; private set; }

    /// <summary>
    /// DocNo of the GuaranteeAccount
    /// DocNo الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// GroupTypeFull of the GuaranteeAccount
    /// GroupTypeFull الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? GroupTypeFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GuaranteeAccount
    /// CompanyNumberShort الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GuaranteeAccount
    /// BranchNumber الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GuaranteeAccount
    /// BranchYear الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GuaranteeAccount
    /// BranchUser الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GuaranteeAccount
    /// AccountDetailSubCode الخاص بـ GuaranteeAccount
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Account> Account => _account;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<GuaranteeIssue> GuaranteeIssue => _guaranteeIssue;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

