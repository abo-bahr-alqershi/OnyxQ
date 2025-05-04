using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CostDetail Entity
/// </summary>
public class CostDetail : Entity<CostDetailId>
{
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<CostMaster> _costMaster = new List<CostMaster>();

    private CostDetail() { }

    public CostDetail(CostDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CostDetail
    /// المعرف الفريد لـ CostDetail
    /// </summary>
    public CostDetailId Id { get; private set; }

    /// <summary>
    /// PurchaseInvoiceNumber of the CostDetail
    /// PurchaseInvoiceNumber الخاص بـ CostDetail
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// GroupNumberFull of the CostDetail
    /// GroupNumberFull الخاص بـ CostDetail
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// DocSer of the CostDetail
    /// DocSer الخاص بـ CostDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountDetailCode of the CostDetail
    /// AccountDetailCode الخاص بـ CostDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the CostDetail
    /// AccountDetailType الخاص بـ CostDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrencyAmount of the CostDetail
    /// AccountCurrencyAmount الخاص بـ CostDetail
    /// </summary>
    public decimal? AccountCurrencyAmount { get; private set; }

    /// <summary>
    /// AccountInvoiceCurrencyAmount of the CostDetail
    /// AccountInvoiceCurrencyAmount الخاص بـ CostDetail
    /// </summary>
    public decimal? AccountInvoiceCurrencyAmount { get; private set; }

    /// <summary>
    /// CostDistributionType of the CostDetail
    /// CostDistributionType الخاص بـ CostDetail
    /// </summary>
    public decimal? CostDistributionType { get; private set; }

    /// <summary>
    /// RecordNumber of the CostDetail
    /// RecordNumber الخاص بـ CostDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ExchangeRate of the CostDetail
    /// ExchangeRate الخاص بـ CostDetail
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CostDetail
    /// CompanyNumberShort الخاص بـ CostDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CostDetail
    /// BranchNumber الخاص بـ CostDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CostDetail
    /// BranchYear الخاص بـ CostDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CostDetail
    /// BranchUser الخاص بـ CostDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostMaster> CostMaster => _costMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
