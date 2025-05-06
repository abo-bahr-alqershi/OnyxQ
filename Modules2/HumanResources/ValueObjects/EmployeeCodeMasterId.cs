using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeCodeMaster Identifier Value Object
/// </summary>
public sealed class EmployeeCodeMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeCodeMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeCodeMasterId instance
    /// </summary>
    public EmployeeCodeMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeCodeMasterId with a new GUID
    /// </summary>
    public static EmployeeCodeMasterId CreateUnique()
    {
        return new EmployeeCodeMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeCodeMasterId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeCodeMasterId id) => id.Value;
}
}
