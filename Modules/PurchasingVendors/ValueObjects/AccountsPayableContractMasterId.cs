using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableContractMaster Identifier Value Object
/// </summary>
public sealed class AccountsPayableContractMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableContractMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableContractMasterId instance
    /// </summary>
    public AccountsPayableContractMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableContractMasterId with a new GUID
    /// </summary>
    public static AccountsPayableContractMasterId CreateUnique()
    {
        return new AccountsPayableContractMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableContractMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableContractMasterId id) => id.Value;
}
}
