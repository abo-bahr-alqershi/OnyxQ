using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.Activities.Entities
{
/// <summary>
/// Activity Entity
/// </summary>
public class Activity : Entity<ActivityId>
{
    private Activity() { }

    /// <summary>
    /// The unique identifier for the Activity
    /// المعرف الفريد لـ Activity
    /// </summary>
    public ActivityId Id { get; private set; }

    /// <summary>
    /// ActivityNumber of the Activity
    /// ActivityNumber الخاص بـ Activity
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ActivityCode of the Activity
    /// ActivityCode الخاص بـ Activity
    /// </summary>
    public string ActivityCode { get; private set; }

    /// <summary>
    /// ActivityAName of the Activity
    /// ActivityAName الخاص بـ Activity
    /// </summary>
    public string ActivityAName { get; private set; }

    /// <summary>
    /// ActivityEName of the Activity
    /// ActivityEName الخاص بـ Activity
    /// </summary>
    public string ActivityEName { get; private set; }

    /// <summary>
    /// ActivityParent of the Activity
    /// ActivityParent الخاص بـ Activity
    /// </summary>
    public string ActivityParent { get; private set; }

    /// <summary>
    /// ActivityLevel of the Activity
    /// ActivityLevel الخاص بـ Activity
    /// </summary>
    public decimal? ActivityLevel { get; private set; }

    /// <summary>
    /// ActivitySub of the Activity
    /// ActivitySub الخاص بـ Activity
    /// </summary>
    public decimal? ActivitySub { get; private set; }

    /// <summary>
    /// GroupNumber of the Activity
    /// GroupNumber الخاص بـ Activity
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the Activity
    /// InactiveFlag الخاص بـ Activity
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Activity
    /// InactivatedByUserId الخاص بـ Activity
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Activity
    /// InactiveDate الخاص بـ Activity
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Activity
    /// InactiveReason الخاص بـ Activity
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the Activity
    /// ImportExcelFlag الخاص بـ Activity
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// Field1 of the Activity
    /// Field1 الخاص بـ Activity
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Activity
    /// Field2 الخاص بـ Activity
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Activity
    /// Field3 الخاص بـ Activity
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Activity
    /// Field4 الخاص بـ Activity
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Activity
    /// Field5 الخاص بـ Activity
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Activity
    /// Field6 الخاص بـ Activity
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Activity
    /// Field7 الخاص بـ Activity
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Activity
    /// Field8 الخاص بـ Activity
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Activity
    /// Field9 الخاص بـ Activity
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Activity
    /// Field10 الخاص بـ Activity
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ActivityDescription of the Activity
    /// ActivityDescription الخاص بـ Activity
    /// </summary>
    public string ActivityDescription { get; private set; }

    /// <summary>
    /// ProjectNumber of the Activity
    /// ProjectNumber الخاص بـ Activity
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// StageCode of the Activity
    /// StageCode الخاص بـ Activity
    /// </summary>
    public string StageCode { get; private set; }

    /// <summary>
    /// PlanCode of the Activity
    /// PlanCode الخاص بـ Activity
    /// </summary>
    public string PlanCode { get; private set; }

    /// <summary>
    /// ItemCostType of the Activity
    /// ItemCostType الخاص بـ Activity
    /// </summary>
    public decimal? ItemCostType { get; private set; }

    /// <summary>
    /// ItemCode of the Activity
    /// ItemCode الخاص بـ Activity
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// MeasureCode of the Activity
    /// MeasureCode الخاص بـ Activity
    /// </summary>
    public string MeasureCode { get; private set; }

    /// <summary>
    /// CostPrice of the Activity
    /// CostPrice الخاص بـ Activity
    /// </summary>
    public decimal? CostPrice { get; private set; }

    /// <summary>
    /// SalesPrice of the Activity
    /// SalesPrice الخاص بـ Activity
    /// </summary>
    public decimal? SalesPrice { get; private set; }

    /// <summary>
    /// QuantityAmountFlag of the Activity
    /// QuantityAmountFlag الخاص بـ Activity
    /// </summary>
    public decimal? QuantityAmountFlag { get; private set; }

    /// <summary>
    /// CostAccountCode of the Activity
    /// CostAccountCode الخاص بـ Activity
    /// </summary>
    public string CostAccountCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Activity to JournalFileDetail
    /// </summary>
    public IReadOnlyCollection<JournalFileDetail> JournalFileDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ActivityGroup
    /// </summary>
    public ActivityGroup ActivityGroup { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PrivilegeActivity
    /// </summary>
    public IReadOnlyCollection<PrivilegeActivity> PrivilegeActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceDetail> GeneralLedgerEditBudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyDetail> GeneralLedgerRequestExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyMaster> GeneralLedgerRequestExchangeCurrencyMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestVoucherMasterAccount> GeneralLedgerRequestVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GeneralLedgerVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerVoucherMasterAccount> GeneralLedgerVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GeneralLedgerRequestDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestDetail> GeneralLedgerRequestDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GeneralLedgerRequestMaster
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestMaster> GeneralLedgerRequestMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to Installment
    /// </summary>
    public IReadOnlyCollection<Installment> Installments { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchInstallment
    /// </summary>
    public IReadOnlyCollection<BranchInstallment> BranchInstallments { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to JournalVoucherDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherDetail> JournalVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to Voucher
    /// </summary>
    public IReadOnlyCollection<Voucher> Vouchers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to VoucherDetail
    /// </summary>
    public IReadOnlyCollection<VoucherDetail> VoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OpeningBalance
    /// </summary>
    public IReadOnlyCollection<OpeningBalance> OpeningBalances { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyDetail> ExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ExchangeCurrencyMaster
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyMaster> ExchangeCurrencyMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PostDetail
    /// </summary>
    public IReadOnlyCollection<PostDetail> PostDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PostMaster
    /// </summary>
    public IReadOnlyCollection<PostMaster> PostMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ProfitLossClosingTemp
    /// </summary>
    public IReadOnlyCollection<ProfitLossClosingTemp> ProfitLossClosingTemps { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BudgetApprovalRequestFinanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetApprovalRequestFinanceDetail> BudgetApprovalRequestFinanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AccountCostCenterLimit
    /// </summary>
    public IReadOnlyCollection<AccountCostCenterLimit> AccountCostCenterLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BudgetBalanceColumnDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceColumnDetail> BudgetBalanceColumnDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceDetail> BudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to SalesOrder
    /// </summary>
    public IReadOnlyCollection<SalesOrder> SalesOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to SaleCost
    /// </summary>
    public IReadOnlyCollection<SaleCost> SaleCosts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BillDetail
    /// </summary>
    public IReadOnlyCollection<BillDetail> BillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BillDetailAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscount> BillDetailAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BillDetailAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscountRequest> BillDetailAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchBillDetail> BranchBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BillMaster
    /// </summary>
    public IReadOnlyCollection<BillMaster> BillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscount> BillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BillMasterAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscountRequest> BillMasterAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchBillMaster> BranchBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to DueCreditCard
    /// </summary>
    public IReadOnlyCollection<DueCreditCard> DueCreditCards { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OutgoingDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingDetail> OutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OutgoingMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingMaster> OutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OutRequestDetail
    /// </summary>
    public IReadOnlyCollection<OutRequestDetail> OutRequestDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OutRequestMaster
    /// </summary>
    public IReadOnlyCollection<OutRequestMaster> OutRequestMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetail> ReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<ReturnBillMaster> ReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillDetail> BranchReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ReturnBillDetailRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetailRequest> ReturnBillDetailRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillMaster> BranchReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ReturnBillMasterRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillMasterRequest> ReturnBillMasterRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OutgoingBillDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingBillDetail> OutgoingBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OutgoingBillMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingBillMaster> OutgoingBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PurchaseOrder
    /// </summary>
    public IReadOnlyCollection<PurchaseOrder> PurchaseOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PurchaseRequest
    /// </summary>
    public IReadOnlyCollection<PurchaseRequest> PurchaseRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to Quotation
    /// </summary>
    public IReadOnlyCollection<Quotation> Quotations { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AccountsPayableOtherChargeItem
    /// </summary>
    public IReadOnlyCollection<AccountsPayableOtherChargeItem> AccountsPayableOtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PurchaseBillDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseBillDetail> PurchaseBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PurchaseBillMaster
    /// </summary>
    public IReadOnlyCollection<PurchaseBillMaster> PurchaseBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to TenderMaster
    /// </summary>
    public IReadOnlyCollection<TenderMaster> TenderMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to VendorQuotationMaster
    /// </summary>
    public IReadOnlyCollection<VendorQuotationMaster> VendorQuotationMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentAccountsPayableDetail> AdjustInstallmentAccountsPayableDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentAccountsPayableMaster> AdjustInstallmentAccountsPayableMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AdjustInstallmentDetail
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentDetail> AdjustInstallmentDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AdjustInstallmentMaster
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentMaster> AdjustInstallmentMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to InstallmentPerformaInvoice
    /// </summary>
    public IReadOnlyCollection<InstallmentPerformaInvoice> InstallmentPerformaInvoices { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ItemMovement
    /// </summary>
    public IReadOnlyCollection<ItemMovement> ItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptDetail> GoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchGoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<BranchGoodsReceiptDetail> BranchGoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GoodsReceiptNote
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNote> GoodsReceiptNotes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchGoodsReceiptNote
    /// </summary>
    public IReadOnlyCollection<BranchGoodsReceiptNote> BranchGoodsReceiptNotes { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GoodsReceiptNoteMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteMaster> GoodsReceiptNoteMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to StockAdjustment
    /// </summary>
    public IReadOnlyCollection<StockAdjustment> StockAdjustments { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to StockAdjustmentDetail
    /// </summary>
    public IReadOnlyCollection<StockAdjustmentDetail> StockAdjustmentDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ConnectWarehouseCodeByActivity
    /// </summary>
    public IReadOnlyCollection<ConnectWarehouseCodeByActivity> ConnectWarehouseCodeByActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to DefaultDataOnline
    /// </summary>
    public IReadOnlyCollection<DefaultDataOnline> DefaultDataOnlines { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GoodsReceiptIncomingMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingMaster> GoodsReceiptIncomingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to IncomingOutgoingMaster
    /// </summary>
    public IReadOnlyCollection<IncomingOutgoingMaster> IncomingOutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<ItemSerialNumber> ItemSerialNumbers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<BranchItemSerialNumber> BranchItemSerialNumbers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GoodsReceiptNoteItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteItemSerialNumber> GoodsReceiptNoteItemSerialNumbers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OtherItemSerialNumber
    /// </summary>
    public IReadOnlyCollection<OtherItemSerialNumber> OtherItemSerialNumbers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ItemAttachmentMovement
    /// </summary>
    public IReadOnlyCollection<ItemAttachmentMovement> ItemAttachmentMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchItemAttachmentMovement
    /// </summary>
    public IReadOnlyCollection<BranchItemAttachmentMovement> BranchItemAttachmentMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PerformaInvoiceBillDetail
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillDetail> PerformaInvoiceBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PerformaInvoiceBillExpand
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillExpand> PerformaInvoiceBillExpands { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PerformaInvoiceBillMaster
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMasterAdditionalDiscount> PerformaInvoiceBillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to WarehouseTransferDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferDetail> WarehouseTransferDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchWarehouseTransferDetail
    /// </summary>
    public IReadOnlyCollection<BranchWarehouseTransferDetail> BranchWarehouseTransferDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to WarehouseTransferMaster
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMaster> WarehouseTransferMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchWarehouseTransferMaster
    /// </summary>
    public IReadOnlyCollection<BranchWarehouseTransferMaster> BranchWarehouseTransferMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to WarehouseTransferMultiDetail
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiDetail> WarehouseTransferMultiDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to WarehouseTransferMultiMaster
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiMaster> WarehouseTransferMultiMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AssembleKitItem
    /// </summary>
    public IReadOnlyCollection<AssembleKitItem> AssembleKitItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to AssembleKitItemDetail
    /// </summary>
    public IReadOnlyCollection<AssembleKitItemDetail> AssembleKitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to DisassembleKitItem
    /// </summary>
    public IReadOnlyCollection<DisassembleKitItem> DisassembleKitItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to DisassembleKitItemDetail
    /// </summary>
    public IReadOnlyCollection<DisassembleKitItemDetail> DisassembleKitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to DisassembleKitItemsDetail
    /// </summary>
    public IReadOnlyCollection<DisassembleKitItemsDetail> DisassembleKitItemsDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to KitItemDetail
    /// </summary>
    public IReadOnlyCollection<KitItemDetail> KitItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to Employee
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GuaranteeAccount
    /// </summary>
    public IReadOnlyCollection<GuaranteeAccount> GuaranteeAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to GuaranteeDetail
    /// </summary>
    public IReadOnlyCollection<GuaranteeDetail> GuaranteeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to DocumentDeletion
    /// </summary>
    public IReadOnlyCollection<DocumentDeletion> DocumentDeletions { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to ProjectActivity
    /// </summary>
    public IReadOnlyCollection<ProjectActivity> ProjectActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to RequestJournalDetail
    /// </summary>
    public IReadOnlyCollection<RequestJournalDetail> RequestJournalDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to RequestVoucherDetail
    /// </summary>
    public IReadOnlyCollection<RequestVoucherDetail> RequestVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to RequestVoucherMaster
    /// </summary>
    public IReadOnlyCollection<RequestVoucherMaster> RequestVoucherMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OtherChargeItem
    /// </summary>
    public IReadOnlyCollection<OtherChargeItem> OtherChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to OtherChargeItemOthers
    /// </summary>
    public IReadOnlyCollection<OtherChargeItemOthers> OtherChargeItemOtherses { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to RequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<RequestTaxItemMovement> RequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchRequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchRequestTaxItemMovement> BranchRequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to TaxInputMovement
    /// </summary>
    public IReadOnlyCollection<TaxInputMovement> TaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchTaxInputMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxInputMovement> BranchTaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to TaxItemMovement
    /// </summary>
    public IReadOnlyCollection<TaxItemMovement> TaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to BranchTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxItemMovement> BranchTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: Activity to Project
    /// </summary>
    public IReadOnlyCollection<Project> Projects { get; private set; }
    #endregion
}
}
