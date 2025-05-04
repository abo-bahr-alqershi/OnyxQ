using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TransportationShipping.ValueObjects
{
/// <summary>
/// FreightDetail Identifier Value Object
/// </summary>
public sealed class FreightDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the FreightDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new FreightDetailId instance
    /// </summary>
    public FreightDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new FreightDetailId with a new GUID
    /// </summary>
    public static FreightDetailId CreateUnique()
    {
        return new FreightDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(FreightDetailId id) => id.Value.ToString();
    public static implicit operator Guid(FreightDetailId id) => id.Value;
}
}
