using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeAccount Entity
/// </summary>
public class GuaranteeAccount : Entity<GuaranteeAccountId>
{
    private GuaranteeAccount() { }

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
    /// GroupSerial of the GuaranteeAccount
    /// GroupSerial الخاص بـ GuaranteeAccount
    /// </summary>
    public decimal? GroupSerial { get; private set; }

    /// <summary>
    /// AccountCode of the GuaranteeAccount
    /// AccountCode الخاص بـ GuaranteeAccount
    /// </summary>
    public string AccountCode { get; private set; }

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
    /// CostCenterCode of the GuaranteeAccount
    /// CostCenterCode الخاص بـ GuaranteeAccount
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GuaranteeAccount
    /// ProjectNumber الخاص بـ GuaranteeAccount
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the GuaranteeAccount
    /// ActivityNumber الخاص بـ GuaranteeAccount
    /// </summary>
    public string ActivityNumber { get; private set; }

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
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GuaranteeIssue
    /// </summary>
    public GuaranteeIssue GuaranteeIssue { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion
}
}
