using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CardSaleDiscountType Entity
/// </summary>
public class CardSaleDiscountType : Entity<CardSaleDiscountTypeId>
{
    private CardSaleDiscountType() { }

    /// <summary>
    /// The unique identifier for the CardSaleDiscountType
    /// المعرف الفريد لـ CardSaleDiscountType
    /// </summary>
    public CardSaleDiscountTypeId Id { get; private set; }

    /// <summary>
    /// CreditTypeDiscount of the CardSaleDiscountType
    /// CreditTypeDiscount الخاص بـ CardSaleDiscountType
    /// </summary>
    public decimal? CreditTypeDiscount { get; private set; }

    /// <summary>
    /// CreditTypeLastName of the CardSaleDiscountType
    /// CreditTypeLastName الخاص بـ CardSaleDiscountType
    /// </summary>
    public string CreditTypeLastName { get; private set; }

    /// <summary>
    /// CreditTypeFirstName of the CardSaleDiscountType
    /// CreditTypeFirstName الخاص بـ CardSaleDiscountType
    /// </summary>
    public string CreditTypeFirstName { get; private set; }

    /// <summary>
    /// MinSaleAmount of the CardSaleDiscountType
    /// MinSaleAmount الخاص بـ CardSaleDiscountType
    /// </summary>
    public decimal? MinSaleAmount { get; private set; }

    /// <summary>
    /// DiscPer of the CardSaleDiscountType
    /// DiscPer الخاص بـ CardSaleDiscountType
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// InactiveFlag of the CardSaleDiscountType
    /// InactiveFlag الخاص بـ CardSaleDiscountType
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CardSaleDiscountType
    /// InactivatedByUserId الخاص بـ CardSaleDiscountType
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveReason of the CardSaleDiscountType
    /// InactiveReason الخاص بـ CardSaleDiscountType
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CardSaleDiscountType
    /// InactiveDate الخاص بـ CardSaleDiscountType
    /// </summary>
    public DateTime? InactiveDate { get; private set; }
}
}
