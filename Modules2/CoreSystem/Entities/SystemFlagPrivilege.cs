using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل صلاحية العلم في النظام ويحدد الامتيازات والقيم الخاصة بالمستخدم.
    public class SystemFlagPrivilege : Entity<SystemFlagPrivilegeId>
    {

        private SystemFlagPrivilege() { }

        public SystemFlagPrivilege(SystemFlagPrivilegeId id, decimal? userId, string flagCode, decimal? flagValue)
        {
            Id = id;
            UserId = userId;
            FlagCode = flagCode;
            FlagValue = flagValue;
        }

        // المعرف الفريد لصلاحية العلم (مفتاح رئيسي).
        public SystemFlagPrivilegeId Id { get; private set; }

        // رقم المستخدم المرتبط بالصلاحية.
        public decimal? UserId { get; private set; }

        // كود العلم المرتبط بالصلاحية.
        public string FlagCode { get; private set; }

        // قيمة العلم المرتبط بالصلاحية.
        public decimal? FlagValue { get; private set; }

        // علم خاص بالصلاحية.
        public decimal? PrivateFlag { get; private set; }

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
