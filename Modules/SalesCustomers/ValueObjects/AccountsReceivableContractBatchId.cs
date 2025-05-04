using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// AccountsReceivableContractBatch Identifier Value Object
/// </summary>
public sealed class AccountsReceivableContractBatchId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableContractBatch
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableContractBatchId instance
    /// </summary>
    public AccountsReceivableContractBatchId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableContractBatchId with a new GUID
    /// </summary>
    public static AccountsReceivableContractBatchId CreateUnique()
    {
        return new AccountsReceivableContractBatchId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableContractBatchId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableContractBatchId id) => id.Value;
}
}
