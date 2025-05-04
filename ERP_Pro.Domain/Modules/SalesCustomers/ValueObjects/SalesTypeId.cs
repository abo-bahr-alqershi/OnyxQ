using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesType Identifier Value Object
/// </summary>
public sealed class SalesTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesTypeId instance
    /// </summary>
    public SalesTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesTypeId with a new GUID
    /// </summary>
    public static SalesTypeId CreateUnique()
    {
        return new SalesTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesTypeId id) => id.Value.ToString();
    public static implicit operator Guid(SalesTypeId id) => id.Value;
}
}
