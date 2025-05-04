using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesOrder Entity
/// </summary>
public class SalesOrder : Entity<SalesOrderId>
{
    private SalesOrder() { }

    /// <summary>
    /// The unique identifier for the SalesOrder
    /// المعرف الفريد لـ SalesOrder
    /// </summary>
    public SalesOrderId Id { get; private set; }

    /// <summary>
    /// SalesOrderType of the SalesOrder
    /// SalesOrderType الخاص بـ SalesOrder
    /// </summary>
    public decimal? SalesOrderType { get; private set; }

    /// <summary>
    /// OrderNumber of the SalesOrder
    /// OrderNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? OrderNumber { get; private set; }

    /// <summary>
    /// OrderSerial of the SalesOrder
    /// OrderSerial الخاص بـ SalesOrder
    /// </summary>
    public decimal? OrderSerial { get; private set; }

    /// <summary>
    /// OrderDate of the SalesOrder
    /// OrderDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? OrderDate { get; private set; }

    /// <summary>
    /// QuotationNumberFull of the SalesOrder
    /// QuotationNumberFull الخاص بـ SalesOrder
    /// </summary>
    public decimal? QuotationNumberFull { get; private set; }

    /// <summary>
    /// QuotationSerialFull of the SalesOrder
    /// QuotationSerialFull الخاص بـ SalesOrder
    /// </summary>
    public decimal? QuotationSerialFull { get; private set; }

    /// <summary>
    /// OrderCurrency of the SalesOrder
    /// OrderCurrency الخاص بـ SalesOrder
    /// </summary>
    public string OrderCurrency { get; private set; }

    /// <summary>
    /// CurRate of the SalesOrder
    /// CurRate الخاص بـ SalesOrder
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// CCode of the SalesOrder
    /// CCode الخاص بـ SalesOrder
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the SalesOrder
    /// CName الخاص بـ SalesOrder
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// AccountDescription of the SalesOrder
    /// AccountDescription الخاص بـ SalesOrder
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// CostCenterCode of the SalesOrder
    /// CostCenterCode الخاص بـ SalesOrder
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the SalesOrder
    /// ProjectNumber الخاص بـ SalesOrder
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the SalesOrder
    /// ActivityNumber الخاص بـ SalesOrder
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the SalesOrder
    /// WarehouseCode الخاص بـ SalesOrder
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RepCode of the SalesOrder
    /// RepCode الخاص بـ SalesOrder
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the SalesOrder
    /// ProcessedFlagAlt الخاص بـ SalesOrder
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// StandByFlag of the SalesOrder
    /// StandByFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// LoadedFlag of the SalesOrder
    /// LoadedFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? LoadedFlag { get; private set; }

    /// <summary>
    /// ReferenceDocumentNumber of the SalesOrder
    /// ReferenceDocumentNumber الخاص بـ SalesOrder
    /// </summary>
    public string ReferenceDocumentNumber { get; private set; }

    /// <summary>
    /// ReferenceDocumentDate of the SalesOrder
    /// ReferenceDocumentDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? ReferenceDocumentDate { get; private set; }

    /// <summary>
    /// DiscAmt of the SalesOrder
    /// DiscAmt الخاص بـ SalesOrder
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the SalesOrder
    /// DiscAmtMst الخاص بـ SalesOrder
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the SalesOrder
    /// DiscAmtDtl الخاص بـ SalesOrder
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// DiscAmtMstVat of the SalesOrder
    /// DiscAmtMstVat الخاص بـ SalesOrder
    /// </summary>
    public decimal? DiscAmtMstVat { get; private set; }

    /// <summary>
    /// VatAmountDiscountMaster of the SalesOrder
    /// VatAmountDiscountMaster الخاص بـ SalesOrder
    /// </summary>
    public decimal? VatAmountDiscountMaster { get; private set; }

    /// <summary>
    /// ApprovedFlag of the SalesOrder
    /// ApprovedFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the SalesOrder
    /// ApprovalUserId الخاص بـ SalesOrder
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the SalesOrder
    /// ApprovalDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the SalesOrder
    /// ApprovalDescription الخاص بـ SalesOrder
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// PrepareDate of the SalesOrder
    /// PrepareDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? PrepareDate { get; private set; }

    /// <summary>
    /// ReceiveDealerDate of the SalesOrder
    /// ReceiveDealerDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? ReceiveDealerDate { get; private set; }

