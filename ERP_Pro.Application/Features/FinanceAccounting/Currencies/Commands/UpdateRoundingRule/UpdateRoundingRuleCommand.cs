using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateRoundingRule
{
    /// <summary>
    /// أمر تحديث قاعدة تقريب للعملة
    /// </summary>
    public class UpdateRoundingRuleCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف قاعدة التقريب
        /// </summary>
        public Guid Id { get; set; }
        
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
        public bool IsActive { get; set; }
    }
}