using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// OutgoingMaster Entity
/// </summary>
public class OutgoingMaster : Entity<OutgoingMasterId>
{

    private OutgoingMaster() { }

    public OutgoingMaster(OutgoingMasterId id, decimal? outgoingSerialShort)
    {
        Id = id;
        OutgoingSerialShort = outgoingSerialShort;
    }

    /// <summary>
    /// The unique identifier for the OutgoingMaster
    /// المعرف الفريد لـ OutgoingMaster
    /// </summary>
    public OutgoingMasterId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the OutgoingMaster
    /// OutgoingNumber الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingSerialShort of the OutgoingMaster
    /// OutgoingSerialShort الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? OutgoingSerialShort { get; private set; }

    /// <summary>
    /// OutgoingDate of the OutgoingMaster
    /// OutgoingDate الخاص بـ OutgoingMaster
    /// </summary>
    public DateTime? OutgoingDate { get; private set; }

    /// <summary>
    /// AccountRate of the OutgoingMaster
    /// AccountRate الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRateShort of the OutgoingMaster
    /// StockRateShort الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// AccountDetailCode of the OutgoingMaster
    /// AccountDetailCode الخاص بـ OutgoingMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the OutgoingMaster
    /// AccountDetailType الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CCode of the OutgoingMaster
    /// CCode الخاص بـ OutgoingMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the OutgoingMaster
    /// VendorCode الخاص بـ OutgoingMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// OutgoingDueDate of the OutgoingMaster
    /// OutgoingDueDate الخاص بـ OutgoingMaster
    /// </summary>
    public DateTime? OutgoingDueDate { get; private set; }

    /// <summary>
    /// OutgoingPostFlag of the OutgoingMaster
    /// OutgoingPostFlag الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? OutgoingPostFlag { get; private set; }

    /// <summary>
    /// OutgoingAmount of the OutgoingMaster
    /// OutgoingAmount الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? OutgoingAmount { get; private set; }

    /// <summary>
    /// ReferenceNumber of the OutgoingMaster
    /// ReferenceNumber الخاص بـ OutgoingMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashBankNumber of the OutgoingMaster
    /// CashBankNumber الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the OutgoingMaster
    /// LetterCreditNumber الخاص بـ OutgoingMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the OutgoingMaster
    /// AccountDescription الخاص بـ OutgoingMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AttachmentCount of the OutgoingMaster
    /// AttachmentCount الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// BeneficiaryName of the OutgoingMaster
    /// BeneficiaryName الخاص بـ OutgoingMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ExpenseAmount of the OutgoingMaster
    /// ExpenseAmount الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// ExpenseRate of the OutgoingMaster
    /// ExpenseRate الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? ExpenseRate { get; private set; }

    /// <summary>
    /// PurchaseType of the OutgoingMaster
    /// PurchaseType الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// OrderHotelNumber of the OutgoingMaster
    /// OrderHotelNumber الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? OrderHotelNumber { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the OutgoingMaster
    /// CalcTypeNumberTax الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OutgoingMaster
    /// ExternalPostFlag الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// HungFlag of the OutgoingMaster
    /// HungFlag الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// AuditReference of the OutgoingMaster
    /// AuditReference الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the OutgoingMaster
    /// AuditReferenceDescription الخاص بـ OutgoingMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the OutgoingMaster
    /// AuditReferenceUserId الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the OutgoingMaster
    /// AuditReferenceDate الخاص بـ OutgoingMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ConnectionWithSalesInvoice of the OutgoingMaster
    /// ConnectionWithSalesInvoice الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? ConnectionWithSalesInvoice { get; private set; }

    /// <summary>
    /// UseVat of the OutgoingMaster
    /// UseVat الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// VatPercent of the OutgoingMaster
    /// VatPercent الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the OutgoingMaster
    /// VatAmount الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ProceededSalesInvoice of the OutgoingMaster
    /// ProceededSalesInvoice الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? ProceededSalesInvoice { get; private set; }

    /// <summary>
    /// ProcessedFlag of the OutgoingMaster
    /// ProcessedFlag الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// PostUserId of the OutgoingMaster
    /// PostUserId الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the OutgoingMaster
    /// PostDate الخاص بـ OutgoingMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the OutgoingMaster
    /// UnpostUserId الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the OutgoingMaster
    /// UnpostDate الخاص بـ OutgoingMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// MrpMrOrder of the OutgoingMaster
    /// MrpMrOrder الخاص بـ OutgoingMaster
    /// </summary>
    public string MrpMrOrder { get; private set; }

    /// <summary>
    /// MrpMrSequence of the OutgoingMaster
    /// MrpMrSequence الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? MrpMrSequence { get; private set; }

    /// <summary>
    /// MrpStatus of the OutgoingMaster
    /// MrpStatus الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? MrpStatus { get; private set; }

    /// <summary>
    /// DocBrnNo of the OutgoingMaster
    /// DocBrnNo الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// Field1 of the OutgoingMaster
    /// Field1 الخاص بـ OutgoingMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the OutgoingMaster
    /// Field2 الخاص بـ OutgoingMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the OutgoingMaster
    /// Field3 الخاص بـ OutgoingMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutgoingMaster
    /// CompanyNumberShort الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OutgoingMaster
    /// BranchNumber الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutgoingMaster
    /// BranchYear الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OutgoingMaster
    /// BranchUser الخاص بـ OutgoingMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// RepCode of the OutgoingMaster
    /// RepCode الخاص بـ OutgoingMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// PromoterCode of the OutgoingMaster
    /// PromoterCode الخاص بـ OutgoingMaster
    /// </summary>
    public string PromoterCode { get; private set; }

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
    public AccountCurrency AccountCurrencyExpACode { get; private set; }
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
    public Warehouse Warehouse { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public OutgoingType OutgoingType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
