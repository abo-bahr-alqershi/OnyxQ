using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل صلاحيات المستخدم على الفرع ويحدد الامتيازات الممنوحة له.
public class BranchUserPrivilege : Entity<BranchUserPrivilegeId>
{
    private BranchUserPrivilege() { }

    public BranchUserPrivilege(BranchUserPrivilegeId id)
    {
        Id = id;
    }

    // المعرف الفريد لصلاحية المستخدم على الفرع (مفتاح رئيسي).
    public BranchUserPrivilegeId Id { get; private set; }

    // علم إضافي للصلاحية.
    public decimal? AdditionalFlag { get; private set; }

    // علم عرض الصلاحية.
    public decimal? ViewFlag { get; private set; }

    // علم تعبئة الصلاحية.
    public decimal? FillFlag { get; private set; }

    // علم منفعة إضافية للصلاحية.
    public decimal? AdditionalBenefitFlag { get; private set; }

    #region Navigation Properties
    // الفرع المرتبط بهذه الصلاحية.
    public Branch Branch { get; private set; }
    // المستخدم المرتبط بهذه الصلاحية.
    public User User { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص بصلاحية المستخدم على الفرع
    #endregion
}
}
