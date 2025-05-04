using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// QuotationPromotionSubDetail Entity
/// </summary>
public class QuotationPromotionSubDetail : Entity<QuotationPromotionSubDetailId>
{
    private QuotationPromotionSubDetail() { }

    /// <summary>
    /// The unique identifier for the QuotationPromotionSubDetail
    /// المعرف الفريد لـ QuotationPromotionSubDetail
    /// </summary>
    public QuotationPromotionSubDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the QuotationPromotionSubDetail
    /// RecordNumber الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// QuotationNumberFull of the QuotationPromotionSubDetail
    /// QuotationNumberFull الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? QuotationNumberFull { get; private set; }

    /// <summary>
    /// QuotationSerialFull of the QuotationPromotionSubDetail
    /// QuotationSerialFull الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? QuotationSerialFull { get; private set; }

    /// <summary>
    /// ItemCode of the QuotationPromotionSubDetail
    /// ItemCode الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the QuotationPromotionSubDetail
    /// ItemUnit الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the QuotationPromotionSubDetail
    /// PSize الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// FreeQuantity of the QuotationPromotionSubDetail
    /// FreeQuantity الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the QuotationPromotionSubDetail
    /// CompanyNumberShort الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the QuotationPromotionSubDetail
    /// BranchNumber الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the QuotationPromotionSubDetail
    /// BranchYear الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuotationPromotionSubDetail
    /// BranchUser الخاص بـ QuotationPromotionSubDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
