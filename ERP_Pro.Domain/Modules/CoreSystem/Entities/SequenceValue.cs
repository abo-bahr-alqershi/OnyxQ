using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل قيمة التسلسل ويحتوي على جميع خصائص التسلسل وقيمه.
    public class SequenceValue : Entity<SequenceValueId>
    {
        private SequenceValue() { }

        public SequenceValue(SequenceValueId id)
        {
            Id = id;
        }

        // المعرف الفريد لقيمة التسلسل (مفتاح رئيسي).
        public SequenceValueId Id { get; private set; }

        // اسم الجدول المرتبط بالتسلسل.
        public string STableName { get; private set; }

        // اسم العمود المرتبط بالتسلسل.
        public string SColumnName { get; private set; }

        // قيمة التسلسل 1.
        public decimal? SValue1 { get; private set; }

        // قيمة التسلسل 2.
        public decimal? SValue2 { get; private set; }

        // قيمة التسلسل 3.
        public decimal? SValue3 { get; private set; }

        // قيمة التسلسل 4.
        public decimal? SValue4 { get; private set; }

        // قيمة التسلسل 5.
        public decimal? SValue5 { get; private set; }

        // قيمة التسلسل 6.
        public decimal? SValue6 { get; private set; }

        // قيمة الزيادة في التسلسل.
        public decimal? SIncreaseByValue { get; private set; }

        // القيمة الابتدائية للتسلسل.
        public decimal? SInitialValue { get; private set; }

        // قيمة التسلسل الحالية.
        public decimal? SSequenceValue { get; private set; }

        // نوع التسلسل.
        public decimal? SSequenceType { get; private set; }

        // رقم الشركة المختصر.
        public decimal? CompanyNumberShort { get; private set; }

        // رقم الفرع.
        public decimal? BranchNumber { get; private set; }

        // سنة الفرع.
        public decimal? BranchYear { get; private set; }

        // المستخدم المسؤول عن الفرع.
        public decimal? BranchUser { get; private set; }

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
