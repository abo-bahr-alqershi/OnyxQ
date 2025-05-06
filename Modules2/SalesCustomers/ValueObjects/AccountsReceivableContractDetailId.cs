using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// AccountsReceivableContractDetail Identifier Value Object
/// </summary>
public sealed class AccountsReceivableContractDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableContractDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableContractDetailId instance
    /// </summary>
    public AccountsReceivableContractDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableContractDetailId with a new GUID
    /// </summary>
    public static AccountsReceivableContractDetailId CreateUnique()
    {
        return new AccountsReceivableContractDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableContractDetailId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableContractDetailId id) => id.Value;
}
}
