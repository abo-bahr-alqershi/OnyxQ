using System;
using MediatR;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.ChangePeriodStatus
{
    /// <summary>
    /// أمر تغيير حالة فترة محاسبية
    /// </summary>
    public class ChangePeriodStatusCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; set; }

        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public FiscalPeriodStatusEnum NewStatus { get; set; }

        /// <summary>
        /// سبب تغيير الحالة
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 