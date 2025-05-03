using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a document type message.
/// يمثل المعرف الفريد لرسالة نوع المستند
/// </summary>
public sealed class DocumentTypeMessageId : ValueObject
{
    /// <summary>
    /// Gets the record number.
    /// رقم السجل
    /// </summary>
    public int RecordNumber { get; }

    private DocumentTypeMessageId(int recordNumber)
    {
        RecordNumber = recordNumber;
    }

    public static DocumentTypeMessageId Create(int recordNumber)
    {
        return new DocumentTypeMessageId(recordNumber);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return RecordNumber;
    }
} 