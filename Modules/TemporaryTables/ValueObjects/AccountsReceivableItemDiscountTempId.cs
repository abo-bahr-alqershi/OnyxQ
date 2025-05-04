using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// AccountsReceivableItemDiscountTemp Identifier Value Object
/// </summary>
public sealed class AccountsReceivableItemDiscountTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountTempId instance
    /// </summary>
    public AccountsReceivableItemDiscountTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountTempId with a new GUID
    /// </summary>
    public static AccountsReceivableItemDiscountTempId CreateUnique()
    {
        return new AccountsReceivableItemDiscountTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableItemDiscountTempId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableItemDiscountTempId id) => id.Value;
}
}
