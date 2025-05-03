using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

/// <summary>
/// Represents the unique identifier for a document type account detail message
/// يمثل المعرف الفريد لرسالة تفاصيل حساب نوع المستند
/// </summary>
public class DocumentTypeAccountDetailMessageId : ValueObject
{
    /// <summary>
    /// The unique identifier value
    /// قيمة المعرف الفريد
    /// </summary>
    public Guid Value { get; }

    public DocumentTypeAccountDetailMessageId(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("Message ID cannot be empty", nameof(value));

        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public override string ToString() => Value.ToString();
} 