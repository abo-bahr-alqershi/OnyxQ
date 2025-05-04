using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PurchaseOrderType Entity
/// </summary>
public class PurchaseOrderType : Entity<PurchaseOrderTypeId>
{

    private PurchaseOrderType() { }

    public PurchaseOrderType(PurchaseOrderTypeId id, decimal? purchaseOrderType)
    {
        Id = id;
        PurchaseOrderType = purchaseOrderType;
    }

    /// <summary>
    /// The unique identifier for the PurchaseOrderType
    /// المعرف الفريد لـ PurchaseOrderType
    /// </summary>
    public PurchaseOrderTypeId Id { get; private set; }

    /// <summary>
    /// PurchaseOrderType of the PurchaseOrderType
    /// PurchaseOrderType الخاص بـ PurchaseOrderType
    /// </summary>
    public decimal? PurchaseOrderType { get; private set; }

    /// <summary>
    /// PurchaseOrderNameArabic of the PurchaseOrderType
    /// PurchaseOrderNameArabic الخاص بـ PurchaseOrderType
    /// </summary>
    public string PurchaseOrderNameArabic { get; private set; }

    /// <summary>
    /// PurchaseOrderNameEnglish of the PurchaseOrderType
    /// PurchaseOrderNameEnglish الخاص بـ PurchaseOrderType
    /// </summary>
    public string PurchaseOrderNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
