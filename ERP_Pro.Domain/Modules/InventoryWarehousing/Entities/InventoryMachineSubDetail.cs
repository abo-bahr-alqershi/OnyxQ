using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryMachineSubDetail Entity
/// </summary>
public class InventoryMachineSubDetail : Entity<InventoryMachineSubDetailId>
{
    private readonly List<InventoryMachineMaster> _inventoryMachineMaster = new List<InventoryMachineMaster>();
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<Warehouse> _warehouse = new List<Warehouse>();

    private InventoryMachineSubDetail() { }

    public InventoryMachineSubDetail(InventoryMachineSubDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InventoryMachineSubDetail
    /// المعرف الفريد لـ InventoryMachineSubDetail
    /// </summary>
    public InventoryMachineSubDetailId Id { get; private set; }

    /// <summary>
    /// InvoiceNumber of the InventoryMachineSubDetail
    /// InvoiceNumber الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? InvoiceNumber { get; private set; }

    /// <summary>
    /// InvoiceType of the InventoryMachineSubDetail
    /// InvoiceType الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? InvoiceType { get; private set; }

    /// <summary>
    /// ItemQuantity of the InventoryMachineSubDetail
    /// ItemQuantity الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the InventoryMachineSubDetail
    /// PSize الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the InventoryMachineSubDetail
    /// PQuantity الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// BankCode of the InventoryMachineSubDetail
    /// BankCode الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public string BankCode { get; private set; }

    /// <summary>
    /// Barcode of the InventoryMachineSubDetail
    /// Barcode الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// ExpireDate of the InventoryMachineSubDetail
    /// ExpireDate الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the InventoryMachineSubDetail
    /// BatchNumber الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// AvailableQuantity of the InventoryMachineSubDetail
    /// AvailableQuantity الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryMachineSubDetail
    /// RecordNumber الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the InventoryMachineSubDetail
    /// UseAttachment الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ItemDescription of the InventoryMachineSubDetail
    /// ItemDescription الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// AttachmentNumber1 of the InventoryMachineSubDetail
    /// AttachmentNumber1 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentNumber1 { get; private set; }

    /// <summary>
    /// AttachmentNumber2 of the InventoryMachineSubDetail
    /// AttachmentNumber2 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentNumber2 { get; private set; }

    /// <summary>
    /// AttachmentNumber3 of the InventoryMachineSubDetail
    /// AttachmentNumber3 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentNumber3 { get; private set; }

    /// <summary>
    /// AttachmentNumber4 of the InventoryMachineSubDetail
    /// AttachmentNumber4 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentNumber4 { get; private set; }

    /// <summary>
    /// AttachmentNumber5 of the InventoryMachineSubDetail
    /// AttachmentNumber5 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentNumber5 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber1 of the InventoryMachineSubDetail
    /// AttachmentDescriptionNumber1 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber1 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber2 of the InventoryMachineSubDetail
    /// AttachmentDescriptionNumber2 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber2 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber3 of the InventoryMachineSubDetail
    /// AttachmentDescriptionNumber3 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber3 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber4 of the InventoryMachineSubDetail
    /// AttachmentDescriptionNumber4 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber4 { get; private set; }

    /// <summary>
    /// AttachmentDescriptionNumber5 of the InventoryMachineSubDetail
    /// AttachmentDescriptionNumber5 الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? AttachmentDescriptionNumber5 { get; private set; }

    /// <summary>
    /// FlexNumber of the InventoryMachineSubDetail
    /// FlexNumber الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? FlexNumber { get; private set; }

    /// <summary>
    /// ItemLength of the InventoryMachineSubDetail
    /// ItemLength الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the InventoryMachineSubDetail
    /// ItemWidth الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the InventoryMachineSubDetail
    /// ItemHeightShort الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the InventoryMachineSubDetail
    /// ItemNumberShort الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryMachineSubDetail
    /// CompanyNumberShort الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryMachineSubDetail
    /// BranchNumber الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryMachineSubDetail
    /// BranchYear الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryMachineSubDetail
    /// BranchUser الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryMachineSubDetail
    /// ExternalPostFlag الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ItemUnit of the InventoryMachineSubDetail
    /// ItemUnit الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the InventoryMachineSubDetail
    /// WeightedQuantity الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the InventoryMachineSubDetail
    /// WeightedUnit الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ArgumentNumber of the InventoryMachineSubDetail
    /// ArgumentNumber الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// DocSequence of the InventoryMachineSubDetail
    /// DocSequence الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DmgFlg of the InventoryMachineSubDetail
    /// DmgFlg الخاص بـ InventoryMachineSubDetail
    /// </summary>
    public decimal? DmgFlg { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<InventoryMachineMaster> InventoryMachineMaster => _inventoryMachineMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Warehouse> Warehouse => _warehouse;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
