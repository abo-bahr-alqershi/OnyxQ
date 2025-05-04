using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.Activities.Entities
{
/// <summary>
/// ActivitySerialNumberMaster Entity
/// </summary>
public class ActivitySerialNumberMaster : Entity<ActivitySerialNumberMasterId>
{

    private ActivitySerialNumberMaster() { }

    public ActivitySerialNumberMaster(ActivitySerialNumberMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the ActivitySerialNumberMaster
    /// المعرف الفريد لـ ActivitySerialNumberMaster
    /// </summary>
    public ActivitySerialNumberMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the ActivitySerialNumberMaster
    /// DocNo الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ActivitySerialNumberMaster
    /// DocSer الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the ActivitySerialNumberMaster
    /// DocDate الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc of the ActivitySerialNumberMaster
    /// DocDesc الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ActivitySerialNumberMaster
    /// ReferenceNumber الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ActivitySerialNumberMaster
    /// CompanyNumberShort الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ActivitySerialNumberMaster
    /// BranchNumber الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ActivitySerialNumberMaster
    /// BranchYear الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ActivitySerialNumberMaster
    /// BranchUser الخاص بـ ActivitySerialNumberMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
