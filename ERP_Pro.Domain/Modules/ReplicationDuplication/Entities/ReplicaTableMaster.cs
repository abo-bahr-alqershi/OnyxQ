using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.Entities
{
/// <summary>
/// ReplicaTableMaster Entity
/// </summary>
public class ReplicaTableMaster : Entity<ReplicaTableMasterId>
{

    private ReplicaTableMaster() { }

    public ReplicaTableMaster(ReplicaTableMasterId id, decimal? transactionCode, string centerBranch)
    {
        Id = id;
        TransactionCode = transactionCode;
        CenterBranch = centerBranch;
    }

    /// <summary>
    /// The unique identifier for the ReplicaTableMaster
    /// المعرف الفريد لـ ReplicaTableMaster
    /// </summary>
    public ReplicaTableMasterId Id { get; private set; }

    /// <summary>
    /// TransactionCode of the ReplicaTableMaster
    /// TransactionCode الخاص بـ ReplicaTableMaster
    /// </summary>
    public decimal? TransactionCode { get; private set; }

    /// <summary>
    /// OptionCode of the ReplicaTableMaster
    /// OptionCode الخاص بـ ReplicaTableMaster
    /// </summary>
    public decimal? OptionCode { get; private set; }

    /// <summary>
    /// Flag of the ReplicaTableMaster
    /// Flag الخاص بـ ReplicaTableMaster
    /// </summary>
    public decimal? Flag { get; private set; }

    /// <summary>
    /// CenterBranch of the ReplicaTableMaster
    /// CenterBranch الخاص بـ ReplicaTableMaster
    /// </summary>
    public string CenterBranch { get; private set; }

    /// <summary>
    /// POrder of the ReplicaTableMaster
    /// POrder الخاص بـ ReplicaTableMaster
    /// </summary>
    public decimal? POrder { get; private set; }

    /// <summary>
    /// ReplicaAutoType of the ReplicaTableMaster
    /// ReplicaAutoType الخاص بـ ReplicaTableMaster
    /// </summary>
    public decimal? ReplicaAutoType { get; private set; }

    /// <summary>
    /// ReplicaAutoTime of the ReplicaTableMaster
    /// ReplicaAutoTime الخاص بـ ReplicaTableMaster
    /// </summary>
    public decimal? ReplicaAutoTime { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
