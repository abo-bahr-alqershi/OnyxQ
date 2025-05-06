using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesFreeQuantity Entity
/// </summary>
public class SalesFreeQuantity : Entity<SalesFreeQuantityId>
{

    private SalesFreeQuantity() { }

    public SalesFreeQuantity(SalesFreeQuantityId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesFreeQuantity
    /// المعرف الفريد لـ SalesFreeQuantity
    /// </summary>
    public SalesFreeQuantityId Id { get; private set; }

    /// <summary>
    /// PSize of the SalesFreeQuantity
    /// PSize الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PaymentType of the SalesFreeQuantity
    /// PaymentType الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? PaymentType { get; private set; }

    /// <summary>
    /// LowQuantity of the SalesFreeQuantity
    /// LowQuantity الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? LowQuantity { get; private set; }

    /// <summary>
    /// PeriodQuantity of the SalesFreeQuantity
    /// PeriodQuantity الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? PeriodQuantity { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SalesFreeQuantity
    /// BillDocumentTypeFull الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// RecordNumber of the SalesFreeQuantity
    /// RecordNumber الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// FQuantity of the SalesFreeQuantity
    /// FQuantity الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? FQuantity { get; private set; }

    /// <summary>
    /// TQuantity of the SalesFreeQuantity
    /// TQuantity الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? TQuantity { get; private set; }

    /// <summary>
    /// FDate of the SalesFreeQuantity
    /// FDate الخاص بـ SalesFreeQuantity
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesFreeQuantity
    /// TDate الخاص بـ SalesFreeQuantity
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesFreeQuantity
    /// BranchNumber الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public WarehouseGroup WarehouseGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

