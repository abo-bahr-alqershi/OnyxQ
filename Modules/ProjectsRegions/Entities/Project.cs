using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Project Entity
/// </summary>
public class Project : Entity<ProjectId>
{
    private Project() { }

    /// <summary>
    /// The unique identifier for the Project
    /// المعرف الفريد لـ Project
    /// </summary>
    public ProjectId Id { get; private set; }

    /// <summary>
    /// ProjectNumber of the Project
    /// ProjectNumber الخاص بـ Project
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ProjectCode of the Project
    /// ProjectCode الخاص بـ Project
    /// </summary>
    public string ProjectCode { get; private set; }

    /// <summary>
    /// ProjectNameArabic of the Project
    /// ProjectNameArabic الخاص بـ Project
    /// </summary>
    public string ProjectNameArabic { get; private set; }

    /// <summary>
    /// ProjectNameEnglish of the Project
    /// ProjectNameEnglish الخاص بـ Project
    /// </summary>
    public string ProjectNameEnglish { get; private set; }

    /// <summary>
    /// ProjectParent of the Project
    /// ProjectParent الخاص بـ Project
    /// </summary>
    public string ProjectParent { get; private set; }

    /// <summary>
    /// ProjectLevel of the Project
    /// ProjectLevel الخاص بـ Project
    /// </summary>
    public decimal? ProjectLevel { get; private set; }

    /// <summary>
    /// ProjectSub of the Project
    /// ProjectSub الخاص بـ Project
    /// </summary>
    public decimal? ProjectSub { get; private set; }

    /// <summary>
    /// GroupNumber of the Project
    /// GroupNumber الخاص بـ Project
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the Project
    /// InactiveFlag الخاص بـ Project
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Project
    /// InactivatedByUserId الخاص بـ Project
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Project
    /// InactiveDate الخاص بـ Project
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Project
    /// InactiveReason الخاص بـ Project
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Project
    /// ImportExcelFlag الخاص بـ Project
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// StartDate of the Project
    /// StartDate الخاص بـ Project
    /// </summary>
    public DateTime? StartDate { get; private set; }

    /// <summary>
    /// EndDate of the Project
    /// EndDate الخاص بـ Project
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// Address of the Project
    /// Address الخاص بـ Project
    /// </summary>
    public string Address { get; private set; }

    /// <summary>
    /// ProjectAdmin of the Project
    /// ProjectAdmin الخاص بـ Project
    /// </summary>
    public string ProjectAdmin { get; private set; }

    /// <summary>
    /// ProjectDescription of the Project
    /// ProjectDescription الخاص بـ Project
    /// </summary>
    public string ProjectDescription { get; private set; }

    /// <summary>
    /// ProjectNotes of the Project
    /// ProjectNotes الخاص بـ Project
    /// </summary>
    public string ProjectNotes { get; private set; }

    /// <summary>
    /// CurCode of the Project
    /// CurCode الخاص بـ Project
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// ProjectCost of the Project
    /// ProjectCost الخاص بـ Project
    /// </summary>
    public decimal? ProjectCost { get; private set; }

    /// <summary>
    /// ExchangeRate of the Project
    /// ExchangeRate الخاص بـ Project
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// CountryNumber of the Project
    /// CountryNumber الخاص بـ Project
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the Project
    /// CityNumber الخاص بـ Project
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Project
    /// ProvinceNumber الخاص بـ Project
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// RegionCode of the Project
    /// RegionCode الخاص بـ Project
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// BidDate of the Project
    /// BidDate الخاص بـ Project
    /// </summary>
    public DateTime? BidDate { get; private set; }

    /// <summary>
    /// ContractSpecialDate of the Project
    /// ContractSpecialDate الخاص بـ Project
    /// </summary>
    public DateTime? ContractSpecialDate { get; private set; }

    /// <summary>
    /// CCode of the Project
    /// CCode الخاص بـ Project
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CodeNumberProjectManager of the Project
    /// CodeNumberProjectManager الخاص بـ Project
    /// </summary>
    public decimal? CodeNumberProjectManager { get; private set; }

