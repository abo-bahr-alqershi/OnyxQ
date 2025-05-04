using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SalesmanItemActivity Identifier Value Object
/// </summary>
public sealed class SalesmanItemActivityId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SalesmanItemActivity
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SalesmanItemActivityId instance
    /// </summary>
    public SalesmanItemActivityId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SalesmanItemActivityId with a new GUID
    /// </summary>
    public static SalesmanItemActivityId CreateUnique()
    {
        return new SalesmanItemActivityId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SalesmanItemActivityId id) => id.Value.ToString();
    public static implicit operator Guid(SalesmanItemActivityId id) => id.Value;
}
}
