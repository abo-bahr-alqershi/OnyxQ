using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// QuotationPromotionGroupDetail Entity
/// </summary>
public class QuotationPromotionGroupDetail : Entity<QuotationPromotionGroupDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<QuotationPromotionGroupMaster> _quotationPromotionGroupMaster = new List<QuotationPromotionGroupMaster>();

    private QuotationPromotionGroupDetail() { }

    public QuotationPromotionGroupDetail(QuotationPromotionGroupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the QuotationPromotionGroupDetail
    /// المعرف الفريد لـ QuotationPromotionGroupDetail
    /// </summary>
    public QuotationPromotionGroupDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the QuotationPromotionGroupDetail
    /// RecordNumber الخاص بـ QuotationPromotionGroupDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the QuotationPromotionGroupDetail
    /// ItemUnit الخاص بـ QuotationPromotionGroupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the QuotationPromotionGroupDetail
    /// PSize الخاص بـ QuotationPromotionGroupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the QuotationPromotionGroupDetail
    /// ItemQuantity الخاص بـ QuotationPromotionGroupDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// BranchYear of the QuotationPromotionGroupDetail
    /// BranchYear الخاص بـ QuotationPromotionGroupDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the QuotationPromotionGroupDetail
    /// BranchUser الخاص بـ QuotationPromotionGroupDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemPriceShort of the QuotationPromotionGroupDetail
    /// ItemPriceShort الخاص بـ QuotationPromotionGroupDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<QuotationPromotionGroupMaster> QuotationPromotionGroupMaster => _quotationPromotionGroupMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
