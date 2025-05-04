using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// JournalVoucherMaster Identifier Value Object
/// </summary>
public sealed class JournalVoucherMasterId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JournalVoucherMaster
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JournalVoucherMasterId instance
    /// </summary>
    public JournalVoucherMasterId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JournalVoucherMasterId with a new GUID
    /// </summary>
    public static JournalVoucherMasterId CreateUnique()
    {
        return new JournalVoucherMasterId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JournalVoucherMasterId id) => id.Value.ToString();
    public static implicit operator Guid(JournalVoucherMasterId id) => id.Value;
}
}
