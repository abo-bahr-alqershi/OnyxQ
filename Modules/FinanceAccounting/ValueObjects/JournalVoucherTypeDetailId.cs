using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// JournalVoucherTypeDetail Identifier Value Object
/// </summary>
public sealed class JournalVoucherTypeDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JournalVoucherTypeDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JournalVoucherTypeDetailId instance
    /// </summary>
    public JournalVoucherTypeDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JournalVoucherTypeDetailId with a new GUID
    /// </summary>
    public static JournalVoucherTypeDetailId CreateUnique()
    {
        return new JournalVoucherTypeDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JournalVoucherTypeDetailId id) => id.Value.ToString();
    public static implicit operator Guid(JournalVoucherTypeDetailId id) => id.Value;
}
}
