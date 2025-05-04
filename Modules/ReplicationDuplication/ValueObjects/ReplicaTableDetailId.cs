using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.ValueObjects
{
/// <summary>
/// ReplicaTableDetail Identifier Value Object
/// </summary>
public sealed class ReplicaTableDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReplicaTableDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReplicaTableDetailId instance
    /// </summary>
    public ReplicaTableDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReplicaTableDetailId with a new GUID
    /// </summary>
    public static ReplicaTableDetailId CreateUnique()
    {
        return new ReplicaTableDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReplicaTableDetailId id) => id.Value.ToString();
    public static implicit operator Guid(ReplicaTableDetailId id) => id.Value;
}
}
