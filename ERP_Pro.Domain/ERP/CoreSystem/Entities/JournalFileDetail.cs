using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a journal file detail
/// يمثل تفاصيل ملف اليومية
/// </summary>
public class JournalFileDetail : AuditableEntity
{
    /// <summary>
    /// The unique identifier for the detail
    /// المعرف الفريد للتفاصيل
    /// </summary>
    public JournalFileDetailId Id { get; private set; }

    /// <summary>
    /// The master ID
    /// معرف الرئيسي
    /// </summary>
    public int MasterId { get; private set; }

    /// <summary>
    /// The field name
    /// اسم الحقل
    /// </summary>
    public string FieldName { get; private set; }

    /// <summary>
    /// The field type
    /// نوع الحقل
    /// </summary>
    public string FieldType { get; private set; }

    /// <summary>
    /// The field length
    /// طول الحقل
    /// </summary>
    public int FieldLength { get; private set; }

    /// <summary>
    /// The field order
    /// ترتيب الحقل
    /// </summary>
    public int FieldOrder { get; private set; }

    /// <summary>
    /// Whether the field is required
    /// ما إذا كان الحقل مطلوبًا
    /// </summary>
    public bool IsRequired { get; private set; }

    /// <summary>
    /// Navigation property for the journal file master relationship
    /// خاصية التنقل لعلاقة ملف اليومية الرئيسي
    /// </summary>
    public JournalFileMaster JournalFileMaster { get; private set; }

    private JournalFileDetail() { } // For EF Core

    public JournalFileDetail(
        int masterId,
        string fieldName,
        string fieldType,
        int fieldLength,
        int fieldOrder,
        bool isRequired)
    {
        Id = new JournalFileDetailId(Guid.NewGuid());
        MasterId = masterId;
        FieldName = fieldName;
        FieldType = fieldType;
        FieldLength = fieldLength;
        FieldOrder = fieldOrder;
        IsRequired = isRequired;

        AddDomainEvent(new JournalFileDetailCreatedEvent(this));
    }

    public void Update(
        string fieldName,
        string fieldType,
        int fieldLength,
        int fieldOrder,
        bool isRequired)
    {
        FieldName = fieldName;
        FieldType = fieldType;
        FieldLength = fieldLength;
        FieldOrder = fieldOrder;
        IsRequired = isRequired;

        AddDomainEvent(new JournalFileDetailUpdatedEvent(this));
    }
} 