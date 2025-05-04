using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerDegree Identifier Value Object
/// </summary>
public sealed class CustomerDegreeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerDegree
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerDegreeId instance
    /// </summary>
    public CustomerDegreeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerDegreeId with a new GUID
    /// </summary>
    public static CustomerDegreeId CreateUnique()
    {
        return new CustomerDegreeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerDegreeId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerDegreeId id) => id.Value;
}
}
