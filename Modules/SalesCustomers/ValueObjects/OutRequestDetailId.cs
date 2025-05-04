using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// OutRequestDetail Identifier Value Object
/// </summary>
public sealed class OutRequestDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutRequestDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutRequestDetailId instance
    /// </summary>
    public OutRequestDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutRequestDetailId with a new GUID
    /// </summary>
    public static OutRequestDetailId CreateUnique()
    {
        return new OutRequestDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutRequestDetailId id) => id.Value.ToString();
    public static implicit operator Guid(OutRequestDetailId id) => id.Value;
}
}
