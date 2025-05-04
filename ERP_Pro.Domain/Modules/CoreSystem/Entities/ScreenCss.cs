using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل خصائص CSS لشاشة النظام ويحتوي على جميع خصائص التصميم والألوان للشاشة.
public class ScreenCss : Entity<ScreenCssId>
{

    private ScreenCss() { }

    public ScreenCss(ScreenCssId id, decimal? screenNumber)
    {
        Id = id;
        ScreenNumber = screenNumber;
    }

    // المعرف الفريد لخصائص CSS للشاشة (مفتاح رئيسي).
    public ScreenCssId Id { get; private set; }

    // رقم النظام المرتبط بالخصائص.
    public decimal? SystemNumber { get; private set; }

    // رقم الشاشة.
    public decimal? ScreenNumber { get; private set; }

    // رقم التسمية للشاشة.
    public decimal? LabelNumber { get; private set; }

    // رقم الشاشة الأب المختصر.
    public decimal? ScreenParentNumberShort { get; private set; }

    // علم التعطيل للخصائص.
    public decimal? InactiveFlag { get; private set; }

    // علم الافتراضية للخصائص.
    public decimal? DfltFlg { get; private set; }

    // رقم ترتيب الخصائص.
    public decimal? OrderNumberShort { get; private set; }

    // نوع الشاشة.
    public decimal? ScreenType { get; private set; }

    // اسم ملف الشاشة المختصر.
    public string FileNameShort { get; private set; }

    // أيقونة الشاشة.
    public string ScreenIcon { get; private set; }

    // لون الشاشة.
    public string ScreenColor { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
