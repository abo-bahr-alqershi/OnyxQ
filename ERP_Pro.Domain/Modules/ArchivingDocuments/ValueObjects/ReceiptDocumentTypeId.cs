using System;
using ERP_Pro.Domain.Common.Primitives;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects
{
/// <summary>
/// ReceiptDocumentType Identifier Value Object
/// </summary>
public sealed class ReceiptDocumentTypeId : ValueObject
{
    /// <summary>
    /// The unique identifier for the ReceiptDocumentType
    /// </summary>
    public Guid Value { get; }

    /// <summary>
    /// Creates a new ReceiptDocumentTypeId instance
    /// </summary>
    public ReceiptDocumentTypeId(Guid value)
    {
        Value = value;
    }

    /// <summary>
    /// Creates a new ReceiptDocumentTypeId with a new GUID
    /// </summary>
    public static ReceiptDocumentTypeId CreateUnique()
    {
        return new ReceiptDocumentTypeId(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();

    public static implicit operator string(ReceiptDocumentTypeId id) => id.Value.ToString();
    public static implicit operator Guid(ReceiptDocumentTypeId id) => id.Value;
}
}
