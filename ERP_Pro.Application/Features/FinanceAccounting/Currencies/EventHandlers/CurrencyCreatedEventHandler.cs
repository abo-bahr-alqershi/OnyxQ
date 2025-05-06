using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث إنشاء عملة جديدة
    /// </summary>
    public class CurrencyCreatedEventHandler : INotificationHandler<CurrencyCreatedEvent>
    {
        private readonly ILogger<CurrencyCreatedEventHandler> _logger;

        public CurrencyCreatedEventHandler(ILogger<CurrencyCreatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(CurrencyCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("تم إنشاء عملة جديدة: {CurrencyCode} - {CurrencyName}", 
                notification.Currency.Code, 
                notification.Currency.NameAr);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند إنشاء عملة جديدة
            // مثل إرسال إشعارات أو تحديث بيانات أخرى

            return Task.CompletedTask;
        }
    }
} 