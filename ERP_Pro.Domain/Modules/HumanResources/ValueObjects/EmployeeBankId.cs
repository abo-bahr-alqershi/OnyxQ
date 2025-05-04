using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeBank Identifier Value Object
/// </summary>
public sealed class EmployeeBankId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeBank
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeBankId instance
    /// </summary>
    public EmployeeBankId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeBankId with a new GUID
    /// </summary>
    public static EmployeeBankId CreateUnique()
    {
        return new EmployeeBankId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeBankId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeBankId id) => id.Value;
}
}
