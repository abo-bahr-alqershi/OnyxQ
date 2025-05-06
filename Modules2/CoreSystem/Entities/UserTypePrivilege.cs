using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل صلاحية نوع المستخدم ويحدد الامتيازات الممنوحة له على النظام أو النماذج.
    public class UserTypePrivilege : Entity<UserTypePrivilegeId>
    {
        private UserTypePrivilege() { }

        public UserTypePrivilege(UserTypePrivilegeId id)
        {
            Id = id;
        }

        // المعرف الفريد لصلاحية نوع المستخدم (مفتاح رئيسي).
        public UserTypePrivilegeId Id { get; private set; }

        // علم الامتياز.
        public decimal? PrivilegeFlag { get; private set; }

        #region Navigation Properties
        // نوع النظام المرتبط بهذه الصلاحية.
        public SystemType SystemType { get; private set; }
        // تفاصيل النموذج المرتبطة بهذه الصلاحية.
        public FormDetail FormDetail { get; private set; }
        // المستخدم المرتبط بهذه الصلاحية.
        public User User { get; private set; }
        #endregion

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
