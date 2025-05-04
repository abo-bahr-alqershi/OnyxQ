using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// OutgoingMaster Identifier Value Object
/// </summary>
public sealed class OutgoingMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingMasterId instance
    /// </summary>
    public OutgoingMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingMasterId with a new GUID
    /// </summary>
    public static OutgoingMasterId CreateUnique()
    {
        return new OutgoingMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingMasterId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingMasterId id) => id.Value;
}
}
