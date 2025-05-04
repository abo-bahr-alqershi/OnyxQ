using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// JournalVoucherDetail Identifier Value Object
/// </summary>
public sealed class JournalVoucherDetailId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JournalVoucherDetail
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JournalVoucherDetailId instance
    /// </summary>
    public JournalVoucherDetailId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JournalVoucherDetailId with a new GUID
    /// </summary>
    public static JournalVoucherDetailId CreateUnique()
    {
        return new JournalVoucherDetailId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JournalVoucherDetailId id) => id.Value.ToString();
    public static implicit operator Guid(JournalVoucherDetailId id) => id.Value;
}
}
