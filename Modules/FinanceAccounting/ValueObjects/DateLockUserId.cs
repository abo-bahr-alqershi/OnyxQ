using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// DateLockUser Identifier Value Object
/// </summary>
public sealed class DateLockUserId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DateLockUser
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DateLockUserId instance
    /// </summary>
    public DateLockUserId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DateLockUserId with a new GUID
    /// </summary>
    public static DateLockUserId CreateUnique()
    {
        return new DateLockUserId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DateLockUserId id) => id.Value.ToString();
    public static implicit operator Guid(DateLockUserId id) => id.Value;
}
}
