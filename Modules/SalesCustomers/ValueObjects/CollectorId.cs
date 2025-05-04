using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// Collector Identifier Value Object
/// </summary>
public sealed class CollectorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Collector
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CollectorId instance
    /// </summary>
    public CollectorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CollectorId with a new GUID
    /// </summary>
    public static CollectorId CreateUnique()
    {
        return new CollectorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CollectorId id) => id.Value.ToString();
    public static implicit operator Guid(CollectorId id) => id.Value;
}
}
