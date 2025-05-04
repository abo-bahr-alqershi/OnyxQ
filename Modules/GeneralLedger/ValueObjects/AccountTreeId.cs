using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountTree Identifier Value Object
/// </summary>
public sealed class AccountTreeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountTree
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountTreeId instance
    /// </summary>
    public AccountTreeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountTreeId with a new GUID
    /// </summary>
    public static AccountTreeId CreateUnique()
    {
        return new AccountTreeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountTreeId id) => id.Value.ToString();
    public static implicit operator Guid(AccountTreeId id) => id.Value;
}
}
