using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerMeasure Identifier Value Object
/// </summary>
public sealed class CustomerMeasureId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerMeasure
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerMeasureId instance
    /// </summary>
    public CustomerMeasureId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerMeasureId with a new GUID
    /// </summary>
    public static CustomerMeasureId CreateUnique()
    {
        return new CustomerMeasureId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerMeasureId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerMeasureId id) => id.Value;
}
}
