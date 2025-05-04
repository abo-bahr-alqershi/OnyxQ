using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeCodeDetail Identifier Value Object
/// </summary>
public sealed class EmployeeCodeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeCodeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeCodeDetailId instance
    /// </summary>
    public EmployeeCodeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeCodeDetailId with a new GUID
    /// </summary>
    public static EmployeeCodeDetailId CreateUnique()
    {
        return new EmployeeCodeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeCodeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeCodeDetailId id) => id.Value;
}
}
