using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanType Identifier Value Object
/// </summary>
public sealed class SalesmanTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanTypeId instance
    /// </summary>
    public SalesmanTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanTypeId with a new GUID
    /// </summary>
    public static SalesmanTypeId CreateUnique()
    {
        return new SalesmanTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanTypeId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanTypeId id) => id.Value;
}
}
