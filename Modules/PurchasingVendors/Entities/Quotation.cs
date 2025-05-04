using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// Quotation Entity
/// </summary>
public class Quotation : Entity<QuotationId>
{
    private Quotation() { }

    /// <summary>
    /// The unique identifier for the Quotation
    /// المعرف الفريد لـ Quotation
    /// </summary>
    public QuotationId Id { get; private set; }

    /// <summary>
    /// QuotationType of the Quotation
    /// QuotationType الخاص بـ Quotation
    /// </summary>
    public decimal? QuotationType { get; private set; }

    /// <summary>
    /// QuotationNumberFull of the Quotation
    /// QuotationNumberFull الخاص بـ Quotation
    /// </summary>
    public decimal? QuotationNumberFull { get; private set; }

    /// <summary>
    /// QuotationSerialFull of the Quotation
    /// QuotationSerialFull الخاص بـ Quotation
    /// </summary>
    public decimal? QuotationSerialFull { get; private set; }

    /// <summary>
    /// QuotationDateFull of the Quotation
    /// QuotationDateFull الخاص بـ Quotation
    /// </summary>
    public DateTime? QuotationDateFull { get; private set; }

    /// <summary>
    /// QuotationCurrency of the Quotation
    /// QuotationCurrency الخاص بـ Quotation
    /// </summary>
    public string QuotationCurrency { get; private set; }

    /// <summary>
    /// CCode of the Quotation
    /// CCode الخاص بـ Quotation
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the Quotation
    /// CName الخاص بـ Quotation
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// CostCenterCode of the Quotation
    /// CostCenterCode الخاص بـ Quotation
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the Quotation
    /// WarehouseCode الخاص بـ Quotation
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the Quotation
    /// ProjectNumber الخاص بـ Quotation
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the Quotation
    /// ActivityNumber الخاص بـ Quotation
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the Quotation
    /// AccountDescription الخاص بـ Quotation
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// QuotationTender of the Quotation
    /// QuotationTender الخاص بـ Quotation
    /// </summary>
    public string QuotationTender { get; private set; }

    /// <summary>
    /// QuotationTenderDate of the Quotation
    /// QuotationTenderDate الخاص بـ Quotation
    /// </summary>
    public DateTime? QuotationTenderDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the Quotation
    /// ReferenceNumber الخاص بـ Quotation
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReferenceDate of the Quotation
    /// ReferenceDate الخاص بـ Quotation
    /// </summary>
    public DateTime? ReferenceDate { get; private set; }

    /// <summary>
    /// PortOfDeparture of the Quotation
    /// PortOfDeparture الخاص بـ Quotation
    /// </summary>
    public string PortOfDeparture { get; private set; }

    /// <summary>
    /// RequestDays of the Quotation
    /// RequestDays الخاص بـ Quotation
    /// </summary>
    public decimal? RequestDays { get; private set; }

    /// <summary>
    /// PaymentTerms of the Quotation
    /// PaymentTerms الخاص بـ Quotation
    /// </summary>
    public string PaymentTerms { get; private set; }

    /// <summary>
    /// DiscAmt of the Quotation
    /// DiscAmt الخاص بـ Quotation
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the Quotation
    /// ProcessedFlagFull الخاص بـ Quotation
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag of the Quotation
    /// ApprovedFlag الخاص بـ Quotation
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the Quotation
    /// ApprovalDate الخاص بـ Quotation
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the Quotation
    /// ApprovalDescription الخاص بـ Quotation
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ApprovalUserId of the Quotation
    /// ApprovalUserId الخاص بـ Quotation
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// OtherAmount of the Quotation
    /// OtherAmount الخاص بـ Quotation
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the Quotation
    /// SalesInvoiceType الخاص بـ Quotation
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// QuotationAmount of the Quotation
    /// QuotationAmount الخاص بـ Quotation
    /// </summary>
    public decimal? QuotationAmount { get; private set; }

    /// <summary>
    /// InactiveFlag of the Quotation
    /// InactiveFlag الخاص بـ Quotation
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the Quotation
    /// InactiveReason الخاص بـ Quotation
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the Quotation
    /// InactiveDate الخاص بـ Quotation
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Quotation
    /// InactivatedByUserId الخاص بـ Quotation
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the Quotation
    /// ExternalPostFlag الخاص بـ Quotation
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CostType of the Quotation
    /// CostType الخاص بـ Quotation
    /// </summary>
    public string CostType { get; private set; }

