using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a sequence control.
/// يمثل المعرف الفريد للتحكم في التسلسل
/// </summary>
public sealed class SequenceControlId : AggregateRootId<Guid>
{
    /// <summary>
    /// Initializes a new instance of the SequenceControlId class.
    /// ينشئ نسخة جديدة من معرف التحكم في التسلسل
    /// </summary>
    /// <param name="value">The ID value. قيمة المعرف</param>
    private SequenceControlId(Guid value) : base(value)
    {
    }

    /// <summary>
    /// Creates a new unique identifier.
    /// ينشئ معرف فريد جديد
    /// </summary>
    /// <returns>A new SequenceControlId. معرف تحكم في التسلسل جديد</returns>
    public static SequenceControlId CreateUnique()
    {
        return new SequenceControlId(Guid.NewGuid());
    }

    /// <summary>
    /// Creates a SequenceControlId from an existing GUID.
    /// ينشئ معرف تحكم في التسلسل من GUID موجود
    /// </summary>
    /// <param name="id">The existing GUID. المعرف الفريد الموجود</param>
    /// <returns>A SequenceControlId. معرف التحكم في التسلسل</returns>
    public static SequenceControlId Create(Guid id)
    {
        return new SequenceControlId(id);
    }
} 