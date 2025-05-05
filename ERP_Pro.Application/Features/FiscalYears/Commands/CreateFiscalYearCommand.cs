using System;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Commands
{
    /// <summary>
    /// أمر إنشاء سنة مالية جديدة
    /// </summary>
    public class CreateFiscalYearCommand : IRequest<Guid>
    {
        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم السنة المالية
        /// </summary>
        public string NameAr { get; set; }

        /// <summary>
        /// اسم السنة المالية بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// تاريخ البداية
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// نوع التقويم
        /// </summary>
        public CalendarTypeEnum CalendarType { get; set; }

        /// <summary>
        /// نمط ترقيم الفترات
        /// </summary>
        public string PeriodNumberingPattern { get; set; }

        /// <summary>
        /// حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsAccountId { get; set; }

        /// <summary>
        /// حساب نتيجة النشاط
        /// </summary>
        public string IncomeStatementAccountId { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// السنة المالية الافتراضية
        /// </summary>
        public bool IsDefault { get; set; }
    }
} 