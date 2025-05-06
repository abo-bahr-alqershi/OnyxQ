using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث حذف سعر صرف
    /// </summary>
    public class ExchangeRateDeletedEventHandler : INotificationHandler<ExchangeRateDeletedEvent>
    {
        private readonly ILogger<ExchangeRateDeletedEventHandler> _logger;

        public ExchangeRateDeletedEventHandler(ILogger<ExchangeRateDeletedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(ExchangeRateDeletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم حذف سعر صرف: المعرف {ExchangeRateId} للعملة {CurrencyId}", 
                notification.ExchangeRateId, 
                notification.CurrencyId);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند حذف سعر صرف
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 