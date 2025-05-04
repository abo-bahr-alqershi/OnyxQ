using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BranchGoodsReceiptNote Entity
/// </summary>
public class BranchGoodsReceiptNote : Entity<BranchGoodsReceiptNoteId>
{

    private BranchGoodsReceiptNote() { }

    public BranchGoodsReceiptNote(BranchGoodsReceiptNoteId id, decimal? guarantorSerial)
    {
        Id = id;
        GuarantorSerial = guarantorSerial;
    }

    /// <summary>
    /// The unique identifier for the BranchGoodsReceiptNote
    /// المعرف الفريد لـ BranchGoodsReceiptNote
    /// </summary>
    public BranchGoodsReceiptNoteId Id { get; private set; }

    /// <summary>
    /// PurchaseInvoiceType of the BranchGoodsReceiptNote
    /// PurchaseInvoiceType الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? PurchaseInvoiceType { get; private set; }

    /// <summary>
    /// GroupNumberFull of the BranchGoodsReceiptNote
    /// GroupNumberFull الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the BranchGoodsReceiptNote
    /// GuarantorSerial الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// IncomeType of the BranchGoodsReceiptNote
    /// IncomeType الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? IncomeType { get; private set; }

    /// <summary>
    /// GroupDate of the BranchGoodsReceiptNote
    /// GroupDate الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public DateTime? GroupDate { get; private set; }

    /// <summary>
    /// AccountCode of the BranchGoodsReceiptNote
    /// AccountCode الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BranchGoodsReceiptNote
    /// AccountDetailCode الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BranchGoodsReceiptNote
    /// AccountDetailType الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchGoodsReceiptNote
    /// AccountCurrency الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchGoodsReceiptNote
    /// AccountRate الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRate of the BranchGoodsReceiptNote
    /// StockRate الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// GroupAmount of the BranchGoodsReceiptNote
    /// GroupAmount الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? GroupAmount { get; private set; }

    /// <summary>
    /// PurchaseInvoiceNumber of the BranchGoodsReceiptNote
    /// PurchaseInvoiceNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// VendorCode of the BranchGoodsReceiptNote
    /// VendorCode الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CCode of the BranchGoodsReceiptNote
    /// CCode الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the BranchGoodsReceiptNote
    /// LetterCreditNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// CFlag of the BranchGoodsReceiptNote
    /// CFlag الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? CFlag { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchGoodsReceiptNote
    /// WarehouseCode الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CashBankNumber of the BranchGoodsReceiptNote
    /// CashBankNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// GroupPostFlag of the BranchGoodsReceiptNote
    /// GroupPostFlag الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? GroupPostFlag { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchGoodsReceiptNote
    /// ReferenceNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchGoodsReceiptNote
    /// AccountDescription الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchGoodsReceiptNote
    /// CostCenterCode الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchGoodsReceiptNote
    /// ProjectNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// AttachmentCount of the BranchGoodsReceiptNote
    /// AttachmentCount الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// PendingFlag of the BranchGoodsReceiptNote
    /// PendingFlag الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? PendingFlag { get; private set; }

    /// <summary>
    /// PurchaseType of the BranchGoodsReceiptNote
    /// PurchaseType الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// DriverName of the BranchGoodsReceiptNote
    /// DriverName الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string DriverName { get; private set; }

    /// <summary>
    /// CarNumber of the BranchGoodsReceiptNote
    /// CarNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string CarNumber { get; private set; }

    /// <summary>
    /// WorkShop of the BranchGoodsReceiptNote
    /// WorkShop الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? WorkShop { get; private set; }

    /// <summary>
    /// DocSer of the BranchGoodsReceiptNote
    /// DocSer الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocNo of the BranchGoodsReceiptNote
    /// DocNo الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ReturnOutFlag of the BranchGoodsReceiptNote
    /// ReturnOutFlag الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? ReturnOutFlag { get; private set; }

    /// <summary>
    /// OutgoingDifferenceAccountCode of the BranchGoodsReceiptNote
    /// OutgoingDifferenceAccountCode الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string OutgoingDifferenceAccountCode { get; private set; }

    /// <summary>
    /// OutgoingDifferenceAccountCurrency of the BranchGoodsReceiptNote
    /// OutgoingDifferenceAccountCurrency الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string OutgoingDifferenceAccountCurrency { get; private set; }

    /// <summary>
    /// OutgoingDifferenceAmount of the BranchGoodsReceiptNote
    /// OutgoingDifferenceAmount الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? OutgoingDifferenceAmount { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the BranchGoodsReceiptNote
    /// BillOfExchangeNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// UseVat of the BranchGoodsReceiptNote
    /// UseVat الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// VatAmount of the BranchGoodsReceiptNote
    /// VatAmount الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// PurchaseInvoiceDocumentType of the BranchGoodsReceiptNote
    /// PurchaseInvoiceDocumentType الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? PurchaseInvoiceDocumentType { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchGoodsReceiptNote
    /// ExternalPostFlag الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// HungFlag of the BranchGoodsReceiptNote
    /// HungFlag الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// MrpMtSequence of the BranchGoodsReceiptNote
    /// MrpMtSequence الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? MrpMtSequence { get; private set; }

    /// <summary>
    /// MrpMtOrder of the BranchGoodsReceiptNote
    /// MrpMtOrder الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string MrpMtOrder { get; private set; }

    /// <summary>
    /// MrpMtType of the BranchGoodsReceiptNote
    /// MrpMtType الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? MrpMtType { get; private set; }

    /// <summary>
    /// UnderSellingFlag of the BranchGoodsReceiptNote
    /// UnderSellingFlag الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? UnderSellingFlag { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchGoodsReceiptNote
    /// DocBrnNo الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// DocDueDate of the BranchGoodsReceiptNote
    /// DocDueDate الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// Field1 of the BranchGoodsReceiptNote
    /// Field1 الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchGoodsReceiptNote
    /// Field2 الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchGoodsReceiptNote
    /// Field3 الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// AuditReference of the BranchGoodsReceiptNote
    /// AuditReference الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchGoodsReceiptNote
    /// AuditReferenceDescription الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchGoodsReceiptNote
    /// AuditReferenceUserId الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchGoodsReceiptNote
    /// AuditReferenceDate الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BranchGoodsReceiptNote
    /// CalcTypeNumberTax الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// OnWithPurchaseInvoice of the BranchGoodsReceiptNote
    /// OnWithPurchaseInvoice الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? OnWithPurchaseInvoice { get; private set; }

    /// <summary>
    /// VatAmountOther of the BranchGoodsReceiptNote
    /// VatAmountOther الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// PostUserId of the BranchGoodsReceiptNote
    /// PostUserId الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchGoodsReceiptNote
    /// PostDate الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchGoodsReceiptNote
    /// UnpostUserId الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchGoodsReceiptNote
    /// UnpostDate الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchGoodsReceiptNote
    /// CompanyNumberShort الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchGoodsReceiptNote
    /// BranchNumber الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchGoodsReceiptNote
    /// BranchYear الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchGoodsReceiptNote
    /// BranchUser الخاص بـ BranchGoodsReceiptNote
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
