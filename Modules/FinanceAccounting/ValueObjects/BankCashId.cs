using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// BankCash Identifier Value Object
/// </summary>
public sealed class BankCashId : ValueObject
{
    /// <summary>
    /// The unique identifier for the BankCash
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new BankCashId instance
    /// </summary>
    public BankCashId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new BankCashId with a new GUID
    /// </summary>
    public static BankCashId CreateUnique()
    {
        return new BankCashId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(BankCashId id) => id.Value.ToString();
    public static implicit operator Guid(BankCashId id) => id.Value;
}
}
