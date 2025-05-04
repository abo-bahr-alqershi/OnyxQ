using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// VoucherDetails Entity
/// </summary>
public class VoucherDetails : Entity<VoucherDetailsId>
{
    private VoucherDetails() { }

    /// <summary>
    /// The unique identifier for the VoucherDetails
    /// المعرف الفريد لـ VoucherDetails
    /// </summary>
    public VoucherDetailsId Id { get; private set; }

    /// <summary>
    /// VendorCode of the VoucherDetails
    /// VendorCode الخاص بـ VoucherDetails
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorNameArabic of the VoucherDetails
    /// VendorNameArabic الخاص بـ VoucherDetails
    /// </summary>
    public string VendorNameArabic { get; private set; }

    /// <summary>
    /// VendorNameEnglish of the VoucherDetails
    /// VendorNameEnglish الخاص بـ VoucherDetails
    /// </summary>
    public string VendorNameEnglish { get; private set; }

    /// <summary>
    /// VendorAccountCode of the VoucherDetails
    /// VendorAccountCode الخاص بـ VoucherDetails
    /// </summary>
    public string VendorAccountCode { get; private set; }

    /// <summary>
    /// VendorGroupCode of the VoucherDetails
    /// VendorGroupCode الخاص بـ VoucherDetails
    /// </summary>
    public decimal? VendorGroupCode { get; private set; }

    /// <summary>
    /// VendorClass of the VoucherDetails
    /// VendorClass الخاص بـ VoucherDetails
    /// </summary>
    public decimal? VendorClass { get; private set; }

    /// <summary>
    /// VendorDegree of the VoucherDetails
    /// VendorDegree الخاص بـ VoucherDetails
    /// </summary>
    public decimal? VendorDegree { get; private set; }

    /// <summary>
    /// VendorTaxCode of the VoucherDetails
    /// VendorTaxCode الخاص بـ VoucherDetails
    /// </summary>
    public string VendorTaxCode { get; private set; }

    /// <summary>
    /// Taxpayer of the VoucherDetails
    /// Taxpayer الخاص بـ VoucherDetails
    /// </summary>
    public decimal? Taxpayer { get; private set; }

    /// <summary>
    /// VendorAddress of the VoucherDetails
    /// VendorAddress الخاص بـ VoucherDetails
    /// </summary>
    public string VendorAddress { get; private set; }

    /// <summary>
    /// CountryNumber of the VoucherDetails
    /// CountryNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the VoucherDetails
    /// CityNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the VoucherDetails
    /// CostCenterCode الخاص بـ VoucherDetails
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CostCenterNumber of the VoucherDetails
    /// CostCenterNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? CostCenterNumber { get; private set; }

    /// <summary>
    /// VendorPhone of the VoucherDetails
    /// VendorPhone الخاص بـ VoucherDetails
    /// </summary>
    public string VendorPhone { get; private set; }

    /// <summary>
    /// VendorFax of the VoucherDetails
    /// VendorFax الخاص بـ VoucherDetails
    /// </summary>
    public string VendorFax { get; private set; }

    /// <summary>
    /// VendorBox of the VoucherDetails
    /// VendorBox الخاص بـ VoucherDetails
    /// </summary>
    public string VendorBox { get; private set; }

    /// <summary>
    /// VendorPerson of the VoucherDetails
    /// VendorPerson الخاص بـ VoucherDetails
    /// </summary>
    public string VendorPerson { get; private set; }

    /// <summary>
    /// VendorEmail of the VoucherDetails
    /// VendorEmail الخاص بـ VoucherDetails
    /// </summary>
    public string VendorEmail { get; private set; }

    /// <summary>
    /// VendorWebsite of the VoucherDetails
    /// VendorWebsite الخاص بـ VoucherDetails
    /// </summary>
    public string VendorWebsite { get; private set; }

    /// <summary>
    /// VendorMobile of the VoucherDetails
    /// VendorMobile الخاص بـ VoucherDetails
    /// </summary>
    public string VendorMobile { get; private set; }

    /// <summary>
    /// VendorSince of the VoucherDetails
    /// VendorSince الخاص بـ VoucherDetails
    /// </summary>
    public DateTime? VendorSince { get; private set; }

    /// <summary>
    /// InactiveFlag of the VoucherDetails
    /// InactiveFlag الخاص بـ VoucherDetails
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivePurchase of the VoucherDetails
    /// InactivePurchase الخاص بـ VoucherDetails
    /// </summary>
    public decimal? InactivePurchase { get; private set; }

    /// <summary>
    /// VendorNote of the VoucherDetails
    /// VendorNote الخاص بـ VoucherDetails
    /// </summary>
    public string VendorNote { get; private set; }

