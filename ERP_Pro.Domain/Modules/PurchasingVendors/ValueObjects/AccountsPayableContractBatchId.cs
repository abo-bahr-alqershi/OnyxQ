using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableContractBatch Identifier Value Object
/// </summary>
public sealed class AccountsPayableContractBatchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableContractBatch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableContractBatchId instance
    /// </summary>
    public AccountsPayableContractBatchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableContractBatchId with a new GUID
    /// </summary>
    public static AccountsPayableContractBatchId CreateUnique()
    {
        return new AccountsPayableContractBatchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableContractBatchId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableContractBatchId id) => id.Value;
}
}
