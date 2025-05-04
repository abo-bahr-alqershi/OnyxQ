using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// InvoiceDetail Entity
/// </summary>
public class InvoiceDetail : Entity<InvoiceDetailId>
{
    private InvoiceDetail() { }

    /// <summary>
    /// The unique identifier for the InvoiceDetail
    /// المعرف الفريد لـ InvoiceDetail
    /// </summary>
    public InvoiceDetailId Id { get; private set; }

    /// <summary>
    /// InvoiceNumber of the InvoiceDetail
    /// InvoiceNumber الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? InvoiceNumber { get; private set; }

    /// <summary>
    /// InvoiceType of the InvoiceDetail
    /// InvoiceType الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? InvoiceType { get; private set; }

    /// <summary>
    /// InvoiceSerial of the InvoiceDetail
    /// InvoiceSerial الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? InvoiceSerial { get; private set; }

    /// <summary>
    /// ItemCode of the InvoiceDetail
    /// ItemCode الخاص بـ InvoiceDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the InvoiceDetail
    /// ItemUnit الخاص بـ InvoiceDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the InvoiceDetail
    /// WarehouseCode الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the InvoiceDetail
    /// ItemQuantity الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the InvoiceDetail
    /// PSize الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the InvoiceDetail
    /// PQuantity الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// BankCode of the InvoiceDetail
    /// BankCode الخاص بـ InvoiceDetail
    /// </summary>
    public string BankCode { get; private set; }

    /// <summary>
    /// Barcode of the InvoiceDetail
    /// Barcode الخاص بـ InvoiceDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ExpireDate of the InvoiceDetail
    /// ExpireDate الخاص بـ InvoiceDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the InvoiceDetail
    /// BatchNumber الخاص بـ InvoiceDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// AvailableQuantity of the InvoiceDetail
    /// AvailableQuantity الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the InvoiceDetail
    /// RecordNumber الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the InvoiceDetail
    /// UseAttachment الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the InvoiceDetail
    /// ItemDescription الخاص بـ InvoiceDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// AttachmentNumber1 of the InvoiceDetail
    /// AttachmentNumber1 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentNumber1 { get; private set; }

    /// <summary>
    /// AttachmentNumber2 of the InvoiceDetail
    /// AttachmentNumber2 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentNumber2 { get; private set; }

    /// <summary>
    /// AttachmentNumber3 of the InvoiceDetail
    /// AttachmentNumber3 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentNumber3 { get; private set; }

    /// <summary>
    /// AttachmentNumber4 of the InvoiceDetail
    /// AttachmentNumber4 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentNumber4 { get; private set; }

    /// <summary>
    /// AttachmentNumber5 of the InvoiceDetail
    /// AttachmentNumber5 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentNumber5 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber1 of the InvoiceDetail
    /// AttachmentDescriptionNumber1 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber1 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber2 of the InvoiceDetail
    /// AttachmentDescriptionNumber2 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber2 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber3 of the InvoiceDetail
    /// AttachmentDescriptionNumber3 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber3 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber4 of the InvoiceDetail
    /// AttachmentDescriptionNumber4 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber4 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber5 of the InvoiceDetail
    /// AttachmentDescriptionNumber5 الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber5 { get; private set; }

    /// <summary>
    /// FlexNumber of the InvoiceDetail
    /// FlexNumber الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    /// <summary>
    /// DocTypeRef of the InvoiceDetail
    /// DocTypeRef الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the InvoiceDetail
    /// DocJvTypeRef الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the InvoiceDetail
    /// DocNoRef الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the InvoiceDetail
    /// DocSerRef الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InvoiceDetail
    /// ExternalPostFlag الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemLength of the InvoiceDetail
    /// ItemLength الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the InvoiceDetail
    /// ItemWidth الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the InvoiceDetail
    /// ItemHeightShort الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the InvoiceDetail
    /// ItemNumberShort الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the InvoiceDetail
    /// WeightedQuantity الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the InvoiceDetail
    /// WeightedUnit الخاص بـ InvoiceDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ProcessedAdjustmentFlag of the InvoiceDetail
    /// ProcessedAdjustmentFlag الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ProcessedAdjustmentFlag { get; private set; }

    /// <summary>
    /// ArgumentNumber of the InvoiceDetail
    /// ArgumentNumber الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InvoiceDetail
    /// CompanyNumberShort الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InvoiceDetail
    /// BranchNumber الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InvoiceDetail
    /// BranchYear الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InvoiceDetail
    /// BranchUser الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// KitItem of the InvoiceDetail
    /// KitItem الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? KitItem { get; private set; }

    /// <summary>
    /// MinQuantity of the InvoiceDetail
    /// MinQuantity الخاص بـ InvoiceDetail
    /// </summary>
    public decimal? MinQuantity { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    /// <summary>
    /// ManyToOne relationship to InvoiceMaster
    /// </summary>
    public InvoiceMaster InvoiceMaster { get; private set; }
    #endregion
}
}
