using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a screen label.
/// يمثل المعرف الفريد لتسمية الشاشة
/// </summary>
public sealed class ScreenLabelId : AggregateRootId<Guid>
{
    /// <summary>
    /// Initializes a new instance of the ScreenLabelId class.
    /// ينشئ نسخة جديدة من معرف تسمية الشاشة
    /// </summary>
    /// <param name="value">The ID value. قيمة المعرف</param>
    private ScreenLabelId(Guid value) : base(value)
    {
    }

    /// <summary>
    /// Creates a new unique identifier.
    /// ينشئ معرف فريد جديد
    /// </summary>
    /// <returns>A new ScreenLabelId. معرف تسمية شاشة جديد</returns>
    public static ScreenLabelId CreateUnique()
    {
        return new ScreenLabelId(Guid.NewGuid());
    }

    /// <summary>
    /// Creates a ScreenLabelId from an existing GUID.
    /// ينشئ معرف تسمية شاشة من GUID موجود
    /// </summary>
    /// <param name="id">The existing GUID. المعرف الفريد الموجود</param>
    /// <returns>A ScreenLabelId. معرف تسمية الشاشة</returns>
    public static ScreenLabelId Create(Guid id)
    {
        return new ScreenLabelId(id);
    }
} 