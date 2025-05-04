using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// BranchGroup Entity
/// </summary>
public class BranchGroup : Entity<BranchGroupId>
{
    private BranchGroup() { }

    /// <summary>
    /// The unique identifier for the BranchGroup
    /// المعرف الفريد لـ BranchGroup
    /// </summary>
    public BranchGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumberShort of the BranchGroup
    /// GroupNumberShort الخاص بـ BranchGroup
    /// </summary>
    public decimal? GroupNumberShort { get; private set; }

    /// <summary>
    /// GroupLastNameShort of the BranchGroup
    /// GroupLastNameShort الخاص بـ BranchGroup
    /// </summary>
    public string GroupLastNameShort { get; private set; }

    /// <summary>
    /// GroupFirstNameShort of the BranchGroup
    /// GroupFirstNameShort الخاص بـ BranchGroup
    /// </summary>
    public string GroupFirstNameShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: BranchGroup to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    #endregion
}
}
