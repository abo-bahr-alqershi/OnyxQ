using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRiskLimit
{
    /// <summary>
    /// أمر إنشاء حد مخاطر جديد للعملة
    /// </summary>
    public class CreateRiskLimitCommand : IRequest<Guid>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
        
        /// <summary>
        /// الحد الأدنى لسعر الصرف
        /// </summary>
        public decimal MinRate { get; set; }
        
        /// <summary>
        /// الحد الأعلى لسعر الصرف
        /// </summary>
        public decimal MaxRate { get; set; }
        
        /// <summary>
        /// نسبة التحذير (%)
        /// </summary>
        public decimal WarningThreshold { get; set; }
        
        /// <summary>
        /// سعر المستهدف
        /// </summary>
        public decimal TargetRate { get; set; }
        
        /// <summary>
        /// هل التنبيه مفعل؟
        /// </summary>
        public bool AlertEnabled { get; set; } = true;
    }
} 