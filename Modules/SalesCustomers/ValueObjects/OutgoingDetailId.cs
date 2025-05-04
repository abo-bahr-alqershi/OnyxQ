using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// OutgoingDetail Identifier Value Object
/// </summary>
public sealed class OutgoingDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingDetailId instance
    /// </summary>
    public OutgoingDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingDetailId with a new GUID
    /// </summary>
    public static OutgoingDetailId CreateUnique()
    {
        return new OutgoingDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingDetailId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingDetailId id) => id.Value;
}
}
