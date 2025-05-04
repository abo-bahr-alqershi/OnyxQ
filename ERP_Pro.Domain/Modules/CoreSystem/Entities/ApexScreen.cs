using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل شاشة النظام ويحتوي على جميع خصائص الشاشة ومعلوماتها الأساسية.
public class ApexScreen : Entity<ApexScreenId>
{
    private ApexScreen() { }

    public ApexScreen(ApexScreenId id, decimal? screenNumber)
    {
        Id = id;
        ScreenNumber = screenNumber;
    }

    // المعرف الفريد للشاشة (مفتاح رئيسي).
    public ApexScreenId Id { get; private set; }

    // رقم الشاشة في النظام.
    public decimal? ScreenNumber { get; private set; }

    // رقم التسمية الخاص بالشاشة.
    public decimal? LabelNumber { get; private set; }

    // رقم الشاشة الأب المختصر.
    public decimal? ScreenParentNumberShort { get; private set; }

    // علم التعطيل (يحدد إذا كانت الشاشة غير نشطة).
    public decimal? InactiveFlag { get; private set; }

    // رقم ترتيب الشاشة المختصر.
    public decimal? OrderNumberShort { get; private set; }

    // نوع الشاشة.
    public decimal? ScreenType { get; private set; }

    // اسم ملف الشاشة المختصر.
    public string FileNameShort { get; private set; }

    // أيقونة الشاشة.
    public string ScreenIcon { get; private set; }

    // علم الافتراضية (يحدد إذا كانت الشاشة افتراضية).
    public decimal? DfltFlg { get; private set; }

    // اسم ملف الشاشة على الجوال.
    public string MobileFileName { get; private set; }

    // أيقونة الشاشة على الجوال.
    public string MobileScreenIcon { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بالشاشة
    #endregion
}
}
