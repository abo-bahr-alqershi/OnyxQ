using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeHandheldDevice Identifier Value Object
/// </summary>
public sealed class EmployeeHandheldDeviceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeHandheldDevice
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeHandheldDeviceId instance
    /// </summary>
    public EmployeeHandheldDeviceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeHandheldDeviceId with a new GUID
    /// </summary>
    public static EmployeeHandheldDeviceId CreateUnique()
    {
        return new EmployeeHandheldDeviceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeHandheldDeviceId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeHandheldDeviceId id) => id.Value;
}
}
