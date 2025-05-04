using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// AccountsReceivableItemSalesExportTemp Identifier Value Object
/// </summary>
public sealed class AccountsReceivableItemSalesExportTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableItemSalesExportTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableItemSalesExportTempId instance
    /// </summary>
    public AccountsReceivableItemSalesExportTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableItemSalesExportTempId with a new GUID
    /// </summary>
    public static AccountsReceivableItemSalesExportTempId CreateUnique()
    {
        return new AccountsReceivableItemSalesExportTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableItemSalesExportTempId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableItemSalesExportTempId id) => id.Value;
}
}
