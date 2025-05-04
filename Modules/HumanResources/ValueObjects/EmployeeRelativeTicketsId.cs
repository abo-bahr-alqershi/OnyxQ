using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeRelativeTickets Identifier Value Object
/// </summary>
public sealed class EmployeeRelativeTicketsId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeRelativeTickets
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeRelativeTicketsId instance
    /// </summary>
    public EmployeeRelativeTicketsId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeRelativeTicketsId with a new GUID
    /// </summary>
    public static EmployeeRelativeTicketsId CreateUnique()
    {
        return new EmployeeRelativeTicketsId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeRelativeTicketsId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeRelativeTicketsId id) => id.Value;
}
}
