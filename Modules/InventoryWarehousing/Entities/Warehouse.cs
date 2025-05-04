using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// Warehouse Entity
/// </summary>
public class Warehouse : Entity<WarehouseId>
{
    private Warehouse() { }

    /// <summary>
    /// The unique identifier for the Warehouse
    /// المعرف الفريد لـ Warehouse
    /// </summary>
    public WarehouseId Id { get; private set; }

    /// <summary>
    /// WarehouseCode of the Warehouse
    /// WarehouseCode الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseName of the Warehouse
    /// WarehouseName الخاص بـ Warehouse
    /// </summary>
    public string WarehouseName { get; private set; }

    /// <summary>
    /// WarehouseNameEnglish of the Warehouse
    /// WarehouseNameEnglish الخاص بـ Warehouse
    /// </summary>
    public string WarehouseNameEnglish { get; private set; }

    /// <summary>
    /// Location of the Warehouse
    /// Location الخاص بـ Warehouse
    /// </summary>
    public string Location { get; private set; }

    /// <summary>
    /// TelephoneNumber of the Warehouse
    /// TelephoneNumber الخاص بـ Warehouse
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the Warehouse
    /// InactiveFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// WarehouseKeeper of the Warehouse
    /// WarehouseKeeper الخاص بـ Warehouse
    /// </summary>
    public string WarehouseKeeper { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the Warehouse
    /// WarehouseGroupCode الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// WarehouseType of the Warehouse
    /// WarehouseType الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseType { get; private set; }

    /// <summary>
    /// UseBillOfExchange of the Warehouse
    /// UseBillOfExchange الخاص بـ Warehouse
    /// </summary>
    public decimal? UseBillOfExchange { get; private set; }

    /// <summary>
    /// NoSaleFlag of the Warehouse
    /// NoSaleFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? NoSaleFlag { get; private set; }

    /// <summary>
    /// CheckAvailableQuantity of the Warehouse
    /// CheckAvailableQuantity الخاص بـ Warehouse
    /// </summary>
    public decimal? CheckAvailableQuantity { get; private set; }

    /// <summary>
    /// TransactionAccountCode of the Warehouse
    /// TransactionAccountCode الخاص بـ Warehouse
    /// </summary>
    public string TransactionAccountCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the Warehouse
    /// CostCenterCode الخاص بـ Warehouse
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CountryNumber of the Warehouse
    /// CountryNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// Gps of the Warehouse
    /// Gps الخاص بـ Warehouse
    /// </summary>
    public string Gps { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Warehouse
    /// ProvinceNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the Warehouse
    /// CityNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the Warehouse
    /// RegionCode الخاص بـ Warehouse
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// WarehouseSerial of the Warehouse
    /// WarehouseSerial الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseSerial { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the Warehouse
    /// ConnectionBranchNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the Warehouse
    /// ActivityNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// MainWarehouseCode of the Warehouse
    /// MainWarehouseCode الخاص بـ Warehouse
    /// </summary>
    public decimal? MainWarehouseCode { get; private set; }

    /// <summary>
    /// DbLinkName of the Warehouse
    /// DbLinkName الخاص بـ Warehouse
    /// </summary>
    public string DbLinkName { get; private set; }

    /// <summary>
    /// UseAutoReceiveWarehouseTransfer of the Warehouse
    /// UseAutoReceiveWarehouseTransfer الخاص بـ Warehouse
    /// </summary>
    public decimal? UseAutoReceiveWarehouseTransfer { get; private set; }

    /// <summary>
    /// PriceLevel of the Warehouse
    /// PriceLevel الخاص بـ Warehouse
    /// </summary>
    public decimal? PriceLevel { get; private set; }

    /// <summary>
    /// ServiceFlag of the Warehouse
    /// ServiceFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? ServiceFlag { get; private set; }

    /// <summary>
    /// Latitude of the Warehouse
    /// Latitude الخاص بـ Warehouse
    /// </summary>
    public string Latitude { get; private set; }

    /// <summary>
    /// Longitude of the Warehouse
    /// Longitude الخاص بـ Warehouse
    /// </summary>
    public string Longitude { get; private set; }

    /// <summary>
    /// GlnCode of the Warehouse
    /// GlnCode الخاص بـ Warehouse
    /// </summary>
    public string GlnCode { get; private set; }

    /// <summary>
    /// WarehouseLastAddress of the Warehouse
    /// WarehouseLastAddress الخاص بـ Warehouse
    /// </summary>
    public string WarehouseLastAddress { get; private set; }

    /// <summary>
    /// WarehouseFullAddress of the Warehouse
    /// WarehouseFullAddress الخاص بـ Warehouse
    /// </summary>
    public string WarehouseFullAddress { get; private set; }

    /// <summary>
    /// ShowWarehouseCodeType of the Warehouse
    /// ShowWarehouseCodeType الخاص بـ Warehouse
    /// </summary>
    public decimal? ShowWarehouseCodeType { get; private set; }

    /// <summary>
    /// ProjectNumber of the Warehouse
    /// ProjectNumber الخاص بـ Warehouse
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the Warehouse
    /// ActivityNumber الخاص بـ Warehouse
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// SalesOrderDescription of the Warehouse
    /// SalesOrderDescription الخاص بـ Warehouse
    /// </summary>
    public string SalesOrderDescription { get; private set; }

    /// <summary>
    /// SalesOrderType of the Warehouse
    /// SalesOrderType الخاص بـ Warehouse
    /// </summary>
    public decimal? SalesOrderType { get; private set; }

    /// <summary>
    /// ServiceNumber of the Warehouse
    /// ServiceNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// BankNumber of the Warehouse
    /// BankNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// RepCode of the Warehouse
    /// RepCode الخاص بـ Warehouse
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the Warehouse
    /// ColumnNumberShort الخاص بـ Warehouse
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CCode of the Warehouse
    /// CCode الخاص بـ Warehouse
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the Warehouse
    /// CalcTypeNumberTax الخاص بـ Warehouse
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CGroupCode of the Warehouse
    /// CGroupCode الخاص بـ Warehouse
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// ShowSystemType of the Warehouse
    /// ShowSystemType الخاص بـ Warehouse
    /// </summary>
    public decimal? ShowSystemType { get; private set; }

    /// <summary>
    /// UsePreparationFlag of the Warehouse
    /// UsePreparationFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? UsePreparationFlag { get; private set; }

    /// <summary>
    /// UseBinMovement of the Warehouse
    /// UseBinMovement الخاص بـ Warehouse
    /// </summary>
    public decimal? UseBinMovement { get; private set; }

    /// <summary>
    /// WarehouseCostLimit of the Warehouse
    /// WarehouseCostLimit الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseCostLimit { get; private set; }

    /// <summary>
    /// ForDamagedItem of the Warehouse
    /// ForDamagedItem الخاص بـ Warehouse
    /// </summary>
    public decimal? ForDamagedItem { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Warehouse to ActivitySerialNumberDetail
    /// </summary>
    public IReadOnlyCollection<ActivitySerialNumberDetail> ActivitySerialNumberDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to WarehousePermission
    /// </summary>
    public IReadOnlyCollection<WarehousePermission> WarehousePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to CreditCardType
    /// </summary>
    public IReadOnlyCollection<CreditCardType> CreditCardTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PostMaster
    /// </summary>
    public IReadOnlyCollection<PostMaster> PostMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to SalesDiscount
    /// </summary>
    public IReadOnlyCollection<SalesDiscount> SalesDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to SalesFreeQuantity
    /// </summary>
    public IReadOnlyCollection<SalesFreeQuantity> SalesFreeQuantities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to InvoiceDetail
    /// </summary>
    public IReadOnlyCollection<InvoiceDetail> InvoiceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to SaleCost
    /// </summary>
    public IReadOnlyCollection<SaleCost> SaleCosts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to CustomerItemActivity
    /// </summary>
    public IReadOnlyCollection<CustomerItemActivity> CustomerItemActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to SalesPlanDetail
    /// </summary>
    public IReadOnlyCollection<SalesPlanDetail> SalesPlanDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillDetail
    /// </summary>
    public IReadOnlyCollection<BillDetail> BillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillDetailAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscount> BillDetailAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillDetailAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscountRequest> BillDetailAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BranchBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchBillDetail> BranchBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillMaster
    /// </summary>
    public IReadOnlyCollection<BillMaster> BillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscount> BillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillMasterAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscountRequest> BillMasterAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BranchBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchBillMaster> BranchBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillExpireDetail
    /// </summary>
    public IReadOnlyCollection<BillExpireDetail> BillExpireDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BillExpireMaster
    /// </summary>
    public IReadOnlyCollection<BillExpireMaster> BillExpireMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to DueCreditCard
    /// </summary>
    public IReadOnlyCollection<DueCreditCard> DueCreditCards { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OutgoingDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingDetail> OutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OutgoingMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingMaster> OutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OutRequestDetail
    /// </summary>
    public IReadOnlyCollection<OutRequestDetail> OutRequestDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OutRequestMaster
    /// </summary>
    public IReadOnlyCollection<OutRequestMaster> OutRequestMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetail> ReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<ReturnBillMaster> ReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BranchReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillDetail> BranchReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ReturnBillDetailRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetailRequest> ReturnBillDetailRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BranchReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillMaster> BranchReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ReturnBillMasterRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillMasterRequest> ReturnBillMasterRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OutgoingBillDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingBillDetail> OutgoingBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OutgoingBillMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingBillMaster> OutgoingBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PurchaseOrderDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseOrderDetail> PurchaseOrderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PurchaseRequest
    /// </summary>
    public IReadOnlyCollection<PurchaseRequest> PurchaseRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PurchaseBillDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseBillDetail> PurchaseBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PurchaseBillMaster
    /// </summary>
    public IReadOnlyCollection<PurchaseBillMaster> PurchaseBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemMovement
    /// </summary>
    public IReadOnlyCollection<ItemMovement> ItemMovements { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Province
    /// </summary>
    public Province Province { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to City
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Country
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to BinDetail
    /// </summary>
    public IReadOnlyCollection<BinDetail> BinDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptDetail> GoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GoodsReceiptNote
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNote> GoodsReceiptNotes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GoodsReceiptNoteDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteDetail> GoodsReceiptNoteDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GoodsReceiptNoteMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteMaster> GoodsReceiptNoteMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ConnectWarehouseCodeByActivity
    /// </summary>
    public IReadOnlyCollection<ConnectWarehouseCodeByActivity> ConnectWarehouseCodeByActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GoodsReceiptIncomingDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingDetail> GoodsReceiptIncomingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GoodsReceiptIncomingMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingMaster> GoodsReceiptIncomingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to IncomingOutgoingDetail
    /// </summary>
    public IReadOnlyCollection<IncomingOutgoingDetail> IncomingOutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to IncomingOutgoingMaster
    /// </summary>
    public IReadOnlyCollection<IncomingOutgoingMaster> IncomingOutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to InventoryMachineDetail
    /// </summary>
    public IReadOnlyCollection<InventoryMachineDetail> InventoryMachineDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to InventoryMachineSubDetail
    /// </summary>
    public IReadOnlyCollection<InventoryMachineSubDetail> InventoryMachineSubDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemPrice
    /// </summary>
    public IReadOnlyCollection<ItemPrice> ItemPrices { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<ItemSerialNumber> ItemSerialNumbers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteItemSerialNumber> GoodsReceiptNoteItemSerialNumbers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OtherItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<OtherItemSerialNumber> OtherItemSerialNumbers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemAttachmentMovement
    /// </summary>
    public IReadOnlyCollection<ItemAttachmentMovement> ItemAttachmentMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OtherItemAttachment
    /// </summary>
    public IReadOnlyCollection<OtherItemAttachment> OtherItemAttachments { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemPeriodicCost
    /// </summary>
    public IReadOnlyCollection<ItemPeriodicCost> ItemPeriodicCosts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemQuantityLimit
    /// </summary>
    public IReadOnlyCollection<ItemQuantityLimit> ItemQuantityLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemWarehouseCode
    /// </summary>
    public IReadOnlyCollection<ItemWarehouseCode> ItemWarehouseCodes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to Machine
    /// </summary>
    public IReadOnlyCollection<Machine> Machines { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OnlineConnectWarehouseCode
    /// </summary>
    public IReadOnlyCollection<OnlineConnectWarehouseCode> OnlineConnectWarehouseCodes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OnlineConnectWarehouseCodeRegion
    /// </summary>
    public IReadOnlyCollection<OnlineConnectWarehouseCodeRegion> OnlineConnectWarehouseCodeRegions { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to OpeningStock
    /// </summary>
    public IReadOnlyCollection<OpeningStock> OpeningStocks { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PerformaInvoiceBillDetail
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillDetail> PerformaInvoiceBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillDetailAdditionalDiscount> PerformaInvoiceBillDetailAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PerformaInvoiceBillMaster
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMasterAdditionalDiscount> PerformaInvoiceBillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ReservationDetail
    /// </summary>
    public IReadOnlyCollection<ReservationDetail> ReservationDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ScaleMovement
    /// </summary>
    public IReadOnlyCollection<ScaleMovement> ScaleMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to WarehouseTransferDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferDetail> WarehouseTransferDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to WarehouseTransferMaster
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMaster> WarehouseTransferMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to WarehouseTransferMultiDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiDetail> WarehouseTransferMultiDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to RepairOrderDetail
    /// </summary>
    public IReadOnlyCollection<RepairOrderDetail> RepairOrderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to RepairOrderMaster
    /// </summary>
    public IReadOnlyCollection<RepairOrderMaster> RepairOrderMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to FreightDetail
    /// </summary>
    public IReadOnlyCollection<FreightDetail> FreightDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ExpenseDetail
    /// </summary>
    public IReadOnlyCollection<ExpenseDetail> ExpenseDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemDetail
    /// </summary>
    public IReadOnlyCollection<ItemDetail> ItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to CustomerClass
    /// </summary>
    public IReadOnlyCollection<CustomerClass> CustomerClasses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to WarehouseGroup
    /// </summary>
    public IReadOnlyCollection<WarehouseGroup> WarehouseGroups { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to GroupDetail
    /// </summary>
    public IReadOnlyCollection<GroupDetail> GroupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to PricingLevel
    /// </summary>
    public IReadOnlyCollection<PricingLevel> PricingLevels { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to ItemMaster
    /// </summary>
    public IReadOnlyCollection<ItemMaster> ItemMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Warehouse to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    #endregion
}
}
