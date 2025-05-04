using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableKimbMaster Identifier Value Object
/// </summary>
public sealed class AccountsPayableKimbMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableKimbMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableKimbMasterId instance
    /// </summary>
    public AccountsPayableKimbMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableKimbMasterId with a new GUID
    /// </summary>
    public static AccountsPayableKimbMasterId CreateUnique()
    {
        return new AccountsPayableKimbMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableKimbMasterId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableKimbMasterId id) => id.Value;
}
}
