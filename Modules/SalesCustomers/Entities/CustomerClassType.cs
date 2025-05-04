using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerClassType Entity
/// </summary>
public class CustomerClassType : Entity<CustomerClassTypeId>
{
    private CustomerClassType() { }

    /// <summary>
    /// The unique identifier for the CustomerClassType
    /// المعرف الفريد لـ CustomerClassType
    /// </summary>
    public CustomerClassTypeId Id { get; private set; }

    /// <summary>
    /// CClassTyp of the CustomerClassType
    /// CClassTyp الخاص بـ CustomerClassType
    /// </summary>
    public decimal? CClassTyp { get; private set; }

    /// <summary>
    /// CClassTypNm of the CustomerClassType
    /// CClassTypNm الخاص بـ CustomerClassType
    /// </summary>
    public string CClassTypNm { get; private set; }

    /// <summary>
    /// CClassTypFNm of the CustomerClassType
    /// CClassTypFNm الخاص بـ CustomerClassType
    /// </summary>
    public string CClassTypFNm { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CustomerClassType to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    #endregion
}
}
