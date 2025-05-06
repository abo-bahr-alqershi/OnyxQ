using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects
{
/// <summary>
/// AccountsPayableBillType Identifier Value Object
/// </summary>
public sealed class AccountsPayableBillTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsPayableBillType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsPayableBillTypeId instance
    /// </summary>
    public AccountsPayableBillTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsPayableBillTypeId with a new GUID
    /// </summary>
    public static AccountsPayableBillTypeId CreateUnique()
    {
        return new AccountsPayableBillTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsPayableBillTypeId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsPayableBillTypeId id) => id.Value;
}
}
