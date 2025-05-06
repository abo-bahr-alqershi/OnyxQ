using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteRoundingRule
{
    /// <summary>
    /// أمر حذف قاعدة تقريب
    /// </summary>
    public class DeleteRoundingRuleCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف قاعدة التقريب
        /// </summary>
        public Guid Id { get; set; }
    }
} 