using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a screen link.
/// يمثل المعرف الفريد لرابط الشاشة
/// </summary>
public sealed class ScreenLinkId : AggregateRootId<Guid>
{
    /// <summary>
    /// Initializes a new instance of the ScreenLinkId class.
    /// ينشئ نسخة جديدة من معرف رابط الشاشة
    /// </summary>
    /// <param name="value">The ID value. قيمة المعرف</param>
    private ScreenLinkId(Guid value) : base(value)
    {
    }

    /// <summary>
    /// Creates a new unique identifier.
    /// ينشئ معرف فريد جديد
    /// </summary>
    /// <returns>A new ScreenLinkId. معرف رابط شاشة جديد</returns>
    public static ScreenLinkId CreateUnique()
    {
        return new ScreenLinkId(Guid.NewGuid());
    }

    /// <summary>
    /// Creates a ScreenLinkId from an existing GUID.
    /// ينشئ معرف رابط شاشة من GUID موجود
    /// </summary>
    /// <param name="id">The existing GUID. المعرف الفريد الموجود</param>
    /// <returns>A ScreenLinkId. معرف رابط الشاشة</returns>
    public static ScreenLinkId Create(Guid id)
    {
        return new ScreenLinkId(id);
    }
} 