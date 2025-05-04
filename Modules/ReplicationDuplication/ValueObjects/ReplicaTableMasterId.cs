using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ReplicationDuplication.ValueObjects
{
/// <summary>
/// ReplicaTableMaster Identifier Value Object
/// </summary>
public sealed class ReplicaTableMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReplicaTableMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReplicaTableMasterId instance
    /// </summary>
    public ReplicaTableMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReplicaTableMasterId with a new GUID
    /// </summary>
    public static ReplicaTableMasterId CreateUnique()
    {
        return new ReplicaTableMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReplicaTableMasterId id) => id.Value.ToString();
    public static implicit operator Guid(ReplicaTableMasterId id) => id.Value;
}
}
