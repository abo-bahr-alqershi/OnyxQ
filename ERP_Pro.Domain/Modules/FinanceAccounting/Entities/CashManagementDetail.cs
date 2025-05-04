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
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<CashInHandDetail> _cashInHandDetail = new List<CashInHandDetail>();
    private readonly List<CashManagementMaster> _cashManagementMaster = new List<CashManagementMaster>();

    private CashManagementDetail() { }

    public CashManagementDetail(CashManagementDetailId id)
    {
        Id = id;
    }

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
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CashInHandDetail> CashInHandDetail => _cashInHandDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CashManagementMaster> CashManagementMaster => _cashManagementMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
