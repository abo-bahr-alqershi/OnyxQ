using System;
using MediatR;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر تعيين العملة الأساسية
    /// </summary>
    public class SetBaseCurrencyCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid Id { get; set; }
    }
} 