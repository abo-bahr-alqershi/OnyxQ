using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceBillMaster Entity
/// </summary>
public class PerformaInvoiceBillMaster : Entity<PerformaInvoiceBillMasterId>
{

    private PerformaInvoiceBillMaster() { }

    public PerformaInvoiceBillMaster(PerformaInvoiceBillMasterId id, decimal? billSerial)
    {
        Id = id;
        BillSerial = billSerial;
    }

    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillMaster
    /// المعرف الفريد لـ PerformaInvoiceBillMaster
    /// </summary>
    public PerformaInvoiceBillMasterId Id { get; private set; }

    /// <summary>
    /// PurchaseType of the PerformaInvoiceBillMaster
    /// PurchaseType الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the PerformaInvoiceBillMaster
    /// BillDocumentTypeFull الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the PerformaInvoiceBillMaster
    /// BillNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the PerformaInvoiceBillMaster
    /// BillSerial الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the PerformaInvoiceBillMaster
    /// BillDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// BillRate of the PerformaInvoiceBillMaster
    /// BillRate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the PerformaInvoiceBillMaster
    /// StockRateShort الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// VendorName of the PerformaInvoiceBillMaster
    /// VendorName الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the PerformaInvoiceBillMaster
    /// LetterCreditNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// AccountCode of the PerformaInvoiceBillMaster
    /// AccountCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PerformaInvoiceBillMaster
    /// AccountDetailCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PerformaInvoiceBillMaster
    /// AccountDetailType الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// ChequeNumber of the PerformaInvoiceBillMaster
    /// ChequeNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the PerformaInvoiceBillMaster
    /// ChequeAmount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the PerformaInvoiceBillMaster
    /// ChequeDueDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// BillDueDate of the PerformaInvoiceBillMaster
    /// BillDueDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? BillDueDate { get; private set; }

    /// <summary>
    /// BillPostFlag of the PerformaInvoiceBillMaster
    /// BillPostFlag الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillPostFlag { get; private set; }

    /// <summary>
    /// BillGoodReceipt of the PerformaInvoiceBillMaster
    /// BillGoodReceipt الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillGoodReceipt { get; private set; }

    /// <summary>
    /// DiscAmt of the PerformaInvoiceBillMaster
    /// DiscAmt الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the PerformaInvoiceBillMaster
    /// DiscAmtMst الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the PerformaInvoiceBillMaster
    /// DiscAmtDtl الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// VatAmount of the PerformaInvoiceBillMaster
    /// VatAmount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// BillAmount of the PerformaInvoiceBillMaster
    /// BillAmount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the PerformaInvoiceBillMaster
    /// OtherAmount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// BillWithoutOtherAmount of the PerformaInvoiceBillMaster
    /// BillWithoutOtherAmount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillWithoutOtherAmount { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PerformaInvoiceBillMaster
    /// ReferenceNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the PerformaInvoiceBillMaster
    /// CashNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the PerformaInvoiceBillMaster
    /// CashNumberForeignCurrencyCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the PerformaInvoiceBillMaster
    /// CashAccountForeignCurrencyCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// AccountDescription of the PerformaInvoiceBillMaster
    /// AccountDescription الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// DriverName of the PerformaInvoiceBillMaster
    /// DriverName الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string DriverName { get; private set; }

    /// <summary>
    /// CarNumber of the PerformaInvoiceBillMaster
    /// CarNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string CarNumber { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the PerformaInvoiceBillMaster
    /// CalcVatPriceType الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// Field1 of the PerformaInvoiceBillMaster
    /// Field1 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the PerformaInvoiceBillMaster
    /// Field2 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the PerformaInvoiceBillMaster
    /// Field3 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the PerformaInvoiceBillMaster
    /// Field4 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the PerformaInvoiceBillMaster
    /// Field5 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the PerformaInvoiceBillMaster
    /// Field6 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the PerformaInvoiceBillMaster
    /// Field7 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the PerformaInvoiceBillMaster
    /// Field8 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the PerformaInvoiceBillMaster
    /// Field9 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the PerformaInvoiceBillMaster
    /// Field10 الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ExpenseAmount of the PerformaInvoiceBillMaster
    /// ExpenseAmount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// UseVat of the PerformaInvoiceBillMaster
    /// UseVat الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the PerformaInvoiceBillMaster
    /// ExternalPostFlag الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// BillTypeNumber of the PerformaInvoiceBillMaster
    /// BillTypeNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillTypeNumber { get; private set; }

    /// <summary>
    /// ConnectWithContract of the PerformaInvoiceBillMaster
    /// ConnectWithContract الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? ConnectWithContract { get; private set; }

    /// <summary>
    /// ContractNumber of the PerformaInvoiceBillMaster
    /// ContractNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerial of the PerformaInvoiceBillMaster
    /// ContractSerial الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string ContractSerial { get; private set; }

    /// <summary>
    /// HungFlag of the PerformaInvoiceBillMaster
    /// HungFlag الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// FreightMethod of the PerformaInvoiceBillMaster
    /// FreightMethod الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? FreightMethod { get; private set; }

