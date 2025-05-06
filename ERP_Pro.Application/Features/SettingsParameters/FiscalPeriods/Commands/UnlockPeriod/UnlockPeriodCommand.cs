using System;
using MediatR;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.UnlockPeriod
{
    /// <summary>
    /// أمر إلغاء تأمين فترة محاسبية
    /// </summary>
    public class UnlockPeriodCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; set; }

        /// <summary>
        /// معرف التأمين المراد إلغاؤه (اختياري: إذا لم يتم تحديده سيتم إلغاء آخر تأمين نشط)
        /// </summary>
        public Guid? LockId { get; set; }

        /// <summary>
        /// سبب إلغاء التأمين
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 