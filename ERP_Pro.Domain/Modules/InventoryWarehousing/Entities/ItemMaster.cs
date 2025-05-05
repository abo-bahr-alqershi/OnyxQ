using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.ProductionManufacturing.Entities;
using ERP_Pro.Domain.ERP.InsuranceClaims.Entities;
using ERP_Pro.Domain.ERP.TransportationShipping.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;
using ERP_Pro.Domain.ERP.TaxFees.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemMaster Entity
/// </summary>
public class ItemMaster : AggregateRoot<ItemMasterId>
{

    private ItemMaster() { }

    public ItemMaster(ItemMasterId id, string itemCode)
    {
        Id = id;
        ItemCode = itemCode;
    }

    /// <summary>
    /// The unique identifier for the ItemMaster
    /// المعرف الفريد لـ ItemMaster
    /// </summary>
    public ItemMasterId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemMaster
    /// ItemCode الخاص بـ ItemMaster
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemNameFull of the ItemMaster
    /// ItemNameFull الخاص بـ ItemMaster
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// ItemNameEnglish of the ItemMaster
    /// ItemNameEnglish الخاص بـ ItemMaster
    /// </summary>
    public string ItemNameEnglish { get; private set; }

    /// <summary>
    /// ManagerCode of the ItemMaster
    /// ManagerCode الخاص بـ ItemMaster
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the ItemMaster
    /// SubGroupCode الخاص بـ ItemMaster
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// ItemSize of the ItemMaster
    /// ItemSize الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemSize { get; private set; }

    /// <summary>
    /// PrimaryCost of the ItemMaster
    /// PrimaryCost الخاص بـ ItemMaster
    /// </summary>
    public decimal? PrimaryCost { get; private set; }

    /// <summary>
    /// ItemCostWeightedAverageShort of the ItemMaster
    /// ItemCostWeightedAverageShort الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemCostWeightedAverageShort { get; private set; }

    /// <summary>
    /// ItemDescriptionShort of the ItemMaster
    /// ItemDescriptionShort الخاص بـ ItemMaster
    /// </summary>
    public string ItemDescriptionShort { get; private set; }

    /// <summary>
    /// AlterCode of the ItemMaster
    /// AlterCode الخاص بـ ItemMaster
    /// </summary>
    public string AlterCode { get; private set; }

    /// <summary>
    /// ManufacturerCode of the ItemMaster
    /// ManufacturerCode الخاص بـ ItemMaster
    /// </summary>
    public string ManufacturerCode { get; private set; }

    /// <summary>
    /// BlockedFlag of the ItemMaster
    /// BlockedFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? BlockedFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the ItemMaster
    /// InactiveFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the ItemMaster
    /// InactiveReason الخاص بـ ItemMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the ItemMaster
    /// InactiveDate الخاص بـ ItemMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the ItemMaster
    /// InactivatedByUserId الخاص بـ ItemMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// ServiceItemShort of the ItemMaster
    /// ServiceItemShort الخاص بـ ItemMaster
    /// </summary>
    public decimal? ServiceItemShort { get; private set; }

    /// <summary>
    /// CashSale of the ItemMaster
    /// CashSale الخاص بـ ItemMaster
    /// </summary>
    public decimal? CashSale { get; private set; }

    /// <summary>
    /// NoReturnSale of the ItemMaster
    /// NoReturnSale الخاص بـ ItemMaster
    /// </summary>
    public decimal? NoReturnSale { get; private set; }

    /// <summary>
    /// ReturnPeriod of the ItemMaster
    /// ReturnPeriod الخاص بـ ItemMaster
    /// </summary>
    public decimal? ReturnPeriod { get; private set; }

    /// <summary>
    /// KitItem of the ItemMaster
    /// KitItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? KitItem { get; private set; }

    /// <summary>
    /// UseExportDate of the ItemMaster
    /// UseExportDate الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseExportDate { get; private set; }

    /// <summary>
    /// UseBatchNumber of the ItemMaster
    /// UseBatchNumber الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseBatchNumber { get; private set; }

