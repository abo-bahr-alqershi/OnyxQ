using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a document type account detail message.
/// يمثل المعرف الفريد لرسالة تفاصيل حساب نوع المستند
/// </summary>
public sealed class DocumentTypeAccountDetailMessageId : ValueObject
{
    /// <summary>
    /// Gets the record number.
    /// رقم السجل
    /// </summary>
    public int RecordNumber { get; }

    private DocumentTypeAccountDetailMessageId(int recordNumber)
    {
        RecordNumber = recordNumber;
    }

    public static DocumentTypeAccountDetailMessageId Create(int recordNumber)
    {
        return new DocumentTypeAccountDetailMessageId(recordNumber);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return RecordNumber;
    }
} 