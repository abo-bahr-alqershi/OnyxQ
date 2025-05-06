using System;
using MediatR;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodAdjustment
{
    /// <summary>
    /// أمر إنشاء تسوية للفترة المحاسبية
    /// </summary>
    public class CreatePeriodAdjustmentCommand : IRequest<Guid>
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid FiscalPeriodId { get; set; }

        /// <summary>
        /// نوع التسوية
        /// </summary>
        public AdjustmentTypeEnum AdjustmentType { get; set; }

        /// <summary>
        /// تاريخ التسوية
        /// </summary>
        public DateTime AdjustmentDate { get; set; }

        /// <summary>
        /// وصف التسوية
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// معرف قيد التسوية (اختياري)
        /// </summary>
        public Guid? JournalEntryId { get; set; }

        /// <summary>
        /// رقم قيد التسوية (اختياري)
        /// </summary>
        public string JournalEntryNumber { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 