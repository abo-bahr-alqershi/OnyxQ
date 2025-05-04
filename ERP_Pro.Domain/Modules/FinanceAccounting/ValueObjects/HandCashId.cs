using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// HandCash Identifier Value Object
/// </summary>
public sealed class HandCashId : ValueObject
{
    /// <summary>
    /// The unique identifier for the HandCash
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new HandCashId instance
    /// </summary>
    public HandCashId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new HandCashId with a new GUID
    /// </summary>
    public static HandCashId CreateUnique()
    {
        return new HandCashId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(HandCashId id) => id.Value.ToString();
    public static implicit operator Guid(HandCashId id) => id.Value;
}
}
