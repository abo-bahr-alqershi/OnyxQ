using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects
{
/// <summary>
/// DateLock Identifier Value Object
/// </summary>
public sealed class DateLockId : ValueObject
{
    /// <summary>
    /// The unique identifier for the DateLock
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new DateLockId instance
    /// </summary>
    public DateLockId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new DateLockId with a new GUID
    /// </summary>
    public static DateLockId CreateUnique()
    {
        return new DateLockId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(DateLockId id) => id.Value.ToString();
    public static implicit operator Guid(DateLockId id) => id.Value;
}
}
