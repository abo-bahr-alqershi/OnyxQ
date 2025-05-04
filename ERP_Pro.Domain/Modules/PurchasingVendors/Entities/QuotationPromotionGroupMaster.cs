using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// QuotationPromotionGroupMaster Entity
/// </summary>
public class QuotationPromotionGroupMaster : Entity<QuotationPromotionGroupMasterId>
{

    private QuotationPromotionGroupMaster() { }

    public QuotationPromotionGroupMaster(QuotationPromotionGroupMasterId id, decimal? promoterGroupNumber)
    {
        Id = id;
        PromoterGroupNumber = promoterGroupNumber;
    }

    /// <summary>
    /// The unique identifier for the QuotationPromotionGroupMaster
    /// المعرف الفريد لـ QuotationPromotionGroupMaster
    /// </summary>
    public QuotationPromotionGroupMasterId Id { get; private set; }

    /// <summary>
    /// PromoterGroupNumber of the QuotationPromotionGroupMaster
    /// PromoterGroupNumber الخاص بـ QuotationPromotionGroupMaster
    /// </summary>
    public decimal? PromoterGroupNumber { get; private set; }

    /// <summary>
    /// PromoterGroupLastName of the QuotationPromotionGroupMaster
    /// PromoterGroupLastName الخاص بـ QuotationPromotionGroupMaster
    /// </summary>
    public string PromoterGroupLastName { get; private set; }

    /// <summary>
    /// PromoterGroupFirstName of the QuotationPromotionGroupMaster
    /// PromoterGroupFirstName الخاص بـ QuotationPromotionGroupMaster
    /// </summary>
    public string PromoterGroupFirstName { get; private set; }

    /// <summary>
    /// CheckAllItems of the QuotationPromotionGroupMaster
    /// CheckAllItems الخاص بـ QuotationPromotionGroupMaster
    /// </summary>
    public decimal? CheckAllItems { get; private set; }

    /// <summary>
    /// GrantFreeQuantityType of the QuotationPromotionGroupMaster
    /// GrantFreeQuantityType الخاص بـ QuotationPromotionGroupMaster
    /// </summary>
    public decimal? GrantFreeQuantityType { get; private set; }

    /// <summary>
    /// PromoterGroupType of the QuotationPromotionGroupMaster
    /// PromoterGroupType الخاص بـ QuotationPromotionGroupMaster
    /// </summary>
    public decimal? PromoterGroupType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
