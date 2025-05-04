using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// Hierarchy Entity
/// </summary>
public class Hierarchy : Entity<HierarchyId>
{
    private Hierarchy() { }

    /// <summary>
    /// The unique identifier for the Hierarchy
    /// المعرف الفريد لـ Hierarchy
    /// </summary>
    public HierarchyId Id { get; private set; }

    /// <summary>
    /// HierarchyNumber of the Hierarchy
    /// HierarchyNumber الخاص بـ Hierarchy
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// HierarchyLastName of the Hierarchy
    /// HierarchyLastName الخاص بـ Hierarchy
    /// </summary>
    public string HierarchyLastName { get; private set; }

    /// <summary>
    /// HierarchyFirstName of the Hierarchy
    /// HierarchyFirstName الخاص بـ Hierarchy
    /// </summary>
    public string HierarchyFirstName { get; private set; }

    /// <summary>
    /// HierarchyParent of the Hierarchy
    /// HierarchyParent الخاص بـ Hierarchy
    /// </summary>
    public decimal? HierarchyParent { get; private set; }

    /// <summary>
    /// LevelNumber of the Hierarchy
    /// LevelNumber الخاص بـ Hierarchy
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// TypeNumberShort of the Hierarchy
    /// TypeNumberShort الخاص بـ Hierarchy
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// EvaluationType of the Hierarchy
    /// EvaluationType الخاص بـ Hierarchy
    /// </summary>
    public decimal? EvaluationType { get; private set; }

    /// <summary>
    /// InactiveFlag of the Hierarchy
    /// InactiveFlag الخاص بـ Hierarchy
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the Hierarchy
    /// InactiveReason الخاص بـ Hierarchy
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Hierarchy
    /// InactivatedByUserId الخاص بـ Hierarchy
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Hierarchy
    /// InactiveDate الخاص بـ Hierarchy
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// HierarchyCode of the Hierarchy
    /// HierarchyCode الخاص بـ Hierarchy
    /// </summary>
    public string HierarchyCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to HierarchyType
    /// </summary>
    public HierarchyType HierarchyType { get; private set; }
    /// <summary>
    /// One-to-many relationship: Hierarchy to Employee
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; private set; }
    #endregion
}
}
