using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionCustomer Entity
/// </summary>
public class PromotionCustomer : Entity<PromotionCustomerId>
{
    private PromotionCustomer() { }

    /// <summary>
    /// The unique identifier for the PromotionCustomer
    /// المعرف الفريد لـ PromotionCustomer
    /// </summary>
    public PromotionCustomerId Id { get; private set; }

    /// <summary>
    /// CCode of the PromotionCustomer
    /// CCode الخاص بـ PromotionCustomer
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// PromoterCode of the PromotionCustomer
    /// PromoterCode الخاص بـ PromotionCustomer
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the PromotionCustomer
    /// CostCenterCode الخاص بـ PromotionCustomer
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PromotionCustomer
    /// ProjectNumber الخاص بـ PromotionCustomer
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PromotionCustomer
    /// ActivityNumber الخاص بـ PromotionCustomer
    /// </summary>
    public string ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Promoter
    /// </summary>
    public Promoter Promoter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