    /// <summary>
    /// CodeTypeShort of the Project
    /// CodeTypeShort الخاص بـ Project
    /// </summary>
    public decimal? CodeTypeShort { get; private set; }

    /// <summary>
    /// CodeNumberProjectGroupSpecial of the Project
    /// CodeNumberProjectGroupSpecial الخاص بـ Project
    /// </summary>
    public decimal? CodeNumberProjectGroupSpecial { get; private set; }

    /// <summary>
    /// CodeNumberProjectSpecial of the Project
    /// CodeNumberProjectSpecial الخاص بـ Project
    /// </summary>
    public decimal? CodeNumberProjectSpecial { get; private set; }

    /// <summary>
    /// ProjectStatus of the Project
    /// ProjectStatus الخاص بـ Project
    /// </summary>
    public decimal? ProjectStatus { get; private set; }

    /// <summary>
    /// PmsConditionNumber of the Project
    /// PmsConditionNumber الخاص بـ Project
    /// </summary>
    public decimal? PmsConditionNumber { get; private set; }

    /// <summary>
    /// Field1 of the Project
    /// Field1 الخاص بـ Project
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Project
    /// Field2 الخاص بـ Project
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Project
    /// Field3 الخاص بـ Project
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Project
    /// Field4 الخاص بـ Project
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Project
    /// Field5 الخاص بـ Project
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Project
    /// Field6 الخاص بـ Project
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Project
    /// Field7 الخاص بـ Project
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Project
    /// Field8 الخاص بـ Project
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Project
    /// Field9 الخاص بـ Project
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Project
    /// Field10 الخاص بـ Project
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field21 of the Project
    /// Field21 الخاص بـ Project
    /// </summary>
    public DateTime? Field21 { get; private set; }

    /// <summary>
    /// Field22 of the Project
    /// Field22 الخاص بـ Project
    /// </summary>
    public DateTime? Field22 { get; private set; }

    /// <summary>
    /// Field23 of the Project
    /// Field23 الخاص بـ Project
    /// </summary>
    public DateTime? Field23 { get; private set; }

    /// <summary>
    /// Field24 of the Project
    /// Field24 الخاص بـ Project
    /// </summary>
    public DateTime? Field24 { get; private set; }

    /// <summary>
    /// Field25 of the Project
    /// Field25 الخاص بـ Project
    /// </summary>
    public DateTime? Field25 { get; private set; }

    /// <summary>
    /// Field26 of the Project
    /// Field26 الخاص بـ Project
    /// </summary>
    public DateTime? Field26 { get; private set; }

    /// <summary>
    /// Field27 of the Project
    /// Field27 الخاص بـ Project
    /// </summary>
    public DateTime? Field27 { get; private set; }

    /// <summary>
    /// Field28 of the Project
    /// Field28 الخاص بـ Project
    /// </summary>
    public DateTime? Field28 { get; private set; }

    /// <summary>
    /// Field29 of the Project
    /// Field29 الخاص بـ Project
    /// </summary>
    public DateTime? Field29 { get; private set; }

    /// <summary>
    /// Field30 of the Project
    /// Field30 الخاص بـ Project
    /// </summary>
    public DateTime? Field30 { get; private set; }

    /// <summary>
    /// Field31 of the Project
    /// Field31 الخاص بـ Project
    /// </summary>
    public decimal? Field31 { get; private set; }

    /// <summary>
    /// Field32 of the Project
    /// Field32 الخاص بـ Project
    /// </summary>
    public decimal? Field32 { get; private set; }

    /// <summary>
    /// Field33 of the Project
    /// Field33 الخاص بـ Project
    /// </summary>
    public decimal? Field33 { get; private set; }

    /// <summary>
    /// Field34 of the Project
    /// Field34 الخاص بـ Project
    /// </summary>
    public decimal? Field34 { get; private set; }

    /// <summary>
    /// Field35 of the Project
    /// Field35 الخاص بـ Project
    /// </summary>
    public decimal? Field35 { get; private set; }

    /// <summary>
    /// Field36 of the Project
    /// Field36 الخاص بـ Project
    /// </summary>
    public decimal? Field36 { get; private set; }

    /// <summary>
    /// Field37 of the Project
    /// Field37 الخاص بـ Project
    /// </summary>
    public decimal? Field37 { get; private set; }

