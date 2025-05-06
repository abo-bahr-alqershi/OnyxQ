using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerMeasureDetail Identifier Value Object
/// </summary>
public sealed class CustomerMeasureDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerMeasureDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerMeasureDetailId instance
    /// </summary>
    public CustomerMeasureDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerMeasureDetailId with a new GUID
    /// </summary>
    public static CustomerMeasureDetailId CreateUnique()
    {
        return new CustomerMeasureDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerMeasureDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerMeasureDetailId id) => id.Value;
}
}
