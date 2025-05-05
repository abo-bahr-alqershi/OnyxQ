using System;
using MediatR;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر حذف عملة
    /// </summary>
    public class DeleteCurrencyCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid Id { get; set; }
    }
} 