    /// <summary>
    /// Field38 of the Project
    /// Field38 الخاص بـ Project
    /// </summary>
    public decimal? Field38 { get; private set; }

    /// <summary>
    /// Field39 of the Project
    /// Field39 الخاص بـ Project
    /// </summary>
    public decimal? Field39 { get; private set; }

    /// <summary>
    /// Field40 of the Project
    /// Field40 الخاص بـ Project
    /// </summary>
    public decimal? Field40 { get; private set; }

    /// <summary>
    /// UseActive of the Project
    /// UseActive الخاص بـ Project
    /// </summary>
    public decimal? UseActive { get; private set; }

    /// <summary>
    /// AccountsCostFlag of the Project
    /// AccountsCostFlag الخاص بـ Project
    /// </summary>
    public decimal? AccountsCostFlag { get; private set; }

    /// <summary>
    /// MaxExecutionPercent of the Project
    /// MaxExecutionPercent الخاص بـ Project
    /// </summary>
    public decimal? MaxExecutionPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Project to PrivilegeProjects
    /// </summary>
    public IReadOnlyCollection<PrivilegeProjects> PrivilegeProjectses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceDetail> GeneralLedgerEditBudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyDetail> GeneralLedgerRequestExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyMaster> GeneralLedgerRequestExchangeCurrencyMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestVoucherMasterAccount> GeneralLedgerRequestVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GeneralLedgerVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerVoucherMasterAccount> GeneralLedgerVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to JournalVoucherDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherDetail> JournalVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to Voucher
    /// </summary>
    public IReadOnlyCollection<Voucher> Vouchers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to VoucherDetail
    /// </summary>
    public IReadOnlyCollection<VoucherDetail> VoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to CostCenterProject
    /// </summary>
    public IReadOnlyCollection<CostCenterProject> CostCenterProjects { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyDetail> ExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ExchangeCurrencyMaster
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyMaster> ExchangeCurrencyMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PostDetail
    /// </summary>
    public IReadOnlyCollection<PostDetail> PostDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ProfitLossClosingTemp
    /// </summary>
    public IReadOnlyCollection<ProfitLossClosingTemp> ProfitLossClosingTemps { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BudgetApprovalRequestFinanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetApprovalRequestFinanceDetail> BudgetApprovalRequestFinanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to AccountCostCenterLimit
    /// </summary>
    public IReadOnlyCollection<AccountCostCenterLimit> AccountCostCenterLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BudgetBalanceColumnDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceColumnDetail> BudgetBalanceColumnDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceDetail> BudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to SaleCost
    /// </summary>
    public IReadOnlyCollection<SaleCost> SaleCosts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BillDetail
    /// </summary>
    public IReadOnlyCollection<BillDetail> BillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BillDetailAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscount> BillDetailAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BillDetailAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscountRequest> BillDetailAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchBillDetail> BranchBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BillMaster
    /// </summary>
    public IReadOnlyCollection<BillMaster> BillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscount> BillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BillMasterAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscountRequest> BillMasterAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to OutgoingDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingDetail> OutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to OutgoingMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingMaster> OutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to OutRequestDetail
    /// </summary>
    public IReadOnlyCollection<OutRequestDetail> OutRequestDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to OutRequestMaster
    /// </summary>
    public IReadOnlyCollection<OutRequestMaster> OutRequestMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetail> ReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillDetail> BranchReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ReturnBillDetailRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetailRequest> ReturnBillDetailRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<ReturnBillMaster> ReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ReturnBillMasterRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillMasterRequest> ReturnBillMasterRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to OutgoingBillDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingBillDetail> OutgoingBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PurchaseOrder
    /// </summary>
    public IReadOnlyCollection<PurchaseOrder> PurchaseOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PurchaseRequest
    /// </summary>
    public IReadOnlyCollection<PurchaseRequest> PurchaseRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to AccountsPayableOtherChargeItem
    /// </summary>
    public IReadOnlyCollection<AccountsPayableOtherChargeItem> AccountsPayableOtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PurchaseBillDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseBillDetail> PurchaseBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PurchaseBillMaster
    /// </summary>
    public IReadOnlyCollection<PurchaseBillMaster> PurchaseBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptDetail> GoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchGoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<BranchGoodsReceiptDetail> BranchGoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GoodsReceiptNote
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNote> GoodsReceiptNotes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GoodsReceiptNoteMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteMaster> GoodsReceiptNoteMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to StockAdjustmentDetail
    /// </summary>
    public IReadOnlyCollection<StockAdjustmentDetail> StockAdjustmentDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ConnectWarehouseCodeByActivity
    /// </summary>
    public IReadOnlyCollection<ConnectWarehouseCodeByActivity> ConnectWarehouseCodeByActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to DefaultDataOnline
    /// </summary>
    public IReadOnlyCollection<DefaultDataOnline> DefaultDataOnlines { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GoodsReceiptIncomingMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingMaster> GoodsReceiptIncomingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to IncomingOutgoingMaster
    /// </summary>
    public IReadOnlyCollection<IncomingOutgoingMaster> IncomingOutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ItemAttachmentMovement
    /// </summary>
    public IReadOnlyCollection<ItemAttachmentMovement> ItemAttachmentMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchItemAttachmentMovement
    /// </summary>
    public IReadOnlyCollection<BranchItemAttachmentMovement> BranchItemAttachmentMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PerformaInvoiceBillDetail
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillDetail> PerformaInvoiceBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PerformaInvoiceBillExpand
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillExpand> PerformaInvoiceBillExpands { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PerformaInvoiceBillMaster
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMasterAdditionalDiscount> PerformaInvoiceBillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to WarehouseTransferDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferDetail> WarehouseTransferDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchWarehouseTransferDetail
    /// </summary>
    public IReadOnlyCollection<BranchWarehouseTransferDetail> BranchWarehouseTransferDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to WarehouseTransferMaster
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMaster> WarehouseTransferMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to WarehouseTransferMultiDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiDetail> WarehouseTransferMultiDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to WarehouseTransferMultiMaster
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiMaster> WarehouseTransferMultiMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to AssembleKitItem
    /// </summary>
    public IReadOnlyCollection<AssembleKitItem> AssembleKitItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to AssembleKitItemDetail
    /// </summary>
    public IReadOnlyCollection<AssembleKitItemDetail> AssembleKitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to DisassembleKitItem
    /// </summary>
    public IReadOnlyCollection<DisassembleKitItem> DisassembleKitItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to DisassembleKitItemDetail
    /// </summary>
    public IReadOnlyCollection<DisassembleKitItemDetail> DisassembleKitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to DisassembleKitItemsDetail
    /// </summary>
    public IReadOnlyCollection<DisassembleKitItemsDetail> DisassembleKitItemsDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to KitItemDetail
    /// </summary>
    public IReadOnlyCollection<KitItemDetail> KitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to Employee
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to GuaranteeDetail
    /// </summary>
    public IReadOnlyCollection<GuaranteeDetail> GuaranteeDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ProjectGroup
    /// </summary>
    public ProjectGroup ProjectGroup { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to ProjectActivity
    /// </summary>
    public IReadOnlyCollection<ProjectActivity> ProjectActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to OtherChargeItem
    /// </summary>
    public IReadOnlyCollection<OtherChargeItem> OtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to OtherChargeItemOthers
    /// </summary>
    public IReadOnlyCollection<OtherChargeItemOthers> OtherChargeItemOtherses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to RequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<RequestTaxItemMovement> RequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchRequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchRequestTaxItemMovement> BranchRequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to TaxInputMovement
    /// </summary>
    public IReadOnlyCollection<TaxInputMovement> TaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchTaxInputMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxInputMovement> BranchTaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to TaxItemMovement
    /// </summary>
    public IReadOnlyCollection<TaxItemMovement> TaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to BranchTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxItemMovement> BranchTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to CostCenter
    /// </summary>
    public IReadOnlyCollection<CostCenter> CostCenters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Project to Activity
    /// </summary>
    public IReadOnlyCollection<Activity> Activities { get; private set; }
    #endregion
}
}
