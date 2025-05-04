using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseRequestType Entity
/// </summary>
public class PurchaseRequestType : Entity<PurchaseRequestTypeId>
{

    private PurchaseRequestType() { }

    public PurchaseRequestType(PurchaseRequestTypeId id, decimal? priceTypeFull)
    {
        Id = id;
        PriceTypeFull = priceTypeFull;
    }

    /// <summary>
    /// The unique identifier for the PurchaseRequestType
    /// المعرف الفريد لـ PurchaseRequestType
    /// </summary>
    public PurchaseRequestTypeId Id { get; private set; }

    /// <summary>
    /// PriceTypeFull of the PurchaseRequestType
    /// PriceTypeFull الخاص بـ PurchaseRequestType
    /// </summary>
    public decimal? PriceTypeFull { get; private set; }

    /// <summary>
    /// PriceAdjustmentNameArabic of the PurchaseRequestType
    /// PriceAdjustmentNameArabic الخاص بـ PurchaseRequestType
    /// </summary>
    public string PriceAdjustmentNameArabic { get; private set; }

    /// <summary>
    /// PriceNameEnglish of the PurchaseRequestType
    /// PriceNameEnglish الخاص بـ PurchaseRequestType
    /// </summary>
    public string PriceNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
