using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// AccountCostCenterLimit Identifier Value Object
/// </summary>
public sealed class AccountCostCenterLimitId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountCostCenterLimit
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountCostCenterLimitId instance
    /// </summary>
    public AccountCostCenterLimitId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountCostCenterLimitId with a new GUID
    /// </summary>
    public static AccountCostCenterLimitId CreateUnique()
    {
        return new AccountCostCenterLimitId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountCostCenterLimitId id) => id.Value.ToString();
    public static implicit operator Guid(AccountCostCenterLimitId id) => id.Value;
}
}
