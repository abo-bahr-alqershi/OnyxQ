using ERP_Pro.Domain.Common.Models;

namespace ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

/// <summary>
/// Represents the unique identifier for a user type privilege.
/// يمثل المعرف الفريد لامتياز نوع المستخدم
/// </summary>
public sealed class UserTypePrivilegeId : ValueObject
{
    /// <summary>
    /// Gets the value of the user type privilege ID.
    /// الحصول على قيمة معرف امتياز نوع المستخدم
    /// </summary>
    public Guid Value { get; }

    private UserTypePrivilegeId(Guid value)
    {
        Value = value;
    }

    public static UserTypePrivilegeId CreateUnique()
    {
        return new UserTypePrivilegeId(Guid.NewGuid());
    }

    public static UserTypePrivilegeId Create(Guid value)
    {
        return new UserTypePrivilegeId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
} 