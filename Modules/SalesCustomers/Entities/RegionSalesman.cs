using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// RegionSalesman Entity
/// </summary>
public class RegionSalesman : Entity<RegionSalesmanId>
{
    private RegionSalesman() { }

    /// <summary>
    /// The unique identifier for the RegionSalesman
    /// المعرف الفريد لـ RegionSalesman
    /// </summary>
    public RegionSalesmanId Id { get; private set; }

    /// <summary>
    /// RegionCode of the RegionSalesman
    /// RegionCode الخاص بـ RegionSalesman
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RepCode of the RegionSalesman
    /// RepCode الخاص بـ RegionSalesman
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// PromoterCode of the RegionSalesman
    /// PromoterCode الخاص بـ RegionSalesman
    /// </summary>
    public string PromoterCode { get; private set; }

    #region Navigation Properties
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
    #endregion
}
}
