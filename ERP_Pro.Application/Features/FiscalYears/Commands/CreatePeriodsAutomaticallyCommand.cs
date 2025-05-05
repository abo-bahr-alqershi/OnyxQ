using System;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Commands
{
    /// <summary>
    /// أمر إنشاء فترات محاسبية تلقائياً
    /// </summary>
    public class CreatePeriodsAutomaticallyCommand : IRequest<bool>
    {
        /// <summary>
        /// رقم السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; set; }

        /// <summary>
        /// نمط الفترات
        /// </summary>
        public FiscalPeriodTypeEnum PeriodPattern { get; set; }

        /// <summary>
        /// عدد الفترات
        /// </summary>
        public int PeriodsCount { get; set; }

        /// <summary>
        /// بادئة رمز الفترة
        /// </summary>
        public string CodePrefix { get; set; }

        /// <summary>
        /// بادئة اسم الفترة
        /// </summary>
        public string NamePrefix { get; set; }

        /// <summary>
        /// بادئة اسم الفترة بالإنجليزية
        /// </summary>
        public string NamePrefixEn { get; set; }
    }
} 