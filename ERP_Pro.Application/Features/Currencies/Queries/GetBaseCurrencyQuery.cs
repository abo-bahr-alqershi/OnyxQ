using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على العملة الأساسية
    /// </summary>
    public class GetBaseCurrencyQuery : IRequest<CurrencyDto>
    {
    }
} 