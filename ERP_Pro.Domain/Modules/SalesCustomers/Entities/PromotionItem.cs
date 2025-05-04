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
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<Promoter> _promoter = new List<Promoter>();

    private PromotionItem() { }

    public PromotionItem(PromotionItemId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PromotionItem
    /// المعرف الفريد لـ PromotionItem
    /// </summary>
    public PromotionItemId Id { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Promoter> Promoter => _promoter;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
