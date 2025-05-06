using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerMeasureMaster Entity
/// </summary>
public class CustomerMeasureMaster : Entity<CustomerMeasureMasterId>
{

    private CustomerMeasureMaster() { }

    public CustomerMeasureMaster(CustomerMeasureMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the CustomerMeasureMaster
    /// المعرف الفريد لـ CustomerMeasureMaster
    /// </summary>
    public CustomerMeasureMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the CustomerMeasureMaster
    /// DocNo الخاص بـ CustomerMeasureMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CustomerMeasureMaster
    /// DocSer الخاص بـ CustomerMeasureMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the CustomerMeasureMaster
    /// DocDate الخاص بـ CustomerMeasureMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CustomerMeasureMaster
    /// CompanyNumberShort الخاص بـ CustomerMeasureMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerMeasureMaster
    /// BranchNumber الخاص بـ CustomerMeasureMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerMeasureMaster
    /// BranchYear الخاص بـ CustomerMeasureMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CustomerMeasureMaster
    /// BranchUser الخاص بـ CustomerMeasureMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// UpdateCustomer of the CustomerMeasureMaster
    /// UpdateCustomer الخاص بـ CustomerMeasureMaster
    /// </summary>
    public decimal? UpdateCustomer { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

