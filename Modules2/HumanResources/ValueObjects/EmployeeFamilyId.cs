using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeFamily Identifier Value Object
/// </summary>
public sealed class EmployeeFamilyId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeFamily
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeFamilyId instance
    /// </summary>
    public EmployeeFamilyId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeFamilyId with a new GUID
    /// </summary>
    public static EmployeeFamilyId CreateUnique()
    {
        return new EmployeeFamilyId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeFamilyId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeFamilyId id) => id.Value;
}
}
