using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerLocation Entity
/// </summary>
public class CustomerLocation : Entity<CustomerLocationId>
{
    private CustomerLocation() { }

    /// <summary>
    /// The unique identifier for the CustomerLocation
    /// المعرف الفريد لـ CustomerLocation
    /// </summary>
    public CustomerLocationId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerLocation
    /// CCode الخاص بـ CustomerLocation
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// LocationNumber of the CustomerLocation
    /// LocationNumber الخاص بـ CustomerLocation
    /// </summary>
    public decimal? LocationNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerLocation
    /// BranchNumber الخاص بـ CustomerLocation
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerLocation
    /// BranchYear الخاص بـ CustomerLocation
    /// </summary>
    public decimal? BranchYear { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
