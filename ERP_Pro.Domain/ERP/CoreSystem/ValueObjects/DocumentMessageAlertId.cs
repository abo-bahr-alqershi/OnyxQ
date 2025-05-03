using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a document message alert.
/// يمثل المعرف الفريد لتنبيه رسالة المستند
/// </summary>
public sealed class DocumentMessageAlertId : ValueObject
{
    /// <summary>
    /// Gets the record number.
    /// رقم السجل
    /// </summary>
    public int RecordNumber { get; }

    private DocumentMessageAlertId(int recordNumber)
    {
        RecordNumber = recordNumber;
    }

    public static DocumentMessageAlertId Create(int recordNumber)
    {
        return new DocumentMessageAlertId(recordNumber);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return RecordNumber;
    }
} 