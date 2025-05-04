using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// OutgoingType Identifier Value Object
/// </summary>
public sealed class OutgoingTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the OutgoingType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new OutgoingTypeId instance
    /// </summary>
    public OutgoingTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new OutgoingTypeId with a new GUID
    /// </summary>
    public static OutgoingTypeId CreateUnique()
    {
        return new OutgoingTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(OutgoingTypeId id) => id.Value.ToString();
    public static implicit operator Guid(OutgoingTypeId id) => id.Value;
}
}
