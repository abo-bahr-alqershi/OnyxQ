using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a code send message.
/// يمثل المعرف الفريد لرسالة إرسال الرمز
/// </summary>
public sealed class CodeSendMessageId : ValueObject
{
    /// <summary>
    /// Gets the record number.
    /// رقم السجل
    /// </summary>
    public int RecordNumber { get; }

    private CodeSendMessageId(int recordNumber)
    {
        RecordNumber = recordNumber;
    }

    public static CodeSendMessageId Create(int recordNumber)
    {
        return new CodeSendMessageId(recordNumber);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return RecordNumber;
    }
} 