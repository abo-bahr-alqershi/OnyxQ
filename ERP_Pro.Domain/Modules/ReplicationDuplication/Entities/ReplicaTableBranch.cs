using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.Entities
{
/// <summary>
/// ReplicaTableBranch Entity
/// </summary>
public class ReplicaTableBranch : Entity<ReplicaTableBranchId>
{

    private ReplicaTableBranch() { }

    public ReplicaTableBranch(ReplicaTableBranchId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ReplicaTableBranch
    /// المعرف الفريد لـ ReplicaTableBranch
    /// </summary>
    public ReplicaTableBranchId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the ReplicaTableBranch
    /// RecordNumber الخاص بـ ReplicaTableBranch
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// MovementName of the ReplicaTableBranch
    /// MovementName الخاص بـ ReplicaTableBranch
    /// </summary>
    public string MovementName { get; private set; }

    /// <summary>
    /// TName of the ReplicaTableBranch
    /// TName الخاص بـ ReplicaTableBranch
    /// </summary>
    public string TName { get; private set; }

    /// <summary>
    /// CenterBranch of the ReplicaTableBranch
    /// CenterBranch الخاص بـ ReplicaTableBranch
    /// </summary>
    public string CenterBranch { get; private set; }

    /// <summary>
    /// BranchNumber of the ReplicaTableBranch
    /// BranchNumber الخاص بـ ReplicaTableBranch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// LastUpdateDate of the ReplicaTableBranch
    /// LastUpdateDate الخاص بـ ReplicaTableBranch
    /// </summary>
    public DateTime? LastUpdateDate { get; private set; }

    /// <summary>
    /// TransactionCode of the ReplicaTableBranch
    /// TransactionCode الخاص بـ ReplicaTableBranch
    /// </summary>
    public decimal? TransactionCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
