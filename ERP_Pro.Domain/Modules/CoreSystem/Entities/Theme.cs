using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل سمة النظام ويحتوي على خصائص الألوان والأنماط الخاصة بالمستخدم أو النظام.
    public class Theme : Entity<ThemeId>
    {

        private Theme() { }

        public Theme(ThemeId id, decimal? themeNumber)
        {
            Id = id;
            ThemeNumber = themeNumber;
        }

        // المعرف الفريد للسمة (مفتاح رئيسي).
        public ThemeId Id { get; private set; }

        // رقم السمة.
        public decimal? ThemeNumber { get; private set; }

        // بيانات ألوان السمة.
        public string ThemeColorData { get; private set; }

        // لون المستخدم في السمة.
        public string ThemeColorUser { get; private set; }

        // لون السجل الحالي في السمة.
        public string ThemeCurrentRecordColor { get; private set; }

        // نمط السمة.
        public string ThemePattern { get; private set; }

        // لون المقدمة في السمة.
        public string ThemeForegroundColor { get; private set; }

        // بيانات خلفية النص في السمة.
        public string ThemeTextBackgroundData { get; private set; }

        // خلفية نص المستخدم في السمة.
        public string ThemeTextBackgroundUser { get; private set; }

        // علم السمة.
        public decimal? ThemeFlag { get; private set; }

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
