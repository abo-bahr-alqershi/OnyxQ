using System;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على عملة بالمعرف
    /// </summary>
    public class GetCurrencyByIdQuery : IRequest<CurrencyDto>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid Id { get; set; }
    }
} 