    /// <summary>
    /// BlackListFlag of the VoucherDetails
    /// BlackListFlag الخاص بـ VoucherDetails
    /// </summary>
    public decimal? BlackListFlag { get; private set; }

    /// <summary>
    /// BlackListReason of the VoucherDetails
    /// BlackListReason الخاص بـ VoucherDetails
    /// </summary>
    public string BlackListReason { get; private set; }

    /// <summary>
    /// CreditPeriod of the VoucherDetails
    /// CreditPeriod الخاص بـ VoucherDetails
    /// </summary>
    public decimal? CreditPeriod { get; private set; }

    /// <summary>
    /// AccountOperationNumber of the VoucherDetails
    /// AccountOperationNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? AccountOperationNumber { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the VoucherDetails
    /// ImportExcelFlag الخاص بـ VoucherDetails
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the VoucherDetails
    /// ConnectionBranchNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the VoucherDetails
    /// CalcVatPriceType الخاص بـ VoucherDetails
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// Field1 of the VoucherDetails
    /// Field1 الخاص بـ VoucherDetails
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the VoucherDetails
    /// Field2 الخاص بـ VoucherDetails
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the VoucherDetails
    /// Field3 الخاص بـ VoucherDetails
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the VoucherDetails
    /// Field4 الخاص بـ VoucherDetails
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the VoucherDetails
    /// Field5 الخاص بـ VoucherDetails
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the VoucherDetails
    /// Field6 الخاص بـ VoucherDetails
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the VoucherDetails
    /// Field7 الخاص بـ VoucherDetails
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the VoucherDetails
    /// Field8 الخاص بـ VoucherDetails
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the VoucherDetails
    /// Field9 الخاص بـ VoucherDetails
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the VoucherDetails
    /// Field10 الخاص بـ VoucherDetails
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// FavoriteAccountFlag of the VoucherDetails
    /// FavoriteAccountFlag الخاص بـ VoucherDetails
    /// </summary>
    public decimal? FavoriteAccountFlag { get; private set; }

    /// <summary>
    /// ConfigLastDate of the VoucherDetails
    /// ConfigLastDate الخاص بـ VoucherDetails
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// CreditNumberShort of the VoucherDetails
    /// CreditNumberShort الخاص بـ VoucherDetails
    /// </summary>
    public string CreditNumberShort { get; private set; }

    /// <summary>
    /// ActivityName of the VoucherDetails
    /// ActivityName الخاص بـ VoucherDetails
    /// </summary>
    public string ActivityName { get; private set; }

    /// <summary>
    /// NisNumber of the VoucherDetails
    /// NisNumber الخاص بـ VoucherDetails
    /// </summary>
    public string NisNumber { get; private set; }

    /// <summary>
    /// NaiDescription of the VoucherDetails
    /// NaiDescription الخاص بـ VoucherDetails
    /// </summary>
    public string NaiDescription { get; private set; }

    /// <summary>
    /// EquipmentCapital of the VoucherDetails
    /// EquipmentCapital الخاص بـ VoucherDetails
    /// </summary>
    public string EquipmentCapital { get; private set; }

    /// <summary>
    /// CTaxCode of the VoucherDetails
    /// CTaxCode الخاص بـ VoucherDetails
    /// </summary>
    public string CTaxCode { get; private set; }

    /// <summary>
    /// VendorGcc of the VoucherDetails
    /// VendorGcc الخاص بـ VoucherDetails
    /// </summary>
    public decimal? VendorGcc { get; private set; }

    /// <summary>
    /// PanCode of the VoucherDetails
    /// PanCode الخاص بـ VoucherDetails
    /// </summary>
    public string PanCode { get; private set; }

    /// <summary>
    /// ProvinceNumber of the VoucherDetails
    /// ProvinceNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the VoucherDetails
    /// CalcTypeNumberTax الخاص بـ VoucherDetails
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// UseTdsFlag of the VoucherDetails
    /// UseTdsFlag الخاص بـ VoucherDetails
    /// </summary>
    public decimal? UseTdsFlag { get; private set; }

    /// <summary>
    /// UsePanNumber of the VoucherDetails
    /// UsePanNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? UsePanNumber { get; private set; }

    /// <summary>
    /// UsePriceListFlag of the VoucherDetails
    /// UsePriceListFlag الخاص بـ VoucherDetails
    /// </summary>
    public decimal? UsePriceListFlag { get; private set; }

    /// <summary>
    /// GlnCode of the VoucherDetails
    /// GlnCode الخاص بـ VoucherDetails
    /// </summary>
    public string GlnCode { get; private set; }

