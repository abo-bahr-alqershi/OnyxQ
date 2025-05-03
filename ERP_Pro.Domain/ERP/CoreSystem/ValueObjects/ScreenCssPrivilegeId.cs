using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

/// <summary>
/// Represents the unique identifier for a screen CSS privilege.
/// يمثل المعرف الفريد لامتياز CSS للشاشة
/// </summary>
public sealed class ScreenCssPrivilegeId : AggregateRootId<Guid>
{
    /// <summary>
    /// Initializes a new instance of the ScreenCssPrivilegeId class.
    /// ينشئ نسخة جديدة من معرف امتياز CSS للشاشة
    /// </summary>
    /// <param name="value">The ID value. قيمة المعرف</param>
    private ScreenCssPrivilegeId(Guid value) : base(value)
    {
    }

    /// <summary>
    /// Creates a new unique identifier.
    /// ينشئ معرف فريد جديد
    /// </summary>
    /// <returns>A new ScreenCssPrivilegeId. معرف امتياز CSS جديد للشاشة</returns>
    public static ScreenCssPrivilegeId CreateUnique()
    {
        return new ScreenCssPrivilegeId(Guid.NewGuid());
    }

    /// <summary>
    /// Creates a ScreenCssPrivilegeId from an existing GUID.
    /// ينشئ معرف امتياز CSS للشاشة من GUID موجود
    /// </summary>
    /// <param name="id">The existing GUID. المعرف الفريد الموجود</param>
    /// <returns>A ScreenCssPrivilegeId. معرف امتياز CSS للشاشة</returns>
    public static ScreenCssPrivilegeId Create(Guid id)
    {
        return new ScreenCssPrivilegeId(id);
    }
} 