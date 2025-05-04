using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeProfession Identifier Value Object
/// </summary>
public sealed class EmployeeProfessionId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeProfession
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeProfessionId instance
    /// </summary>
    public EmployeeProfessionId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeProfessionId with a new GUID
    /// </summary>
    public static EmployeeProfessionId CreateUnique()
    {
        return new EmployeeProfessionId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeProfessionId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeProfessionId id) => id.Value;
}
}
