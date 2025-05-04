using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل موافقة المستخدم على العمليات أو المستندات في النظام.
    public class ApprovedUserDetail : Entity<ApprovedUserDetailId>
    {
        // المعرف الفريد لتفاصيل موافقة المستخدم (مفتاح رئيسي).
        public ApprovedUserDetailId Id { get; private set; }

        // رقم المستخدم الذي قام بالموافقة.
        public decimal? ApprovedUser { get; private set; }

        // رقم العملية أو المستند المرتبط بالموافقة.
        public decimal? DocNo { get; private set; }

        // نوع العملية أو المستند المرتبط بالموافقة.
        public decimal? DocTyp { get; private set; }

        // تاريخ الموافقة على العملية أو المستند.
        public DateTime? ApprovedDate { get; private set; }

        // وصف أو ملاحظات حول الموافقة.
        public string ApprovedDescription { get; private set; }

        #region Navigation Properties
        // المستخدم المرتبط بهذه الموافقة.
        public User User { get; private set; }
        #endregion

        private ApprovedUserDetail() { }

        public ApprovedUserDetail(ApprovedUserDetailId id, decimal? approvedUser)
        {
            Id = id;
            ApprovedUser = approvedUser;
        }

        #region Methods
        /// <summary>
        /// أضف هنا منطق الدومين الخاص بتفاصيل المستخدم الموافق
        /// </summary>
        #endregion
    }
}
