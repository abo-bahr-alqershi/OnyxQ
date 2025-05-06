using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// Salesman Entity
/// </summary>
public class Salesman : Entity<SalesmanId>
{
    private readonly List<Salesman> _salesmans = new List<Salesman>();

    private Salesman() { }

    public Salesman(SalesmanId id, string representativeCode)
    {
        Id = id;
        RepresentativeCode = representativeCode;
    }

    /// <summary>
    /// The unique identifier for the Salesman
    /// المعرف الفريد لـ Salesman
    /// </summary>
    public SalesmanId Id { get; private set; }

    /// <summary>
    /// RepresentativeCode of the Salesman
    /// RepresentativeCode الخاص بـ Salesman
    /// </summary>
    public string RepresentativeCode { get; private set; }

    /// <summary>
    /// RepresentativeNameArabic of the Salesman
    /// RepresentativeNameArabic الخاص بـ Salesman
    /// </summary>
    public string RepresentativeNameArabic { get; private set; }

    /// <summary>
    /// RepresentativeNameEnglish of the Salesman
    /// RepresentativeNameEnglish الخاص بـ Salesman
    /// </summary>
    public string RepresentativeNameEnglish { get; private set; }

    /// <summary>
    /// RegionPhone of the Salesman
    /// RegionPhone الخاص بـ Salesman
    /// </summary>
    public string RegionPhone { get; private set; }

    /// <summary>
    /// InactiveFlag of the Salesman
    /// InactiveFlag الخاص بـ Salesman
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// RegionBox of the Salesman
    /// RegionBox الخاص بـ Salesman
    /// </summary>
    public string RegionBox { get; private set; }

    /// <summary>
    /// RegionFax of the Salesman
    /// RegionFax الخاص بـ Salesman
    /// </summary>
    public string RegionFax { get; private set; }

    /// <summary>
    /// RegionNote of the Salesman
    /// RegionNote الخاص بـ Salesman
    /// </summary>
    public string RegionNote { get; private set; }

    /// <summary>
    /// RegionMobile of the Salesman
    /// RegionMobile الخاص بـ Salesman
    /// </summary>
    public string RegionMobile { get; private set; }

    /// <summary>
    /// RegionAddress of the Salesman
    /// RegionAddress الخاص بـ Salesman
    /// </summary>
    public string RegionAddress { get; private set; }

    /// <summary>
    /// CommissionPercent of the Salesman
    /// CommissionPercent الخاص بـ Salesman
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// GuarantorName of the Salesman
    /// GuarantorName الخاص بـ Salesman
    /// </summary>
    public string GuarantorName { get; private set; }

    /// <summary>
    /// GuarantorAddress of the Salesman
    /// GuarantorAddress الخاص بـ Salesman
    /// </summary>
    public string GuarantorAddress { get; private set; }

    /// <summary>
    /// GuarantorStartDate of the Salesman
    /// GuarantorStartDate الخاص بـ Salesman
    /// </summary>
    public DateTime? GuarantorStartDate { get; private set; }

    /// <summary>
    /// GuarantorExpireDate of the Salesman
    /// GuarantorExpireDate الخاص بـ Salesman
    /// </summary>
    public DateTime? GuarantorExpireDate { get; private set; }

    /// <summary>
    /// GuarantorType of the Salesman
    /// GuarantorType الخاص بـ Salesman
    /// </summary>
    public decimal? GuarantorType { get; private set; }

    /// <summary>
    /// GuarantorAmount of the Salesman
    /// GuarantorAmount الخاص بـ Salesman
    /// </summary>
    public decimal? GuarantorAmount { get; private set; }

    /// <summary>
    /// GuarantorStatus of the Salesman
    /// GuarantorStatus الخاص بـ Salesman
    /// </summary>
    public decimal? GuarantorStatus { get; private set; }

    /// <summary>
    /// GuarantorFinancialCenter of the Salesman
    /// GuarantorFinancialCenter الخاص بـ Salesman
    /// </summary>
    public string GuarantorFinancialCenter { get; private set; }

    /// <summary>
    /// GuarantorWork of the Salesman
    /// GuarantorWork الخاص بـ Salesman
    /// </summary>
    public string GuarantorWork { get; private set; }

    /// <summary>
    /// GuarantorDocumentDate of the Salesman
    /// GuarantorDocumentDate الخاص بـ Salesman
    /// </summary>
    public DateTime? GuarantorDocumentDate { get; private set; }

    /// <summary>
    /// GuarantorRegisterCourt of the Salesman
    /// GuarantorRegisterCourt الخاص بـ Salesman
    /// </summary>
    public string GuarantorRegisterCourt { get; private set; }

