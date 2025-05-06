using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// DedicatedScreenDetail Identifier Value Object
/// </summary>
public sealed class DedicatedScreenDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DedicatedScreenDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DedicatedScreenDetailId instance
    /// </summary>
    public DedicatedScreenDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DedicatedScreenDetailId with a new GUID
    /// </summary>
    public static DedicatedScreenDetailId CreateUnique()
    {
        return new DedicatedScreenDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DedicatedScreenDetailId id) => id.Value.ToString();
    public static implicit operator Guid(DedicatedScreenDetailId id) => id.Value;
}
}
