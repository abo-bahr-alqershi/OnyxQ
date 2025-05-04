using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeProfessionLink Identifier Value Object
/// </summary>
public sealed class EmployeeProfessionLinkId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeProfessionLink
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeProfessionLinkId instance
    /// </summary>
    public EmployeeProfessionLinkId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeProfessionLinkId with a new GUID
    /// </summary>
    public static EmployeeProfessionLinkId CreateUnique()
    {
        return new EmployeeProfessionLinkId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeProfessionLinkId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeProfessionLinkId id) => id.Value;
}
}
