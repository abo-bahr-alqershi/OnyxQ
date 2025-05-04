using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PurchaseOrderType Entity
/// </summary>
public class PurchaseOrderType : Entity<PurchaseOrderTypeId>
{
    private PurchaseOrderType() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: PurchaseOrderType to PurchaseOrder
    /// </summary>
    public IReadOnlyCollection<PurchaseOrder> PurchaseOrders { get; private set; }
    #endregion
}
}
