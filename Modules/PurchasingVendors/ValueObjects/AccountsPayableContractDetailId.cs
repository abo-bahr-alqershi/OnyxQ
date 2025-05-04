using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableContractDetail Identifier Value Object
/// </summary>
public sealed class AccountsPayableContractDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableContractDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableContractDetailId instance
    /// </summary>
    public AccountsPayableContractDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableContractDetailId with a new GUID
    /// </summary>
    public static AccountsPayableContractDetailId CreateUnique()
    {
        return new AccountsPayableContractDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableContractDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableContractDetailId id) => id.Value;
}
}
