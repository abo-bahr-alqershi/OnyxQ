using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل تفاصيل عرض المستند الفرعي الموافق عليه ويحتوي على معلومات المستندات الفرعية التي تمت الموافقة على عرضها.
public class ApprovedShowDocumentSub : Entity<ApprovedShowDocumentSubId>
{
    // المعرف الفريد لتفاصيل عرض المستند الفرعي الموافق عليه (مفتاح رئيسي).
    public ApprovedShowDocumentSubId Id { get; private set; }

    // رقم المستند الفرعي المرتبط.
    public decimal? DocNo { get; private set; }

    // نوع المستند الفرعي.
    public decimal? DocTyp { get; private set; }

    // رقم التسلسل الفرعي للمستند.
    public decimal? DocSer { get; private set; }

    // رقم الشركة المالكة للمستند.
    public decimal? CompanyNumber { get; private set; }

    // رقم الفرع المرتبط بالمستند.
    public decimal? BranchNumber { get; private set; }

    // سنة الفرع المرتبط بالمستند.
    public decimal? BranchYear { get; private set; }

    // رقم المستخدم الذي قام بالموافقة.
    public decimal? ApprovedUser { get; private set; }

    // تاريخ الموافقة على عرض المستند الفرعي.
    public DateTime? ApprovedDate { get; private set; }

    // وصف أو ملاحظات حول الموافقة.
    public string ApprovedDescription { get; private set; }

    #region Navigation Properties
    // المستخدم المرتبط بهذه الموافقة.
    public User User { get; private set; }
    #endregion

    private ApprovedShowDocumentSub() { }

    public ApprovedShowDocumentSub(ApprovedShowDocumentSubId id, decimal? docNo)
    {
        Id = id;
        DocNo = docNo;
    }

    #region Methods
    /// <summary>
    /// أضف هنا منطق الدومين الخاص بتفاصيل عرض المستند الفرعي الموافق عليه
    /// </summary>
    #endregion
}
}
