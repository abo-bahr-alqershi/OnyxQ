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
    private PromotionRegion() { }

    /// <summary>
    /// The unique identifier for the PromotionRegion
    /// المعرف الفريد لـ PromotionRegion
    /// </summary>
    public PromotionRegionId Id { get; private set; }

    /// <summary>
    /// PromoterCode of the PromotionRegion
    /// PromoterCode الخاص بـ PromotionRegion
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// RegionCode of the PromotionRegion
    /// RegionCode الخاص بـ PromotionRegion
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// MarketPercent of the PromotionRegion
    /// MarketPercent الخاص بـ PromotionRegion
    /// </summary>
    public decimal? MarketPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Promoter
    /// </summary>
    public Promoter Promoter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    #endregion
}
}
