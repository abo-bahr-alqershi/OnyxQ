using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// ReceiptDocument Identifier Value Object
/// </summary>
public sealed class ReceiptDocumentId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReceiptDocument
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReceiptDocumentId instance
    /// </summary>
    public ReceiptDocumentId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReceiptDocumentId with a new GUID
    /// </summary>
    public static ReceiptDocumentId CreateUnique()
    {
        return new ReceiptDocumentId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReceiptDocumentId id) => id.Value.ToString();
    public static implicit operator Guid(ReceiptDocumentId id) => id.Value;
}
}
