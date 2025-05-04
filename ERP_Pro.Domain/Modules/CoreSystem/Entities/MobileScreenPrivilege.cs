using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل صلاحية شاشة الجوال ويحدد امتيازات المستخدم على الشاشات في تطبيق الجوال.
public class MobileScreenPrivilege : Entity<MobileScreenPrivilegeId>
{
    private MobileScreenPrivilege() { }

    public MobileScreenPrivilege(MobileScreenPrivilegeId id)
    {
        Id = id;
    }

    // المعرف الفريد لصلاحية شاشة الجوال (مفتاح رئيسي).
    public MobileScreenPrivilegeId Id { get; private set; }

    // علم الصلاحية (يحدد نوع الامتياز).
    public decimal? PrivilegeFlag { get; private set; }

    // علم إضافي للصلاحية.
    public decimal? AdditionalFlag { get; private set; }

    #region Navigation Properties
    // شاشة الجوال المرتبطة بهذه الصلاحية.
    public MobileScreen MobileScreen { get; private set; }
    // المستخدم المرتبط بهذه الصلاحية.
    public User User { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص بصلاحية شاشة الجوال
    #endregion
}
}
