using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesFreeQuantity Entity
/// </summary>
public class SalesFreeQuantity : Entity<SalesFreeQuantityId>
{
    private SalesFreeQuantity() { }

    /// <summary>
    /// The unique identifier for the SalesFreeQuantity
    /// المعرف الفريد لـ SalesFreeQuantity
    /// </summary>
    public SalesFreeQuantityId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesFreeQuantity
    /// GuarantorCode الخاص بـ SalesFreeQuantity
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// CCode of the SalesFreeQuantity
    /// CCode الخاص بـ SalesFreeQuantity
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CClass of the SalesFreeQuantity
    /// CClass الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// ItemCode of the SalesFreeQuantity
    /// ItemCode الخاص بـ SalesFreeQuantity
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// PSize of the SalesFreeQuantity
    /// PSize الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesFreeQuantity
    /// ItemUnit الخاص بـ SalesFreeQuantity
    /// </summary>
    public string ItemUnit { get; private set; }

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
    /// WarehouseCode of the SalesFreeQuantity
    /// WarehouseCode الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the SalesFreeQuantity
    /// WarehouseGroupCode الخاص بـ SalesFreeQuantity
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

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
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    /// <summary>
    /// ManyToOne relationship to WarehouseGroup
    /// </summary>
    public WarehouseGroup WarehouseGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion
}
}
