using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.Entities
{
/// <summary>
/// ReplicaTableDetail Entity
/// </summary>
public class ReplicaTableDetail : Entity<ReplicaTableDetailId>
{

    private ReplicaTableDetail() { }

    public ReplicaTableDetail(ReplicaTableDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ReplicaTableDetail
    /// المعرف الفريد لـ ReplicaTableDetail
    /// </summary>
    public ReplicaTableDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the ReplicaTableDetail
    /// RecordNumber الخاص بـ ReplicaTableDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// MovementName of the ReplicaTableDetail
    /// MovementName الخاص بـ ReplicaTableDetail
    /// </summary>
    public string MovementName { get; private set; }

    /// <summary>
    /// RefreshType of the ReplicaTableDetail
    /// RefreshType الخاص بـ ReplicaTableDetail
    /// </summary>
    public string RefreshType { get; private set; }

    /// <summary>
    /// TName of the ReplicaTableDetail
    /// TName الخاص بـ ReplicaTableDetail
    /// </summary>
    public string TName { get; private set; }

    /// <summary>
    /// WhereClause of the ReplicaTableDetail
    /// WhereClause الخاص بـ ReplicaTableDetail
    /// </summary>
    public string WhereClause { get; private set; }

    /// <summary>
    /// PrimaryKeyName of the ReplicaTableDetail
    /// PrimaryKeyName الخاص بـ ReplicaTableDetail
    /// </summary>
    public string PrimaryKeyName { get; private set; }

    /// <summary>
    /// PrimaryKeyField of the ReplicaTableDetail
    /// PrimaryKeyField الخاص بـ ReplicaTableDetail
    /// </summary>
    public string PrimaryKeyField { get; private set; }

    /// <summary>
    /// CenterBranch of the ReplicaTableDetail
    /// CenterBranch الخاص بـ ReplicaTableDetail
    /// </summary>
    public string CenterBranch { get; private set; }

    /// <summary>
    /// FieldDate of the ReplicaTableDetail
    /// FieldDate الخاص بـ ReplicaTableDetail
    /// </summary>
    public string FieldDate { get; private set; }

    /// <summary>
    /// TransactionCode of the ReplicaTableDetail
    /// TransactionCode الخاص بـ ReplicaTableDetail
    /// </summary>
    public decimal? TransactionCode { get; private set; }

    /// <summary>
    /// UsePeriod of the ReplicaTableDetail
    /// UsePeriod الخاص بـ ReplicaTableDetail
    /// </summary>
    public decimal? UsePeriod { get; private set; }

    /// <summary>
    /// WhereDelete of the ReplicaTableDetail
    /// WhereDelete الخاص بـ ReplicaTableDetail
    /// </summary>
    public string WhereDelete { get; private set; }

    /// <summary>
    /// WhereInsert of the ReplicaTableDetail
    /// WhereInsert الخاص بـ ReplicaTableDetail
    /// </summary>
    public string WhereInsert { get; private set; }

    /// <summary>
    /// WhereModify of the ReplicaTableDetail
    /// WhereModify الخاص بـ ReplicaTableDetail
    /// </summary>
    public string WhereModify { get; private set; }

    /// <summary>
    /// UseDelete of the ReplicaTableDetail
    /// UseDelete الخاص بـ ReplicaTableDetail
    /// </summary>
    public decimal? UseDelete { get; private set; }

    /// <summary>
    /// UseMovement of the ReplicaTableDetail
    /// UseMovement الخاص بـ ReplicaTableDetail
    /// </summary>
    public decimal? UseMovement { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
