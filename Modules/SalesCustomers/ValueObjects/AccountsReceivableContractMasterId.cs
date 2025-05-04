using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects
{
/// <summary>
/// AccountsReceivableContractMaster Identifier Value Object
/// </summary>
public sealed class AccountsReceivableContractMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableContractMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableContractMasterId instance
    /// </summary>
    public AccountsReceivableContractMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableContractMasterId with a new GUID
    /// </summary>
    public static AccountsReceivableContractMasterId CreateUnique()
    {
        return new AccountsReceivableContractMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableContractMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableContractMasterId id) => id.Value;
}
}