    /// <summary>
    /// RepCode of the Quotation
    /// RepCode الخاص بـ Quotation
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ExportFlag of the Quotation
    /// ExportFlag الخاص بـ Quotation
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// QuotationExpireDate of the Quotation
    /// QuotationExpireDate الخاص بـ Quotation
    /// </summary>
    public DateTime? QuotationExpireDate { get; private set; }

    /// <summary>
    /// CurRate of the Quotation
    /// CurRate الخاص بـ Quotation
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// ChequeDueDate of the Quotation
    /// ChequeDueDate الخاص بـ Quotation
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// DiscAmtMst of the Quotation
    /// DiscAmtMst الخاص بـ Quotation
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the Quotation
    /// DiscAmtDtl الخاص بـ Quotation
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the Quotation
    /// DiscAmtMstVat الخاص بـ Quotation
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the Quotation
    /// VatAmountDiscountMaster الخاص بـ Quotation
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// VatAmount of the Quotation
    /// VatAmount الخاص بـ Quotation
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// QuotationDocumentType of the Quotation
    /// QuotationDocumentType الخاص بـ Quotation
    /// </summary>
    public decimal? QuotationDocumentType { get; private set; }

    /// <summary>
    /// QuotationDueDate of the Quotation
    /// QuotationDueDate الخاص بـ Quotation
    /// </summary>
    public DateTime? QuotationDueDate { get; private set; }

    /// <summary>
    /// CustomerAcceptType of the Quotation
    /// CustomerAcceptType الخاص بـ Quotation
    /// </summary>
    public decimal? CustomerAcceptType { get; private set; }

    /// <summary>
    /// CustomerAcceptDate of the Quotation
    /// CustomerAcceptDate الخاص بـ Quotation
    /// </summary>
    public DateTime? CustomerAcceptDate { get; private set; }

    /// <summary>
    /// CustomerAcceptDescription of the Quotation
    /// CustomerAcceptDescription الخاص بـ Quotation
    /// </summary>
    public string CustomerAcceptDescription { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the Quotation
    /// CalcTypeNumberTax الخاص بـ Quotation
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// Field1 of the Quotation
    /// Field1 الخاص بـ Quotation
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Quotation
    /// Field2 الخاص بـ Quotation
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Quotation
    /// Field3 الخاص بـ Quotation
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Quotation
    /// Field4 الخاص بـ Quotation
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Quotation
    /// Field5 الخاص بـ Quotation
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Quotation
    /// Field6 الخاص بـ Quotation
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Quotation
    /// Field7 الخاص بـ Quotation
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Quotation
    /// Field8 الخاص بـ Quotation
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Quotation
    /// Field9 الخاص بـ Quotation
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Quotation
    /// Field10 الخاص بـ Quotation
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Quotation
    /// CompanyNumberShort الخاص بـ Quotation
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the Quotation
    /// BranchNumber الخاص بـ Quotation
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the Quotation
    /// BranchYear الخاص بـ Quotation
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the Quotation
    /// BranchUser الخاص بـ Quotation
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// VatAmountOther of the Quotation
    /// VatAmountOther الخاص بـ Quotation
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the Quotation
    /// DocSerExtrnl الخاص بـ Quotation
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the Quotation
    /// CalcVatPriceType الخاص بـ Quotation
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the Quotation
    /// CalcTaxFreeQuantityFlag الخاص بـ Quotation
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// CreatedDateClock of the Quotation
    /// CreatedDateClock الخاص بـ Quotation
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the Quotation
    /// ContractBatchNumber الخاص بـ Quotation
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// ContractDate of the Quotation
    /// ContractDate الخاص بـ Quotation
    /// </summary>
    public DateTime? ContractDate { get; private set; }

    /// <summary>
    /// ContractNumber of the Quotation
    /// ContractNumber الخاص بـ Quotation
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// DeliveryDate of the Quotation
    /// DeliveryDate الخاص بـ Quotation
    /// </summary>
    public DateTime? DeliveryDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to QuotationType
    /// </summary>
    public QuotationType QuotationType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// One-to-many relationship: Quotation to QuotationDetail
    /// </summary>
    public IReadOnlyCollection<QuotationDetail> QuotationDetails { get; private set; }
    #endregion
}
}