    /// <summary>
    /// GuarantorRegisterTrade of the Salesman
    /// GuarantorRegisterTrade الخاص بـ Salesman
    /// </summary>
    public string GuarantorRegisterTrade { get; private set; }

    /// <summary>
    /// GuarantorFileTrade of the Salesman
    /// GuarantorFileTrade الخاص بـ Salesman
    /// </summary>
    public string GuarantorFileTrade { get; private set; }

    /// <summary>
    /// GuarantorTelephone of the Salesman
    /// GuarantorTelephone الخاص بـ Salesman
    /// </summary>
    public string GuarantorTelephone { get; private set; }

    /// <summary>
    /// GuarantorFax of the Salesman
    /// GuarantorFax الخاص بـ Salesman
    /// </summary>
    public string GuarantorFax { get; private set; }

    /// <summary>
    /// RouteNumber of the Salesman
    /// RouteNumber الخاص بـ Salesman
    /// </summary>
    public decimal? RouteNumber { get; private set; }

    /// <summary>
    /// SortInRoute of the Salesman
    /// SortInRoute الخاص بـ Salesman
    /// </summary>
    public decimal? SortInRoute { get; private set; }

    /// <summary>
    /// CashNumber of the Salesman
    /// CashNumber الخاص بـ Salesman
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the Salesman
    /// WarehouseCode الخاص بـ Salesman
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BankNumber of the Salesman
    /// BankNumber الخاص بـ Salesman
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// GroupCode of the Salesman
    /// GroupCode الخاص بـ Salesman
    /// </summary>
    public string GroupCode { get; private set; }

    /// <summary>
    /// SalesmanPassword of the Salesman
    /// SalesmanPassword الخاص بـ Salesman
    /// </summary>
    public string SalesmanPassword { get; private set; }

    /// <summary>
    /// UseInvoiceDetails of the Salesman
    /// UseInvoiceDetails الخاص بـ Salesman
    /// </summary>
    public decimal? UseInvoiceDetails { get; private set; }

    /// <summary>
    /// CreditLimitShort of the Salesman
    /// CreditLimitShort الخاص بـ Salesman
    /// </summary>
    public decimal? CreditLimitShort { get; private set; }

