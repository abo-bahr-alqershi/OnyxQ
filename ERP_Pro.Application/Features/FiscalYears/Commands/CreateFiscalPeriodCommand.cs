using System;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Commands
{
    /// <summary>
    /// أمر إنشاء فترة محاسبية جديدة
    /// </summary>
    public class CreateFiscalPeriodCommand : IRequest<Guid>
    {
        /// <summary>
        /// رقم السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; set; }

        /// <summary>
        /// رقم الفترة
        /// </summary>
        public int PeriodNumber { get; set; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم الفترة
        /// </summary>
        public string NameAr { get; set; }

        /// <summary>
        /// اسم الفترة بالإنجليزية
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
        /// نوع الفترة
        /// </summary>
        public FiscalPeriodTypeEnum PeriodType { get; set; }

        /// <summary>
        /// رمز الفترة في التقويم
        /// </summary>
        public string CalendarReference { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 