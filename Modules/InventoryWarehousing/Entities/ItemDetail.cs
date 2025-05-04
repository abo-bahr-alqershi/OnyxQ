using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemDetail Entity
/// </summary>
public class ItemDetail : Entity<ItemDetailId>
{
    private ItemDetail() { }

    /// <summary>
    /// The unique identifier for the ItemDetail
    /// المعرف الفريد لـ ItemDetail
    /// </summary>
    public ItemDetailId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemDetail
    /// ItemCode الخاص بـ ItemDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemDetail
    /// ItemUnit الخاص بـ ItemDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemDetail
    /// PSize الخاص بـ ItemDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// MainUnit of the ItemDetail
    /// MainUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? MainUnit { get; private set; }

    /// <summary>
    /// SaleUnit of the ItemDetail
    /// SaleUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? SaleUnit { get; private set; }

    /// <summary>
    /// PurchaseUnit of the ItemDetail
    /// PurchaseUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? PurchaseUnit { get; private set; }

    /// <summary>
    /// StockUnit of the ItemDetail
    /// StockUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? StockUnit { get; private set; }

    /// <summary>
    /// PriceUnit of the ItemDetail
    /// PriceUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? PriceUnit { get; private set; }

    /// <summary>
    /// NoSaleFlag of the ItemDetail
    /// NoSaleFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? NoSaleFlag { get; private set; }

    /// <summary>
    /// Barcode of the ItemDetail
    /// Barcode الخاص بـ ItemDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// LevelUnit of the ItemDetail
    /// LevelUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? LevelUnit { get; private set; }

    /// <summary>
    /// ExceptionDiscountCreditFlag of the ItemDetail
    /// ExceptionDiscountCreditFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? ExceptionDiscountCreditFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the ItemDetail
    /// InactiveFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the ItemDetail
    /// InactiveReason الخاص بـ ItemDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the ItemDetail
    /// InactivatedByUserId الخاص بـ ItemDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the ItemDetail
    /// InactiveDate الخاص بـ ItemDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// QrCodeMethodNumber of the ItemDetail
    /// QrCodeMethodNumber الخاص بـ ItemDetail
    /// </summary>
    public decimal? QrCodeMethodNumber { get; private set; }

    /// <summary>
    /// UseSerialNumberShort of the ItemDetail
    /// UseSerialNumberShort الخاص بـ ItemDetail
    /// </summary>
    public decimal? UseSerialNumberShort { get; private set; }

    /// <summary>
    /// ChiefUnitFlag of the ItemDetail
    /// ChiefUnitFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? ChiefUnitFlag { get; private set; }

    /// <summary>
    /// ItemUnitLastDescription of the ItemDetail
    /// ItemUnitLastDescription الخاص بـ ItemDetail
    /// </summary>
    public string ItemUnitLastDescription { get; private set; }

    /// <summary>
    /// ItemUnitFullDescription of the ItemDetail
    /// ItemUnitFullDescription الخاص بـ ItemDetail
    /// </summary>
    public string ItemUnitFullDescription { get; private set; }

    /// <summary>
    /// StoreUnit of the ItemDetail
    /// StoreUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? StoreUnit { get; private set; }

