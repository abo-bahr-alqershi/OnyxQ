using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerDegree Entity
/// </summary>
public class CustomerDegree : Entity<CustomerDegreeId>
{

    private CustomerDegree() { }

    public CustomerDegree(CustomerDegreeId id, decimal? cDegree)
    {
        Id = id;
        CDegree = cDegree;
    }

    /// <summary>
    /// The unique identifier for the CustomerDegree
    /// المعرف الفريد لـ CustomerDegree
    /// </summary>
    public CustomerDegreeId Id { get; private set; }

    /// <summary>
    /// CDegree of the CustomerDegree
    /// CDegree الخاص بـ CustomerDegree
    /// </summary>
    public decimal? CDegree { get; private set; }

    /// <summary>
    /// CDegreeAName of the CustomerDegree
    /// CDegreeAName الخاص بـ CustomerDegree
    /// </summary>
    public string CDegreeAName { get; private set; }

    /// <summary>
    /// CDegreeEName of the CustomerDegree
    /// CDegreeEName الخاص بـ CustomerDegree
    /// </summary>
    public string CDegreeEName { get; private set; }

    /// <summary>
    /// DegreeValue of the CustomerDegree
    /// DegreeValue الخاص بـ CustomerDegree
    /// </summary>
    public decimal? DegreeValue { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

