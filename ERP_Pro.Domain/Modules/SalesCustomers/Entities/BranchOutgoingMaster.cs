using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// BranchOutgoingMaster Entity
/// </summary>
public class BranchOutgoingMaster : Entity<BranchOutgoingMasterId>
{

    private BranchOutgoingMaster() { }

    public BranchOutgoingMaster(BranchOutgoingMasterId id, decimal? outgoingSerialShort)
    {
        Id = id;
        OutgoingSerialShort = outgoingSerialShort;
    }

    /// <summary>
    /// The unique identifier for the BranchOutgoingMaster
    /// المعرف الفريد لـ BranchOutgoingMaster
    /// </summary>
    public BranchOutgoingMasterId Id { get; private set; }

    /// <summary>
    /// OutgoingNumber of the BranchOutgoingMaster
    /// OutgoingNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? OutgoingNumber { get; private set; }

    /// <summary>
    /// OutgoingSerialShort of the BranchOutgoingMaster
    /// OutgoingSerialShort الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? OutgoingSerialShort { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the BranchOutgoingMaster
    /// OutgoingTypeFull الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// OutgoingDate of the BranchOutgoingMaster
    /// OutgoingDate الخاص بـ BranchOutgoingMaster
    /// </summary>
    public DateTime? OutgoingDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchOutgoingMaster
    /// AccountCurrency الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchOutgoingMaster
    /// AccountRate الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRateShort of the BranchOutgoingMaster
    /// StockRateShort الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// AccountCode of the BranchOutgoingMaster
    /// AccountCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BranchOutgoingMaster
    /// AccountDetailCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BranchOutgoingMaster
    /// AccountDetailType الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CCode of the BranchOutgoingMaster
    /// CCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the BranchOutgoingMaster
    /// VendorCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// OutgoingDueDate of the BranchOutgoingMaster
    /// OutgoingDueDate الخاص بـ BranchOutgoingMaster
    /// </summary>
    public DateTime? OutgoingDueDate { get; private set; }

    /// <summary>
    /// OutgoingPostFlag of the BranchOutgoingMaster
    /// OutgoingPostFlag الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? OutgoingPostFlag { get; private set; }

    /// <summary>
    /// OutgoingAmount of the BranchOutgoingMaster
    /// OutgoingAmount الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? OutgoingAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchOutgoingMaster
    /// WarehouseCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchOutgoingMaster
    /// ReferenceNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchOutgoingMaster
    /// CostCenterCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchOutgoingMaster
    /// ProjectNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchOutgoingMaster
    /// ActivityNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CashBankNumber of the BranchOutgoingMaster
    /// CashBankNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the BranchOutgoingMaster
    /// LetterCreditNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// RepCode of the BranchOutgoingMaster
    /// RepCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// PromoterCode of the BranchOutgoingMaster
    /// PromoterCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchOutgoingMaster
    /// AccountDescription الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// AttachmentCount of the BranchOutgoingMaster
    /// AttachmentCount الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? AttachmentCount { get; private set; }

    /// <summary>
    /// BeneficiaryName of the BranchOutgoingMaster
    /// BeneficiaryName الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ExpenseAccountCode of the BranchOutgoingMaster
    /// ExpenseAccountCode الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string ExpenseAccountCode { get; private set; }

    /// <summary>
    /// ExpenseAccountCurrency of the BranchOutgoingMaster
    /// ExpenseAccountCurrency الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string ExpenseAccountCurrency { get; private set; }

    /// <summary>
    /// ExpenseAmount of the BranchOutgoingMaster
    /// ExpenseAmount الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// ExpenseRate of the BranchOutgoingMaster
    /// ExpenseRate الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? ExpenseRate { get; private set; }

    /// <summary>
    /// PurchaseType of the BranchOutgoingMaster
    /// PurchaseType الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// OrderHotelNumber of the BranchOutgoingMaster
    /// OrderHotelNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? OrderHotelNumber { get; private set; }

    /// <summary>
    /// ConnectionWithSalesInvoice of the BranchOutgoingMaster
    /// ConnectionWithSalesInvoice الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? ConnectionWithSalesInvoice { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchOutgoingMaster
    /// ExternalPostFlag الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ProcessedFlag of the BranchOutgoingMaster
    /// ProcessedFlag الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ProceededSalesInvoice of the BranchOutgoingMaster
    /// ProceededSalesInvoice الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? ProceededSalesInvoice { get; private set; }

    /// <summary>
    /// VatAmount of the BranchOutgoingMaster
    /// VatAmount الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the BranchOutgoingMaster
    /// VatPercent الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// UseVat of the BranchOutgoingMaster
    /// UseVat الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// HungFlag of the BranchOutgoingMaster
    /// HungFlag الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? HungFlag { get; private set; }

    /// <summary>
    /// AuditReference of the BranchOutgoingMaster
    /// AuditReference الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchOutgoingMaster
    /// AuditReferenceDescription الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchOutgoingMaster
    /// AuditReferenceUserId الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchOutgoingMaster
    /// AuditReferenceDate الخاص بـ BranchOutgoingMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// PostUserId of the BranchOutgoingMaster
    /// PostUserId الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchOutgoingMaster
    /// PostDate الخاص بـ BranchOutgoingMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchOutgoingMaster
    /// UnpostUserId الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchOutgoingMaster
    /// UnpostDate الخاص بـ BranchOutgoingMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// MrpMrOrder of the BranchOutgoingMaster
    /// MrpMrOrder الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string MrpMrOrder { get; private set; }

    /// <summary>
    /// MrpMrSequence of the BranchOutgoingMaster
    /// MrpMrSequence الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? MrpMrSequence { get; private set; }

    /// <summary>
    /// MrpStatus of the BranchOutgoingMaster
    /// MrpStatus الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? MrpStatus { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchOutgoingMaster
    /// DocBrnNo الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the BranchOutgoingMaster
    /// CalcTypeNumberTax الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// Field1 of the BranchOutgoingMaster
    /// Field1 الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchOutgoingMaster
    /// Field2 الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchOutgoingMaster
    /// Field3 الخاص بـ BranchOutgoingMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchOutgoingMaster
    /// CompanyNumberShort الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchOutgoingMaster
    /// BranchNumber الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchOutgoingMaster
    /// BranchYear الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchOutgoingMaster
    /// BranchUser الخاص بـ BranchOutgoingMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
