using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a sequence value.
/// يمثل المعرف الفريد لقيمة التسلسل
/// </summary>
public sealed class SequenceValueId : AggregateRootId<Guid>
{
    /// <summary>
    /// Initializes a new instance of the SequenceValueId class.
    /// ينشئ نسخة جديدة من معرف قيمة التسلسل
    /// </summary>
    /// <param name="value">The ID value. قيمة المعرف</param>
    private SequenceValueId(Guid value) : base(value)
    {
    }

    /// <summary>
    /// Creates a new unique identifier.
    /// ينشئ معرف فريد جديد
    /// </summary>
    /// <returns>A new SequenceValueId. معرف قيمة تسلسل جديد</returns>
    public static SequenceValueId CreateUnique()
    {
        return new SequenceValueId(Guid.NewGuid());
    }

    /// <summary>
    /// Creates a SequenceValueId from an existing GUID.
    /// ينشئ معرف قيمة تسلسل من GUID موجود
    /// </summary>
    /// <param name="id">The existing GUID. المعرف الفريد الموجود</param>
    /// <returns>A SequenceValueId. معرف قيمة التسلسل</returns>
    public static SequenceValueId Create(Guid id)
    {
        return new SequenceValueId(id);
    }
} 