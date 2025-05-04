using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// RequestMaterial Entity
/// </summary>
public class RequestMaterial : Entity<RequestMaterialId>
{
    private RequestMaterial() { }

    /// <summary>
    /// The unique identifier for the RequestMaterial
    /// المعرف الفريد لـ RequestMaterial
    /// </summary>
    public RequestMaterialId Id { get; private set; }

    /// <summary>
    /// DocNo of the RequestMaterial
    /// DocNo الخاص بـ RequestMaterial
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the RequestMaterial
    /// DocSer الخاص بـ RequestMaterial
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// ItemCode of the RequestMaterial
    /// ItemCode الخاص بـ RequestMaterial
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the RequestMaterial
    /// ItemUnit الخاص بـ RequestMaterial
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the RequestMaterial
    /// PSize الخاص بـ RequestMaterial
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the RequestMaterial
    /// ItemQuantity الخاص بـ RequestMaterial
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the RequestMaterial
    /// ItemPriceShort الخاص بـ RequestMaterial
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// WarehouseCode of the RequestMaterial
    /// WarehouseCode الخاص بـ RequestMaterial
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RecordNumber of the RequestMaterial
    /// RecordNumber الخاص بـ RequestMaterial
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestMaterial
    /// CompanyNumberShort الخاص بـ RequestMaterial
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestMaterial
    /// BranchNumber الخاص بـ RequestMaterial
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestMaterial
    /// BranchYear الخاص بـ RequestMaterial
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestMaterial
    /// BranchUser الخاص بـ RequestMaterial
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemDescription of the RequestMaterial
    /// ItemDescription الخاص بـ RequestMaterial
    /// </summary>
    public string ItemDescription { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ReceiptDocument
    /// </summary>
    public ReceiptDocument ReceiptDocument { get; private set; }
    #endregion
}
}
