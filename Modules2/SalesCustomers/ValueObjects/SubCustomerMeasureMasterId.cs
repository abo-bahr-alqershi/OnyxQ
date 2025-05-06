using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// SubCustomerMeasureMaster Identifier Value Object
/// </summary>
public sealed class SubCustomerMeasureMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the SubCustomerMeasureMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new SubCustomerMeasureMasterId instance
    /// </summary>
    public SubCustomerMeasureMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new SubCustomerMeasureMasterId with a new GUID
    /// </summary>
    public static SubCustomerMeasureMasterId CreateUnique()
    {
        return new SubCustomerMeasureMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(SubCustomerMeasureMasterId id) => id.Value.ToString();
    public static implicit operator Guid(SubCustomerMeasureMasterId id) => id.Value;
}
}
