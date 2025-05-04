using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects
{
/// <summary>
/// PerformaInvoiceBillJournal Identifier Value Object
/// </summary>
public sealed class PerformaInvoiceBillJournalId : ValueObject
{
    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillJournal
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new PerformaInvoiceBillJournalId instance
    /// </summary>
    public PerformaInvoiceBillJournalId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new PerformaInvoiceBillJournalId with a new GUID
    /// </summary>
    public static PerformaInvoiceBillJournalId CreateUnique()
    {
        return new PerformaInvoiceBillJournalId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(PerformaInvoiceBillJournalId id) => id.Value.ToString();
    public static implicit operator Guid(PerformaInvoiceBillJournalId id) => id.Value;
}
}