    /// <summary>
    /// UseSerialNumber of the ItemMaster
    /// UseSerialNumber الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseSerialNumber { get; private set; }

    /// <summary>
    /// UseAttachment of the ItemMaster
    /// UseAttachment الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseAttachment { get; private set; }

    /// <summary>
    /// VatType of the ItemMaster
    /// VatType الخاص بـ ItemMaster
    /// </summary>
    public decimal? VatType { get; private set; }

    /// <summary>
    /// VatPercent of the ItemMaster
    /// VatPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// AllowDiscount of the ItemMaster
    /// AllowDiscount الخاص بـ ItemMaster
    /// </summary>
    public decimal? AllowDiscount { get; private set; }

    /// <summary>
    /// DiscPer of the ItemMaster
    /// DiscPer الخاص بـ ItemMaster
    /// </summary>
    public decimal? DiscPer { get; private set; }

    /// <summary>
    /// AllowDiscountOnPurchaseInvoice of the ItemMaster
    /// AllowDiscountOnPurchaseInvoice الخاص بـ ItemMaster
    /// </summary>
    public decimal? AllowDiscountOnPurchaseInvoice { get; private set; }

    /// <summary>
    /// RestaurantItem of the ItemMaster
    /// RestaurantItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? RestaurantItem { get; private set; }

    /// <summary>
    /// DiscPerPi of the ItemMaster
    /// DiscPerPi الخاص بـ ItemMaster
    /// </summary>
    public decimal? DiscPerPi { get; private set; }

    /// <summary>
    /// AllowFreeQuantity of the ItemMaster
    /// AllowFreeQuantity الخاص بـ ItemMaster
    /// </summary>
    public decimal? AllowFreeQuantity { get; private set; }

    /// <summary>
    /// FreeQuantityPercent of the ItemMaster
    /// FreeQuantityPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? FreeQuantityPercent { get; private set; }

    /// <summary>
    /// UseQuantityFraction of the ItemMaster
    /// UseQuantityFraction الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseQuantityFraction { get; private set; }

    /// <summary>
    /// UnderSellingFlag of the ItemMaster
    /// UnderSellingFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? UnderSellingFlag { get; private set; }

    /// <summary>
    /// ItemImage of the ItemMaster
    /// ItemImage الخاص بـ ItemMaster
    /// </summary>
    public string ItemImage { get; private set; }

    /// <summary>
    /// DayItmExpire of the ItemMaster
    /// DayItmExpire الخاص بـ ItemMaster
    /// </summary>
    public decimal? DayItmExpire { get; private set; }

    /// <summary>
    /// MinLimitCostPercent of the ItemMaster
    /// MinLimitCostPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? MinLimitCostPercent { get; private set; }

    /// <summary>
    /// MaxLimitCostPercent of the ItemMaster
    /// MaxLimitCostPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? MaxLimitCostPercent { get; private set; }

    /// <summary>
    /// Field1 of the ItemMaster
    /// Field1 الخاص بـ ItemMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the ItemMaster
    /// Field2 الخاص بـ ItemMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the ItemMaster
    /// Field3 الخاص بـ ItemMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the ItemMaster
    /// Field4 الخاص بـ ItemMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the ItemMaster
    /// Field5 الخاص بـ ItemMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the ItemMaster
    /// Field6 الخاص بـ ItemMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the ItemMaster
    /// Field7 الخاص بـ ItemMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the ItemMaster
    /// Field8 الخاص بـ ItemMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the ItemMaster
    /// Field9 الخاص بـ ItemMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the ItemMaster
    /// Field10 الخاص بـ ItemMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ItemLength of the ItemMaster
    /// ItemLength الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// WidthItem of the ItemMaster
    /// WidthItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? WidthItem { get; private set; }

    /// <summary>
    /// ItemHeight of the ItemMaster
    /// ItemHeight الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemHeight { get; private set; }

    /// <summary>
    /// SizeItem of the ItemMaster
    /// SizeItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? SizeItem { get; private set; }

