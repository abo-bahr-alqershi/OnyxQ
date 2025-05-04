using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// InterfaceAccount Identifier Value Object
/// </summary>
public sealed class InterfaceAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the InterfaceAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new InterfaceAccountId instance
    /// </summary>
    public InterfaceAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new InterfaceAccountId with a new GUID
    /// </summary>
    public static InterfaceAccountId CreateUnique()
    {
        return new InterfaceAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(InterfaceAccountId id) => id.Value.ToString();
    public static implicit operator Guid(InterfaceAccountId id) => id.Value;
}
}
