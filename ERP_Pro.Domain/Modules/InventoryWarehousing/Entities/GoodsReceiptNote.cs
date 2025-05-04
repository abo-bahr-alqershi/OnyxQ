using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GoodsReceiptNote Entity
/// </summary>
public class GoodsReceiptNote : Entity<GoodsReceiptNoteId>
{

    private GoodsReceiptNote() { }

    public GoodsReceiptNote(GoodsReceiptNoteId id, decimal? guarantorSerial)
    {
        Id = id;
        GuarantorSerial = guarantorSerial;
    }

    /// <summary>
    /// The unique identifier for the GoodsReceiptNote
    /// المعرف الفريد لـ GoodsReceiptNote
    /// </summary>
    public GoodsReceiptNoteId Id { get; private set; }

    /// <summary>
    /// PurchaseInvoiceType of the GoodsReceiptNote
    /// PurchaseInvoiceType الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? PurchaseInvoiceType { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GoodsReceiptNote
    /// GroupNumberFull الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// GuarantorSerial of the GoodsReceiptNote
    /// GuarantorSerial الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? GuarantorSerial { get; private set; }

    /// <summary>
    /// IncomeType of the GoodsReceiptNote
    /// IncomeType الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? IncomeType { get; private set; }

    /// <summary>
    /// GroupDate of the GoodsReceiptNote
    /// GroupDate الخاص بـ GoodsReceiptNote
    /// </summary>
    public DateTime? GroupDate { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GoodsReceiptNote
    /// AccountDetailCode الخاص بـ GoodsReceiptNote
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GoodsReceiptNote
    /// AccountDetailType الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountRate of the GoodsReceiptNote
    /// AccountRate الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRate of the GoodsReceiptNote
    /// StockRate الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// GroupAmount of the GoodsReceiptNote
    /// GroupAmount الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? GroupAmount { get; private set; }

    /// <summary>
    /// PurchaseInvoiceNumber of the GoodsReceiptNote
    /// PurchaseInvoiceNumber الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the GoodsReceiptNote
    /// LetterCreditNumber الخاص بـ GoodsReceiptNote
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// CFlag of the GoodsReceiptNote
    /// CFlag الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? CFlag { get; private set; }

    /// <summary>
    /// CashBankNumber of the GoodsReceiptNote
    /// CashBankNumber الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// GroupPostFlag of the GoodsReceiptNote
    /// GroupPostFlag الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? GroupPostFlag { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GoodsReceiptNote
    /// ReferenceNumber الخاص بـ GoodsReceiptNote
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the GoodsReceiptNote
    /// AccountDescription الخاص بـ GoodsReceiptNote
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AttachmentCount of the GoodsReceiptNote
    /// AttachmentCount الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// PendingFlag of the GoodsReceiptNote
    /// PendingFlag الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? PendingFlag { get; private set; }

    /// <summary>
    /// PurchaseType of the GoodsReceiptNote
    /// PurchaseType الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// DriverName of the GoodsReceiptNote
    /// DriverName الخاص بـ GoodsReceiptNote
    /// </summary>
    public string DriverName { get; private set; }

    /// <summary>
    /// CarNumber of the GoodsReceiptNote
    /// CarNumber الخاص بـ GoodsReceiptNote
    /// </summary>
    public string CarNumber { get; private set; }

    /// <summary>
    /// WorkShop of the GoodsReceiptNote
    /// WorkShop الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? WorkShop { get; private set; }

    /// <summary>
    /// DocSer of the GoodsReceiptNote
    /// DocSer الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocNo of the GoodsReceiptNote
    /// DocNo الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ReturnOutFlag of the GoodsReceiptNote
    /// ReturnOutFlag الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? ReturnOutFlag { get; private set; }

    /// <summary>
    /// OutgoingDifferenceAmount of the GoodsReceiptNote
    /// OutgoingDifferenceAmount الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? OutgoingDifferenceAmount { get; private set; }

    /// <summary>
    /// BillOfExchangeNumber of the GoodsReceiptNote
    /// BillOfExchangeNumber الخاص بـ GoodsReceiptNote
    /// </summary>
    public string BillOfExchangeNumber { get; private set; }

    /// <summary>
    /// UseVat of the GoodsReceiptNote
    /// UseVat الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// VatAmount of the GoodsReceiptNote
    /// VatAmount الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// PurchaseInvoiceDocumentType of the GoodsReceiptNote
    /// PurchaseInvoiceDocumentType الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? PurchaseInvoiceDocumentType { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GoodsReceiptNote
    /// ExternalPostFlag الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// HungFlag of the GoodsReceiptNote
    /// HungFlag الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// MrpMtSequence of the GoodsReceiptNote
    /// MrpMtSequence الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? MrpMtSequence { get; private set; }

    /// <summary>
    /// MrpMtOrder of the GoodsReceiptNote
    /// MrpMtOrder الخاص بـ GoodsReceiptNote
    /// </summary>
    public string MrpMtOrder { get; private set; }

    /// <summary>
    /// MrpMtType of the GoodsReceiptNote
    /// MrpMtType الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? MrpMtType { get; private set; }

    /// <summary>
    /// UnderSellingFlag of the GoodsReceiptNote
    /// UnderSellingFlag الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? UnderSellingFlag { get; private set; }

    /// <summary>
    /// DocBrnNo of the GoodsReceiptNote
    /// DocBrnNo الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// DocDueDate of the GoodsReceiptNote
    /// DocDueDate الخاص بـ GoodsReceiptNote
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// VatAmountOther of the GoodsReceiptNote
    /// VatAmountOther الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the GoodsReceiptNote
    /// CalcTypeNumberTax الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// ConnectionWithPurchaseInvoice of the GoodsReceiptNote
    /// ConnectionWithPurchaseInvoice الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? ConnectionWithPurchaseInvoice { get; private set; }

    /// <summary>
    /// Field1 of the GoodsReceiptNote
    /// Field1 الخاص بـ GoodsReceiptNote
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GoodsReceiptNote
    /// Field2 الخاص بـ GoodsReceiptNote
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GoodsReceiptNote
    /// Field3 الخاص بـ GoodsReceiptNote
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// AuditReference of the GoodsReceiptNote
    /// AuditReference الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the GoodsReceiptNote
    /// AuditReferenceDescription الخاص بـ GoodsReceiptNote
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the GoodsReceiptNote
    /// AuditReferenceUserId الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the GoodsReceiptNote
    /// AuditReferenceDate الخاص بـ GoodsReceiptNote
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the GoodsReceiptNote
    /// PostUserId الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the GoodsReceiptNote
    /// PostDate الخاص بـ GoodsReceiptNote
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the GoodsReceiptNote
    /// UnpostUserId الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the GoodsReceiptNote
    /// UnpostDate الخاص بـ GoodsReceiptNote
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GoodsReceiptNote
    /// CompanyNumberShort الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GoodsReceiptNote
    /// BranchNumber الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GoodsReceiptNote
    /// BranchYear الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GoodsReceiptNote
    /// BranchUser الخاص بـ GoodsReceiptNote
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PurchaseInvoiceDate of the GoodsReceiptNote
    /// PurchaseInvoiceDate الخاص بـ GoodsReceiptNote
    /// </summary>
    public DateTime? PurchaseInvoiceDate { get; private set; }

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
    public AccountCurrency AccountCurrencyOutDiffACode { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
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
