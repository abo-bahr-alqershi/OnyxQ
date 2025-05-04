using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل صلاحية خصائص CSS للشاشة ويحدد الامتيازات الممنوحة للمستخدم أو العميل على خصائص التصميم.
    public class ScreenCssPrivilege : Entity<ScreenCssPrivilegeId>
    {

        private ScreenCssPrivilege() { }

        public ScreenCssPrivilege(ScreenCssPrivilegeId id, decimal? screenNumber)
        {
            Id = id;
            ScreenNumber = screenNumber;
        }

        // المعرف الفريد لصلاحية خصائص CSS للشاشة (مفتاح رئيسي).
        public ScreenCssPrivilegeId Id { get; private set; }

        // رقم الشاشة المرتبطة بالصلاحية.
        public decimal? ScreenNumber { get; private set; }

        // علم الدخل للصلاحية.
        public decimal? IncomeFlag { get; private set; }

        #region Navigation Properties
        // العميل المرتبط بهذه الصلاحية.
        public Customer Customer { get; private set; }
        #endregion

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