    /// <summary>
    /// DeliveryDate of the SalesOrder
    /// DeliveryDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? DeliveryDate { get; private set; }

    /// <summary>
    /// RepeatUseInBillsFlag of the SalesOrder
    /// RepeatUseInBillsFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? RepeatUseInBillsFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the SalesOrder
    /// InactiveFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the SalesOrder
    /// InactiveReason الخاص بـ SalesOrder
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the SalesOrder
    /// InactiveDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the SalesOrder
    /// InactivatedByUserId الخاص بـ SalesOrder
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// PaperNumber of the SalesOrder
    /// PaperNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? PaperNumber { get; private set; }

    /// <summary>
    /// PaperSerial of the SalesOrder
    /// PaperSerial الخاص بـ SalesOrder
    /// </summary>
    public decimal? PaperSerial { get; private set; }

    /// <summary>
    /// RegionCode of the SalesOrder
    /// RegionCode الخاص بـ SalesOrder
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// PromoterCode of the SalesOrder
    /// PromoterCode الخاص بـ SalesOrder
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// DriverNo of the SalesOrder
    /// DriverNo الخاص بـ SalesOrder
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SalesOrder
    /// BillDocumentTypeFull الخاص بـ SalesOrder
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillDueDate of the SalesOrder
    /// BillDueDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? BillDueDate { get; private set; }

    /// <summary>
    /// OrderExpireDate of the SalesOrder
    /// OrderExpireDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? OrderExpireDate { get; private set; }

    /// <summary>
    /// ChequeDueDate of the SalesOrder
    /// ChequeDueDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the SalesOrder
    /// ExternalPostFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ProcessIncomeFlag of the SalesOrder
    /// ProcessIncomeFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? ProcessIncomeFlag { get; private set; }

    /// <summary>
    /// ProcessWarehouseTransferFlag of the SalesOrder
    /// ProcessWarehouseTransferFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? ProcessWarehouseTransferFlag { get; private set; }

    /// <summary>
    /// ApprovedSalesManager of the SalesOrder
    /// ApprovedSalesManager الخاص بـ SalesOrder
    /// </summary>
    public decimal? ApprovedSalesManager { get; private set; }

    /// <summary>
    /// ApprovalSalesManagerUserId of the SalesOrder
    /// ApprovalSalesManagerUserId الخاص بـ SalesOrder
    /// </summary>
    public decimal? ApprovalSalesManagerUserId { get; private set; }

    /// <summary>
    /// ApprovalSalesManagerDate of the SalesOrder
    /// ApprovalSalesManagerDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? ApprovalSalesManagerDate { get; private set; }

    /// <summary>
    /// TransferProduct of the SalesOrder
    /// TransferProduct الخاص بـ SalesOrder
    /// </summary>
    public decimal? TransferProduct { get; private set; }

    /// <summary>
    /// ExportFlag of the SalesOrder
    /// ExportFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? ExportFlag { get; private set; }

    /// <summary>
    /// VatAmount of the SalesOrder
    /// VatAmount الخاص بـ SalesOrder
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OrderAmount of the SalesOrder
    /// OrderAmount الخاص بـ SalesOrder
    /// </summary>
    public decimal? OrderAmount { get; private set; }

    /// <summary>
    /// EmpNo of the SalesOrder
    /// EmpNo الخاص بـ SalesOrder
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// OtherAmount of the SalesOrder
    /// OtherAmount الخاص بـ SalesOrder
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the SalesOrder
    /// SalesInvoiceType الخاص بـ SalesOrder
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the SalesOrder
    /// CalcTypeNumberTax الخاص بـ SalesOrder
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// Field1 of the SalesOrder
    /// Field1 الخاص بـ SalesOrder
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the SalesOrder
    /// Field2 الخاص بـ SalesOrder
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the SalesOrder
    /// Field3 الخاص بـ SalesOrder
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the SalesOrder
    /// Field4 الخاص بـ SalesOrder
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the SalesOrder
    /// Field5 الخاص بـ SalesOrder
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the SalesOrder
    /// Field6 الخاص بـ SalesOrder
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the SalesOrder
    /// Field7 الخاص بـ SalesOrder
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the SalesOrder
    /// Field8 الخاص بـ SalesOrder
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the SalesOrder
    /// Field9 الخاص بـ SalesOrder
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the SalesOrder
    /// Field10 الخاص بـ SalesOrder
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field11 of the SalesOrder
    /// Field11 الخاص بـ SalesOrder
    /// </summary>
    public string Field11 { get; private set; }