    /// <summary>
    /// UnderSellingFlag of the PerformaInvoiceBillMaster
    /// UnderSellingFlag الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? UnderSellingFlag { get; private set; }

    /// <summary>
    /// BillNumberVoucherCode of the PerformaInvoiceBillMaster
    /// BillNumberVoucherCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string BillNumberVoucherCode { get; private set; }

    /// <summary>
    /// AdditionalAmountType of the PerformaInvoiceBillMaster
    /// AdditionalAmountType الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? AdditionalAmountType { get; private set; }

    /// <summary>
    /// DiscAmtNotEffect of the PerformaInvoiceBillMaster
    /// DiscAmtNotEffect الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? DiscAmtNotEffect { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the PerformaInvoiceBillMaster
    /// AdditionalDiscountAmountMaster الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the PerformaInvoiceBillMaster
    /// AdditionalDiscountAmountDetail الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// ReceiveBillDate of the PerformaInvoiceBillMaster
    /// ReceiveBillDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? ReceiveBillDate { get; private set; }

    /// <summary>
    /// BillDateVoucherCode of the PerformaInvoiceBillMaster
    /// BillDateVoucherCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? BillDateVoucherCode { get; private set; }

    /// <summary>
    /// DocAmt of the PerformaInvoiceBillMaster
    /// DocAmt الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// DocBrnNo of the PerformaInvoiceBillMaster
    /// DocBrnNo الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// DocType of the PerformaInvoiceBillMaster
    /// DocType الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillNumberReference of the PerformaInvoiceBillMaster
    /// BillNumberReference الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillNumberReference { get; private set; }

    /// <summary>
    /// BillSerialReference of the PerformaInvoiceBillMaster
    /// BillSerialReference الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillSerialReference { get; private set; }

    /// <summary>
    /// ServiceBill of the PerformaInvoiceBillMaster
    /// ServiceBill الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? ServiceBill { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the PerformaInvoiceBillMaster
    /// ContractBatchNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// BillNumberConnection of the PerformaInvoiceBillMaster
    /// BillNumberConnection الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillNumberConnection { get; private set; }

    /// <summary>
    /// BillSerialConnection of the PerformaInvoiceBillMaster
    /// BillSerialConnection الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BillSerialConnection { get; private set; }

    /// <summary>
    /// VendorGcc of the PerformaInvoiceBillMaster
    /// VendorGcc الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? VendorGcc { get; private set; }

    /// <summary>
    /// VendorAddress of the PerformaInvoiceBillMaster
    /// VendorAddress الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string VendorAddress { get; private set; }

    /// <summary>
    /// VendorTaxCode of the PerformaInvoiceBillMaster
    /// VendorTaxCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string VendorTaxCode { get; private set; }

    /// <summary>
    /// CreditNumberShort of the PerformaInvoiceBillMaster
    /// CreditNumberShort الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string CreditNumberShort { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the PerformaInvoiceBillMaster
    /// OtherAmountDiscount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatAmountOther of the PerformaInvoiceBillMaster
    /// VatAmountOther الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// AuditReference of the PerformaInvoiceBillMaster
    /// AuditReference الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the PerformaInvoiceBillMaster
    /// AuditReferenceDescription الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the PerformaInvoiceBillMaster
    /// AuditReferenceUserId الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the PerformaInvoiceBillMaster
    /// AuditReferenceDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the PerformaInvoiceBillMaster
    /// PostUserId الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the PerformaInvoiceBillMaster
    /// PostDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the PerformaInvoiceBillMaster
    /// UnpostUserId الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the PerformaInvoiceBillMaster
    /// UnpostDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PerformaInvoiceBillMaster
    /// CompanyNumberShort الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PerformaInvoiceBillMaster
    /// BranchNumber الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PerformaInvoiceBillMaster
    /// BranchYear الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PerformaInvoiceBillMaster
    /// BranchUser الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the PerformaInvoiceBillMaster
    /// CalcTypeNumberTax الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// ArrivalDate of the PerformaInvoiceBillMaster
    /// ArrivalDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? ArrivalDate { get; private set; }

    /// <summary>
    /// FreightRegisterDate of the PerformaInvoiceBillMaster
    /// FreightRegisterDate الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public DateTime? FreightRegisterDate { get; private set; }

    /// <summary>
    /// PostTaxDueAccountCode of the PerformaInvoiceBillMaster
    /// PostTaxDueAccountCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? PostTaxDueAccountCode { get; private set; }

    /// <summary>
    /// UseTdsFlag of the PerformaInvoiceBillMaster
    /// UseTdsFlag الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? UseTdsFlag { get; private set; }

    /// <summary>
    /// AccountCode of the PerformaInvoiceBillMaster
    /// AccountCode الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountAmount of the PerformaInvoiceBillMaster
    /// AccountAmount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// PaymentAccount of the PerformaInvoiceBillMaster
    /// PaymentAccount الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// LevelNumberPrice of the PerformaInvoiceBillMaster
    /// LevelNumberPrice الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? LevelNumberPrice { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the PerformaInvoiceBillMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ PerformaInvoiceBillMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PurchaseManager PurchaseManager { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

