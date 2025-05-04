using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل المستخدم الموافق في النظام ويحتوي على معلومات المستخدمين المخولين بالموافقة على العمليات أو المستندات.
    public class ApprovedUser : Entity<ApprovedUserId>
    {
        // المعرف الفريد للمستخدم الموافق (مفتاح رئيسي).
        public ApprovedUserId Id { get; private set; }

        // اسم المستخدم الموافق.
        public string UserName { get; private set; }

        // رقم المستخدم الموافق.
        public decimal? UserNumber { get; private set; }

        // حالة تفعيل المستخدم (نشط/غير نشط).
        public bool? IsActive { get; private set; }

        #region Navigation Properties
        // تفاصيل الموافقات المرتبطة بهذا المستخدم.
        public ICollection<ApprovedUserDetail> ApprovedUserDetails { get; private set; }
        #endregion

        private ApprovedUser() { }

        public ApprovedUser(ApprovedUserId id, string userName)
        {
            Id = id;
            UserName = userName;
            ApprovedUserDetails = new List<ApprovedUserDetail>();
        }

        #region Methods
        // أضف هنا منطق الدومين الخاص بالمستخدم الموافق
        #endregion
    }
}
