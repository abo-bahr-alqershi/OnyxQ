using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableContractRenew Identifier Value Object
/// </summary>
public sealed class AccountsPayableContractRenewId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableContractRenew
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableContractRenewId instance
    /// </summary>
    public AccountsPayableContractRenewId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableContractRenewId with a new GUID
    /// </summary>
    public static AccountsPayableContractRenewId CreateUnique()
    {
        return new AccountsPayableContractRenewId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableContractRenewId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableContractRenewId id) => id.Value;
}
}
