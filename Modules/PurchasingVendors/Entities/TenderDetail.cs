using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// TenderDetail Entity
/// </summary>
public class TenderDetail : Entity<TenderDetailId>
{
    private TenderDetail() { }

    /// <summary>
    /// The unique identifier for the TenderDetail
    /// المعرف الفريد لـ TenderDetail
    /// </summary>
    public TenderDetailId Id { get; private set; }

    /// <summary>
    /// TdType of the TenderDetail
    /// TdType الخاص بـ TenderDetail
    /// </summary>
    public decimal? TdType { get; private set; }

    /// <summary>
    /// TdNumber of the TenderDetail
    /// TdNumber الخاص بـ TenderDetail
    /// </summary>
    public decimal? TdNumber { get; private set; }

    /// <summary>
    /// TdSerial of the TenderDetail
    /// TdSerial الخاص بـ TenderDetail
    /// </summary>
    public decimal? TdSerial { get; private set; }

    /// <summary>
    /// ItemCode of the TenderDetail
    /// ItemCode الخاص بـ TenderDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the TenderDetail
    /// ItemQuantity الخاص بـ TenderDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the TenderDetail
    /// ItemUnit الخاص بـ TenderDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the TenderDetail
    /// PSize الخاص بـ TenderDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the TenderDetail
    /// PQuantity الخاص بـ TenderDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the TenderDetail
    /// WarehouseCode الخاص بـ TenderDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// PriceNumber of the TenderDetail
    /// PriceNumber الخاص بـ TenderDetail
    /// </summary>
    public decimal? PriceNumber { get; private set; }

    /// <summary>
    /// PriceSerial of the TenderDetail
    /// PriceSerial الخاص بـ TenderDetail
    /// </summary>
    public decimal? PriceSerial { get; private set; }

    /// <summary>
    /// ItemPriceShort of the TenderDetail
    /// ItemPriceShort الخاص بـ TenderDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// RecordNumber of the TenderDetail
    /// RecordNumber الخاص بـ TenderDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the TenderDetail
    /// ItemDescription الخاص بـ TenderDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TenderDetail
    /// CompanyNumberShort الخاص بـ TenderDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TenderDetail
    /// BranchNumber الخاص بـ TenderDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TenderDetail
    /// BranchYear الخاص بـ TenderDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TenderDetail
    /// BranchUser الخاص بـ TenderDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to TenderMaster
    /// </summary>
    public TenderMaster TenderMaster { get; private set; }
    #endregion
}
}
