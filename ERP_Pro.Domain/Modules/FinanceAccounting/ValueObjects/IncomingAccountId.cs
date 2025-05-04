using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// IncomingAccount Identifier Value Object
/// </summary>
public sealed class IncomingAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the IncomingAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new IncomingAccountId instance
    /// </summary>
    public IncomingAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new IncomingAccountId with a new GUID
    /// </summary>
    public static IncomingAccountId CreateUnique()
    {
        return new IncomingAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(IncomingAccountId id) => id.Value.ToString();
    public static implicit operator Guid(IncomingAccountId id) => id.Value;
}
}
