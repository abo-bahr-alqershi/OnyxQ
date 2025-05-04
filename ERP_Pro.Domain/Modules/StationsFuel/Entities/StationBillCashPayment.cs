using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationBillCashPayment Entity
/// </summary>
public class StationBillCashPayment : Entity<StationBillCashPaymentId>
{

    private StationBillCashPayment() { }

    public StationBillCashPayment(StationBillCashPaymentId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the StationBillCashPayment
    /// المعرف الفريد لـ StationBillCashPayment
    /// </summary>
    public StationBillCashPaymentId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationBillCashPayment
    /// DocNo الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// AccountCurrencyCategory of the StationBillCashPayment
    /// AccountCurrencyCategory الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? AccountCurrencyCategory { get; private set; }

    /// <summary>
    /// AccountCurrencyCount of the StationBillCashPayment
    /// AccountCurrencyCount الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? AccountCurrencyCount { get; private set; }

    /// <summary>
    /// Amount of the StationBillCashPayment
    /// Amount الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// DiscAmtMst of the StationBillCashPayment
    /// DiscAmtMst الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// VatAmount of the StationBillCashPayment
    /// VatAmount الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationBillCashPayment
    /// CompanyNumberShort الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationBillCashPayment
    /// BranchNumber الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationBillCashPayment
    /// BranchYear الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationBillCashPayment
    /// BranchUser الخاص بـ StationBillCashPayment
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public StationBillMaster StationBillMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
