using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// CustomerMeasureMaster Identifier Value Object
/// </summary>
public sealed class CustomerMeasureMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CustomerMeasureMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CustomerMeasureMasterId instance
    /// </summary>
    public CustomerMeasureMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CustomerMeasureMasterId with a new GUID
    /// </summary>
    public static CustomerMeasureMasterId CreateUnique()
    {
        return new CustomerMeasureMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CustomerMeasureMasterId id) => id.Value.ToString();
    public static implicit operator Guid(CustomerMeasureMasterId id) => id.Value;
}
}
