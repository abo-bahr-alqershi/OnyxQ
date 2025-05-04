using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// AccountsReceivableContractRenew Identifier Value Object
/// </summary>
public sealed class AccountsReceivableContractRenewId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableContractRenew
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableContractRenewId instance
    /// </summary>
    public AccountsReceivableContractRenewId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableContractRenewId with a new GUID
    /// </summary>
    public static AccountsReceivableContractRenewId CreateUnique()
    {
        return new AccountsReceivableContractRenewId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableContractRenewId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableContractRenewId id) => id.Value;
}
}
