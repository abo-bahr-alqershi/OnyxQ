using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تفاصيل عرض المستند الموافق عليه ويحتوي على معلومات المستندات التي تمت الموافقة على عرضها في النظام.
    public class ApprovedShowDocument : Entity<ApprovedShowDocumentId>
    {
        // المعرف الفريد لتفاصيل عرض المستند الموافق عليه (مفتاح رئيسي).
        public ApprovedShowDocumentId Id { get; private set; }

        // رقم المستند المرتبط بالموافقة.
        public decimal? DocNo { get; private set; }

        // نوع المستند المرتبط بالموافقة.
        public decimal? DocTyp { get; private set; }

        // رقم التسلسل للمستند.
        public decimal? DocSer { get; private set; }

        // رقم الشركة المالكة للمستند.
        public decimal? CompanyNumber { get; private set; }

        // رقم الفرع المرتبط بالمستند.
        public decimal? BranchNumber { get; private set; }

        // سنة الفرع المرتبط بالمستند.
        public decimal? BranchYear { get; private set; }

        // رقم المستخدم الذي قام بالموافقة.
        public decimal? ApprovedUser { get; private set; }

        // تاريخ الموافقة على عرض المستند.
        public DateTime? ApprovedDate { get; private set; }

        // وصف أو ملاحظات حول الموافقة.
        public string ApprovedDescription { get; private set; }

        #region Navigation Properties
        // المستخدم المرتبط بهذه الموافقة.
        public User User { get; private set; }
        #endregion

        private ApprovedShowDocument() { }

        public ApprovedShowDocument(ApprovedShowDocumentId id, decimal? docNo)
        {
            Id = id;
            DocNo = docNo;
        }

        #region Methods
        // أضف هنا منطق الدومين الخاص بتفاصيل عرض المستند الموافق عليه
        #endregion
    }
}