    /// <summary>
    /// AreaItem of the ItemMaster
    /// AreaItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? AreaItem { get; private set; }

    /// <summary>
    /// WeightItem of the ItemMaster
    /// WeightItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? WeightItem { get; private set; }

    /// <summary>
    /// SeasonItem of the ItemMaster
    /// SeasonItem الخاص بـ ItemMaster
    /// </summary>
    public string SeasonItem { get; private set; }

    /// <summary>
    /// OreItem of the ItemMaster
    /// OreItem الخاص بـ ItemMaster
    /// </summary>
    public string OreItem { get; private set; }

    /// <summary>
    /// MarkItem of the ItemMaster
    /// MarkItem الخاص بـ ItemMaster
    /// </summary>
    public string MarkItem { get; private set; }

    /// <summary>
    /// CompanyItem of the ItemMaster
    /// CompanyItem الخاص بـ ItemMaster
    /// </summary>
    public string CompanyItem { get; private set; }

    /// <summary>
    /// CountryItem of the ItemMaster
    /// CountryItem الخاص بـ ItemMaster
    /// </summary>
    public string CountryItem { get; private set; }

    /// <summary>
    /// IncomeDate of the ItemMaster
    /// IncomeDate الخاص بـ ItemMaster
    /// </summary>
    public DateTime? IncomeDate { get; private set; }

    /// <summary>
    /// Requirement of the ItemMaster
    /// Requirement الخاص بـ ItemMaster
    /// </summary>
    public decimal? Requirement { get; private set; }

    /// <summary>
    /// ItemStore of the ItemMaster
    /// ItemStore الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemStore { get; private set; }

    /// <summary>
    /// Assets of the ItemMaster
    /// Assets الخاص بـ ItemMaster
    /// </summary>
    public decimal? Assets { get; private set; }

    /// <summary>
    /// HasCommission of the ItemMaster
    /// HasCommission الخاص بـ ItemMaster
    /// </summary>
    public decimal? HasCommission { get; private set; }

    /// <summary>
    /// CommissionType of the ItemMaster
    /// CommissionType الخاص بـ ItemMaster
    /// </summary>
    public decimal? CommissionType { get; private set; }

    /// <summary>
    /// CommissionAmount of the ItemMaster
    /// CommissionAmount الخاص بـ ItemMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemMaster
    /// ActivityNumber الخاص بـ ItemMaster
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// VendorCode of the ItemMaster
    /// VendorCode الخاص بـ ItemMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorAccountCurrency of the ItemMaster
    /// VendorAccountCurrency الخاص بـ ItemMaster
    /// </summary>
    public string VendorAccountCurrency { get; private set; }

    /// <summary>
    /// VendorPrice of the ItemMaster
    /// VendorPrice الخاص بـ ItemMaster
    /// </summary>
    public decimal? VendorPrice { get; private set; }

    /// <summary>
    /// VendorItemCode of the ItemMaster
    /// VendorItemCode الخاص بـ ItemMaster
    /// </summary>
    public string VendorItemCode { get; private set; }

    /// <summary>
    /// HotKey of the ItemMaster
    /// HotKey الخاص بـ ItemMaster
    /// </summary>
    public decimal? HotKey { get; private set; }

    /// <summary>
    /// LowLimitPrintFirst of the ItemMaster
    /// LowLimitPrintFirst الخاص بـ ItemMaster
    /// </summary>
    public decimal? LowLimitPrintFirst { get; private set; }

    /// <summary>
    /// LowLimitPrintSecond of the ItemMaster
    /// LowLimitPrintSecond الخاص بـ ItemMaster
    /// </summary>
    public decimal? LowLimitPrintSecond { get; private set; }

    /// <summary>
    /// LowLimitApproveRequestAttachment of the ItemMaster
    /// LowLimitApproveRequestAttachment الخاص بـ ItemMaster
    /// </summary>
    public decimal? LowLimitApproveRequestAttachment { get; private set; }

