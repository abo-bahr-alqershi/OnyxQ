using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CashInHandDetail Entity
/// </summary>
public class CashInHandDetail : Entity<CashInHandDetailId>
{
    private CashInHandDetail() { }

    /// <summary>
    /// The unique identifier for the CashInHandDetail
    /// المعرف الفريد لـ CashInHandDetail
    /// </summary>
    public CashInHandDetailId Id { get; private set; }

    /// <summary>
    /// CashNumber of the CashInHandDetail
    /// CashNumber الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountCode of the CashInHandDetail
    /// AccountCode الخاص بـ CashInHandDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CashInHandDetail
    /// AccountCurrency الخاص بـ CashInHandDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// OpenBalanceLocal of the CashInHandDetail
    /// OpenBalanceLocal الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? OpenBalanceLocal { get; private set; }

    /// <summary>
    /// OpenBalanceForeign of the CashInHandDetail
    /// OpenBalanceForeign الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? OpenBalanceForeign { get; private set; }

    /// <summary>
    /// CurrBalL of the CashInHandDetail
    /// CurrBalL الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? CurrBalL { get; private set; }

    /// <summary>
    /// CurrBalF of the CashInHandDetail
    /// CurrBalF الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? CurrBalF { get; private set; }

    /// <summary>
    /// InactiveFlag of the CashInHandDetail
    /// InactiveFlag الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// MinLimitAmount of the CashInHandDetail
    /// MinLimitAmount الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? MinLimitAmount { get; private set; }

    /// <summary>
    /// MaxLimitAmount of the CashInHandDetail
    /// MaxLimitAmount الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? MaxLimitAmount { get; private set; }

    /// <summary>
    /// MaxLimitTransactionAmount of the CashInHandDetail
    /// MaxLimitTransactionAmount الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? MaxLimitTransactionAmount { get; private set; }

    /// <summary>
    /// MinLimitTransactionAmount of the CashInHandDetail
    /// MinLimitTransactionAmount الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? MinLimitTransactionAmount { get; private set; }

    /// <summary>
    /// PassportLimit of the CashInHandDetail
    /// PassportLimit الخاص بـ CashInHandDetail
    /// </summary>
    public decimal? PassportLimit { get; private set; }

    /// <summary>
    /// InactiveDate of the CashInHandDetail
    /// InactiveDate الخاص بـ CashInHandDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to HandCash
    /// </summary>
    public HandCash HandCash { get; private set; }
    /// <summary>
    /// One-to-many relationship: CashInHandDetail to CashManagementDetail
    /// </summary>
    public IReadOnlyCollection<CashManagementDetail> CashManagementDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CashInHandDetail to StationBillMaster
    /// </summary>
    public IReadOnlyCollection<StationBillMaster> StationBillMasters { get; private set; }
    #endregion
}
}
