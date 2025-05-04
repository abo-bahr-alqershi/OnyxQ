using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.HumanResources.ValueObjects
{
/// <summary>
/// EmployeeHolidayBalance Identifier Value Object
/// </summary>
public sealed class EmployeeHolidayBalanceId : ValueObject
{
    /// <summary>
    /// The unique identifier for the EmployeeHolidayBalance
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new EmployeeHolidayBalanceId instance
    /// </summary>
    public EmployeeHolidayBalanceId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new EmployeeHolidayBalanceId with a new GUID
    /// </summary>
    public static EmployeeHolidayBalanceId CreateUnique()
    {
        return new EmployeeHolidayBalanceId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(EmployeeHolidayBalanceId id) => id.Value.ToString();
    public static implicit operator Guid(EmployeeHolidayBalanceId id) => id.Value;
}
}