    /// <summary>
    /// LowLimitNotApproveRequestAttachment of the ItemMaster
    /// LowLimitNotApproveRequestAttachment الخاص بـ ItemMaster
    /// </summary>
    public decimal? LowLimitNotApproveRequestAttachment { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the ItemMaster
    /// ImportExcelFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// DocTypeRef of the ItemMaster
    /// DocTypeRef الخاص بـ ItemMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ItemMaster
    /// DocNoRef الخاص بـ ItemMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ItemMaster
    /// DocSerRef الخاص بـ ItemMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// WeightedFlag of the ItemMaster
    /// WeightedFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? WeightedFlag { get; private set; }

    /// <summary>
    /// BalanceNumber of the ItemMaster
    /// BalanceNumber الخاص بـ ItemMaster
    /// </summary>
    public decimal? BalanceNumber { get; private set; }

    /// <summary>
    /// ReturnItemBeforeExpirePeriod of the ItemMaster
    /// ReturnItemBeforeExpirePeriod الخاص بـ ItemMaster
    /// </summary>
    public decimal? ReturnItemBeforeExpirePeriod { get; private set; }

    /// <summary>
    /// MeasureUnitReport of the ItemMaster
    /// MeasureUnitReport الخاص بـ ItemMaster
    /// </summary>
    public string MeasureUnitReport { get; private set; }

    /// <summary>
    /// PurchaseInvoiceBillNumber of the ItemMaster
    /// PurchaseInvoiceBillNumber الخاص بـ ItemMaster
    /// </summary>
    public decimal? PurchaseInvoiceBillNumber { get; private set; }

    /// <summary>
    /// UseGrant of the ItemMaster
    /// UseGrant الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseGrant { get; private set; }

    /// <summary>
    /// GrantPeriod of the ItemMaster
    /// GrantPeriod الخاص بـ ItemMaster
    /// </summary>
    public decimal? GrantPeriod { get; private set; }

    /// <summary>
    /// ItemColor of the ItemMaster
    /// ItemColor الخاص بـ ItemMaster
    /// </summary>
    public string ItemColor { get; private set; }

    /// <summary>
    /// ItemMeasure of the ItemMaster
    /// ItemMeasure الخاص بـ ItemMaster
    /// </summary>
    public string ItemMeasure { get; private set; }

    /// <summary>
    /// UseWeight of the ItemMaster
    /// UseWeight الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseWeight { get; private set; }

    /// <summary>
    /// ConnectionItemSalesOrderInclude of the ItemMaster
    /// ConnectionItemSalesOrderInclude الخاص بـ ItemMaster
    /// </summary>
    public decimal? ConnectionItemSalesOrderInclude { get; private set; }

    /// <summary>
    /// LinkBrochure of the ItemMaster
    /// LinkBrochure الخاص بـ ItemMaster
    /// </summary>
    public string LinkBrochure { get; private set; }

    /// <summary>
    /// LinkYoutube of the ItemMaster
    /// LinkYoutube الخاص بـ ItemMaster
    /// </summary>
    public string LinkYoutube { get; private set; }

    /// <summary>
    /// UseEmployeeFlag of the ItemMaster
    /// UseEmployeeFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseEmployeeFlag { get; private set; }

    /// <summary>
    /// AlterMultiFlag of the ItemMaster
    /// AlterMultiFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? AlterMultiFlag { get; private set; }

    /// <summary>
    /// ItemFullDescription of the ItemMaster
    /// ItemFullDescription الخاص بـ ItemMaster
    /// </summary>
    public string ItemFullDescription { get; private set; }

    /// <summary>
    /// RestaurantItemCombo of the ItemMaster
    /// RestaurantItemCombo الخاص بـ ItemMaster
    /// </summary>
    public decimal? RestaurantItemCombo { get; private set; }

    /// <summary>
    /// UsedItem of the ItemMaster
    /// UsedItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? UsedItem { get; private set; }

    /// <summary>
    /// MrpItem of the ItemMaster
    /// MrpItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? MrpItem { get; private set; }

    /// <summary>
    /// MrpItemClass of the ItemMaster
    /// MrpItemClass الخاص بـ ItemMaster
    /// </summary>
    public decimal? MrpItemClass { get; private set; }

    /// <summary>
    /// CustomerPercent of the ItemMaster
    /// CustomerPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? CustomerPercent { get; private set; }

    /// <summary>
    /// ProfitMarginPercent of the ItemMaster
    /// ProfitMarginPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? ProfitMarginPercent { get; private set; }

    /// <summary>
    /// CheckAvailableQuantityInReserve of the ItemMaster
    /// CheckAvailableQuantityInReserve الخاص بـ ItemMaster
    /// </summary>
    public decimal? CheckAvailableQuantityInReserve { get; private set; }

    /// <summary>
    /// FoodGroupNumber of the ItemMaster
    /// FoodGroupNumber الخاص بـ ItemMaster
    /// </summary>
    public string FoodGroupNumber { get; private set; }

    /// <summary>
    /// UseAutoPostRmsDataToInvoice of the ItemMaster
    /// UseAutoPostRmsDataToInvoice الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseAutoPostRmsDataToInvoice { get; private set; }

    /// <summary>
    /// HospitalItem of the ItemMaster
    /// HospitalItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? HospitalItem { get; private set; }

    /// <summary>
    /// GenerateItemFlag of the ItemMaster
    /// GenerateItemFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? GenerateItemFlag { get; private set; }

    /// <summary>
    /// ProcedureType of the ItemMaster
    /// ProcedureType الخاص بـ ItemMaster
    /// </summary>
    public decimal? ProcedureType { get; private set; }

    /// <summary>
    /// HsnCode of the ItemMaster
    /// HsnCode الخاص بـ ItemMaster
    /// </summary>
    public string HsnCode { get; private set; }

    /// <summary>
    /// CstStandr of the ItemMaster
    /// CstStandr الخاص بـ ItemMaster
    /// </summary>
    public decimal? CstStandr { get; private set; }

    /// <summary>
    /// CustomerLastProduct of the ItemMaster
    /// CustomerLastProduct الخاص بـ ItemMaster
    /// </summary>
    public decimal? CustomerLastProduct { get; private set; }

    /// <summary>
    /// ItemOrderNumber of the ItemMaster
    /// ItemOrderNumber الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemOrderNumber { get; private set; }

    /// <summary>
    /// ShortItemLastName of the ItemMaster
    /// ShortItemLastName الخاص بـ ItemMaster
    /// </summary>
    public string ShortItemLastName { get; private set; }

    /// <summary>
    /// ShortItemFirstName of the ItemMaster
    /// ShortItemFirstName الخاص بـ ItemMaster
    /// </summary>
    public string ShortItemFirstName { get; private set; }

    /// <summary>
    /// ItemMinQuantity of the ItemMaster
    /// ItemMinQuantity الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemMinQuantity { get; private set; }

    /// <summary>
    /// ItemMaxQuantity of the ItemMaster
    /// ItemMaxQuantity الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemMaxQuantity { get; private set; }

    /// <summary>
    /// SubFoodGroupNumber of the ItemMaster
    /// SubFoodGroupNumber الخاص بـ ItemMaster
    /// </summary>
    public string SubFoodGroupNumber { get; private set; }

    /// <summary>
    /// SampleType of the ItemMaster
    /// SampleType الخاص بـ ItemMaster
    /// </summary>
    public decimal? SampleType { get; private set; }

    /// <summary>
    /// RentService of the ItemMaster
    /// RentService الخاص بـ ItemMaster
    /// </summary>
    public decimal? RentService { get; private set; }

    /// <summary>
    /// PostWithAdmission of the ItemMaster
    /// PostWithAdmission الخاص بـ ItemMaster
    /// </summary>
    public decimal? PostWithAdmission { get; private set; }

    /// <summary>
    /// PostWithRent of the ItemMaster
    /// PostWithRent الخاص بـ ItemMaster
    /// </summary>
    public decimal? PostWithRent { get; private set; }

    /// <summary>
    /// HasPercent of the ItemMaster
    /// HasPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? HasPercent { get; private set; }

    /// <summary>
    /// BirthService of the ItemMaster
    /// BirthService الخاص بـ ItemMaster
    /// </summary>
    public decimal? BirthService { get; private set; }

    /// <summary>
    /// EquipmentService of the ItemMaster
    /// EquipmentService الخاص بـ ItemMaster
    /// </summary>
    public decimal? EquipmentService { get; private set; }

    /// <summary>
    /// SurgeryClass of the ItemMaster
    /// SurgeryClass الخاص بـ ItemMaster
    /// </summary>
    public decimal? SurgeryClass { get; private set; }

    /// <summary>
    /// ServiceSort of the ItemMaster
    /// ServiceSort الخاص بـ ItemMaster
    /// </summary>
    public decimal? ServiceSort { get; private set; }

    /// <summary>
    /// CssdFlag of the ItemMaster
    /// CssdFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? CssdFlag { get; private set; }

    /// <summary>
    /// LaundryFlag of the ItemMaster
    /// LaundryFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? LaundryFlag { get; private set; }

    /// <summary>
    /// UseQrCode of the ItemMaster
    /// UseQrCode الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseQrCode { get; private set; }

    /// <summary>
    /// ItemMinLimitQuantity of the ItemMaster
    /// ItemMinLimitQuantity الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemMinLimitQuantity { get; private set; }

    /// <summary>
    /// ItemMaxLimitQuantity of the ItemMaster
    /// ItemMaxLimitQuantity الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemMaxLimitQuantity { get; private set; }

    /// <summary>
    /// ItemRollLimitQuantity of the ItemMaster
    /// ItemRollLimitQuantity الخاص بـ ItemMaster
    /// </summary>
    public decimal? ItemRollLimitQuantity { get; private set; }

    /// <summary>
    /// DfltAsmOrdQty of the ItemMaster
    /// DfltAsmOrdQty الخاص بـ ItemMaster
    /// </summary>
    public decimal? DfltAsmOrdQty { get; private set; }

    /// <summary>
    /// FillItemComponentInRmsInvoice of the ItemMaster
    /// FillItemComponentInRmsInvoice الخاص بـ ItemMaster
    /// </summary>
    public decimal? FillItemComponentInRmsInvoice { get; private set; }

    /// <summary>
    /// UsePriceExpireDateOptional of the ItemMaster
    /// UsePriceExpireDateOptional الخاص بـ ItemMaster
    /// </summary>
    public decimal? UsePriceExpireDateOptional { get; private set; }

    /// <summary>
    /// UsePriceBatchNumberOptional of the ItemMaster
    /// UsePriceBatchNumberOptional الخاص بـ ItemMaster
    /// </summary>
    public decimal? UsePriceBatchNumberOptional { get; private set; }

    /// <summary>
    /// PurchaseServiceAccountCode of the ItemMaster
    /// PurchaseServiceAccountCode الخاص بـ ItemMaster
    /// </summary>
    public string PurchaseServiceAccountCode { get; private set; }

    /// <summary>
    /// FeedItemFlag of the ItemMaster
    /// FeedItemFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? FeedItemFlag { get; private set; }

    /// <summary>
    /// InsuranceFlag of the ItemMaster
    /// InsuranceFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? InsuranceFlag { get; private set; }

    /// <summary>
    /// GtinCode of the ItemMaster
    /// GtinCode الخاص بـ ItemMaster
    /// </summary>
    public string GtinCode { get; private set; }

    /// <summary>
    /// UseSerialNumberType of the ItemMaster
    /// UseSerialNumberType الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseSerialNumberType { get; private set; }

    /// <summary>
    /// UseQrCodeType of the ItemMaster
    /// UseQrCodeType الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseQrCodeType { get; private set; }

    /// <summary>
    /// QrCodeMethodNumber of the ItemMaster
    /// QrCodeMethodNumber الخاص بـ ItemMaster
    /// </summary>
    public decimal? QrCodeMethodNumber { get; private set; }

    /// <summary>
    /// UseBatchNumberAutoSequenceFlag of the ItemMaster
    /// UseBatchNumberAutoSequenceFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseBatchNumberAutoSequenceFlag { get; private set; }

    /// <summary>
    /// BatchNumberMethodNumberSequence of the ItemMaster
    /// BatchNumberMethodNumberSequence الخاص بـ ItemMaster
    /// </summary>
    public decimal? BatchNumberMethodNumberSequence { get; private set; }

    /// <summary>
    /// ExecutionTat of the ItemMaster
    /// ExecutionTat الخاص بـ ItemMaster
    /// </summary>
    public decimal? ExecutionTat { get; private set; }

    /// <summary>
    /// ExecutionTatUnit of the ItemMaster
    /// ExecutionTatUnit الخاص بـ ItemMaster
    /// </summary>
    public decimal? ExecutionTatUnit { get; private set; }

    /// <summary>
    /// HideItemChiefScreenFlag of the ItemMaster
    /// HideItemChiefScreenFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? HideItemChiefScreenFlag { get; private set; }

    /// <summary>
    /// KitItemClassificationType of the ItemMaster
    /// KitItemClassificationType الخاص بـ ItemMaster
    /// </summary>
    public decimal? KitItemClassificationType { get; private set; }

    /// <summary>
    /// StatisticalClass of the ItemMaster
    /// StatisticalClass الخاص بـ ItemMaster
    /// </summary>
    public decimal? StatisticalClass { get; private set; }

    /// <summary>
    /// GetAvailableQuantityFromComponentFlag of the ItemMaster
    /// GetAvailableQuantityFromComponentFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? GetAvailableQuantityFromComponentFlag { get; private set; }

    /// <summary>
    /// KitItemRank of the ItemMaster
    /// KitItemRank الخاص بـ ItemMaster
    /// </summary>
    public decimal? KitItemRank { get; private set; }

    /// <summary>
    /// LimitQuantitySalesCustomer of the ItemMaster
    /// LimitQuantitySalesCustomer الخاص بـ ItemMaster
    /// </summary>
    public decimal? LimitQuantitySalesCustomer { get; private set; }

    /// <summary>
    /// WeightValueItem of the ItemMaster
    /// WeightValueItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? WeightValueItem { get; private set; }

    /// <summary>
    /// UseItemInCssSystemFlag of the ItemMaster
    /// UseItemInCssSystemFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? UseItemInCssSystemFlag { get; private set; }

    /// <summary>
    /// InitialPrimaryCost of the ItemMaster
    /// InitialPrimaryCost الخاص بـ ItemMaster
    /// </summary>
    public decimal? InitialPrimaryCost { get; private set; }

    /// <summary>
    /// CheckItemPiecesMandatoryFlag of the ItemMaster
    /// CheckItemPiecesMandatoryFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? CheckItemPiecesMandatoryFlag { get; private set; }

    /// <summary>
    /// ExceedPercent of the ItemMaster
    /// ExceedPercent الخاص بـ ItemMaster
    /// </summary>
    public decimal? ExceedPercent { get; private set; }

    /// <summary>
    /// UsedInKitItem of the ItemMaster
    /// UsedInKitItem الخاص بـ ItemMaster
    /// </summary>
    public decimal? UsedInKitItem { get; private set; }

    /// <summary>
    /// MwsCheckFlag of the ItemMaster
    /// MwsCheckFlag الخاص بـ ItemMaster
    /// </summary>
    public decimal? MwsCheckFlag { get; private set; }

    /// <summary>
    /// DfltTimeMnt of the ItemMaster
    /// DfltTimeMnt الخاص بـ ItemMaster
    /// </summary>
    public decimal? DfltTimeMnt { get; private set; }

    /// <summary>
    /// LostPercentInPurchase of the ItemMaster
    /// LostPercentInPurchase الخاص بـ ItemMaster
    /// </summary>
    public decimal? LostPercentInPurchase { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GroupItemLevel GroupItemLevel { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemLevel ItemLevel { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public DetailGroup DetailGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AlternativeGroup AlternativeGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AssistantGroup AssistantGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemType ItemType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

