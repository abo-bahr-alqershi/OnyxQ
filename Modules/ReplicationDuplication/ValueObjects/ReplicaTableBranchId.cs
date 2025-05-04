using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.ValueObjects
{
/// <summary>
/// ReplicaTableBranch Identifier Value Object
/// </summary>
public sealed class ReplicaTableBranchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReplicaTableBranch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReplicaTableBranchId instance
    /// </summary>
    public ReplicaTableBranchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReplicaTableBranchId with a new GUID
    /// </summary>
    public static ReplicaTableBranchId CreateUnique()
    {
        return new ReplicaTableBranchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReplicaTableBranchId id) => id.Value.ToString();
    public static implicit operator Guid(ReplicaTableBranchId id) => id.Value;
}
}
