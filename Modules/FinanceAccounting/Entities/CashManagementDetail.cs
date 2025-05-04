using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CashManagementDetail Entity
/// </summary>
public class CashManagementDetail : Entity<CashManagementDetailId>
{
    private CashManagementDetail() { }

    /// <summary>
    /// The unique identifier for the CashManagementDetail
    /// المعرف الفريد لـ CashManagementDetail
    /// </summary>
    public CashManagementDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the CashManagementDetail
    /// DocNo الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CashManagementDetail
    /// DocSer الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// CashNumber of the CashManagementDetail
    /// CashNumber الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountCode of the CashManagementDetail
    /// AccountCode الخاص بـ CashManagementDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CashManagementDetail
    /// AccountCurrency الخاص بـ CashManagementDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the CashManagementDetail
    /// AccountRate الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Amount of the CashManagementDetail
    /// Amount الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the CashManagementDetail
    /// AmountForeign الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// RecordNumber of the CashManagementDetail
    /// RecordNumber الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// MoneyClass of the CashManagementDetail
    /// MoneyClass الخاص بـ CashManagementDetail
    /// </summary>
    public string MoneyClass { get; private set; }

    /// <summary>
    /// CashAmount of the CashManagementDetail
    /// CashAmount الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? CashAmount { get; private set; }

    /// <summary>
    /// CashBalance of the CashManagementDetail
    /// CashBalance الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? CashBalance { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CashManagementDetail
    /// CompanyNumberShort الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CashManagementDetail
    /// BranchNumber الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CashManagementDetail
    /// BranchYear الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CashManagementDetail
    /// BranchUser الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ClassCount of the CashManagementDetail
    /// ClassCount الخاص بـ CashManagementDetail
    /// </summary>
    public decimal? ClassCount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CashInHandDetail
    /// </summary>
    public CashInHandDetail CashInHandDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CashManagementMaster
    /// </summary>
    public CashManagementMaster CashManagementMaster { get; private set; }
    #endregion
}
}
