using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل اسم شاشة الجوال ويحتوي على اسم الشاشة واللغة المرتبطة بها.
public class MobileScreenName : Entity<MobileScreenNameId>
{
    private MobileScreenName() { }

    public MobileScreenName(MobileScreenNameId id, decimal? languageNumber)
    {
        Id = id;
        LanguageNumber = languageNumber;
    }

    // المعرف الفريد لاسم شاشة الجوال (مفتاح رئيسي).
    public MobileScreenNameId Id { get; private set; }

    // رقم اللغة المرتبطة باسم الشاشة.
    public decimal? LanguageNumber { get; private set; }

    // اسم الشاشة على الجوال.
    public string ScreenName { get; private set; }

    #region Navigation Properties
    // شاشة الجوال المرتبطة بهذا الاسم.
    public MobileScreen MobileScreen { get; private set; }
    #endregion

    #region Methods
    // أضف هنا منطق الدومين الخاص باسم شاشة الجوال
    #endregion
}
}
