using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// HierarchyType Entity
/// </summary>
public class HierarchyType : Entity<HierarchyTypeId>
{
    private HierarchyType() { }

    /// <summary>
    /// The unique identifier for the HierarchyType
    /// المعرف الفريد لـ HierarchyType
    /// </summary>
    public HierarchyTypeId Id { get; private set; }

    /// <summary>
    /// TypeNumberShort of the HierarchyType
    /// TypeNumberShort الخاص بـ HierarchyType
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// TypeLastNameShort of the HierarchyType
    /// TypeLastNameShort الخاص بـ HierarchyType
    /// </summary>
    public string TypeLastNameShort { get; private set; }

    /// <summary>
    /// TypeFirstNameShort of the HierarchyType
    /// TypeFirstNameShort الخاص بـ HierarchyType
    /// </summary>
    public string TypeFirstNameShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: HierarchyType to Hierarchy
    /// </summary>
    public IReadOnlyCollection<Hierarchy> Hierarchies { get; private set; }
    #endregion
}
}
