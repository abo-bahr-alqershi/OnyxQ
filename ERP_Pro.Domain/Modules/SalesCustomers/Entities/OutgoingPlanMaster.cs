using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// OutgoingPlanMaster Entity
/// </summary>
public class OutgoingPlanMaster : AggregateRoot<OutgoingPlanMasterId>
{

    private OutgoingPlanMaster() { }

    public OutgoingPlanMaster(OutgoingPlanMasterId id, decimal? planSerial)
    {
        Id = id;
        PlanSerial = planSerial;
    }

    /// <summary>
    /// The unique identifier for the OutgoingPlanMaster
    /// المعرف الفريد لـ OutgoingPlanMaster
    /// </summary>
    public OutgoingPlanMasterId Id { get; private set; }

    /// <summary>
    /// PlanSerial of the OutgoingPlanMaster
    /// PlanSerial الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    /// <summary>
    /// PlanNumber of the OutgoingPlanMaster
    /// PlanNumber الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanType of the OutgoingPlanMaster
    /// PlanType الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? PlanType { get; private set; }

    /// <summary>
    /// PlanPeriodType of the OutgoingPlanMaster
    /// PlanPeriodType الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// ReferenceNumber of the OutgoingPlanMaster
    /// ReferenceNumber الخاص بـ OutgoingPlanMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// PlanDescription of the OutgoingPlanMaster
    /// PlanDescription الخاص بـ OutgoingPlanMaster
    /// </summary>
    public string PlanDescription { get; private set; }

    /// <summary>
    /// BranchNumber of the OutgoingPlanMaster
    /// BranchNumber الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutgoingPlanMaster
    /// BranchYear الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutgoingPlanMaster
    /// CompanyNumberShort الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the OutgoingPlanMaster
    /// BranchUser الخاص بـ OutgoingPlanMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

