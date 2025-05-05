using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerClass Entity
/// </summary>
public class CustomerClass : Entity<CustomerClassId>
{

    private CustomerClass() { }

    public CustomerClass(CustomerClassId id, decimal? cClass)
    {
        Id = id;
        CClass = cClass;
    }

    /// <summary>
    /// The unique identifier for the CustomerClass
    /// المعرف الفريد لـ CustomerClass
    /// </summary>
    public CustomerClassId Id { get; private set; }

    /// <summary>
    /// CClass of the CustomerClass
    /// CClass الخاص بـ CustomerClass
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CClassName of the CustomerClass
    /// CClassName الخاص بـ CustomerClass
    /// </summary>
    public string CClassName { get; private set; }

    /// <summary>
    /// CClassEName of the CustomerClass
    /// CClassEName الخاص بـ CustomerClass
    /// </summary>
    public string CClassEName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

