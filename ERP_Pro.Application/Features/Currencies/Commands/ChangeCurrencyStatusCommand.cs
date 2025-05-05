using System;
using MediatR;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر تغيير حالة عملة
    /// </summary>
    public class ChangeCurrencyStatusCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public CurrencyStatusEnum NewStatus { get; set; }
    }
} 