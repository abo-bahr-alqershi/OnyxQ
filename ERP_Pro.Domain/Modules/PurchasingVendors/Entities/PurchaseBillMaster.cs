using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseBillMaster Entity
/// </summary>
public class PurchaseBillMaster : AggregateRoot<PurchaseBillMasterId>
{

    private PurchaseBillMaster() { }

    public PurchaseBillMaster(PurchaseBillMasterId id, decimal? returnBillSerial)
    {
        Id = id;
        ReturnBillSerial = returnBillSerial;
    }

    /// <summary>
    /// The unique identifier for the PurchaseBillMaster
    /// المعرف الفريد لـ PurchaseBillMaster
    /// </summary>
    public PurchaseBillMasterId Id { get; private set; }

    /// <summary>
    /// ReturnBillDocumentType of the PurchaseBillMaster
    /// ReturnBillDocumentType الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ReturnBillDocumentType { get; private set; }

    /// <summary>
    /// ReturnBillNumberAlt of the PurchaseBillMaster
    /// ReturnBillNumberAlt الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ReturnBillNumberAlt { get; private set; }

    /// <summary>
    /// ReturnBillSerial of the PurchaseBillMaster
    /// ReturnBillSerial الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ReturnBillSerial { get; private set; }

    /// <summary>
    /// PYear of the PurchaseBillMaster
    /// PYear الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// ReturnBillDate of the PurchaseBillMaster
    /// ReturnBillDate الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? ReturnBillDate { get; private set; }

    /// <summary>
    /// ReturnBillRate of the PurchaseBillMaster
    /// ReturnBillRate الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ReturnBillRate { get; private set; }

    /// <summary>
    /// StockRateShort of the PurchaseBillMaster
    /// StockRateShort الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// VendorName of the PurchaseBillMaster
    /// VendorName الخاص بـ PurchaseBillMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PurchaseBillMaster
    /// AccountDetailCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PurchaseBillMaster
    /// AccountDetailType الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// ChequeNumber of the PurchaseBillMaster
    /// ChequeNumber الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the PurchaseBillMaster
    /// ChequeAmount الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the PurchaseBillMaster
    /// ChequeDueDate الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ReturnBillDueDate of the PurchaseBillMaster
    /// ReturnBillDueDate الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? ReturnBillDueDate { get; private set; }

    /// <summary>
    /// ReturnBillPostFlag of the PurchaseBillMaster
    /// ReturnBillPostFlag الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ReturnBillPostFlag { get; private set; }

    /// <summary>
    /// DiscAmtMst of the PurchaseBillMaster
    /// DiscAmtMst الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the PurchaseBillMaster
    /// DiscAmtDtl الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmt of the PurchaseBillMaster
    /// DiscAmt الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// BillAmount of the PurchaseBillMaster
    /// BillAmount الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// VatAmount of the PurchaseBillMaster
    /// VatAmount الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the PurchaseBillMaster
    /// OtherAmount الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// CashNumber of the PurchaseBillMaster
    /// CashNumber الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the PurchaseBillMaster
    /// CashNumberForeignCurrencyCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PurchaseBillMaster
    /// ReferenceNumber الخاص بـ PurchaseBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// PriceTypeAlt of the PurchaseBillMaster
    /// PriceTypeAlt الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? PriceTypeAlt { get; private set; }

    /// <summary>
    /// DiffAcCode of the PurchaseBillMaster
    /// DiffAcCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public string DiffAcCode { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the PurchaseBillMaster
    /// CashAccountForeignCurrencyCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// AccountDescription of the PurchaseBillMaster
    /// AccountDescription الخاص بـ PurchaseBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// PreviousYear of the PurchaseBillMaster
    /// PreviousYear الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? PreviousYear { get; private set; }

    /// <summary>
    /// ReturnReason of the PurchaseBillMaster
    /// ReturnReason الخاص بـ PurchaseBillMaster
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// DiscAmtNotEffect of the PurchaseBillMaster
    /// DiscAmtNotEffect الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? DiscAmtNotEffect { get; private set; }

