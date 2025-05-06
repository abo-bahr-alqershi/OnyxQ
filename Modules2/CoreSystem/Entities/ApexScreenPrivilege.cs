using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل صلاحية شاشة النظام ويحدد امتيازات المستخدم على الشاشات المختلفة.
    public class ApexScreenPrivilege : Entity<ApexScreenPrivilegeId>
    {
        private ApexScreenPrivilege() { }

        public ApexScreenPrivilege(ApexScreenPrivilegeId id)
        {
            Id = id;
        }

        // المعرف الفريد لصلاحية الشاشة (مفتاح رئيسي).
        public ApexScreenPrivilegeId Id { get; private set; }

        // علم الدخل لصلاحية الشاشة (يحدد إذا كانت الصلاحية متعلقة بالدخل).
        public decimal? IncomeFlag { get; private set; }

        #region Navigation Properties
        // الشاشة المرتبطة بهذه الصلاحية.
        public ApexScreen ApexScreen { get; private set; }
        // المستخدم المرتبط بهذه الصلاحية.
        public User User { get; private set; }
        #endregion

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
