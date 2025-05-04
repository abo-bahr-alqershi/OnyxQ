using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل سجل التحقق قبل الإغلاق ويحتوي على رسائل التحقق والتقارير المرتبطة.
    public class LogCheckBeforeClose : Entity<LogCheckBeforeCloseId>
    {
        private LogCheckBeforeClose() { }

        public LogCheckBeforeClose(LogCheckBeforeCloseId id)
        {
            Id = id;
        }

        // المعرف الفريد لسجل التحقق قبل الإغلاق (مفتاح رئيسي).
        public LogCheckBeforeCloseId Id { get; private set; }

        // رقم الرسالة.
        public decimal? MessageNumber { get; private set; }

        // نص الرسالة الثابتة.
        public string MessageTextFixed { get; private set; }

        // اسم التقرير المختصر المرتبط بالتحقق.
        public string ReportNameShort { get; private set; }

        // شرط التقرير المرتبط بالتحقق.
        public string ReportWhere { get; private set; }

        #region Methods
        // أضف هنا منطق الدومين الخاص بسجل التحقق قبل الإغلاق
        #endregion
    }
}
