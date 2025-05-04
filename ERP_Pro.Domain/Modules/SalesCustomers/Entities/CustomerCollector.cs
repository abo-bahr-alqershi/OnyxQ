using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCollector Entity
/// </summary>
public class CustomerCollector : Entity<CustomerCollectorId>
{

    private CustomerCollector() { }

    public CustomerCollector(CustomerCollectorId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerCollector
    /// المعرف الفريد لـ CustomerCollector
    /// </summary>
    public CustomerCollectorId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerCollector
    /// CCode الخاص بـ CustomerCollector
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the CustomerCollector
    /// CostCenterCode الخاص بـ CustomerCollector
    /// </summary>
    public string CostCenterCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
