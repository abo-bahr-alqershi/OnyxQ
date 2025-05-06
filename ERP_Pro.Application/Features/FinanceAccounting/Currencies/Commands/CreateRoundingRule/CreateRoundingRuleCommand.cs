using System;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRoundingRule
{
    /// <summary>
    /// أمر إنشاء قاعدة تقريب جديدة للعملة
    /// </summary>
    public class CreateRoundingRuleCommand : IRequest<Guid>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
        
        /// <summary>
        /// نوع التقريب
        /// </summary>
        public string RoundingType { get; set; }
        
        /// <summary>
        /// وصف القاعدة
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// قيمة التقريب
        /// </summary>
        public decimal RoundingValue { get; set; }
        
        /// <summary>
        /// عدد المنازل العشرية
        /// </summary>
        public int DecimalPlaces { get; set; }
        
        /// <summary>
        /// هل القاعدة مفعلة
        /// </summary>
        public bool IsActive { get; set; } = true;
    }
} 