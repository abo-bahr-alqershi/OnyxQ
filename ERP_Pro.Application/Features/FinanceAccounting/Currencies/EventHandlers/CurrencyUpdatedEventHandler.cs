using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث تحديث العملة
    /// </summary>
    public class CurrencyUpdatedEventHandler : INotificationHandler<CurrencyUpdatedEvent>
    {
        private readonly ILogger<CurrencyUpdatedEventHandler> _logger;

        public CurrencyUpdatedEventHandler(ILogger<CurrencyUpdatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(CurrencyUpdatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("تم تحديث بيانات العملة: {CurrencyId}", notification.CurrencyId);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند تحديث بيانات العملة
            // مثل إرسال إشعارات أو تحديث بيانات أخرى

            return Task.CompletedTask;
        }
    }
} 