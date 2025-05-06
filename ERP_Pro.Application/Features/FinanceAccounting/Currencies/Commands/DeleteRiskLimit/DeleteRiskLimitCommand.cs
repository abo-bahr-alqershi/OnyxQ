using System;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteRiskLimit
{
    /// <summary>
    /// أمر حذف حد مخاطر
    /// </summary>
    public class DeleteRiskLimitCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف حد المخاطر
        /// </summary>
        public Guid Id { get; set; }
    }
} 