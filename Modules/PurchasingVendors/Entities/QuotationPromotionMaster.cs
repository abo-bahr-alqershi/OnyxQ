using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// QuotationPromotionMaster Entity
/// </summary>
public class QuotationPromotionMaster : Entity<QuotationPromotionMasterId>
{
    private QuotationPromotionMaster() { }

    /// <summary>
    /// The unique identifier for the QuotationPromotionMaster
    /// المعرف الفريد لـ QuotationPromotionMaster
    /// </summary>
    public QuotationPromotionMasterId Id { get; private set; }

    /// <summary>
    /// QuotationNumberFull of the QuotationPromotionMaster
    /// QuotationNumberFull الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? QuotationNumberFull { get; private set; }

    /// <summary>
    /// QuotationSerialFull of the QuotationPromotionMaster
    /// QuotationSerialFull الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? QuotationSerialFull { get; private set; }

    /// <summary>
    /// FDate of the QuotationPromotionMaster
    /// FDate الخاص بـ QuotationPromotionMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the QuotationPromotionMaster
    /// TDate الخاص بـ QuotationPromotionMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// FTime of the QuotationPromotionMaster
    /// FTime الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string FTime { get; private set; }

    /// <summary>
    /// TTime of the QuotationPromotionMaster
    /// TTime الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string TTime { get; private set; }

    /// <summary>
    /// QuotationCurrency of the QuotationPromotionMaster
    /// QuotationCurrency الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string QuotationCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the QuotationPromotionMaster
    /// CostCenterCode الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the QuotationPromotionMaster
    /// WarehouseCode الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the QuotationPromotionMaster
    /// ReferenceNumber الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescription of the QuotationPromotionMaster
    /// AccountDescription الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the QuotationPromotionMaster
    /// InactiveFlag الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the QuotationPromotionMaster
    /// ExternalPostFlag الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// FieldDay1 of the QuotationPromotionMaster
    /// FieldDay1 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? FieldDay1 { get; private set; }

    /// <summary>
    /// FieldDay2 of the QuotationPromotionMaster
    /// FieldDay2 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? FieldDay2 { get; private set; }

    /// <summary>
    /// FieldDay3 of the QuotationPromotionMaster
    /// FieldDay3 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? FieldDay3 { get; private set; }

    /// <summary>
    /// FieldDay4 of the QuotationPromotionMaster
    /// FieldDay4 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? FieldDay4 { get; private set; }

    /// <summary>
    /// FieldDay5 of the QuotationPromotionMaster
    /// FieldDay5 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? FieldDay5 { get; private set; }

    /// <summary>
    /// FieldDay6 of the QuotationPromotionMaster
    /// FieldDay6 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? FieldDay6 { get; private set; }

    /// <summary>
    /// FieldDay7 of the QuotationPromotionMaster
    /// FieldDay7 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? FieldDay7 { get; private set; }

    /// <summary>
    /// QuotationPremiumType of the QuotationPromotionMaster
    /// QuotationPremiumType الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? QuotationPremiumType { get; private set; }

    /// <summary>
    /// QuotationPremiumMethod of the QuotationPromotionMaster
    /// QuotationPremiumMethod الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? QuotationPremiumMethod { get; private set; }

    /// <summary>
    /// QuotationPremiumWarehouseCodeType of the QuotationPromotionMaster
    /// QuotationPremiumWarehouseCodeType الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? QuotationPremiumWarehouseCodeType { get; private set; }

    /// <summary>
    /// QuotationPremiumCostType of the QuotationPromotionMaster
    /// QuotationPremiumCostType الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? QuotationPremiumCostType { get; private set; }

    /// <summary>
    /// ByCompanyQuantity of the QuotationPromotionMaster
    /// ByCompanyQuantity الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? ByCompanyQuantity { get; private set; }

    /// <summary>
    /// CalculateAllSlides of the QuotationPromotionMaster
    /// CalculateAllSlides الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? CalculateAllSlides { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the QuotationPromotionMaster
    /// BillDocumentTypeFull الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// ApprovedFreeQuantityAsDiscount of the QuotationPromotionMaster
    /// ApprovedFreeQuantityAsDiscount الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? ApprovedFreeQuantityAsDiscount { get; private set; }

    /// <summary>
    /// InactiveReason of the QuotationPromotionMaster
    /// InactiveReason الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the QuotationPromotionMaster
    /// InactiveDate الخاص بـ QuotationPromotionMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the QuotationPromotionMaster
    /// InactivatedByUserId الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// Field1 of the QuotationPromotionMaster
    /// Field1 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the QuotationPromotionMaster
    /// Field2 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the QuotationPromotionMaster
    /// Field3 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the QuotationPromotionMaster
    /// Field4 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the QuotationPromotionMaster
    /// Field5 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the QuotationPromotionMaster
    /// Field6 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the QuotationPromotionMaster
    /// Field7 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the QuotationPromotionMaster
    /// Field8 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the QuotationPromotionMaster
    /// Field9 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the QuotationPromotionMaster
    /// Field10 الخاص بـ QuotationPromotionMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the QuotationPromotionMaster
    /// CompanyNumberShort الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the QuotationPromotionMaster
    /// BranchNumber الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the QuotationPromotionMaster
    /// BranchYear الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuotationPromotionMaster
    /// BranchUser الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// QuotationPremiumItemType of the QuotationPromotionMaster
    /// QuotationPremiumItemType الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? QuotationPremiumItemType { get; private set; }

    /// <summary>
    /// CumulativeMonthFlag of the QuotationPromotionMaster
    /// CumulativeMonthFlag الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? CumulativeMonthFlag { get; private set; }

    /// <summary>
    /// CreatedDateClock of the QuotationPromotionMaster
    /// CreatedDateClock الخاص بـ QuotationPromotionMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    /// <summary>
    /// UseQuotationPremiumInCssSystemFlag of the QuotationPromotionMaster
    /// UseQuotationPremiumInCssSystemFlag الخاص بـ QuotationPromotionMaster
    /// </summary>
    public decimal? UseQuotationPremiumInCssSystemFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: QuotationPromotionMaster to QuotationPromotionDetail
    /// </summary>
    public IReadOnlyCollection<QuotationPromotionDetail> QuotationPromotionDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion
}
}
