using System;
using MediatR;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر تغيير حالة حد مخاطر للعملة
    /// </summary>
    public class ChangeCurrencyRiskLimitStatusCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف حد المخاطر
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// الحالة الجديدة (نشط أم لا)
        /// </summary>
        public bool IsActive { get; set; }
    }
} 