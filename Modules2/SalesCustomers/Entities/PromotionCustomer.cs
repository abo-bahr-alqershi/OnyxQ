using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// PromotionCustomer Entity
/// </summary>
public class PromotionCustomer : Entity<PromotionCustomerId>
{
    private readonly List<Promoter> _promoter = new List<Promoter>();
    private readonly List<Customer> _customer = new List<Customer>();

    private PromotionCustomer() { }

    public PromotionCustomer(PromotionCustomerId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PromotionCustomer
    /// المعرف الفريد لـ PromotionCustomer
    /// </summary>
    public PromotionCustomerId Id { get; private set; }

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
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Promoter> Promoter => _promoter;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