    /// <summary>
    /// AccountDetailCode of the Salesman
    /// AccountDetailCode الخاص بـ Salesman
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the Salesman
    /// AccountDetailType الخاص بـ Salesman
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// ChequeType of the Salesman
    /// ChequeType الخاص بـ Salesman
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// PostChequeTypeReceive of the Salesman
    /// PostChequeTypeReceive الخاص بـ Salesman
    /// </summary>
    public decimal? PostChequeTypeReceive { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the Salesman
    /// ConnectionBranchNumber الخاص بـ Salesman
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// WorkWithoutPlan of the Salesman
    /// WorkWithoutPlan الخاص بـ Salesman
    /// </summary>
    public decimal? WorkWithoutPlan { get; private set; }

    /// <summary>
    /// VisitOpenType of the Salesman
    /// VisitOpenType الخاص بـ Salesman
    /// </summary>
    public decimal? VisitOpenType { get; private set; }

    /// <summary>
    /// VisitOpenDistance of the Salesman
    /// VisitOpenDistance الخاص بـ Salesman
    /// </summary>
    public decimal? VisitOpenDistance { get; private set; }

    /// <summary>
    /// RegionRange of the Salesman
    /// RegionRange الخاص بـ Salesman
    /// </summary>
    public decimal? RegionRange { get; private set; }

    /// <summary>
    /// ImplementPlanStartRouteMandatory of the Salesman
    /// ImplementPlanStartRouteMandatory الخاص بـ Salesman
    /// </summary>
    public decimal? ImplementPlanStartRouteMandatory { get; private set; }

    /// <summary>
    /// AutoMobilePostingFlag of the Salesman
    /// AutoMobilePostingFlag الخاص بـ Salesman
    /// </summary>
    public decimal? AutoMobilePostingFlag { get; private set; }

    /// <summary>
    /// ShowQuantityInAllWarehouses of the Salesman
    /// ShowQuantityInAllWarehouses الخاص بـ Salesman
    /// </summary>
    public decimal? ShowQuantityInAllWarehouses { get; private set; }

    /// <summary>
    /// AllowChangeCustomerGps of the Salesman
    /// AllowChangeCustomerGps الخاص بـ Salesman
    /// </summary>
    public decimal? AllowChangeCustomerGps { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the Salesman
    /// CalcTypeNumberTax الخاص بـ Salesman
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// AllowCancelDocument of the Salesman
    /// AllowCancelDocument الخاص بـ Salesman
    /// </summary>
    public decimal? AllowCancelDocument { get; private set; }

    /// <summary>
    /// AllowReturnAllItemsFlag of the Salesman
    /// AllowReturnAllItemsFlag الخاص بـ Salesman
    /// </summary>
    public decimal? AllowReturnAllItemsFlag { get; private set; }

    /// <summary>
    /// ApplicationCustomerPlanInsertMaxLimit of the Salesman
    /// ApplicationCustomerPlanInsertMaxLimit الخاص بـ Salesman
    /// </summary>
    public decimal? ApplicationCustomerPlanInsertMaxLimit { get; private set; }

    /// <summary>
    /// AllowModifyCustomerLocation of the Salesman
    /// AllowModifyCustomerLocation الخاص بـ Salesman
    /// </summary>
    public decimal? AllowModifyCustomerLocation { get; private set; }

    /// <summary>
    /// NoSale of the Salesman
    /// NoSale الخاص بـ Salesman
    /// </summary>
    public decimal? NoSale { get; private set; }

    /// <summary>
    /// NoCollect of the Salesman
    /// NoCollect الخاص بـ Salesman
    /// </summary>
    public decimal? NoCollect { get; private set; }

    /// <summary>
    /// ApplicationVersionCode of the Salesman
    /// ApplicationVersionCode الخاص بـ Salesman
    /// </summary>
    public string ApplicationVersionCode { get; private set; }

    /// <summary>
    /// AllowFileShare of the Salesman
    /// AllowFileShare الخاص بـ Salesman
    /// </summary>
    public decimal? AllowFileShare { get; private set; }

    /// <summary>
    /// RepSerial of the Salesman
    /// RepSerial الخاص بـ Salesman
    /// </summary>
    public decimal? RepSerial { get; private set; }

    /// <summary>
    /// ConnectionSpecialSalesman of the Salesman
    /// ConnectionSpecialSalesman الخاص بـ Salesman
    /// </summary>
    public decimal? ConnectionSpecialSalesman { get; private set; }

    /// <summary>
    /// NotAllowEnterReturnSale of the Salesman
    /// NotAllowEnterReturnSale الخاص بـ Salesman
    /// </summary>
    public decimal? NotAllowEnterReturnSale { get; private set; }

    /// <summary>
    /// SaveVoucherOnlineFlag of the Salesman
    /// SaveVoucherOnlineFlag الخاص بـ Salesman
    /// </summary>
    public decimal? SaveVoucherOnlineFlag { get; private set; }

    /// <summary>
    /// SyncMethod of the Salesman
    /// SyncMethod الخاص بـ Salesman
    /// </summary>
    public decimal? SyncMethod { get; private set; }

    /// <summary>
    /// LastUpdateDateDetails of the Salesman
    /// LastUpdateDateDetails الخاص بـ Salesman
    /// </summary>
    public DateTime? LastUpdateDateDetails { get; private set; }

    /// <summary>
    /// LastPostDateDetails of the Salesman
    /// LastPostDateDetails الخاص بـ Salesman
    /// </summary>
    public DateTime? LastPostDateDetails { get; private set; }

    /// <summary>
    /// DtsClsFlg of the Salesman
    /// DtsClsFlg الخاص بـ Salesman
    /// </summary>
    public decimal? DtsClsFlg { get; private set; }

    /// <summary>
    /// DtsClsUId of the Salesman
    /// DtsClsUId الخاص بـ Salesman
    /// </summary>
    public decimal? DtsClsUId { get; private set; }

    /// <summary>
    /// DtsClsDate of the Salesman
    /// DtsClsDate الخاص بـ Salesman
    /// </summary>
    public DateTime? DtsClsDate { get; private set; }

    /// <summary>
    /// CashAmountLimit of the Salesman
    /// CashAmountLimit الخاص بـ Salesman
    /// </summary>
    public decimal? CashAmountLimit { get; private set; }

    /// <summary>
    /// CashAmountDailyLimit of the Salesman
    /// CashAmountDailyLimit الخاص بـ Salesman
    /// </summary>
    public decimal? CashAmountDailyLimit { get; private set; }

    /// <summary>
    /// PlanNumber of the Salesman
    /// PlanNumber الخاص بـ Salesman
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanSerial of the Salesman
    /// PlanSerial الخاص بـ Salesman
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public SalesmanType SalesmanType { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Collection relationship: ManyToOne
    /// </summary>
    public ICollection<Salesman> Salesmans => _salesmans;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

