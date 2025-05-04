using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionItem Entity
/// </summary>
public class PromotionItem : Entity<PromotionItemId>
{
    private PromotionItem() { }

    /// <summary>
    /// The unique identifier for the PromotionItem
    /// المعرف الفريد لـ PromotionItem
    /// </summary>
    public PromotionItemId Id { get; private set; }

    /// <summary>
    /// PromoterCode of the PromotionItem
    /// PromoterCode الخاص بـ PromotionItem
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// ItemCode of the PromotionItem
    /// ItemCode الخاص بـ PromotionItem
    /// </summary>
    public string ItemCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Promoter
    /// </summary>
    public Promoter Promoter { get; private set; }
    #endregion
}
}
