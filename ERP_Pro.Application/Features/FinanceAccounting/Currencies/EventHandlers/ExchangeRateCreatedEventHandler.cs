using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث إنشاء سعر صرف جديد
    /// </summary>
    public class ExchangeRateCreatedEventHandler : INotificationHandler<ExchangeRateCreatedEvent>
    {
        private readonly ILogger<ExchangeRateCreatedEventHandler> _logger;

        public ExchangeRateCreatedEventHandler(ILogger<ExchangeRateCreatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(ExchangeRateCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("تم إنشاء سعر صرف جديد للعملة {CurrencyId} بقيمة {Rate} بتاريخ {EffectiveDate}", 
                notification.ExchangeRate.CurrencyId, 
                notification.ExchangeRate.Rate,
                notification.ExchangeRate.EffectiveDate);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند إنشاء سعر صرف جديد
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 