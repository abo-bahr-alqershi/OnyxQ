using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// AccountsReceivableItemDiscountExcelTemp Identifier Value Object
/// </summary>
public sealed class AccountsReceivableItemDiscountExcelTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableItemDiscountExcelTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountExcelTempId instance
    /// </summary>
    public AccountsReceivableItemDiscountExcelTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableItemDiscountExcelTempId with a new GUID
    /// </summary>
    public static AccountsReceivableItemDiscountExcelTempId CreateUnique()
    {
        return new AccountsReceivableItemDiscountExcelTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableItemDiscountExcelTempId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableItemDiscountExcelTempId id) => id.Value;
}
}
