using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على عملة بالرمز
    /// </summary>
    public class GetCurrencyByCodeQuery : IRequest<CurrencyDto>
    {
        /// <summary>
        /// رمز العملة
        /// </summary>
        public string Code { get; set; }
    }
} 