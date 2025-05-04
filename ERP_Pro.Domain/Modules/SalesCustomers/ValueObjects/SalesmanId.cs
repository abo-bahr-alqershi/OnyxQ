using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// Salesman Identifier Value Object
/// </summary>
public sealed class SalesmanId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Salesman
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanId instance
    /// </summary>
    public SalesmanId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanId with a new GUID
    /// </summary>
    public static SalesmanId CreateUnique()
    {
        return new SalesmanId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanId id) => id.Value;
}
}
