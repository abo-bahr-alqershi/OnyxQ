using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects
{
/// <summary>
/// AccountClass Identifier Value Object
/// </summary>
public sealed class AccountClassId : ValueObject
{
    /// <summary>
    /// The unique identifier for the AccountClass
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new AccountClassId instance
    /// </summary>
    public AccountClassId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new AccountClassId with a new GUID
    /// </summary>
    public static AccountClassId CreateUnique()
    {
        return new AccountClassId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(AccountClassId id) => id.Value.ToString();
    public static implicit operator Guid(AccountClassId id) => id.Value;
}
}