    /// <summary>
    /// WeightUnit of the ItemDetail
    /// WeightUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? WeightUnit { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ItemDetail to SalesChargeItem
    /// </summary>
    public IReadOnlyCollection<SalesChargeItem> SalesChargeItems { get; private set; }
    /// <summary>
    /// OneToOne relationship to SalesDiscount
    /// </summary>
    public SalesDiscount SalesDiscount { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to SalesFreeQuantity
    /// </summary>
    public IReadOnlyCollection<SalesFreeQuantity> SalesFreeQuantities { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to InvoiceDetail
    /// </summary>
    public IReadOnlyCollection<InvoiceDetail> InvoiceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to SaleCost
    /// </summary>
    public IReadOnlyCollection<SaleCost> SaleCosts { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to CalculateCommissionDetail
    /// </summary>
    public IReadOnlyCollection<CalculateCommissionDetail> CalculateCommissionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to CustomerItemLimitSale
    /// </summary>
    public IReadOnlyCollection<CustomerItemLimitSale> CustomerItemLimitSales { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to SalesCommission
    /// </summary>
    public IReadOnlyCollection<SalesCommission> SalesCommissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to SalesmanCalculateCommissionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCalculateCommissionDetail> SalesmanCalculateCommissionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to SalesmanSalesCommission
    /// </summary>
    public IReadOnlyCollection<SalesmanSalesCommission> SalesmanSalesCommissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to BillDetail
    /// </summary>
    public IReadOnlyCollection<BillDetail> BillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to BillExpireDetail
    /// </summary>
    public IReadOnlyCollection<BillExpireDetail> BillExpireDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to OutgoingDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingDetail> OutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to OutRequestDetail
    /// </summary>
    public IReadOnlyCollection<OutRequestDetail> OutRequestDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetail> ReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to OutgoingBillDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingBillDetail> OutgoingBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to PurchaseOrderDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseOrderDetail> PurchaseOrderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to PurchaseRequestDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseRequestDetail> PurchaseRequestDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to QuotationDetail
    /// </summary>
    public IReadOnlyCollection<QuotationDetail> QuotationDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to AccountsPayableDiscount
    /// </summary>
    public IReadOnlyCollection<AccountsPayableDiscount> AccountsPayableDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to PurchaseBillDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseBillDetail> PurchaseBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to QuotationPromotionDetail
    /// </summary>
    public IReadOnlyCollection<QuotationPromotionDetail> QuotationPromotionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to RequestMaterial
    /// </summary>
    public IReadOnlyCollection<RequestMaterial> RequestMaterials { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to TenderDetail
    /// </summary>
    public IReadOnlyCollection<TenderDetail> TenderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to VendorQuotationDetail
    /// </summary>
    public IReadOnlyCollection<VendorQuotationDetail> VendorQuotationDetails { get; private set; }
    /// <summary>
    /// OneToOne relationship to ItemCosting
    /// </summary>
    public ItemCosting ItemCosting { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ItemMovement
    /// </summary>
    public IReadOnlyCollection<ItemMovement> ItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to GoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptDetail> GoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to GoodsReceiptNoteDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteDetail> GoodsReceiptNoteDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to GateGoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<GateGoodsReceiptDetail> GateGoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to StockAdjustmentDetail
    /// </summary>
    public IReadOnlyCollection<StockAdjustmentDetail> StockAdjustmentDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to GoodsReceiptIncomingDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingDetail> GoodsReceiptIncomingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to IncomingOutgoingDetail
    /// </summary>
    public IReadOnlyCollection<IncomingOutgoingDetail> IncomingOutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ItemPrice
    /// </summary>
    public IReadOnlyCollection<ItemPrice> ItemPrices { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<ItemSerialNumber> ItemSerialNumbers { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Measurement
    /// </summary>
    public Measurement Measurement { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ItemPeriodicCost
    /// </summary>
    public IReadOnlyCollection<ItemPeriodicCost> ItemPeriodicCosts { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ItemUnitBarcode
    /// </summary>
    public IReadOnlyCollection<ItemUnitBarcode> ItemUnitBarcodes { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ItemWarehouseCode
    /// </summary>
    public IReadOnlyCollection<ItemWarehouseCode> ItemWarehouseCodes { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to OpeningStock
    /// </summary>
    public IReadOnlyCollection<OpeningStock> OpeningStocks { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to PerformaInvoiceBillDetail
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillDetail> PerformaInvoiceBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ReservationDetail
    /// </summary>
    public IReadOnlyCollection<ReservationDetail> ReservationDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to WarehouseTransferDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferDetail> WarehouseTransferDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to WarehouseTransferMultiDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiDetail> WarehouseTransferMultiDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to CompoundItem
    /// </summary>
    public IReadOnlyCollection<CompoundItem> CompoundItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to DisassembleKitItemsDetail
    /// </summary>
    public IReadOnlyCollection<DisassembleKitItemsDetail> DisassembleKitItemsDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to KitItem
    /// </summary>
    public IReadOnlyCollection<KitItem> KitItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to KitItemDetail
    /// </summary>
    public IReadOnlyCollection<KitItemDetail> KitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to WorkOrderDetail
    /// </summary>
    public IReadOnlyCollection<WorkOrderDetail> WorkOrderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to RepairOrderDetail
    /// </summary>
    public IReadOnlyCollection<RepairOrderDetail> RepairOrderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to OrderDetail
    /// </summary>
    public IReadOnlyCollection<OrderDetail> OrderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ExpenseDetail
    /// </summary>
    public IReadOnlyCollection<ExpenseDetail> ExpenseDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to OtherChargeItem
    /// </summary>
    public IReadOnlyCollection<OtherChargeItem> OtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to SalesCharge
    /// </summary>
    public IReadOnlyCollection<SalesCharge> SalesCharges { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to GroupDetail
    /// </summary>
    public IReadOnlyCollection<GroupDetail> GroupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to CustomerClass
    /// </summary>
    public IReadOnlyCollection<CustomerClass> CustomerClasses { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to WarehouseGroup
    /// </summary>
    public IReadOnlyCollection<WarehouseGroup> WarehouseGroups { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ReceiptDocument
    /// </summary>
    public IReadOnlyCollection<ReceiptDocument> ReceiptDocuments { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to PricingLevel
    /// </summary>
    public IReadOnlyCollection<PricingLevel> PricingLevels { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemDetail to ItemMaster
    /// </summary>
    public IReadOnlyCollection<ItemMaster> ItemMasters { get; private set; }
    #endregion
}
}
