using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseRequestBillMaster Entity
/// </summary>
public class PurchaseRequestBillMaster : Entity<PurchaseRequestBillMasterId>
{
    private PurchaseRequestBillMaster() { }

    /// <summary>
    /// The unique identifier for the PurchaseRequestBillMaster
    /// المعرف الفريد لـ PurchaseRequestBillMaster
    /// </summary>
    public PurchaseRequestBillMasterId Id { get; private set; }

    /// <summary>
    /// ReturnRequestDocumentType of the PurchaseRequestBillMaster
    /// ReturnRequestDocumentType الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ReturnRequestDocumentType { get; private set; }

    /// <summary>
    /// ReturnRequestNumber of the PurchaseRequestBillMaster
    /// ReturnRequestNumber الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ReturnRequestNumber { get; private set; }

    /// <summary>
    /// ReturnRequestSerial of the PurchaseRequestBillMaster
    /// ReturnRequestSerial الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ReturnRequestSerial { get; private set; }

    /// <summary>
    /// PYear of the PurchaseRequestBillMaster
    /// PYear الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// ReturnRequestDate of the PurchaseRequestBillMaster
    /// ReturnRequestDate الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public DateTime? ReturnRequestDate { get; private set; }

    /// <summary>
    /// ReturnRequestCurrency of the PurchaseRequestBillMaster
    /// ReturnRequestCurrency الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string ReturnRequestCurrency { get; private set; }

    /// <summary>
    /// ReturnRequestRate of the PurchaseRequestBillMaster
    /// ReturnRequestRate الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ReturnRequestRate { get; private set; }

    /// <summary>
    /// StockRateShort of the PurchaseRequestBillMaster
    /// StockRateShort الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// CCode of the PurchaseRequestBillMaster
    /// CCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the PurchaseRequestBillMaster
    /// VendorCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the PurchaseRequestBillMaster
    /// VendorName الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// AccountCode of the PurchaseRequestBillMaster
    /// AccountCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// ChequeNumber of the PurchaseRequestBillMaster
    /// ChequeNumber الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeAmount of the PurchaseRequestBillMaster
    /// ChequeAmount الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ChequeAmount { get; private set; }

    /// <summary>
    /// ChequeDueDate of the PurchaseRequestBillMaster
    /// ChequeDueDate الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ReturnBillDueDate of the PurchaseRequestBillMaster
    /// ReturnBillDueDate الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public DateTime? ReturnBillDueDate { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the PurchaseRequestBillMaster
    /// ProcessedFlagFull الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// DiscAmtMst of the PurchaseRequestBillMaster
    /// DiscAmtMst الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the PurchaseRequestBillMaster
    /// DiscAmtDtl الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmt of the PurchaseRequestBillMaster
    /// DiscAmt الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// RequestAmount of the PurchaseRequestBillMaster
    /// RequestAmount الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? RequestAmount { get; private set; }

    /// <summary>
    /// VatAmount of the PurchaseRequestBillMaster
    /// VatAmount الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the PurchaseRequestBillMaster
    /// WarehouseCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CashNumber of the PurchaseRequestBillMaster
    /// CashNumber الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CashNumberForeignCurrencyCode of the PurchaseRequestBillMaster
    /// CashNumberForeignCurrencyCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? CashNumberForeignCurrencyCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PurchaseRequestBillMaster
    /// ReferenceNumber الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchaseRequestBillMaster
    /// CostCenterCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchaseRequestBillMaster
    /// ProjectNumber الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchaseRequestBillMaster
    /// ActivityNumber الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// PriceTypeAlt of the PurchaseRequestBillMaster
    /// PriceTypeAlt الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? PriceTypeAlt { get; private set; }

    /// <summary>
    /// CashAccountForeignCurrencyCode of the PurchaseRequestBillMaster
    /// CashAccountForeignCurrencyCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string CashAccountForeignCurrencyCode { get; private set; }

    /// <summary>
    /// AccountDescription of the PurchaseRequestBillMaster
    /// AccountDescription الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// PreviousYear of the PurchaseRequestBillMaster
    /// PreviousYear الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? PreviousYear { get; private set; }

    /// <summary>
    /// DiscAmtNotEffect of the PurchaseRequestBillMaster
    /// DiscAmtNotEffect الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? DiscAmtNotEffect { get; private set; }

    /// <summary>
    /// PersonManagerCode of the PurchaseRequestBillMaster
    /// PersonManagerCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string PersonManagerCode { get; private set; }

    /// <summary>
    /// UseVat of the PurchaseRequestBillMaster
    /// UseVat الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the PurchaseRequestBillMaster
    /// CalcVatPriceType الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// Field1 of the PurchaseRequestBillMaster
    /// Field1 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the PurchaseRequestBillMaster
    /// Field2 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the PurchaseRequestBillMaster
    /// Field3 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the PurchaseRequestBillMaster
    /// Field4 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the PurchaseRequestBillMaster
    /// Field5 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the PurchaseRequestBillMaster
    /// Field6 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the PurchaseRequestBillMaster
    /// Field7 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the PurchaseRequestBillMaster
    /// Field8 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the PurchaseRequestBillMaster
    /// Field9 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the PurchaseRequestBillMaster
    /// Field10 الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ApprovedFlag of the PurchaseRequestBillMaster
    /// ApprovedFlag الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the PurchaseRequestBillMaster
    /// ApprovalUserId الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the PurchaseRequestBillMaster
    /// ApprovalDate الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the PurchaseRequestBillMaster
    /// ApprovalDescription الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the PurchaseRequestBillMaster
    /// InactiveFlag الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the PurchaseRequestBillMaster
    /// InactivatedByUserId الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the PurchaseRequestBillMaster
    /// InactiveDate الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the PurchaseRequestBillMaster
    /// InactiveReason الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// TypeNumberShort of the PurchaseRequestBillMaster
    /// TypeNumberShort الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseRequestBillMaster
    /// CompanyNumberShort الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseRequestBillMaster
    /// BranchNumber الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseRequestBillMaster
    /// BranchYear الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseRequestBillMaster
    /// BranchUser الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PurchaseRequestBillMaster
    /// AccountDetailCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PurchaseRequestBillMaster
    /// AccountDetailType الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// ServiceBill of the PurchaseRequestBillMaster
    /// ServiceBill الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ServiceBill { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the PurchaseRequestBillMaster
    /// CalcTypeNumberTax الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// ReserveSerial of the PurchaseRequestBillMaster
    /// ReserveSerial الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ReserveSerial { get; private set; }

    /// <summary>
    /// ReserveNumberShort of the PurchaseRequestBillMaster
    /// ReserveNumberShort الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? ReserveNumberShort { get; private set; }

    /// <summary>
    /// AccountCode of the PurchaseRequestBillMaster
    /// AccountCode الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountAmount of the PurchaseRequestBillMaster
    /// AccountAmount الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// PaymentAccount of the PurchaseRequestBillMaster
    /// PaymentAccount الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? PaymentAccount { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the PurchaseRequestBillMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ PurchaseRequestBillMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: PurchaseRequestBillMaster to PurchaseRequestBillDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseRequestBillDetail> PurchaseRequestBillDetails { get; private set; }
    #endregion
}
}