    /// <summary>
    /// UseAutoSyncVendor of the VoucherDetails
    /// UseAutoSyncVendor الخاص بـ VoucherDetails
    /// </summary>
    public decimal? UseAutoSyncVendor { get; private set; }

    /// <summary>
    /// ExternalCustomerCode of the VoucherDetails
    /// ExternalCustomerCode الخاص بـ VoucherDetails
    /// </summary>
    public string ExternalCustomerCode { get; private set; }

    /// <summary>
    /// UserNumber of the VoucherDetails
    /// UserNumber الخاص بـ VoucherDetails
    /// </summary>
    public string UserNumber { get; private set; }

    /// <summary>
    /// PasswordShort of the VoucherDetails
    /// PasswordShort الخاص بـ VoucherDetails
    /// </summary>
    public string PasswordShort { get; private set; }

    /// <summary>
    /// WebServiceUrl of the VoucherDetails
    /// WebServiceUrl الخاص بـ VoucherDetails
    /// </summary>
    public string WebServiceUrl { get; private set; }

    /// <summary>
    /// UnitServiceNumber of the VoucherDetails
    /// UnitServiceNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? UnitServiceNumber { get; private set; }

    /// <summary>
    /// YearServiceNumber of the VoucherDetails
    /// YearServiceNumber الخاص بـ VoucherDetails
    /// </summary>
    public decimal? YearServiceNumber { get; private set; }

    /// <summary>
    /// CreditPeriodType of the VoucherDetails
    /// CreditPeriodType الخاص بـ VoucherDetails
    /// </summary>
    public decimal? CreditPeriodType { get; private set; }

    /// <summary>
    /// UseCreditPeriodItem of the VoucherDetails
    /// UseCreditPeriodItem الخاص بـ VoucherDetails
    /// </summary>
    public decimal? UseCreditPeriodItem { get; private set; }

    /// <summary>
    /// LevelNumberPrice of the VoucherDetails
    /// LevelNumberPrice الخاص بـ VoucherDetails
    /// </summary>
    public decimal? LevelNumberPrice { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: VoucherDetails to JournalFileDetail
    /// </summary>
    public IReadOnlyCollection<JournalFileDetail> JournalFileDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to JournalVoucherDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherDetail> JournalVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VoucherDetail
    /// </summary>
    public IReadOnlyCollection<VoucherDetail> VoucherDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VendorDegree
    /// </summary>
    public VendorDegree VendorDegree { get; private set; }
    /// <summary>
    /// ManyToOne relationship to City
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Country
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VendorClass
    /// </summary>
    public VendorClass VendorClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VendorGroup
    /// </summary>
    public VendorGroup VendorGroup { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VoucherChequeDetail
    /// </summary>
    public IReadOnlyCollection<VoucherChequeDetail> VoucherChequeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VendorAccount
    /// </summary>
    public IReadOnlyCollection<VendorAccount> VendorAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VendorCurrency
    /// </summary>
    public IReadOnlyCollection<VendorCurrency> VendorCurrencies { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to PurchaseOrder
    /// </summary>
    public IReadOnlyCollection<PurchaseOrder> PurchaseOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to AccountsPayableDiscount
    /// </summary>
    public IReadOnlyCollection<AccountsPayableDiscount> AccountsPayableDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to PurchaseBillMaster
    /// </summary>
    public IReadOnlyCollection<PurchaseBillMaster> PurchaseBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VendorBank
    /// </summary>
    public IReadOnlyCollection<VendorBank> VendorBanks { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VendorClaimItemGroup
    /// </summary>
    public IReadOnlyCollection<VendorClaimItemGroup> VendorClaimItemGroups { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VendorItem
    /// </summary>
    public IReadOnlyCollection<VendorItem> VendorItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to VendorLimitPurchase
    /// </summary>
    public IReadOnlyCollection<VendorLimitPurchase> VendorLimitPurchases { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentAccountsPayableMaster> AdjustInstallmentAccountsPayableMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to GoodsReceiptNote
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNote> GoodsReceiptNotes { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to GoodsReceiptNoteMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteMaster> GoodsReceiptNoteMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to OpeningStock
    /// </summary>
    public IReadOnlyCollection<OpeningStock> OpeningStocks { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to PerformaInvoiceBillMaster
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMasterAdditionalDiscount> PerformaInvoiceBillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to WarehouseTransferMultiDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiDetail> WarehouseTransferMultiDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to LetterOfCreditMaster
    /// </summary>
    public IReadOnlyCollection<LetterOfCreditMaster> LetterOfCreditMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to Account
    /// </summary>
    public IReadOnlyCollection<Account> Accounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: VoucherDetails to ExchangeRate
    /// </summary>
    public IReadOnlyCollection<ExchangeRate> ExchangeRates { get; private set; }
    #endregion
}
}
