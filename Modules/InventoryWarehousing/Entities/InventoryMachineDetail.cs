using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryMachineDetail Entity
/// </summary>
public class InventoryMachineDetail : Entity<InventoryMachineDetailId>
{
    private InventoryMachineDetail() { }

    /// <summary>
    /// The unique identifier for the InventoryMachineDetail
    /// المعرف الفريد لـ InventoryMachineDetail
    /// </summary>
    public InventoryMachineDetailId Id { get; private set; }

    /// <summary>
    /// InvoiceNumber of the InventoryMachineDetail
    /// InvoiceNumber الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? InvoiceNumber { get; private set; }

    /// <summary>
    /// InvoiceType of the InventoryMachineDetail
    /// InvoiceType الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? InvoiceType { get; private set; }

    /// <summary>
    /// InvoiceSerial of the InventoryMachineDetail
    /// InvoiceSerial الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? InvoiceSerial { get; private set; }

    /// <summary>
    /// ItemCode of the InventoryMachineDetail
    /// ItemCode الخاص بـ InventoryMachineDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the InventoryMachineDetail
    /// ItemUnit الخاص بـ InventoryMachineDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WarehouseCode of the InventoryMachineDetail
    /// WarehouseCode الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the InventoryMachineDetail
    /// ItemQuantity الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the InventoryMachineDetail
    /// PSize الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the InventoryMachineDetail
    /// PQuantity الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// BankCode of the InventoryMachineDetail
    /// BankCode الخاص بـ InventoryMachineDetail
    /// </summary>
    public string BankCode { get; private set; }

    /// <summary>
    /// Barcode of the InventoryMachineDetail
    /// Barcode الخاص بـ InventoryMachineDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ExpireDate of the InventoryMachineDetail
    /// ExpireDate الخاص بـ InventoryMachineDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the InventoryMachineDetail
    /// BatchNumber الخاص بـ InventoryMachineDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// AvailableQuantity of the InventoryMachineDetail
    /// AvailableQuantity الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryMachineDetail
    /// RecordNumber الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the InventoryMachineDetail
    /// UseAttachment الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the InventoryMachineDetail
    /// ItemDescription الخاص بـ InventoryMachineDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// AttachmentNumber1 of the InventoryMachineDetail
    /// AttachmentNumber1 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentNumber1 { get; private set; }

    /// <summary>
    /// AttachmentNumber2 of the InventoryMachineDetail
    /// AttachmentNumber2 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentNumber2 { get; private set; }

    /// <summary>
    /// AttachmentNumber3 of the InventoryMachineDetail
    /// AttachmentNumber3 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentNumber3 { get; private set; }

    /// <summary>
    /// AttachmentNumber4 of the InventoryMachineDetail
    /// AttachmentNumber4 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentNumber4 { get; private set; }

    /// <summary>
    /// AttachmentNumber5 of the InventoryMachineDetail
    /// AttachmentNumber5 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentNumber5 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber1 of the InventoryMachineDetail
    /// AttachmentDescriptionNumber1 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber1 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber2 of the InventoryMachineDetail
    /// AttachmentDescriptionNumber2 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber2 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber3 of the InventoryMachineDetail
    /// AttachmentDescriptionNumber3 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber3 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber4 of the InventoryMachineDetail
    /// AttachmentDescriptionNumber4 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber4 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber5 of the InventoryMachineDetail
    /// AttachmentDescriptionNumber5 الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber5 { get; private set; }

    /// <summary>
    /// FlexNumber of the InventoryMachineDetail
    /// FlexNumber الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    /// <summary>
    /// ItemLength of the InventoryMachineDetail
    /// ItemLength الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the InventoryMachineDetail
    /// ItemWidth الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the InventoryMachineDetail
    /// ItemHeightShort الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the InventoryMachineDetail
    /// ItemNumberShort الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// WeightedQuantity of the InventoryMachineDetail
    /// WeightedQuantity الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the InventoryMachineDetail
    /// WeightedUnit الخاص بـ InventoryMachineDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the InventoryMachineDetail
    /// ArgumentNumber الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryMachineDetail
    /// CompanyNumberShort الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryMachineDetail
    /// BranchNumber الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryMachineDetail
    /// BranchYear الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryMachineDetail
    /// BranchUser الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryMachineDetail
    /// ExternalPostFlag الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// MinQuantity of the InventoryMachineDetail
    /// MinQuantity الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? MinQuantity { get; private set; }

    /// <summary>
    /// KitItem of the InventoryMachineDetail
    /// KitItem الخاص بـ InventoryMachineDetail
    /// </summary>
    public decimal? KitItem { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to InventoryMachineMaster
    /// </summary>
    public InventoryMachineMaster InventoryMachineMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
