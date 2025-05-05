using System;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر إضافة حد مخاطر للعملة
    /// </summary>
    public class AddCurrencyRiskLimitCommand : IRequest<CurrencyRiskLimitDto>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }

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