using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerDevices Entity
/// </summary>
public class CustomerDevices : Entity<CustomerDevicesId>
{

    private CustomerDevices() { }

    public CustomerDevices(CustomerDevicesId id, string dvcCode)
    {
        Id = id;
        DvcCode = dvcCode;
    }

    /// <summary>
    /// The unique identifier for the CustomerDevices
    /// المعرف الفريد لـ CustomerDevices
    /// </summary>
    public CustomerDevicesId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the CustomerDevices
    /// RecordNumber الخاص بـ CustomerDevices
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DvcCode of the CustomerDevices
    /// DvcCode الخاص بـ CustomerDevices
    /// </summary>
    public string DvcCode { get; private set; }

    /// <summary>
    /// DvcTyp of the CustomerDevices
    /// DvcTyp الخاص بـ CustomerDevices
    /// </summary>
    public decimal? DvcTyp { get; private set; }

    /// <summary>
    /// DvcDsc of the CustomerDevices
    /// DvcDsc الخاص بـ CustomerDevices
    /// </summary>
    public string DvcDsc { get; private set; }

    /// <summary>
    /// InactiveFlag of the CustomerDevices
    /// InactiveFlag الخاص بـ CustomerDevices
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the CustomerDevices
    /// InactiveDate الخاص بـ CustomerDevices
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the CustomerDevices
    /// InactiveReason الخاص بـ CustomerDevices
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

