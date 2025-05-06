using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل تسمية الشاشة ويحتوي على جميع خصائص التسمية واللغة والحقول المرتبطة بها.
    public class ScreenLabel : Entity<ScreenLabelId>
    {

        private ScreenLabel() { }

        public ScreenLabel(ScreenLabelId id, decimal? languageNumber, decimal? formNumber, string objectNameShort, string fieldNameShort)
        {
            Id = id;
            LanguageNumber = languageNumber;
            FormNumber = formNumber;
            ObjectNameShort = objectNameShort;
            FieldNameShort = fieldNameShort;
        }

        // المعرف الفريد لتسمية الشاشة (مفتاح رئيسي).
        public ScreenLabelId Id { get; private set; }

        // رقم اللغة المرتبط بالتسمية.
        public decimal? LanguageNumber { get; private set; }

        // رقم النموذج المرتبط بالتسمية.
        public decimal? FormNumber { get; private set; }

        // اسم الكائن المختصر المرتبط بالتسمية.
        public string ObjectNameShort { get; private set; }

        // اسم الحقل المختصر المرتبط بالتسمية.
        public string FieldNameShort { get; private set; }

        // نص التسمية.
        public string LabelText { get; private set; }

        // رقم الحقل المرتبط بالتسمية.
        public decimal? FieldNumber { get; private set; }

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
