using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeImage Identifier Value Object
/// </summary>
public sealed class EmployeeImageId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeImage
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeImageId instance
    /// </summary>
    public EmployeeImageId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeImageId with a new GUID
    /// </summary>
    public static EmployeeImageId CreateUnique()
    {
        return new EmployeeImageId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeImageId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeImageId id) => id.Value;
}
}
