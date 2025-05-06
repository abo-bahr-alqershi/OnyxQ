using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SubCustomerMeasureMaster Entity
/// </summary>
public class SubCustomerMeasureMaster : Entity<SubCustomerMeasureMasterId>
{

    private SubCustomerMeasureMaster() { }

    public SubCustomerMeasureMaster(SubCustomerMeasureMasterId id, string itemCode)
    {
        Id = id;
        ItemCode = itemCode;
    }

    /// <summary>
    /// The unique identifier for the SubCustomerMeasureMaster
    /// المعرف الفريد لـ SubCustomerMeasureMaster
    /// </summary>
    public SubCustomerMeasureMasterId Id { get; private set; }

    /// <summary>
    /// ItemCode of the SubCustomerMeasureMaster
    /// ItemCode الخاص بـ SubCustomerMeasureMaster
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// BatchNumber of the SubCustomerMeasureMaster
    /// BatchNumber الخاص بـ SubCustomerMeasureMaster
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DocSeq of the SubCustomerMeasureMaster
    /// DocSeq الخاص بـ SubCustomerMeasureMaster
    /// </summary>
    public decimal? DocSeq { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public SubCustomer SubCustomer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

