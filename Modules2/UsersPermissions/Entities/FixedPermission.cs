using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// FixedPermission Entity
/// </summary>
public class FixedPermission : Entity<FixedPermissionId>
{

    private FixedPermission() { }

    public FixedPermission(FixedPermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the FixedPermission
    /// المعرف الفريد لـ FixedPermission
    /// </summary>
    public FixedPermissionId Id { get; private set; }

    /// <summary>
    /// CreditLimitTypeFull of the FixedPermission
    /// CreditLimitTypeFull الخاص بـ FixedPermission
    /// </summary>
    public decimal? CreditLimitTypeFull { get; private set; }

    /// <summary>
    /// PManual of the FixedPermission
    /// PManual الخاص بـ FixedPermission
    /// </summary>
    public decimal? PManual { get; private set; }

    /// <summary>
    /// InvoiceDiscountLimit of the FixedPermission
    /// InvoiceDiscountLimit الخاص بـ FixedPermission
    /// </summary>
    public decimal? InvoiceDiscountLimit { get; private set; }

    /// <summary>
    /// HideCost of the FixedPermission
    /// HideCost الخاص بـ FixedPermission
    /// </summary>
    public decimal? HideCost { get; private set; }

    /// <summary>
    /// PriceLimitType of the FixedPermission
    /// PriceLimitType الخاص بـ FixedPermission
    /// </summary>
    public decimal? PriceLimitType { get; private set; }

    /// <summary>
    /// PaymentAvailableQuantity of the FixedPermission
    /// PaymentAvailableQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? PaymentAvailableQuantity { get; private set; }

    /// <summary>
    /// PaymentItemMinimumQuantity of the FixedPermission
    /// PaymentItemMinimumQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? PaymentItemMinimumQuantity { get; private set; }

    /// <summary>
    /// InvoiceReport of the FixedPermission
    /// InvoiceReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? InvoiceReport { get; private set; }

    /// <summary>
    /// LPrice of the FixedPermission
    /// LPrice الخاص بـ FixedPermission
    /// </summary>
    public decimal? LPrice { get; private set; }

    /// <summary>
    /// HourlyPrice of the FixedPermission
    /// HourlyPrice الخاص بـ FixedPermission
    /// </summary>
    public decimal? HourlyPrice { get; private set; }

    /// <summary>
    /// ShowMainAccountReport of the FixedPermission
    /// ShowMainAccountReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowMainAccountReport { get; private set; }

    /// <summary>
    /// ArUpdateFreeQuantity of the FixedPermission
    /// ArUpdateFreeQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArUpdateFreeQuantity { get; private set; }

    /// <summary>
    /// ArUpdateItemAllowDiscount of the FixedPermission
    /// ArUpdateItemAllowDiscount الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArUpdateItemAllowDiscount { get; private set; }

    /// <summary>
    /// UseSalesOrderInSalesInvoice of the FixedPermission
    /// UseSalesOrderInSalesInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseSalesOrderInSalesInvoice { get; private set; }

    /// <summary>
    /// UpdateBillsDataFlag of the FixedPermission
    /// UpdateBillsDataFlag الخاص بـ FixedPermission
    /// </summary>
    public decimal? UpdateBillsDataFlag { get; private set; }

    /// <summary>
    /// UpdateKimbAmount of the FixedPermission
    /// UpdateKimbAmount الخاص بـ FixedPermission
    /// </summary>
    public decimal? UpdateKimbAmount { get; private set; }

    /// <summary>
    /// PrintDocumentFlag of the FixedPermission
    /// PrintDocumentFlag الخاص بـ FixedPermission
    /// </summary>
    public decimal? PrintDocumentFlag { get; private set; }

    /// <summary>
    /// UserViewDocumentEntry of the FixedPermission
    /// UserViewDocumentEntry الخاص بـ FixedPermission
    /// </summary>
    public decimal? UserViewDocumentEntry { get; private set; }

    /// <summary>
    /// ShowArabicReportDay of the FixedPermission
    /// ShowArabicReportDay الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowArabicReportDay { get; private set; }

    /// <summary>
    /// AllowBillFreeQuantityOnly of the FixedPermission
    /// AllowBillFreeQuantityOnly الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowBillFreeQuantityOnly { get; private set; }

    /// <summary>
    /// AllowEnterZeroCost of the FixedPermission
    /// AllowEnterZeroCost الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowEnterZeroCost { get; private set; }

    /// <summary>
    /// PriceLimitPrevious of the FixedPermission
    /// PriceLimitPrevious الخاص بـ FixedPermission
    /// </summary>
    public decimal? PriceLimitPrevious { get; private set; }

    /// <summary>
    /// CheckCreditPeriod of the FixedPermission
    /// CheckCreditPeriod الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckCreditPeriod { get; private set; }

    /// <summary>
    /// FillOutBillsOnce of the FixedPermission
    /// FillOutBillsOnce الخاص بـ FixedPermission
    /// </summary>
    public decimal? FillOutBillsOnce { get; private set; }

    /// <summary>
    /// SelectDocumentType of the FixedPermission
    /// SelectDocumentType الخاص بـ FixedPermission
    /// </summary>
    public decimal? SelectDocumentType { get; private set; }

    /// <summary>
    /// AccountLimitPrevious of the FixedPermission
    /// AccountLimitPrevious الخاص بـ FixedPermission
    /// </summary>
    public decimal? AccountLimitPrevious { get; private set; }

    /// <summary>
    /// ShowStockCostInQuantityDiscountFreeQuantity of the FixedPermission
    /// ShowStockCostInQuantityDiscountFreeQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowStockCostInQuantityDiscountFreeQuantity { get; private set; }

    /// <summary>
    /// PaymentVoucherMasterAccountPrevious of the FixedPermission
    /// PaymentVoucherMasterAccountPrevious الخاص بـ FixedPermission
    /// </summary>
    public decimal? PaymentVoucherMasterAccountPrevious { get; private set; }

    /// <summary>
    /// ReceiveVoucherMasterAccountPrevious of the FixedPermission
    /// ReceiveVoucherMasterAccountPrevious الخاص بـ FixedPermission
    /// </summary>
    public decimal? ReceiveVoucherMasterAccountPrevious { get; private set; }

    /// <summary>
    /// AllowModifyFieldName of the FixedPermission
    /// AllowModifyFieldName الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowModifyFieldName { get; private set; }

    /// <summary>
    /// CheckCustomerBlackList of the FixedPermission
    /// CheckCustomerBlackList الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckCustomerBlackList { get; private set; }

    /// <summary>
    /// ModifyItemDiscount of the FixedPermission
    /// ModifyItemDiscount الخاص بـ FixedPermission
    /// </summary>
    public decimal? ModifyItemDiscount { get; private set; }

    /// <summary>
    /// MaxDiscountItemPercent of the FixedPermission
    /// MaxDiscountItemPercent الخاص بـ FixedPermission
    /// </summary>
    public decimal? MaxDiscountItemPercent { get; private set; }

    /// <summary>
    /// UpdateDocumentHoursPeriod of the FixedPermission
    /// UpdateDocumentHoursPeriod الخاص بـ FixedPermission
    /// </summary>
    public decimal? UpdateDocumentHoursPeriod { get; private set; }

    /// <summary>
    /// UpdateDocumentDayPeriod of the FixedPermission
    /// UpdateDocumentDayPeriod الخاص بـ FixedPermission
    /// </summary>
    public decimal? UpdateDocumentDayPeriod { get; private set; }

    /// <summary>
    /// DelDocHrsPrd of the FixedPermission
    /// DelDocHrsPrd الخاص بـ FixedPermission
    /// </summary>
    public decimal? DelDocHrsPrd { get; private set; }

    /// <summary>
    /// DelDocDayPrd of the FixedPermission
    /// DelDocDayPrd الخاص بـ FixedPermission
    /// </summary>
    public decimal? DelDocDayPrd { get; private set; }

    /// <summary>
    /// AllowImportExcel of the FixedPermission
    /// AllowImportExcel الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowImportExcel { get; private set; }

    /// <summary>
    /// AllowCallRepresentativeButton of the FixedPermission
    /// AllowCallRepresentativeButton الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowCallRepresentativeButton { get; private set; }

    /// <summary>
    /// ArUpdateItemNotAllowDiscount of the FixedPermission
    /// ArUpdateItemNotAllowDiscount الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArUpdateItemNotAllowDiscount { get; private set; }

    /// <summary>
    /// InvoiceAdditionalDiscountLimit of the FixedPermission
    /// InvoiceAdditionalDiscountLimit الخاص بـ FixedPermission
    /// </summary>
    public decimal? InvoiceAdditionalDiscountLimit { get; private set; }

    /// <summary>
    /// CheckPrivilegeAccessReport of the FixedPermission
    /// CheckPrivilegeAccessReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeAccessReport { get; private set; }

    /// <summary>
    /// CheckPrivilegeCostCentersReport of the FixedPermission
    /// CheckPrivilegeCostCentersReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeCostCentersReport { get; private set; }

    /// <summary>
    /// CheckPrivilegeProjectsReport of the FixedPermission
    /// CheckPrivilegeProjectsReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeProjectsReport { get; private set; }

    /// <summary>
    /// CheckPrivilegeBranchReport of the FixedPermission
    /// CheckPrivilegeBranchReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeBranchReport { get; private set; }

    /// <summary>
    /// CheckReturnPercent of the FixedPermission
    /// CheckReturnPercent الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckReturnPercent { get; private set; }

    /// <summary>
    /// UpdateSalesInvoicePayType of the FixedPermission
    /// UpdateSalesInvoicePayType الخاص بـ FixedPermission
    /// </summary>
    public decimal? UpdateSalesInvoicePayType { get; private set; }

    /// <summary>
    /// ChangePricePurchaseInvoice of the FixedPermission
    /// ChangePricePurchaseInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? ChangePricePurchaseInvoice { get; private set; }

    /// <summary>
    /// AdditionalDiscountInCreditPeriodOnly of the FixedPermission
    /// AdditionalDiscountInCreditPeriodOnly الخاص بـ FixedPermission
    /// </summary>
    public decimal? AdditionalDiscountInCreditPeriodOnly { get; private set; }

    /// <summary>
    /// CheckPrivilegeAccessAssessment of the FixedPermission
    /// CheckPrivilegeAccessAssessment الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeAccessAssessment { get; private set; }

    /// <summary>
    /// CheckPrivilegeCostCentersAssessment of the FixedPermission
    /// CheckPrivilegeCostCentersAssessment الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeCostCentersAssessment { get; private set; }

    /// <summary>
    /// CheckPrivilegeProjectsAssessment of the FixedPermission
    /// CheckPrivilegeProjectsAssessment الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeProjectsAssessment { get; private set; }

    /// <summary>
    /// AllowPrintDocumentBeforeAuditReference of the FixedPermission
    /// AllowPrintDocumentBeforeAuditReference الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowPrintDocumentBeforeAuditReference { get; private set; }

    /// <summary>
    /// AllowCancelAuditReference of the FixedPermission
    /// AllowCancelAuditReference الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowCancelAuditReference { get; private set; }

    /// <summary>
    /// UseInstallmentJournalVoucher of the FixedPermission
    /// UseInstallmentJournalVoucher الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseInstallmentJournalVoucher { get; private set; }

    /// <summary>
    /// UseInstallmentReceipt of the FixedPermission
    /// UseInstallmentReceipt الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseInstallmentReceipt { get; private set; }

    /// <summary>
    /// UseInstallmentPayment of the FixedPermission
    /// UseInstallmentPayment الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseInstallmentPayment { get; private set; }

    /// <summary>
    /// AllowUpdateAutoDate of the FixedPermission
    /// AllowUpdateAutoDate الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateAutoDate { get; private set; }

    /// <summary>
    /// AllowUpdateOrderPriceInBill of the FixedPermission
    /// AllowUpdateOrderPriceInBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateOrderPriceInBill { get; private set; }

    /// <summary>
    /// ShowAvailableQuantityInRequest of the FixedPermission
    /// ShowAvailableQuantityInRequest الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowAvailableQuantityInRequest { get; private set; }

    /// <summary>
    /// ShowAvailableQuantityInTransaction of the FixedPermission
    /// ShowAvailableQuantityInTransaction الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowAvailableQuantityInTransaction { get; private set; }

    /// <summary>
    /// AllowShowJournal of the FixedPermission
    /// AllowShowJournal الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowShowJournal { get; private set; }

    /// <summary>
    /// InvoiceDiscountLimitItem of the FixedPermission
    /// InvoiceDiscountLimitItem الخاص بـ FixedPermission
    /// </summary>
    public decimal? InvoiceDiscountLimitItem { get; private set; }

    /// <summary>
    /// UseReturnWarehouseTransfer of the FixedPermission
    /// UseReturnWarehouseTransfer الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseReturnWarehouseTransfer { get; private set; }

    /// <summary>
    /// CheckPrivilegeActivityAssessment of the FixedPermission
    /// CheckPrivilegeActivityAssessment الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeActivityAssessment { get; private set; }

    /// <summary>
    /// CheckPrivilegeActivityReport of the FixedPermission
    /// CheckPrivilegeActivityReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeActivityReport { get; private set; }

    /// <summary>
    /// ExceedAmountContractInBill of the FixedPermission
    /// ExceedAmountContractInBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? ExceedAmountContractInBill { get; private set; }

    /// <summary>
    /// ArShowStockCostReport of the FixedPermission
    /// ArShowStockCostReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArShowStockCostReport { get; private set; }

    /// <summary>
    /// AllowDeleteItemFromPosBill of the FixedPermission
    /// AllowDeleteItemFromPosBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowDeleteItemFromPosBill { get; private set; }

    /// <summary>
    /// ArAllowSalesDueDebit of the FixedPermission
    /// ArAllowSalesDueDebit الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArAllowSalesDueDebit { get; private set; }

    /// <summary>
    /// ArAllowSalesPreviousDebit of the FixedPermission
    /// ArAllowSalesPreviousDebit الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArAllowSalesPreviousDebit { get; private set; }

    /// <summary>
    /// ArCheckPeriodAfterDue of the FixedPermission
    /// ArCheckPeriodAfterDue الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArCheckPeriodAfterDue { get; private set; }

    /// <summary>
    /// UseBalancedAccountCurrencyJournalVoucher of the FixedPermission
    /// UseBalancedAccountCurrencyJournalVoucher الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseBalancedAccountCurrencyJournalVoucher { get; private set; }

    /// <summary>
    /// AllowCopyPriceLevel of the FixedPermission
    /// AllowCopyPriceLevel الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowCopyPriceLevel { get; private set; }

    /// <summary>
    /// AllowChangePosQuantity of the FixedPermission
    /// AllowChangePosQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowChangePosQuantity { get; private set; }

    /// <summary>
    /// AccountsPayableAllowUpdateFillQuantity of the FixedPermission
    /// AccountsPayableAllowUpdateFillQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? AccountsPayableAllowUpdateFillQuantity { get; private set; }

    /// <summary>
    /// PriceLimitPercent of the FixedPermission
    /// PriceLimitPercent الخاص بـ FixedPermission
    /// </summary>
    public decimal? PriceLimitPercent { get; private set; }

    /// <summary>
    /// CreditLimitPercent of the FixedPermission
    /// CreditLimitPercent الخاص بـ FixedPermission
    /// </summary>
    public decimal? CreditLimitPercent { get; private set; }

    /// <summary>
    /// AllowHungBills of the FixedPermission
    /// AllowHungBills الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowHungBills { get; private set; }

    /// <summary>
    /// UseUndoCtrlU of the FixedPermission
    /// UseUndoCtrlU الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseUndoCtrlU { get; private set; }

    /// <summary>
    /// ReturnBillNumber of the FixedPermission
    /// ReturnBillNumber الخاص بـ FixedPermission
    /// </summary>
    public decimal? ReturnBillNumber { get; private set; }

    /// <summary>
    /// PrintPreviousBill of the FixedPermission
    /// PrintPreviousBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? PrintPreviousBill { get; private set; }

    /// <summary>
    /// CheckPrivilegeBranchAssessment of the FixedPermission
    /// CheckPrivilegeBranchAssessment الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckPrivilegeBranchAssessment { get; private set; }

    /// <summary>
    /// PaymentForVendorZeroCredit of the FixedPermission
    /// PaymentForVendorZeroCredit الخاص بـ FixedPermission
    /// </summary>
    public decimal? PaymentForVendorZeroCredit { get; private set; }

    /// <summary>
    /// NotAllowModifyDetailDocumentAfterSave of the FixedPermission
    /// NotAllowModifyDetailDocumentAfterSave الخاص بـ FixedPermission
    /// </summary>
    public decimal? NotAllowModifyDetailDocumentAfterSave { get; private set; }

    /// <summary>
    /// FillStockCostIntoPriceSalesInvoice of the FixedPermission
    /// FillStockCostIntoPriceSalesInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? FillStockCostIntoPriceSalesInvoice { get; private set; }

    /// <summary>
    /// AllowUpdateDiscountReturnBill of the FixedPermission
    /// AllowUpdateDiscountReturnBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateDiscountReturnBill { get; private set; }

    /// <summary>
    /// ShowGeneralLedgerCashReportDay of the FixedPermission
    /// ShowGeneralLedgerCashReportDay الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowGeneralLedgerCashReportDay { get; private set; }

    /// <summary>
    /// ShowAmountQuantityStaticArabicReport of the FixedPermission
    /// ShowAmountQuantityStaticArabicReport الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowAmountQuantityStaticArabicReport { get; private set; }

    /// <summary>
    /// AllowUpdateQuantityWeight of the FixedPermission
    /// AllowUpdateQuantityWeight الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateQuantityWeight { get; private set; }

    /// <summary>
    /// ArEnterPriceManualSalesReturn of the FixedPermission
    /// ArEnterPriceManualSalesReturn الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArEnterPriceManualSalesReturn { get; private set; }

    /// <summary>
    /// ArAllowDiscountItemQuotationPremiumSI of the FixedPermission
    /// ArAllowDiscountItemQuotationPremiumSI الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArAllowDiscountItemQuotationPremiumSI { get; private set; }

    /// <summary>
    /// AllowFillSerialNumber of the FixedPermission
    /// AllowFillSerialNumber الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowFillSerialNumber { get; private set; }

    /// <summary>
    /// BudgetLimitPrevious of the FixedPermission
    /// BudgetLimitPrevious الخاص بـ FixedPermission
    /// </summary>
    public decimal? BudgetLimitPrevious { get; private set; }

    /// <summary>
    /// AllowUnapproved of the FixedPermission
    /// AllowUnapproved الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUnapproved { get; private set; }

    /// <summary>
    /// UseHidePriceItemBarcode of the FixedPermission
    /// UseHidePriceItemBarcode الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseHidePriceItemBarcode { get; private set; }

    /// <summary>
    /// ArMaxInstallment of the FixedPermission
    /// ArMaxInstallment الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArMaxInstallment { get; private set; }

    /// <summary>
    /// AllowModifyPercentPriceFromCost of the FixedPermission
    /// AllowModifyPercentPriceFromCost الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowModifyPercentPriceFromCost { get; private set; }

    /// <summary>
    /// ArMaxAdditionalFreeQuantityItemPer of the FixedPermission
    /// ArMaxAdditionalFreeQuantityItemPer الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArMaxAdditionalFreeQuantityItemPer { get; private set; }

    /// <summary>
    /// ArAutoPrintSalesInvoiceAfterSave of the FixedPermission
    /// ArAutoPrintSalesInvoiceAfterSave الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArAutoPrintSalesInvoiceAfterSave { get; private set; }

    /// <summary>
    /// ArAutoPrintSalesReturnAfterSave of the FixedPermission
    /// ArAutoPrintSalesReturnAfterSave الخاص بـ FixedPermission
    /// </summary>
    public decimal? ArAutoPrintSalesReturnAfterSave { get; private set; }

    /// <summary>
    /// UserShowMessageBeforeSave of the FixedPermission
    /// UserShowMessageBeforeSave الخاص بـ FixedPermission
    /// </summary>
    public decimal? UserShowMessageBeforeSave { get; private set; }

    /// <summary>
    /// UseWorkOrderInSalesInvoice of the FixedPermission
    /// UseWorkOrderInSalesInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseWorkOrderInSalesInvoice { get; private set; }

    /// <summary>
    /// AllowUpdateStandbySIOnly of the FixedPermission
    /// AllowUpdateStandbySIOnly الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateStandbySIOnly { get; private set; }

    /// <summary>
    /// DsplyPrvAcStmnt of the FixedPermission
    /// DsplyPrvAcStmnt الخاص بـ FixedPermission
    /// </summary>
    public decimal? DsplyPrvAcStmnt { get; private set; }

    /// <summary>
    /// AllowUpdateCustomerSequence of the FixedPermission
    /// AllowUpdateCustomerSequence الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateCustomerSequence { get; private set; }

    /// <summary>
    /// ModifyMobileVoucherReceiveDocument of the FixedPermission
    /// ModifyMobileVoucherReceiveDocument الخاص بـ FixedPermission
    /// </summary>
    public decimal? ModifyMobileVoucherReceiveDocument { get; private set; }

    /// <summary>
    /// AllowUpdateVatPercent of the FixedPermission
    /// AllowUpdateVatPercent الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateVatPercent { get; private set; }

    /// <summary>
    /// UseTrailerLoadInSalesInvoice of the FixedPermission
    /// UseTrailerLoadInSalesInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseTrailerLoadInSalesInvoice { get; private set; }

    /// <summary>
    /// AllowExceedVendorPrice of the FixedPermission
    /// AllowExceedVendorPrice الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowExceedVendorPrice { get; private set; }

    /// <summary>
    /// UseFreeRmsInvoice of the FixedPermission
    /// UseFreeRmsInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseFreeRmsInvoice { get; private set; }

    /// <summary>
    /// AllowChangeDeliveryServiceAmount of the FixedPermission
    /// AllowChangeDeliveryServiceAmount الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowChangeDeliveryServiceAmount { get; private set; }

    /// <summary>
    /// UpdateMaxLimitPossible of the FixedPermission
    /// UpdateMaxLimitPossible الخاص بـ FixedPermission
    /// </summary>
    public decimal? UpdateMaxLimitPossible { get; private set; }

    /// <summary>
    /// AllowChangeRentPrice of the FixedPermission
    /// AllowChangeRentPrice الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowChangeRentPrice { get; private set; }

    /// <summary>
    /// AllowUnpostedRent of the FixedPermission
    /// AllowUnpostedRent الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUnpostedRent { get; private set; }

    /// <summary>
    /// AllowPostRentPeriod of the FixedPermission
    /// AllowPostRentPeriod الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowPostRentPeriod { get; private set; }

    /// <summary>
    /// AllowUpdateDischargeDate of the FixedPermission
    /// AllowUpdateDischargeDate الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateDischargeDate { get; private set; }

    /// <summary>
    /// AllowUpdateTransferDate of the FixedPermission
    /// AllowUpdateTransferDate الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateTransferDate { get; private set; }

    /// <summary>
    /// AllowOutPatientNoZeroBalance of the FixedPermission
    /// AllowOutPatientNoZeroBalance الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowOutPatientNoZeroBalance { get; private set; }

    /// <summary>
    /// AllowCancelDischargePatient of the FixedPermission
    /// AllowCancelDischargePatient الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowCancelDischargePatient { get; private set; }

    /// <summary>
    /// AllowOutPatientNoOrderException of the FixedPermission
    /// AllowOutPatientNoOrderException الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowOutPatientNoOrderException { get; private set; }

    /// <summary>
    /// AllowPrintResultUnverified of the FixedPermission
    /// AllowPrintResultUnverified الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowPrintResultUnverified { get; private set; }

    /// <summary>
    /// AllowUpdatePaymentInAdmission of the FixedPermission
    /// AllowUpdatePaymentInAdmission الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdatePaymentInAdmission { get; private set; }

    /// <summary>
    /// NotShowKitItemContent of the FixedPermission
    /// NotShowKitItemContent الخاص بـ FixedPermission
    /// </summary>
    public decimal? NotShowKitItemContent { get; private set; }

    /// <summary>
    /// UseStaffFeedingRmsInvoice of the FixedPermission
    /// UseStaffFeedingRmsInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseStaffFeedingRmsInvoice { get; private set; }

    /// <summary>
    /// UseDamagedRmsInvoice of the FixedPermission
    /// UseDamagedRmsInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseDamagedRmsInvoice { get; private set; }

    /// <summary>
    /// UseHospitalityRmsInvoice of the FixedPermission
    /// UseHospitalityRmsInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseHospitalityRmsInvoice { get; private set; }

    /// <summary>
    /// AllowDeleteHungBills of the FixedPermission
    /// AllowDeleteHungBills الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowDeleteHungBills { get; private set; }

    /// <summary>
    /// NotAllowUpdateCustomerCodePatientBills of the FixedPermission
    /// NotAllowUpdateCustomerCodePatientBills الخاص بـ FixedPermission
    /// </summary>
    public decimal? NotAllowUpdateCustomerCodePatientBills { get; private set; }

    /// <summary>
    /// AllowApprovedPosReturnBill of the FixedPermission
    /// AllowApprovedPosReturnBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowApprovedPosReturnBill { get; private set; }

    /// <summary>
    /// AllowPrintLastBill of the FixedPermission
    /// AllowPrintLastBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowPrintLastBill { get; private set; }

    /// <summary>
    /// AllowChangePurchaseInvoicePriceConnectIncome of the FixedPermission
    /// AllowChangePurchaseInvoicePriceConnectIncome الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowChangePurchaseInvoicePriceConnectIncome { get; private set; }

    /// <summary>
    /// AllowOutBillCustomerLargerBalance of the FixedPermission
    /// AllowOutBillCustomerLargerBalance الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowOutBillCustomerLargerBalance { get; private set; }

    /// <summary>
    /// AllowUpdateBedPrice of the FixedPermission
    /// AllowUpdateBedPrice الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateBedPrice { get; private set; }

    /// <summary>
    /// ShowDoctorPercentInBill of the FixedPermission
    /// ShowDoctorPercentInBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowDoctorPercentInBill { get; private set; }

    /// <summary>
    /// AllowEnterWeightManualSalesOrder of the FixedPermission
    /// AllowEnterWeightManualSalesOrder الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowEnterWeightManualSalesOrder { get; private set; }

    /// <summary>
    /// AllowUpdateStockExchangeRateInTransaction of the FixedPermission
    /// AllowUpdateStockExchangeRateInTransaction الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateStockExchangeRateInTransaction { get; private set; }

    /// <summary>
    /// AllowExceedMaxProductReturnInsurance of the FixedPermission
    /// AllowExceedMaxProductReturnInsurance الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowExceedMaxProductReturnInsurance { get; private set; }

    /// <summary>
    /// AllowPrintLastRmsInvoice of the FixedPermission
    /// AllowPrintLastRmsInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowPrintLastRmsInvoice { get; private set; }

    /// <summary>
    /// UpdatePurchaseInvoicePayType of the FixedPermission
    /// UpdatePurchaseInvoicePayType الخاص بـ FixedPermission
    /// </summary>
    public decimal? UpdatePurchaseInvoicePayType { get; private set; }

    /// <summary>
    /// ShowPriceInOutgoingBill of the FixedPermission
    /// ShowPriceInOutgoingBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowPriceInOutgoingBill { get; private set; }

    /// <summary>
    /// AllowDeleteItemFromRmsBill of the FixedPermission
    /// AllowDeleteItemFromRmsBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowDeleteItemFromRmsBill { get; private set; }

    /// <summary>
    /// ShowAvailableQuantityInManualInvoice of the FixedPermission
    /// ShowAvailableQuantityInManualInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowAvailableQuantityInManualInvoice { get; private set; }

    /// <summary>
    /// AllowDrugOrderWithoutQuantityCheck of the FixedPermission
    /// AllowDrugOrderWithoutQuantityCheck الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowDrugOrderWithoutQuantityCheck { get; private set; }

    /// <summary>
    /// CheckBalancePatientAdmitCashInBill of the FixedPermission
    /// CheckBalancePatientAdmitCashInBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? CheckBalancePatientAdmitCashInBill { get; private set; }

    /// <summary>
    /// AllowReturnBillOtherCashier of the FixedPermission
    /// AllowReturnBillOtherCashier الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowReturnBillOtherCashier { get; private set; }

    /// <summary>
    /// RemarkAllowUpdateVoucherDescription of the FixedPermission
    /// RemarkAllowUpdateVoucherDescription الخاص بـ FixedPermission
    /// </summary>
    public decimal? RemarkAllowUpdateVoucherDescription { get; private set; }

    /// <summary>
    /// OpenSystemMoreOnce of the FixedPermission
    /// OpenSystemMoreOnce الخاص بـ FixedPermission
    /// </summary>
    public decimal? OpenSystemMoreOnce { get; private set; }

    /// <summary>
    /// GlassShowBalanceInTransaction of the FixedPermission
    /// GlassShowBalanceInTransaction الخاص بـ FixedPermission
    /// </summary>
    public decimal? GlassShowBalanceInTransaction { get; private set; }

    /// <summary>
    /// AllowModifyDocumentAfterPrint of the FixedPermission
    /// AllowModifyDocumentAfterPrint الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowModifyDocumentAfterPrint { get; private set; }

    /// <summary>
    /// AllowDeleteDocumentAfterPrint of the FixedPermission
    /// AllowDeleteDocumentAfterPrint الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowDeleteDocumentAfterPrint { get; private set; }

    /// <summary>
    /// UseReserveSalesQuantityNoOutInInvoice of the FixedPermission
    /// UseReserveSalesQuantityNoOutInInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseReserveSalesQuantityNoOutInInvoice { get; private set; }

    /// <summary>
    /// MrpMpsIssueExternalWorkOrder of the FixedPermission
    /// MrpMpsIssueExternalWorkOrder الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpMpsIssueExternalWorkOrder { get; private set; }

    /// <summary>
    /// MrpCreateMultipleReceiveTransaction of the FixedPermission
    /// MrpCreateMultipleReceiveTransaction الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpCreateMultipleReceiveTransaction { get; private set; }

    /// <summary>
    /// MrpSfcIssueExternalTransaction of the FixedPermission
    /// MrpSfcIssueExternalTransaction الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpSfcIssueExternalTransaction { get; private set; }

    /// <summary>
    /// MrpMpsPreWorkOrderApprove of the FixedPermission
    /// MrpMpsPreWorkOrderApprove الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpMpsPreWorkOrderApprove { get; private set; }

    /// <summary>
    /// MrpSfcPreMrqApprove of the FixedPermission
    /// MrpSfcPreMrqApprove الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpSfcPreMrqApprove { get; private set; }

    /// <summary>
    /// MrpSfcPreMrcApprove of the FixedPermission
    /// MrpSfcPreMrcApprove الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpSfcPreMrcApprove { get; private set; }

    /// <summary>
    /// MrpSfcPreSfcApprove of the FixedPermission
    /// MrpSfcPreSfcApprove الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpSfcPreSfcApprove { get; private set; }

    /// <summary>
    /// MrpSfcPreMdvApprove of the FixedPermission
    /// MrpSfcPreMdvApprove الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpSfcPreMdvApprove { get; private set; }

    /// <summary>
    /// MrpSfcPreMrtApprove of the FixedPermission
    /// MrpSfcPreMrtApprove الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpSfcPreMrtApprove { get; private set; }

    /// <summary>
    /// RmsLimitTimeCancelOrder of the FixedPermission
    /// RmsLimitTimeCancelOrder الخاص بـ FixedPermission
    /// </summary>
    public decimal? RmsLimitTimeCancelOrder { get; private set; }

    /// <summary>
    /// RmsAllowMinusChiefQuantity of the FixedPermission
    /// RmsAllowMinusChiefQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? RmsAllowMinusChiefQuantity { get; private set; }

    /// <summary>
    /// RmsAllowCancelUnderProcessQuantity of the FixedPermission
    /// RmsAllowCancelUnderProcessQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? RmsAllowCancelUnderProcessQuantity { get; private set; }

    /// <summary>
    /// AllowUpdatePurchaseOrderToBillType of the FixedPermission
    /// AllowUpdatePurchaseOrderToBillType الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdatePurchaseOrderToBillType { get; private set; }

    /// <summary>
    /// AllowUpdateQuotationToPurchaseOrderType of the FixedPermission
    /// AllowUpdateQuotationToPurchaseOrderType الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowUpdateQuotationToPurchaseOrderType { get; private set; }

    /// <summary>
    /// PurchaseByPurchaseUnitOnly of the FixedPermission
    /// PurchaseByPurchaseUnitOnly الخاص بـ FixedPermission
    /// </summary>
    public decimal? PurchaseByPurchaseUnitOnly { get; private set; }

    /// <summary>
    /// ShowItemDiscountAverageAccountsPayableSalesInvoice of the FixedPermission
    /// ShowItemDiscountAverageAccountsPayableSalesInvoice الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowItemDiscountAverageAccountsPayableSalesInvoice { get; private set; }

    /// <summary>
    /// AllowSaleNewExpireDate of the FixedPermission
    /// AllowSaleNewExpireDate الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowSaleNewExpireDate { get; private set; }

    /// <summary>
    /// AllowEnterFreeQuantitySalesOrder of the FixedPermission
    /// AllowEnterFreeQuantitySalesOrder الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowEnterFreeQuantitySalesOrder { get; private set; }

    /// <summary>
    /// ShowStockCostProfitMarginSale of the FixedPermission
    /// ShowStockCostProfitMarginSale الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowStockCostProfitMarginSale { get; private set; }

    /// <summary>
    /// UseSearchItemNameArabic of the FixedPermission
    /// UseSearchItemNameArabic الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseSearchItemNameArabic { get; private set; }

    /// <summary>
    /// SearchItemCriteria of the FixedPermission
    /// SearchItemCriteria الخاص بـ FixedPermission
    /// </summary>
    public decimal? SearchItemCriteria { get; private set; }

    /// <summary>
    /// UseArchiveFileInDb of the FixedPermission
    /// UseArchiveFileInDb الخاص بـ FixedPermission
    /// </summary>
    public decimal? UseArchiveFileInDb { get; private set; }

    /// <summary>
    /// AllowFillAllItemsToReturnBill of the FixedPermission
    /// AllowFillAllItemsToReturnBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowFillAllItemsToReturnBill { get; private set; }

    /// <summary>
    /// PrintCountForBill of the FixedPermission
    /// PrintCountForBill الخاص بـ FixedPermission
    /// </summary>
    public decimal? PrintCountForBill { get; private set; }

    /// <summary>
    /// AllowExceedLimitSalesItem of the FixedPermission
    /// AllowExceedLimitSalesItem الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowExceedLimitSalesItem { get; private set; }

    /// <summary>
    /// ShowBalanceInCashInventory of the FixedPermission
    /// ShowBalanceInCashInventory الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowBalanceInCashInventory { get; private set; }

    /// <summary>
    /// GlassAllowUpdateRepresentativesCommission of the FixedPermission
    /// GlassAllowUpdateRepresentativesCommission الخاص بـ FixedPermission
    /// </summary>
    public decimal? GlassAllowUpdateRepresentativesCommission { get; private set; }

    /// <summary>
    /// GlassStatementHideOpenBalance of the FixedPermission
    /// GlassStatementHideOpenBalance الخاص بـ FixedPermission
    /// </summary>
    public decimal? GlassStatementHideOpenBalance { get; private set; }

    /// <summary>
    /// MrpVaryProductCostPrivilege of the FixedPermission
    /// MrpVaryProductCostPrivilege الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpVaryProductCostPrivilege { get; private set; }

    /// <summary>
    /// ShowAlertScreenAfterLogin of the FixedPermission
    /// ShowAlertScreenAfterLogin الخاص بـ FixedPermission
    /// </summary>
    public decimal? ShowAlertScreenAfterLogin { get; private set; }

    /// <summary>
    /// AllowPrintPriceWithTax of the FixedPermission
    /// AllowPrintPriceWithTax الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowPrintPriceWithTax { get; private set; }

    /// <summary>
    /// HourlyAddPercentCompensationQuantity of the FixedPermission
    /// HourlyAddPercentCompensationQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? HourlyAddPercentCompensationQuantity { get; private set; }

    /// <summary>
    /// AllowDecreaseQuantity of the FixedPermission
    /// AllowDecreaseQuantity الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowDecreaseQuantity { get; private set; }

    /// <summary>
    /// MrpSfcAllowActualProductionLessStandard of the FixedPermission
    /// MrpSfcAllowActualProductionLessStandard الخاص بـ FixedPermission
    /// </summary>
    public decimal? MrpSfcAllowActualProductionLessStandard { get; private set; }

    /// <summary>
    /// AllowExportExcel of the FixedPermission
    /// AllowExportExcel الخاص بـ FixedPermission
    /// </summary>
    public decimal? AllowExportExcel { get; private set; }

    /// <summary>
    /// OutgoingItemSerialWithBarcode of the FixedPermission
    /// OutgoingItemSerialWithBarcode الخاص بـ FixedPermission
    /// </summary>
    public decimal? OutgoingItemSerialWithBarcode { get; private set; }

    /// <summary>
    /// MandatoryBillNoPayment of the FixedPermission
    /// MandatoryBillNoPayment الخاص بـ FixedPermission
    /// </summary>
    public decimal? MandatoryBillNoPayment { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: OneToOne
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

