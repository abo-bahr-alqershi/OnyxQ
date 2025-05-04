using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects
{
/// <summary>
/// AccountsReceivableWarehouseTemp Identifier Value Object
/// </summary>
public sealed class AccountsReceivableWarehouseTempId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountsReceivableWarehouseTemp
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountsReceivableWarehouseTempId instance
    /// </summary>
    public AccountsReceivableWarehouseTempId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountsReceivableWarehouseTempId with a new GUID
    /// </summary>
    public static AccountsReceivableWarehouseTempId CreateUnique()
    {
        return new AccountsReceivableWarehouseTempId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountsReceivableWarehouseTempId id) => id.Value.ToString();
    public static implicit operator Guid(AccountsReceivableWarehouseTempId id) => id.Value;
}
}
