using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CashAtBankDetail Identifier Value Object
/// </summary>
public sealed class CashAtBankDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashAtBankDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashAtBankDetailId instance
    /// </summary>
    public CashAtBankDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashAtBankDetailId with a new GUID
    /// </summary>
    public static CashAtBankDetailId CreateUnique()
    {
        return new CashAtBankDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashAtBankDetailId id) => id.Value.ToString();
    public static implicit operator Guid(CashAtBankDetailId id) => id.Value;
}
}
