using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل صلاحية تنبيه النظام للمستخدم ويحدد الامتيازات والتنبيهات المرتبطة بالمستخدم.
    public class UserAlertSystemPrivilege : Entity<UserAlertSystemPrivilegeId>
    {
        private UserAlertSystemPrivilege() { }

        public UserAlertSystemPrivilege(UserAlertSystemPrivilegeId id, decimal? userId, decimal? alertNumber)
        {
            Id = id;
            UserId = userId;
            AlertNumber = alertNumber;
        }

        // المعرف الفريد لصلاحية تنبيه النظام للمستخدم (مفتاح رئيسي).
        public UserAlertSystemPrivilegeId Id { get; private set; }

        // رقم المستخدم المرتبط بالتنبيه.
        public decimal? UserId { get; private set; }

        // رقم التنبيه المرتبط بالمستخدم.
        public decimal? AlertNumber { get; private set; }

        // علم الامتياز.
        public decimal? PrivilegeFlag { get; private set; }

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
