using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CostCenter Entity
/// </summary>
public class CostCenter : Entity<CostCenterId>
{
    private CostCenter() { }

    /// <summary>
    /// The unique identifier for the CostCenter
    /// المعرف الفريد لـ CostCenter
    /// </summary>
    public CostCenterId Id { get; private set; }

    /// <summary>
    /// CostCenterNumber of the CostCenter
    /// CostCenterNumber الخاص بـ CostCenter
    /// </summary>
    public decimal? CostCenterNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the CostCenter
    /// CostCenterCode الخاص بـ CostCenter
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CostCenterNameArabic of the CostCenter
    /// CostCenterNameArabic الخاص بـ CostCenter
    /// </summary>
    public string CostCenterNameArabic { get; private set; }

    /// <summary>
    /// CostCenterNameEnglish of the CostCenter
    /// CostCenterNameEnglish الخاص بـ CostCenter
    /// </summary>
    public string CostCenterNameEnglish { get; private set; }

    /// <summary>
    /// CLevel of the CostCenter
    /// CLevel الخاص بـ CostCenter
    /// </summary>
    public decimal? CLevel { get; private set; }

    /// <summary>
    /// CParent of the CostCenter
    /// CParent الخاص بـ CostCenter
    /// </summary>
    public string CParent { get; private set; }

    /// <summary>
    /// CSM of the CostCenter
    /// CSM الخاص بـ CostCenter
    /// </summary>
    public decimal? CSM { get; private set; }

    /// <summary>
    /// CSr of the CostCenter
    /// CSr الخاص بـ CostCenter
    /// </summary>
    public decimal? CSr { get; private set; }

    /// <summary>
    /// CGrouping of the CostCenter
    /// CGrouping الخاص بـ CostCenter
    /// </summary>
    public decimal? CGrouping { get; private set; }

    /// <summary>
    /// InactiveFlag of the CostCenter
    /// InactiveFlag الخاص بـ CostCenter
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CostCenter
    /// InactiveReason الخاص بـ CostCenter
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CostCenter
    /// InactiveDate الخاص بـ CostCenter
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// OpenBalance of the CostCenter
    /// OpenBalance الخاص بـ CostCenter
    /// </summary>
    public decimal? OpenBalance { get; private set; }

