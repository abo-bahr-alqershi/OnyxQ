using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CollectionPlan Entity
/// </summary>
public class CollectionPlan : Entity<CollectionPlanId>
{
    private readonly List<PeriodDetail> _periodDetail = new List<PeriodDetail>();
    private readonly List<Collector> _collector = new List<Collector>();
    private readonly List<Customer> _customer = new List<Customer>();

    private CollectionPlan() { }

    public CollectionPlan(CollectionPlanId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CollectionPlan
    /// المعرف الفريد لـ CollectionPlan
    /// </summary>
    public CollectionPlanId Id { get; private set; }

    /// <summary>
    /// ColumnDate of the CollectionPlan
    /// ColumnDate الخاص بـ CollectionPlan
    /// </summary>
    public DateTime? ColumnDate { get; private set; }

    /// <summary>
    /// CBalAmt of the CollectionPlan
    /// CBalAmt الخاص بـ CollectionPlan
    /// </summary>
    public decimal? CBalAmt { get; private set; }

    /// <summary>
    /// TargetPercent of the CollectionPlan
    /// TargetPercent الخاص بـ CollectionPlan
    /// </summary>
    public decimal? TargetPercent { get; private set; }

    /// <summary>
    /// TargetAmount of the CollectionPlan
    /// TargetAmount الخاص بـ CollectionPlan
    /// </summary>
    public decimal? TargetAmount { get; private set; }

    /// <summary>
    /// ColumnDescription of the CollectionPlan
    /// ColumnDescription الخاص بـ CollectionPlan
    /// </summary>
    public string ColumnDescription { get; private set; }

    /// <summary>
    /// PlanPeriodType of the CollectionPlan
    /// PlanPeriodType الخاص بـ CollectionPlan
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// PlanNumber of the CollectionPlan
    /// PlanNumber الخاص بـ CollectionPlan
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanSerial of the CollectionPlan
    /// PlanSerial الخاص بـ CollectionPlan
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    /// <summary>
    /// FDate of the CollectionPlan
    /// FDate الخاص بـ CollectionPlan
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CollectionPlan
    /// TDate الخاص بـ CollectionPlan
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CollectionPlan
    /// CompanyNumberShort الخاص بـ CollectionPlan
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CollectionPlan
    /// BranchNumber الخاص بـ CollectionPlan
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CollectionPlan
    /// BranchYear الخاص بـ CollectionPlan
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CollectionPlan
    /// BranchUser الخاص بـ CollectionPlan
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<PeriodDetail> PeriodDetail => _periodDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Collector> Collector => _collector;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
