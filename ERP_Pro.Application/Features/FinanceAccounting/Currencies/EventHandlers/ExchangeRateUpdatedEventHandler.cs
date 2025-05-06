using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث تحديث سعر صرف
    /// </summary>
    public class ExchangeRateUpdatedEventHandler : INotificationHandler<ExchangeRateUpdatedEvent>
    {
        private readonly ILogger<ExchangeRateUpdatedEventHandler> _logger;

        public ExchangeRateUpdatedEventHandler(ILogger<ExchangeRateUpdatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(ExchangeRateUpdatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم تحديث سعر صرف: المعرف {ExchangeRateId} للعملة {CurrencyId} بقيمة جديدة {Rate}", 
                notification.ExchangeRateId, 
                notification.CurrencyId,
                notification.ExchangeRate.Rate);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند تحديث سعر صرف
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 