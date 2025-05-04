using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeMovement Identifier Value Object
/// </summary>
public sealed class EmployeeMovementId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeMovement
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeMovementId instance
    /// </summary>
    public EmployeeMovementId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeMovementId with a new GUID
    /// </summary>
    public static EmployeeMovementId CreateUnique()
    {
        return new EmployeeMovementId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeMovementId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeMovementId id) => id.Value;
}
}
