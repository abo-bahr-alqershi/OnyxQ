using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CardSale Entity
/// </summary>
public class CardSale : Entity<CardSaleId>
{

    private CardSale() { }

    public CardSale(CardSaleId id, string creditNumber)
    {
        Id = id;
        CreditNumber = creditNumber;
    }

    /// <summary>
    /// The unique identifier for the CardSale
    /// المعرف الفريد لـ CardSale
    /// </summary>
    public CardSaleId Id { get; private set; }

    /// <summary>
    /// CreditNumber of the CardSale
    /// CreditNumber الخاص بـ CardSale
    /// </summary>
    public string CreditNumber { get; private set; }

    /// <summary>
    /// CreditTypeFull of the CardSale
    /// CreditTypeFull الخاص بـ CardSale
    /// </summary>
    public decimal? CreditTypeFull { get; private set; }

    /// <summary>
    /// DiscPer of the CardSale
    /// DiscPer الخاص بـ CardSale
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// PointTypeNumber of the CardSale
    /// PointTypeNumber الخاص بـ CardSale
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the CardSale
    /// ExpireDate الخاص بـ CardSale
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// CreditDescription of the CardSale
    /// CreditDescription الخاص بـ CardSale
    /// </summary>
    public string CreditDescription { get; private set; }

    /// <summary>
    /// UsedOnlyOnceFlag of the CardSale
    /// UsedOnlyOnceFlag الخاص بـ CardSale
    /// </summary>
    public decimal? UsedOnlyOnceFlag { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the CardSale
    /// ProcessedFlagFull الخاص بـ CardSale
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// InactiveFlag of the CardSale
    /// InactiveFlag الخاص بـ CardSale
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CardSale
    /// InactivatedByUserId الخاص بـ CardSale
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveReason of the CardSale
    /// InactiveReason الخاص بـ CardSale
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CardSale
    /// InactiveDate الخاص بـ CardSale
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// CreditTypeDiscount of the CardSale
    /// CreditTypeDiscount الخاص بـ CardSale
    /// </summary>
    public decimal? CreditTypeDiscount { get; private set; }

    /// <summary>
    /// MachineNumber of the CardSale
    /// MachineNumber الخاص بـ CardSale
    /// </summary>
    public decimal? MachineNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the CardSale
    /// WarehouseCode الخاص بـ CardSale
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