    /// <summary>
    /// HungFlag of the PurchaseBillMaster
    /// HungFlag الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// BillNumberVoucherCode of the PurchaseBillMaster
    /// BillNumberVoucherCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public string BillNumberVoucherCode { get; private set; }

    /// <summary>
    /// BillDateVoucherCode of the PurchaseBillMaster
    /// BillDateVoucherCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? BillDateVoucherCode { get; private set; }

    /// <summary>
    /// DocBrnNo of the PurchaseBillMaster
    /// DocBrnNo الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// ServiceBill of the PurchaseBillMaster
    /// ServiceBill الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? ServiceBill { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the PurchaseBillMaster
    /// CalcVatPriceType الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// Field1 of the PurchaseBillMaster
    /// Field1 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the PurchaseBillMaster
    /// Field2 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the PurchaseBillMaster
    /// Field3 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the PurchaseBillMaster
    /// Field4 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the PurchaseBillMaster
    /// Field5 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the PurchaseBillMaster
    /// Field6 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the PurchaseBillMaster
    /// Field7 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the PurchaseBillMaster
    /// Field8 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the PurchaseBillMaster
    /// Field9 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the PurchaseBillMaster
    /// Field10 الخاص بـ PurchaseBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// TypeNumberShort of the PurchaseBillMaster
    /// TypeNumberShort الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// VendorGcc of the PurchaseBillMaster
    /// VendorGcc الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? VendorGcc { get; private set; }

    /// <summary>
    /// UseVat of the PurchaseBillMaster
    /// UseVat الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountMaster of the PurchaseBillMaster
    /// AdditionalDiscountAmountMaster الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountMaster { get; private set; }

    /// <summary>
    /// AdditionalDiscountAmountDetail of the PurchaseBillMaster
    /// AdditionalDiscountAmountDetail الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? AdditionalDiscountAmountDetail { get; private set; }

    /// <summary>
    /// OtherAmountDiscount of the PurchaseBillMaster
    /// OtherAmountDiscount الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? OtherAmountDiscount { get; private set; }

    /// <summary>
    /// VatAmountOther of the PurchaseBillMaster
    /// VatAmountOther الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// AuditReference of the PurchaseBillMaster
    /// AuditReference الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the PurchaseBillMaster
    /// AuditReferenceDescription الخاص بـ PurchaseBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the PurchaseBillMaster
    /// AuditReferenceUserId الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the PurchaseBillMaster
    /// AuditReferenceDate الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the PurchaseBillMaster
    /// PostUserId الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the PurchaseBillMaster
    /// PostDate الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the PurchaseBillMaster
    /// UnpostUserId الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the PurchaseBillMaster
    /// UnpostDate الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseBillMaster
    /// CompanyNumberShort الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseBillMaster
    /// BranchNumber الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseBillMaster
    /// BranchYear الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseBillMaster
    /// BranchUser الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the PurchaseBillMaster
    /// CalcTypeNumberTax الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// PostTaxDueAccountCode of the PurchaseBillMaster
    /// PostTaxDueAccountCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? PostTaxDueAccountCode { get; private set; }

    /// <summary>
    /// AccountCode of the PurchaseBillMaster
    /// AccountCode الخاص بـ PurchaseBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountAmount of the PurchaseBillMaster
    /// AccountAmount الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// PaymentAccount of the PurchaseBillMaster
    /// PaymentAccount الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the PurchaseBillMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// Deliverd of the PurchaseBillMaster
    /// Deliverd الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? Deliverd { get; private set; }

    /// <summary>
    /// DeliverdUId of the PurchaseBillMaster
    /// DeliverdUId الخاص بـ PurchaseBillMaster
    /// </summary>
    public decimal? DeliverdUId { get; private set; }

    /// <summary>
    /// DeliverdDate of the PurchaseBillMaster
    /// DeliverdDate الخاص بـ PurchaseBillMaster
    /// </summary>
    public DateTime? DeliverdDate { get; private set; }

    /// <summary>
    /// DeliverdRes of the PurchaseBillMaster
    /// DeliverdRes الخاص بـ PurchaseBillMaster
    /// </summary>
    public string DeliverdRes { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
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
    public Customer Customer { get; private set; }
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

