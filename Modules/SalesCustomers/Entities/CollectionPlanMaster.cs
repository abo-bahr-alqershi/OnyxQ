using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CollectionPlanMaster Entity
/// </summary>
public class CollectionPlanMaster : Entity<CollectionPlanMasterId>
{
    private CollectionPlanMaster() { }

    /// <summary>
    /// The unique identifier for the CollectionPlanMaster
    /// المعرف الفريد لـ CollectionPlanMaster
    /// </summary>
    public CollectionPlanMasterId Id { get; private set; }

    /// <summary>
    /// PlanPeriodType of the CollectionPlanMaster
    /// PlanPeriodType الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// PlanNumber of the CollectionPlanMaster
    /// PlanNumber الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanSerial of the CollectionPlanMaster
    /// PlanSerial الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CollectionPlanMaster
    /// ColumnNumberShort الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// ColumnDescription of the CollectionPlanMaster
    /// ColumnDescription الخاص بـ CollectionPlanMaster
    /// </summary>
    public string ColumnDescription { get; private set; }

    /// <summary>
    /// AccountCurrency of the CollectionPlanMaster
    /// AccountCurrency الخاص بـ CollectionPlanMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// FDate of the CollectionPlanMaster
    /// FDate الخاص بـ CollectionPlanMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CollectionPlanMaster
    /// TDate الخاص بـ CollectionPlanMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CollectionPlanMaster
    /// CompanyNumberShort الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CollectionPlanMaster
    /// BranchNumber الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CollectionPlanMaster
    /// BranchYear الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CollectionPlanMaster
    /// BranchUser الخاص بـ CollectionPlanMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
