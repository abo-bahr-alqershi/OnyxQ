using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل إغلاق الفترة المالية للفرع ويحتوي على جميع تفاصيل الإغلاق والفتح للفترات.
public class PeriodBranchClose : Entity<PeriodBranchCloseId>
{
    // المعرف الفريد لإغلاق الفترة (مفتاح رئيسي).
    public PeriodBranchCloseId Id { get; private set; }

    // رقم الفترة المالية المختصر.
    public decimal? PeriodNumberShort { get; private set; }

    // رقم الفرع.
    public decimal? BranchNumber { get; private set; }

    // تاريخ بداية الفترة.
    public DateTime? FDate { get; private set; }

    // تاريخ نهاية الفترة.
    public DateTime? TDate { get; private set; }

    // رقم السنة المالية.
    public decimal? YearNumber { get; private set; }

    // علم التعطيل البديل للفترة.
    public decimal? InactiveFlagAlt { get; private set; }

    // تصنيف الفترة.
    public decimal? PeriodClass { get; private set; }

    // معرف المستخدم الذي أغلق الفترة.
    public decimal? PeriodClassUserId { get; private set; }

    // تاريخ إغلاق الفترة.
    public DateTime? PeriodClassDate { get; private set; }

    // معرف المستخدم الذي أعاد فتح الفترة.
    public decimal? PeriodUncloseUserIdShort { get; private set; }

    // تاريخ إعادة فتح الفترة.
    public DateTime? PeriodUncloseDateShort { get; private set; }

    // عدد مرات إغلاق الفترة.
    public decimal? PeriodClassCount { get; private set; }

    // تصنيف المكان.
    public decimal? PlaceClass { get; private set; }

    // عدد مرات إغلاق المكان.
    public decimal? PlaceClassCount { get; private set; }

    // معرف المستخدم الذي أغلق المكان.
    public decimal? PlaceClassUserId { get; private set; }

    // تاريخ إغلاق المكان.
    public DateTime? PlaceClassDate { get; private set; }

    // معرف المستخدم الذي أعاد فتح المكان.
    public decimal? PlaceUncloseUserId { get; private set; }

    // تاريخ إعادة فتح المكان.
    public DateTime? PlaceUncloseDate { get; private set; }

    // تصنيف الفاتورة.
    public decimal? InvoiceClass { get; private set; }

    // معرف المستخدم الذي أغلق الفاتورة.
    public decimal? InvoiceClassUserId { get; private set; }

    // تاريخ إغلاق الفاتورة.
    public DateTime? InvoiceClassDate { get; private set; }

    // عدد مرات إغلاق الفاتورة.
    public decimal? InvoiceClassCount { get; private set; }

    // معرف المستخدم الذي أعاد فتح الفاتورة.
    public decimal? InvoiceUncloseUserId { get; private set; }

    // تاريخ إعادة فتح الفاتورة.
    public DateTime? InvoiceUncloseDate { get; private set; }

    // تصنيف الإهلاك.
    public decimal? DeprCls { get; private set; }

    // معرف المستخدم الذي أغلق الإهلاك.
    public decimal? DeprClsUId { get; private set; }

    // تاريخ إغلاق الإهلاك.
    public DateTime? DeprClsDate { get; private set; }

    // عدد مرات إغلاق الإهلاك.
    public decimal? DeprClsCnt { get; private set; }

    // معرف المستخدم الذي أعاد فتح الإهلاك.
    public decimal? DeprUnclsUId { get; private set; }

    // تاريخ إعادة فتح الإهلاك.
    public DateTime? DeprUnclsDate { get; private set; }

    // تصنيف التخطيط.
    public decimal? MrpClass { get; private set; }

    // عدد مرات إغلاق التخطيط.
    public decimal? MrpClassCount { get; private set; }

    // معرف المستخدم الذي أغلق التخطيط.
    public decimal? MrpClassUserId { get; private set; }

    // تاريخ إغلاق التخطيط.
    public DateTime? MrpClassDate { get; private set; }

    // معرف المستخدم الذي أعاد فتح التخطيط.
    public decimal? MrpUncloseUserId { get; private set; }

    // تاريخ إعادة فتح التخطيط.
    public DateTime? MrpUncloseDate { get; private set; }

    // فترة الأصول الثابتة.
    public decimal? FixedAssetPeriod { get; private set; }

    // كود حساب المكان.
    public string PlaceAccountCodeClass { get; private set; }

    // مبلغ المكان.
    public decimal? PlaceAmountClass { get; private set; }

    // إغلاق عكسي للفترة.
    public decimal? ReverseClose { get; private set; }

    // تاريخ بداية الإغلاق العكسي.
    public DateTime? ReverseFromDateClose { get; private set; }

    // تاريخ نهاية الإغلاق العكسي.
    public DateTime? ReverseToDateClose { get; private set; }

    // إغلاق فروقات العملة.
    public decimal? CurDiffCls { get; private set; }
    public decimal? CurDiffClsWthCc { get; private set; }
    public decimal? CurDiffClsWthPj { get; private set; }
    public decimal? CurDiffClsWthActv { get; private set; }
    public decimal? CurRateFlgCls { get; private set; }
    public decimal? CurRateTypFlgCls { get; private set; }

    #region Navigation Properties
    // الفترة الرئيسية المرتبطة بهذا الإغلاق.
    public PeriodMaster PeriodMaster { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص بإغلاق الفترة للفرع
    #endregion
}
}
