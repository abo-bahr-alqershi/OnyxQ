using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// CashAtBankBranch Identifier Value Object
/// </summary>
public sealed class CashAtBankBranchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the CashAtBankBranch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new CashAtBankBranchId instance
    /// </summary>
    public CashAtBankBranchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new CashAtBankBranchId with a new GUID
    /// </summary>
    public static CashAtBankBranchId CreateUnique()
    {
        return new CashAtBankBranchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(CashAtBankBranchId id) => id.Value.ToString();
    public static implicit operator Guid(CashAtBankBranchId id) => id.Value;
}
}
