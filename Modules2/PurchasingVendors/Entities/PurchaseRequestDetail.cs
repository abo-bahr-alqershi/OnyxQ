using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseRequestDetail Entity
/// </summary>
public class PurchaseRequestDetail : Entity<PurchaseRequestDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<PurchaseRequest> _purchaseRequest = new List<PurchaseRequest>();

    private PurchaseRequestDetail() { }

    public PurchaseRequestDetail(PurchaseRequestDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchaseRequestDetail
    /// المعرف الفريد لـ PurchaseRequestDetail
    /// </summary>
    public PurchaseRequestDetailId Id { get; private set; }

    /// <summary>
    /// PriceTypeFull of the PurchaseRequestDetail
    /// PriceTypeFull الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PriceTypeFull { get; private set; }

    /// <summary>
    /// PriceNumber of the PurchaseRequestDetail
    /// PriceNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PriceNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the PurchaseRequestDetail
    /// ItemQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PSize of the PurchaseRequestDetail
    /// PSize الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the PurchaseRequestDetail
    /// PQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the PurchaseRequestDetail
    /// WarehouseCode الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RecordNumber of the PurchaseRequestDetail
    /// RecordNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemDescription of the PurchaseRequestDetail
    /// ItemDescription الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// UseAttachment of the PurchaseRequestDetail
    /// UseAttachment الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// ReceiveAttachment of the PurchaseRequestDetail
    /// ReceiveAttachment الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ReceiveAttachment { get; private set; }

    /// <summary>
    /// AvailableQuantity of the PurchaseRequestDetail
    /// AvailableQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// AvailableQuantityAll of the PurchaseRequestDetail
    /// AvailableQuantityAll الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? AvailableQuantityAll { get; private set; }

    /// <summary>
    /// ArrivedQuantity of the PurchaseRequestDetail
    /// ArrivedQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ArrivedQuantity { get; private set; }

    /// <summary>
    /// PurchaseOrderQuantityShort of the PurchaseRequestDetail
    /// PurchaseOrderQuantityShort الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PurchaseOrderQuantityShort { get; private set; }

    /// <summary>
    /// ItemMinQuantityShort of the PurchaseRequestDetail
    /// ItemMinQuantityShort الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemMinQuantityShort { get; private set; }

    /// <summary>
    /// LastIncomePrice of the PurchaseRequestDetail
    /// LastIncomePrice الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? LastIncomePrice { get; private set; }

    /// <summary>
    /// Barcode of the PurchaseRequestDetail
    /// Barcode الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// OutgoingRequestNumber of the PurchaseRequestDetail
    /// OutgoingRequestNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? OutgoingRequestNumber { get; private set; }

    /// <summary>
    /// OutgoingRequestSerial of the PurchaseRequestDetail
    /// OutgoingRequestSerial الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? OutgoingRequestSerial { get; private set; }

    /// <summary>
    /// DocSequence of the PurchaseRequestDetail
    /// DocSequence الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ItemLength of the PurchaseRequestDetail
    /// ItemLength الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the PurchaseRequestDetail
    /// ItemWidth الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the PurchaseRequestDetail
    /// ItemHeightShort الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the PurchaseRequestDetail
    /// ItemNumberShort الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// NotPurchaseOrderPreviousQuantity of the PurchaseRequestDetail
    /// NotPurchaseOrderPreviousQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? NotPurchaseOrderPreviousQuantity { get; private set; }

    /// <summary>
    /// PurchaseOrderPreviousQuantity of the PurchaseRequestDetail
    /// PurchaseOrderPreviousQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PurchaseOrderPreviousQuantity { get; private set; }

    /// <summary>
    /// WeightedQuantity of the PurchaseRequestDetail
    /// WeightedQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// WeightedUnit of the PurchaseRequestDetail
    /// WeightedUnit الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// ExpireDate of the PurchaseRequestDetail
    /// ExpireDate الخاص بـ PurchaseRequestDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the PurchaseRequestDetail
    /// BatchNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// PurchaseCount of the PurchaseRequestDetail
    /// PurchaseCount الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PurchaseCount { get; private set; }

    /// <summary>
    /// LostDay of the PurchaseRequestDetail
    /// LostDay الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? LostDay { get; private set; }

    /// <summary>
    /// ItemRoll of the PurchaseRequestDetail
    /// ItemRoll الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemRoll { get; private set; }

    /// <summary>
    /// SQuantity of the PurchaseRequestDetail
    /// SQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? SQuantity { get; private set; }

    /// <summary>
    /// PurchaseOrderQuantity of the PurchaseRequestDetail
    /// PurchaseOrderQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PurchaseOrderQuantity { get; private set; }

    /// <summary>
    /// PurchaseOrderQuantityOpen of the PurchaseRequestDetail
    /// PurchaseOrderQuantityOpen الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PurchaseOrderQuantityOpen { get; private set; }

    /// <summary>
    /// LastIncomeQuantity of the PurchaseRequestDetail
    /// LastIncomeQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? LastIncomeQuantity { get; private set; }

    /// <summary>
    /// LastIncomeDate of the PurchaseRequestDetail
    /// LastIncomeDate الخاص بـ PurchaseRequestDetail
    /// </summary>
    public DateTime? LastIncomeDate { get; private set; }

    /// <summary>
    /// LastExpireDate of the PurchaseRequestDetail
    /// LastExpireDate الخاص بـ PurchaseRequestDetail
    /// </summary>
    public DateTime? LastExpireDate { get; private set; }

    /// <summary>
    /// LastFreeQuantity of the PurchaseRequestDetail
    /// LastFreeQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? LastFreeQuantity { get; private set; }

    /// <summary>
    /// PeriodLastFreeQuantity of the PurchaseRequestDetail
    /// PeriodLastFreeQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? PeriodLastFreeQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the PurchaseRequestDetail
    /// ItemPriceShort الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchaseRequestDetail
    /// CostCenterCode الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchaseRequestDetail
    /// ProjectNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchaseRequestDetail
    /// ActivityNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ArgumentNumber of the PurchaseRequestDetail
    /// ArgumentNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// DocNoRef of the PurchaseRequestDetail
    /// DocNoRef الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PurchaseRequestDetail
    /// DocSerRef الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocTypRef of the PurchaseRequestDetail
    /// DocTypRef الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocSequenceRef of the PurchaseRequestDetail
    /// DocSequenceRef الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseRequestDetail
    /// CompanyNumberShort الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseRequestDetail
    /// BranchNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseRequestDetail
    /// BranchYear الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseRequestDetail
    /// BranchUser الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// FieldDetail1 of the PurchaseRequestDetail
    /// FieldDetail1 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail1 { get; private set; }

    /// <summary>
    /// FieldDetail2 of the PurchaseRequestDetail
    /// FieldDetail2 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail2 { get; private set; }

    /// <summary>
    /// FieldDetail3 of the PurchaseRequestDetail
    /// FieldDetail3 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail3 { get; private set; }

    /// <summary>
    /// FieldDetail4 of the PurchaseRequestDetail
    /// FieldDetail4 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail4 { get; private set; }

    /// <summary>
    /// FieldDetail5 of the PurchaseRequestDetail
    /// FieldDetail5 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail5 { get; private set; }

    /// <summary>
    /// FieldDetail6 of the PurchaseRequestDetail
    /// FieldDetail6 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail6 { get; private set; }

    /// <summary>
    /// FieldDetail7 of the PurchaseRequestDetail
    /// FieldDetail7 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail7 { get; private set; }

    /// <summary>
    /// FieldDetail8 of the PurchaseRequestDetail
    /// FieldDetail8 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail8 { get; private set; }

    /// <summary>
    /// FieldDetail9 of the PurchaseRequestDetail
    /// FieldDetail9 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail9 { get; private set; }

    /// <summary>
    /// FieldDetail10 of the PurchaseRequestDetail
    /// FieldDetail10 الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string FieldDetail10 { get; private set; }

    /// <summary>
    /// ManualReferenceNumber of the PurchaseRequestDetail
    /// ManualReferenceNumber الخاص بـ PurchaseRequestDetail
    /// </summary>
    public string ManualReferenceNumber { get; private set; }

    /// <summary>
    /// ShipDate of the PurchaseRequestDetail
    /// ShipDate الخاص بـ PurchaseRequestDetail
    /// </summary>
    public DateTime? ShipDate { get; private set; }

    /// <summary>
    /// ExpectedQuantity of the PurchaseRequestDetail
    /// ExpectedQuantity الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? ExpectedQuantity { get; private set; }

    /// <summary>
    /// DisPer of the PurchaseRequestDetail
    /// DisPer الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmtDtl of the PurchaseRequestDetail
    /// DisAmtDtl الخاص بـ PurchaseRequestDetail
    /// </summary>
    public decimal? DisAmtDtl { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<PurchaseRequest> PurchaseRequest => _purchaseRequest;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

