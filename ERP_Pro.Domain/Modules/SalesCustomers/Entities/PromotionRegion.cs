using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionRegion Entity
/// </summary>
public class PromotionRegion : Entity<PromotionRegionId>
{
    private readonly List<Promoter> _promoter = new List<Promoter>();
    private readonly List<Region> _region = new List<Region>();

    private PromotionRegion() { }

    public PromotionRegion(PromotionRegionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PromotionRegion
    /// المعرف الفريد لـ PromotionRegion
    /// </summary>
    public PromotionRegionId Id { get; private set; }

    /// <summary>
    /// MarketPercent of the PromotionRegion
    /// MarketPercent الخاص بـ PromotionRegion
    /// </summary>
    public decimal? MarketPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Promoter> Promoter => _promoter;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Region> Region => _region;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
