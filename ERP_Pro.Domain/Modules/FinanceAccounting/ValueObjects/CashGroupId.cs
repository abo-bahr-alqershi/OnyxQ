using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CashGroup Identifier Value Object
/// </summary>
public sealed class CashGroupId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashGroup
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashGroupId instance
    /// </summary>
    public CashGroupId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashGroupId with a new GUID
    /// </summary>
    public static CashGroupId CreateUnique()
    {
        return new CashGroupId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashGroupId id) => id.Value.ToString();
    public static implicit operator Guid(CashGroupId id) => id.Value;
}
}
