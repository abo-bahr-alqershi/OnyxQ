using System;
using MediatR;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.LockPeriod
{
    /// <summary>
    /// أمر تأمين الفترة المحاسبية
    /// </summary>
    public class LockPeriodCommand : IRequest<Guid>
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; set; }

        /// <summary>
        /// نوع التأمين
        /// </summary>
        public LockTypeEnum LockType { get; set; }

        /// <summary>
        /// سبب التأمين
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// تاريخ نهاية التأمين (اختياري: للتأمين المؤقت)
        /// </summary>
        public DateTime? LockEndDate { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 