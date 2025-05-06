using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateExchangeRate
{
    /// <summary>
    /// أمر إنشاء سعر صرف جديد
    /// </summary>
    public class CreateExchangeRateCommand : IRequest<Guid>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
        
        /// <summary>
        /// تاريخ سريان سعر الصرف
        /// </summary>
        public DateTime EffectiveDate { get; set; }
        
        /// <summary>
        /// نوع سعر الصرف (أساسي، بيع، شراء)
        /// </summary>
        public string RateType { get; set; }
        
        /// <summary>
        /// قيمة سعر الصرف
        /// </summary>
        public decimal Rate { get; set; }
        
        /// <summary>
        /// مصدر سعر الصرف (يدوي، API، بنك مركزي)
        /// </summary>
        public string Source { get; set; }
        
        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 