    /// <summary>
    /// CurrBal of the CostCenter
    /// CurrBal الخاص بـ CostCenter
    /// </summary>
    public decimal? CurrBal { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the CostCenter
    /// ImportExcelFlag الخاص بـ CostCenter
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// UseProject of the CostCenter
    /// UseProject الخاص بـ CostCenter
    /// </summary>
    public decimal? UseProject { get; private set; }

    /// <summary>
    /// Field1 of the CostCenter
    /// Field1 الخاص بـ CostCenter
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the CostCenter
    /// Field2 الخاص بـ CostCenter
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the CostCenter
    /// Field3 الخاص بـ CostCenter
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the CostCenter
    /// Field4 الخاص بـ CostCenter
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the CostCenter
    /// Field5 الخاص بـ CostCenter
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the CostCenter
    /// Field6 الخاص بـ CostCenter
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the CostCenter
    /// Field7 الخاص بـ CostCenter
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the CostCenter
    /// Field8 الخاص بـ CostCenter
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the CostCenter
    /// Field9 الخاص بـ CostCenter
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the CostCenter
    /// Field10 الخاص بـ CostCenter
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveSalesFlag of the CostCenter
    /// InactiveSalesFlag الخاص بـ CostCenter
    /// </summary>
    public decimal? InactiveSalesFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CostCenter to JournalFileDetail
    /// </summary>
    public IReadOnlyCollection<JournalFileDetail> JournalFileDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ActivitySerialNumberDetail
    /// </summary>
    public IReadOnlyCollection<ActivitySerialNumberDetail> ActivitySerialNumberDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to CostCenterPermission
    /// </summary>
    public IReadOnlyCollection<CostCenterPermission> CostCenterPermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GeneralLedgerEditBudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerEditBudgetBalanceDetail> GeneralLedgerEditBudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyDetail> GeneralLedgerRequestExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyMaster> GeneralLedgerRequestExchangeCurrencyMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestVoucherMasterAccount> GeneralLedgerRequestVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GeneralLedgerVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerVoucherMasterAccount> GeneralLedgerVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to AccountCostCenter
    /// </summary>
    public IReadOnlyCollection<AccountCostCenter> AccountCostCenters { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenterGroup
    /// </summary>
    public CostCenterGroup CostCenterGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenterType
    /// </summary>
    public CostCenterType CostCenterType { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to JournalVoucherDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherDetail> JournalVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Voucher
    /// </summary>
    public IReadOnlyCollection<Voucher> Vouchers { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to VoucherDetail
    /// </summary>
    public IReadOnlyCollection<VoucherDetail> VoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OpeningBalance
    /// </summary>
    public IReadOnlyCollection<OpeningBalance> OpeningBalances { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to CostCenterProject
    /// </summary>
    public IReadOnlyCollection<CostCenterProject> CostCenterProjects { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyDetail> ExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ExchangeCurrencyMaster
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyMaster> ExchangeCurrencyMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PostDetail
    /// </summary>
    public IReadOnlyCollection<PostDetail> PostDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PostMaster
    /// </summary>
    public IReadOnlyCollection<PostMaster> PostMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ProfitLossClosingTemp
    /// </summary>
    public IReadOnlyCollection<ProfitLossClosingTemp> ProfitLossClosingTemps { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BudgetApprovalRequestFinanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetApprovalRequestFinanceDetail> BudgetApprovalRequestFinanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to AccountCostCenterLimit
    /// </summary>
    public IReadOnlyCollection<AccountCostCenterLimit> AccountCostCenterLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BudgetBalanceColumnDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceColumnDetail> BudgetBalanceColumnDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BudgetBalanceDetail
    /// </summary>
    public IReadOnlyCollection<BudgetBalanceDetail> BudgetBalanceDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to CustomerRequest
    /// </summary>
    public IReadOnlyCollection<CustomerRequest> CustomerRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to SalesOrder
    /// </summary>
    public IReadOnlyCollection<SalesOrder> SalesOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to CustomerCostCenterLimit
    /// </summary>
    public IReadOnlyCollection<CustomerCostCenterLimit> CustomerCostCenterLimits { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to CustomerCostCenterLimitRequest
    /// </summary>
    public IReadOnlyCollection<CustomerCostCenterLimitRequest> CustomerCostCenterLimitRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to SalesPlanDetail
    /// </summary>
    public IReadOnlyCollection<SalesPlanDetail> SalesPlanDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BillDetail
    /// </summary>
    public IReadOnlyCollection<BillDetail> BillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BillDetailAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscount> BillDetailAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BillDetailAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillDetailAdditionalDiscountRequest> BillDetailAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BranchBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchBillDetail> BranchBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BillMaster
    /// </summary>
    public IReadOnlyCollection<BillMaster> BillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscount> BillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BillMasterAdditionalDiscountRequest
    /// </summary>
    public IReadOnlyCollection<BillMasterAdditionalDiscountRequest> BillMasterAdditionalDiscountRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BranchBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchBillMaster> BranchBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to DueCreditCard
    /// </summary>
    public IReadOnlyCollection<DueCreditCard> DueCreditCards { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OutgoingDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingDetail> OutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OutgoingMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingMaster> OutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OutRequestDetail
    /// </summary>
    public IReadOnlyCollection<OutRequestDetail> OutRequestDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OutRequestMaster
    /// </summary>
    public IReadOnlyCollection<OutRequestMaster> OutRequestMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetail> ReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<ReturnBillMaster> ReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BranchReturnBillDetail
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillDetail> BranchReturnBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ReturnBillDetailRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillDetailRequest> ReturnBillDetailRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BranchReturnBillMaster
    /// </summary>
    public IReadOnlyCollection<BranchReturnBillMaster> BranchReturnBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ReturnBillMasterRequest
    /// </summary>
    public IReadOnlyCollection<ReturnBillMasterRequest> ReturnBillMasterRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OutgoingBillDetail
    /// </summary>
    public IReadOnlyCollection<OutgoingBillDetail> OutgoingBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OutgoingBillMaster
    /// </summary>
    public IReadOnlyCollection<OutgoingBillMaster> OutgoingBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PurchaseOrder
    /// </summary>
    public IReadOnlyCollection<PurchaseOrder> PurchaseOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PurchaseRequest
    /// </summary>
    public IReadOnlyCollection<PurchaseRequest> PurchaseRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Quotation
    /// </summary>
    public IReadOnlyCollection<Quotation> Quotations { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PurchaseBillDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseBillDetail> PurchaseBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PurchaseBillMaster
    /// </summary>
    public IReadOnlyCollection<PurchaseBillMaster> PurchaseBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to QuotationPromotionMaster
    /// </summary>
    public IReadOnlyCollection<QuotationPromotionMaster> QuotationPromotionMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to AdjustInstallmentAccountsPayableMaster
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentAccountsPayableMaster> AdjustInstallmentAccountsPayableMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to AdjustInstallmentMaster
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentMaster> AdjustInstallmentMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GoodsReceiptDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptDetail> GoodsReceiptDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GoodsReceiptNote
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNote> GoodsReceiptNotes { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GoodsReceiptNoteDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteDetail> GoodsReceiptNoteDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GoodsReceiptNoteMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptNoteMaster> GoodsReceiptNoteMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to StockAdjustment
    /// </summary>
    public IReadOnlyCollection<StockAdjustment> StockAdjustments { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ConnectWarehouseCodeByActivity
    /// </summary>
    public IReadOnlyCollection<ConnectWarehouseCodeByActivity> ConnectWarehouseCodeByActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to DefaultDataOnline
    /// </summary>
    public IReadOnlyCollection<DefaultDataOnline> DefaultDataOnlines { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GoodsReceiptIncomingDetail
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingDetail> GoodsReceiptIncomingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GoodsReceiptIncomingMaster
    /// </summary>
    public IReadOnlyCollection<GoodsReceiptIncomingMaster> GoodsReceiptIncomingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to IncomingOutgoingDetail
    /// </summary>
    public IReadOnlyCollection<IncomingOutgoingDetail> IncomingOutgoingDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to IncomingOutgoingMaster
    /// </summary>
    public IReadOnlyCollection<IncomingOutgoingMaster> IncomingOutgoingMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ItemAttachmentMovement
    /// </summary>
    public IReadOnlyCollection<ItemAttachmentMovement> ItemAttachmentMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to OtherItemAttachment
    /// </summary>
    public IReadOnlyCollection<OtherItemAttachment> OtherItemAttachments { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PerformaInvoiceBillDetail
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillDetail> PerformaInvoiceBillDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PerformaInvoiceBillDetailAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillDetailAdditionalDiscount> PerformaInvoiceBillDetailAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PerformaInvoiceBillExpand
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillExpand> PerformaInvoiceBillExpands { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PerformaInvoiceBillJournal
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillJournal> PerformaInvoiceBillJournals { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PerformaInvoiceBillMaster
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to PerformaInvoiceBillMasterAdditionalDiscount
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMasterAdditionalDiscount> PerformaInvoiceBillMasterAdditionalDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to WarehouseTransferMaster
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMaster> WarehouseTransferMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to WarehouseTransferMultiMaster
    /// </summary>
    public IReadOnlyCollection<WarehouseTransferMultiMaster> WarehouseTransferMultiMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Employee
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GuaranteeAccount
    /// </summary>
    public IReadOnlyCollection<GuaranteeAccount> GuaranteeAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to GuaranteeDetail
    /// </summary>
    public IReadOnlyCollection<GuaranteeDetail> GuaranteeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to ReceiptDocument
    /// </summary>
    public IReadOnlyCollection<ReceiptDocument> ReceiptDocuments { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to RequestJournalDetail
    /// </summary>
    public IReadOnlyCollection<RequestJournalDetail> RequestJournalDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to RequestVoucherDetail
    /// </summary>
    public IReadOnlyCollection<RequestVoucherDetail> RequestVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to RequestVoucherMaster
    /// </summary>
    public IReadOnlyCollection<RequestVoucherMaster> RequestVoucherMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to RequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<RequestTaxItemMovement> RequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BranchRequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchRequestTaxItemMovement> BranchRequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to TaxInputMovement
    /// </summary>
    public IReadOnlyCollection<TaxInputMovement> TaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BranchTaxInputMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxInputMovement> BranchTaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to TaxItemMovement
    /// </summary>
    public IReadOnlyCollection<TaxItemMovement> TaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to BranchTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxItemMovement> BranchTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Account
    /// </summary>
    public IReadOnlyCollection<Account> Accounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CostCenter to Project
    /// </summary>
    public IReadOnlyCollection<Project> Projects { get; private set; }
    #endregion
}
}
