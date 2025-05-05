using System;
using MediatR;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر تحديث حد مخاطر للعملة
    /// </summary>
    public class UpdateCurrencyRiskLimitCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف حد المخاطر
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// الحد الأقصى للتقلب اليومي (النسبة المئوية)
        /// </summary>
        public decimal MaxDailyFluctuation { get; set; }

        /// <summary>
        /// عتبة التنبيه (النسبة المئوية)
        /// </summary>
        public decimal AlertThreshold { get; set; }

        /// <summary>
        /// الحد الأقصى للتعرض للمخاطر
        /// </summary>
        public decimal MaxExposure { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 