    /// <summary>
    /// Field12 of the SalesOrder
    /// Field12 الخاص بـ SalesOrder
    /// </summary>
    public string Field12 { get; private set; }

    /// <summary>
    /// Field13 of the SalesOrder
    /// Field13 الخاص بـ SalesOrder
    /// </summary>
    public string Field13 { get; private set; }

    /// <summary>
    /// Field14 of the SalesOrder
    /// Field14 الخاص بـ SalesOrder
    /// </summary>
    public string Field14 { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the SalesOrder
    /// InsuranceCompanyNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the SalesOrder
    /// InsuranceBenefitNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsurancePersonName of the SalesOrder
    /// InsurancePersonName الخاص بـ SalesOrder
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the SalesOrder
    /// InsuranceCardNumber الخاص بـ SalesOrder
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// InsuranceCardNumberFamily of the SalesOrder
    /// InsuranceCardNumberFamily الخاص بـ SalesOrder
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// InsuranceRelationType of the SalesOrder
    /// InsuranceRelationType الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

    /// <summary>
    /// InsuranceClassNumber of the SalesOrder
    /// InsuranceClassNumber الخاص بـ SalesOrder
    /// </summary>
    public string InsuranceClassNumber { get; private set; }

    /// <summary>
    /// InsuranceLoadPercent of the SalesOrder
    /// InsuranceLoadPercent الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceLoadPercent { get; private set; }

    /// <summary>
    /// InsuranceDiagnosis of the SalesOrder
    /// InsuranceDiagnosis الخاص بـ SalesOrder
    /// </summary>
    public string InsuranceDiagnosis { get; private set; }

    /// <summary>
    /// InsuranceMedicalNumber of the SalesOrder
    /// InsuranceMedicalNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceMedicalNumber { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the SalesOrder
    /// InsuranceApprovedCode الخاص بـ SalesOrder
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// InsuranceCashAmount of the SalesOrder
    /// InsuranceCashAmount الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceCashAmount { get; private set; }

    /// <summary>
    /// CCodeCsh of the SalesOrder
    /// CCodeCsh الخاص بـ SalesOrder
    /// </summary>
    public string CCodeCsh { get; private set; }

    /// <summary>
    /// CAddress of the SalesOrder
    /// CAddress الخاص بـ SalesOrder
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// CMobile of the SalesOrder
    /// CMobile الخاص بـ SalesOrder
    /// </summary>
    public string CMobile { get; private set; }

    /// <summary>
    /// NoteTransferPath of the SalesOrder
    /// NoteTransferPath الخاص بـ SalesOrder
    /// </summary>
    public string NoteTransferPath { get; private set; }

    /// <summary>
    /// Latitude of the SalesOrder
    /// Latitude الخاص بـ SalesOrder
    /// </summary>
    public string Latitude { get; private set; }

    /// <summary>
    /// Longitude of the SalesOrder
    /// Longitude الخاص بـ SalesOrder
    /// </summary>
    public string Longitude { get; private set; }

    /// <summary>
    /// CashNumber of the SalesOrder
    /// CashNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesOrder
    /// CompanyNumberShort الخاص بـ SalesOrder
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesOrder
    /// BranchNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesOrder
    /// BranchYear الخاص بـ SalesOrder
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SalesOrder
    /// BranchUser الخاص بـ SalesOrder
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// VatAmountOther of the SalesOrder
    /// VatAmountOther الخاص بـ SalesOrder
    /// </summary>
    public decimal? VatAmountOther { get; private set; }

    /// <summary>
    /// DiffAcutlWghtSoQty of the SalesOrder
    /// DiffAcutlWghtSoQty الخاص بـ SalesOrder
    /// </summary>
    public decimal? DiffAcutlWghtSoQty { get; private set; }

    /// <summary>
    /// TareWeight of the SalesOrder
    /// TareWeight الخاص بـ SalesOrder
    /// </summary>
    public decimal? TareWeight { get; private set; }

    /// <summary>
    /// TareWeightDate of the SalesOrder
    /// TareWeightDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? TareWeightDate { get; private set; }

    /// <summary>
    /// TareWeightUserId of the SalesOrder
    /// TareWeightUserId الخاص بـ SalesOrder
    /// </summary>
    public decimal? TareWeightUserId { get; private set; }

    /// <summary>
    /// GrossWeight of the SalesOrder
    /// GrossWeight الخاص بـ SalesOrder
    /// </summary>
    public decimal? GrossWeight { get; private set; }

    /// <summary>
    /// GrossWeightDate of the SalesOrder
    /// GrossWeightDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? GrossWeightDate { get; private set; }

    /// <summary>
    /// GrossWeightUserId of the SalesOrder
    /// GrossWeightUserId الخاص بـ SalesOrder
    /// </summary>
    public decimal? GrossWeightUserId { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the SalesOrder
    /// DocSerExtrnl الخاص بـ SalesOrder
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// CreditCardNumberFull of the SalesOrder
    /// CreditCardNumberFull الخاص بـ SalesOrder
    /// </summary>
    public decimal? CreditCardNumberFull { get; private set; }

    /// <summary>
    /// DiscAmtAftrVat of the SalesOrder
    /// DiscAmtAftrVat الخاص بـ SalesOrder
    /// </summary>
    public decimal? DiscAmtAftrVat { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the SalesOrder
    /// CalcVatPriceType الخاص بـ SalesOrder
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// ContractNumber of the SalesOrder
    /// ContractNumber الخاص بـ SalesOrder
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the SalesOrder
    /// ContractBatchNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// ContractDate of the SalesOrder
    /// ContractDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? ContractDate { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the SalesOrder
    /// ColumnNumberShort الخاص بـ SalesOrder
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// StockRateShort of the SalesOrder
    /// StockRateShort الخاص بـ SalesOrder
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// ProcessOutgoingFlag of the SalesOrder
    /// ProcessOutgoingFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? ProcessOutgoingFlag { get; private set; }

    /// <summary>
    /// PointCalculationTypeNumber of the SalesOrder
    /// PointCalculationTypeNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? PointCalculationTypeNumber { get; private set; }

    /// <summary>
    /// PointCount of the SalesOrder
    /// PointCount الخاص بـ SalesOrder
    /// </summary>
    public decimal? PointCount { get; private set; }

    /// <summary>
    /// PointCountAll of the SalesOrder
    /// PointCountAll الخاص بـ SalesOrder
    /// </summary>
    public decimal? PointCountAll { get; private set; }

    /// <summary>
    /// PointReplaceAmount of the SalesOrder
    /// PointReplaceAmount الخاص بـ SalesOrder
    /// </summary>
    public decimal? PointReplaceAmount { get; private set; }

    /// <summary>
    /// PointReplaceCount of the SalesOrder
    /// PointReplaceCount الخاص بـ SalesOrder
    /// </summary>
    public decimal? PointReplaceCount { get; private set; }

    /// <summary>
    /// PointTypeNumber of the SalesOrder
    /// PointTypeNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// MobileNumber of the SalesOrder
    /// MobileNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? MobileNumber { get; private set; }

    /// <summary>
    /// ProcessMrpFlag of the SalesOrder
    /// ProcessMrpFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? ProcessMrpFlag { get; private set; }

    /// <summary>
    /// NotUseQuotationPremium of the SalesOrder
    /// NotUseQuotationPremium الخاص بـ SalesOrder
    /// </summary>
    public decimal? NotUseQuotationPremium { get; private set; }

    /// <summary>
    /// QuotationPremiumSerial of the SalesOrder
    /// QuotationPremiumSerial الخاص بـ SalesOrder
    /// </summary>
    public decimal? QuotationPremiumSerial { get; private set; }

    /// <summary>
    /// QuotationPremiumRecordNumber of the SalesOrder
    /// QuotationPremiumRecordNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? QuotationPremiumRecordNumber { get; private set; }

    /// <summary>
    /// QuotationPremiumNumber of the SalesOrder
    /// QuotationPremiumNumber الخاص بـ SalesOrder
    /// </summary>
    public decimal? QuotationPremiumNumber { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the SalesOrder
    /// CalcTaxFreeQuantityFlag الخاص بـ SalesOrder
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitMaster of the SalesOrder
    /// InsuranceAdditionalLimitMaster الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceAdditionalLimitMaster { get; private set; }

    /// <summary>
    /// CreatedDateClock of the SalesOrder
    /// CreatedDateClock الخاص بـ SalesOrder
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// ShowSystemType of the SalesOrder
    /// ShowSystemType الخاص بـ SalesOrder
    /// </summary>
    public decimal? ShowSystemType { get; private set; }

    /// <summary>
    /// OrderStatusType of the SalesOrder
    /// OrderStatusType الخاص بـ SalesOrder
    /// </summary>
    public decimal? OrderStatusType { get; private set; }

    /// <summary>
    /// OrderTender of the SalesOrder
    /// OrderTender الخاص بـ SalesOrder
    /// </summary>
    public string OrderTender { get; private set; }

    /// <summary>
    /// CstSpclstNm of the SalesOrder
    /// CstSpclstNm الخاص بـ SalesOrder
    /// </summary>
    public string CstSpclstNm { get; private set; }

    /// <summary>
    /// OrderNumberManual of the SalesOrder
    /// OrderNumberManual الخاص بـ SalesOrder
    /// </summary>
    public string OrderNumberManual { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDocument of the SalesOrder
    /// InsuranceAdditionalLimitDocument الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceAdditionalLimitDocument { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimitDetail of the SalesOrder
    /// InsuranceAdditionalLimitDetail الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceAdditionalLimitDetail { get; private set; }

    /// <summary>
    /// InsuranceLimitAmountLocalDocument of the SalesOrder
    /// InsuranceLimitAmountLocalDocument الخاص بـ SalesOrder
    /// </summary>
    public decimal? InsuranceLimitAmountLocalDocument { get; private set; }

    /// <summary>
    /// PatientNumber of the SalesOrder
    /// PatientNumber الخاص بـ SalesOrder
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// DctrNo of the SalesOrder
    /// DctrNo الخاص بـ SalesOrder
    /// </summary>
    public string DctrNo { get; private set; }

    /// <summary>
    /// PatientType of the SalesOrder
    /// PatientType الخاص بـ SalesOrder
    /// </summary>
    public decimal? PatientType { get; private set; }

    /// <summary>
    /// DocNoAdmson of the SalesOrder
    /// DocNoAdmson الخاص بـ SalesOrder
    /// </summary>
    public decimal? DocNoAdmson { get; private set; }

    /// <summary>
    /// DocSrlAdmson of the SalesOrder
    /// DocSrlAdmson الخاص بـ SalesOrder
    /// </summary>
    public decimal? DocSrlAdmson { get; private set; }

    /// <summary>
    /// DocMSq of the SalesOrder
    /// DocMSq الخاص بـ SalesOrder
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// CustomerAcceptType of the SalesOrder
    /// CustomerAcceptType الخاص بـ SalesOrder
    /// </summary>
    public decimal? CustomerAcceptType { get; private set; }

    /// <summary>
    /// CustomerAcceptUserId of the SalesOrder
    /// CustomerAcceptUserId الخاص بـ SalesOrder
    /// </summary>
    public decimal? CustomerAcceptUserId { get; private set; }

    /// <summary>
    /// CustomerAcceptDate of the SalesOrder
    /// CustomerAcceptDate الخاص بـ SalesOrder
    /// </summary>
    public DateTime? CustomerAcceptDate { get; private set; }

    /// <summary>
    /// CustomerAcceptDescription of the SalesOrder
    /// CustomerAcceptDescription الخاص بـ SalesOrder
    /// </summary>
    public string CustomerAcceptDescription { get; private set; }

    /// <summary>
    /// ProcessRequestAuto of the SalesOrder
    /// ProcessRequestAuto الخاص بـ SalesOrder
    /// </summary>
    public decimal? ProcessRequestAuto { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to SalesOrderType
    /// </summary>
    public SalesOrderType SalesOrderType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Promoter
    /// </summary>
    public Promoter Promoter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Collector
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// OneToOne relationship to AccountsReceivableContractDetail
    /// </summary>
    public AccountsReceivableContractDetail AccountsReceivableContractDetail { get; private set; }
    /// <summary>
    /// One-to-many relationship: SalesOrder to OrderDetail
    /// </summary>
    public IReadOnlyCollection<OrderDetail> OrderDetails { get; private set; }
    #endregion
}
}
