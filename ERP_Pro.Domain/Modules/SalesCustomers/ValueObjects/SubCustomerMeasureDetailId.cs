using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SubCustomerMeasureDetail Identifier Value Object
/// </summary>
public sealed class SubCustomerMeasureDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SubCustomerMeasureDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SubCustomerMeasureDetailId instance
    /// </summary>
    public SubCustomerMeasureDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SubCustomerMeasureDetailId with a new GUID
    /// </summary>
    public static SubCustomerMeasureDetailId CreateUnique()
    {
        return new SubCustomerMeasureDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SubCustomerMeasureDetailId id) => id.Value.ToString();
    public static implicit operator Guid(SubCustomerMeasureDetailId id) => id.Value;
}
}
