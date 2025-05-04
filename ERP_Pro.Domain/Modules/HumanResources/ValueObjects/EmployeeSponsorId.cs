using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeSponsor Identifier Value Object
/// </summary>
public sealed class EmployeeSponsorId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeSponsor
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeSponsorId instance
    /// </summary>
    public EmployeeSponsorId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeSponsorId with a new GUID
    /// </summary>
    public static EmployeeSponsorId CreateUnique()
    {
        return new EmployeeSponsorId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeSponsorId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeSponsorId id) => id.Value;
}
}
