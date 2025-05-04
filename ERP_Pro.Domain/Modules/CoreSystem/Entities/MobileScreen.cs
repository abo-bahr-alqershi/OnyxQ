using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل شاشة الجوال ويحتوي على جميع خصائص الشاشة في تطبيق الجوال.
public class MobileScreen : Entity<MobileScreenId>
{
    private MobileScreen() { }

    public MobileScreen(MobileScreenId id, decimal? screenNumber)
    {
        Id = id;
        ScreenNumber = screenNumber;
    }

    // المعرف الفريد لشاشة الجوال (مفتاح رئيسي).
    public MobileScreenId Id { get; private set; }

    // رقم النظام المرتبط بالشاشة.
    public decimal? SystemNumber { get; private set; }

    // رقم الشاشة في تطبيق الجوال.
    public decimal? ScreenNumber { get; private set; }

    // رقم الشاشة الأب في تطبيق الجوال.
    public decimal? ScreenParentNumber { get; private set; }

    // علم التعطيل (يحدد إذا كانت الشاشة غير نشطة).
    public decimal? InactiveFlag { get; private set; }

    // رقم ترتيب الشاشة المختصر.
    public decimal? OrderNumberShort { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص بشاشة الجوال
    #endregion
}
}
