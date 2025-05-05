using System;
using MediatR;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر تحديث سعر الصرف
    /// </summary>
    public class UpdateExchangeRateCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// سعر الصرف
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// نوع سعر الصرف
        /// </summary>
        public ExchangeRateTypeEnum RateType { get; set; }

        /// <summary>
        /// مصدر سعر الصرف
        /// </summary>
        public ExchangeRateSourceEnum Source { get; set; }

        /// <summary>
        /// معرف المصدر الخارجي (إذا كان من API أو ملف مستورد)
        /// </summary>
        public string ExternalSourceId { get; set; }

        /// <summary>
        /// ملاحظات إضافية
        /// </summary>
        public string Notes { get; set; }
    }
} 