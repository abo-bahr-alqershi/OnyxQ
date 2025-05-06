using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects
{
/// <summary>
/// JudicialDocumentJournalVoucherTypeConnectAccount Identifier Value Object
/// </summary>
public sealed class JudicialDocumentJournalVoucherTypeConnectAccountId : ValueObject
{
    /// <summary>
    /// The unique identifier for the JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new JudicialDocumentJournalVoucherTypeConnectAccountId instance
    /// </summary>
    public JudicialDocumentJournalVoucherTypeConnectAccountId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new JudicialDocumentJournalVoucherTypeConnectAccountId with a new GUID
    /// </summary>
    public static JudicialDocumentJournalVoucherTypeConnectAccountId CreateUnique()
    {
        return new JudicialDocumentJournalVoucherTypeConnectAccountId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(JudicialDocumentJournalVoucherTypeConnectAccountId id) => id.Value.ToString();
    public static implicit operator Guid(JudicialDocumentJournalVoucherTypeConnectAccountId id) => id.Value;
}
}
