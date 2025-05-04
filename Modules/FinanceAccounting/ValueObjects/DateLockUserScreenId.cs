using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// DateLockUserScreen Identifier Value Object
/// </summary>
public sealed class DateLockUserScreenId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DateLockUserScreen
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DateLockUserScreenId instance
    /// </summary>
    public DateLockUserScreenId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DateLockUserScreenId with a new GUID
    /// </summary>
    public static DateLockUserScreenId CreateUnique()
    {
        return new DateLockUserScreenId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DateLockUserScreenId id) => id.Value.ToString();
    public static implicit operator Guid(DateLockUserScreenId id) => id.Value;
}
}
