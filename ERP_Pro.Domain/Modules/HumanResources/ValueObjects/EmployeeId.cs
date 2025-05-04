using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// Employee Identifier Value Object
/// </summary>
public sealed class EmployeeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the Employee
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeId instance
    /// </summary>
    public EmployeeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeId with a new GUID
    /// </summary>
    public static EmployeeId CreateUnique()
    {
        return new EmployeeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeId id) => id.Value;
}
}
