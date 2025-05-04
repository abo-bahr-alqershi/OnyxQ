using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorQuotationMaster Entity
/// </summary>
public class VendorQuotationMaster : Entity<VendorQuotationMasterId>
{

    private VendorQuotationMaster() { }

    public VendorQuotationMaster(VendorQuotationMasterId id, decimal? quotationSerial)
    {
        Id = id;
        QuotationSerial = quotationSerial;
    }

    /// <summary>
    /// The unique identifier for the VendorQuotationMaster
    /// المعرف الفريد لـ VendorQuotationMaster
    /// </summary>
    public VendorQuotationMasterId Id { get; private set; }

    /// <summary>
    /// QuotationNumber of the VendorQuotationMaster
    /// QuotationNumber الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? QuotationNumber { get; private set; }

    /// <summary>
    /// QuotationSerial of the VendorQuotationMaster
    /// QuotationSerial الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? QuotationSerial { get; private set; }

    /// <summary>
    /// QuotationDate of the VendorQuotationMaster
    /// QuotationDate الخاص بـ VendorQuotationMaster
    /// </summary>
    public DateTime? QuotationDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorQuotationMaster
    /// AccountCurrency الخاص بـ VendorQuotationMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CurNo of the VendorQuotationMaster
    /// CurNo الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? CurNo { get; private set; }

    /// <summary>
    /// VendorCode of the VendorQuotationMaster
    /// VendorCode الخاص بـ VendorQuotationMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the VendorQuotationMaster
    /// VendorName الخاص بـ VendorQuotationMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// CostCenterCode of the VendorQuotationMaster
    /// CostCenterCode الخاص بـ VendorQuotationMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the VendorQuotationMaster
    /// ProjectNumber الخاص بـ VendorQuotationMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the VendorQuotationMaster
    /// AccountDescription الخاص بـ VendorQuotationMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the VendorQuotationMaster
    /// ProcessedFlagFull الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// ApprovedFlag of the VendorQuotationMaster
    /// ApprovedFlag الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the VendorQuotationMaster
    /// ApprovalUserId الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the VendorQuotationMaster
    /// ApprovalDate الخاص بـ VendorQuotationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the VendorQuotationMaster
    /// ApprovalDescription الخاص بـ VendorQuotationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the VendorQuotationMaster
    /// ReferenceNumber الخاص بـ VendorQuotationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// TenderNumber of the VendorQuotationMaster
    /// TenderNumber الخاص بـ VendorQuotationMaster
    /// </summary>
    public string TenderNumber { get; private set; }

    /// <summary>
    /// TenderDate of the VendorQuotationMaster
    /// TenderDate الخاص بـ VendorQuotationMaster
    /// </summary>
    public DateTime? TenderDate { get; private set; }

    /// <summary>
    /// ReferenceDate of the VendorQuotationMaster
    /// ReferenceDate الخاص بـ VendorQuotationMaster
    /// </summary>
    public DateTime? ReferenceDate { get; private set; }

    /// <summary>
    /// PortOfDeparture of the VendorQuotationMaster
    /// PortOfDeparture الخاص بـ VendorQuotationMaster
    /// </summary>
    public string PortOfDeparture { get; private set; }

    /// <summary>
    /// RequestDays of the VendorQuotationMaster
    /// RequestDays الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? RequestDays { get; private set; }

    /// <summary>
    /// PaymentTerms of the VendorQuotationMaster
    /// PaymentTerms الخاص بـ VendorQuotationMaster
    /// </summary>
    public string PaymentTerms { get; private set; }

    /// <summary>
    /// DiscAmt of the VendorQuotationMaster
    /// DiscAmt الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// OtherAmount of the VendorQuotationMaster
    /// OtherAmount الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// QuotationWithoutOtherAmount of the VendorQuotationMaster
    /// QuotationWithoutOtherAmount الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? QuotationWithoutOtherAmount { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the VendorQuotationMaster
    /// CalcVatPriceType الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// Field1 of the VendorQuotationMaster
    /// Field1 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the VendorQuotationMaster
    /// Field2 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the VendorQuotationMaster
    /// Field3 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the VendorQuotationMaster
    /// Field4 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the VendorQuotationMaster
    /// Field5 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the VendorQuotationMaster
    /// Field6 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the VendorQuotationMaster
    /// Field7 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the VendorQuotationMaster
    /// Field8 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the VendorQuotationMaster
    /// Field9 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the VendorQuotationMaster
    /// Field10 الخاص بـ VendorQuotationMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// DiscAmtMst of the VendorQuotationMaster
    /// DiscAmtMst الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the VendorQuotationMaster
    /// DiscAmtDtl الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// VatAmount of the VendorQuotationMaster
    /// VatAmount الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// UseVat of the VendorQuotationMaster
    /// UseVat الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// AutoRenewFlag of the VendorQuotationMaster
    /// AutoRenewFlag الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? AutoRenewFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the VendorQuotationMaster
    /// CompanyNumberShort الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the VendorQuotationMaster
    /// BranchNumber الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the VendorQuotationMaster
    /// BranchYear الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the VendorQuotationMaster
    /// BranchUser الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the VendorQuotationMaster
    /// CalcTypeNumberTax الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CostType of the VendorQuotationMaster
    /// CostType الخاص بـ VendorQuotationMaster
    /// </summary>
    public string CostType { get; private set; }

    /// <summary>
    /// QuotationExpireDate of the VendorQuotationMaster
    /// QuotationExpireDate الخاص بـ VendorQuotationMaster
    /// </summary>
    public DateTime? QuotationExpireDate { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the VendorQuotationMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// DlvryTimeDys of the VendorQuotationMaster
    /// DlvryTimeDys الخاص بـ VendorQuotationMaster
    /// </summary>
    public decimal? DlvryTimeDys { get; private set; }

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
