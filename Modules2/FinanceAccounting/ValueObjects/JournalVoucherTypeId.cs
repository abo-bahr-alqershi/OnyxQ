using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// JournalVoucherType Identifier Value Object
/// </summary>
public sealed class JournalVoucherTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JournalVoucherType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JournalVoucherTypeId instance
    /// </summary>
    public JournalVoucherTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JournalVoucherTypeId with a new GUID
    /// </summary>
    public static JournalVoucherTypeId CreateUnique()
    {
        return new JournalVoucherTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JournalVoucherTypeId id) => id.Value.ToString();
    public static implicit operator Guid(JournalVoucherTypeId id) => id.Value;
}
}
