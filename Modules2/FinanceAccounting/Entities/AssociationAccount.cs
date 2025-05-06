using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل حساب الجمعية ويحتوي على جميع خصائص حسابات الجمعيات
/// </summary>
public class AssociationAccount : Entity<AssociationAccountId>
{

    private AssociationAccount() { }

    public AssociationAccount(AssociationAccountId id, decimal? assessmentNumber)
    {
        Id = id;
        AssessmentNumber = assessmentNumber;
    }

    /// <summary>
    /// معرف فريد لحساب الجمعية
    /// </summary>
    public AssociationAccountId Id { get; private set; }

    /// <summary>
    /// رقم التقييم
    /// </summary>
    public decimal? AssessmentNumber { get; private set; }

    /// <summary>
    /// اسم العائلة للتقييم
    /// </summary>
    public string AssessmentLastName { get; private set; }

    /// <summary>
    /// الاسم الأول للتقييم
    /// </summary>
    public string AssessmentFirstName { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// علم التقييم الافتراضي
    /// </summary>
    public decimal? AssessmentDefaultFlag { get; private set; }

    /// <summary>
    /// حالة التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// رقم المستخدم الذي قام بالتعطيل
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// سبب التعطيل
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع الحساب (متعدد إلى واحد)
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

