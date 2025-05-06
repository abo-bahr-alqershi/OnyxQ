using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث تغيير حالة العملة
    /// </summary>
    public class CurrencyStatusChangedEventHandler : INotificationHandler<CurrencyStatusChangedEvent>
    {
        private readonly ILogger<CurrencyStatusChangedEventHandler> _logger;

        public CurrencyStatusChangedEventHandler(ILogger<CurrencyStatusChangedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(CurrencyStatusChangedEvent notification, CancellationToken cancellationToken)
        {
            string statusText = notification.IsActive ? "تفعيل" : "تعطيل";
            
            _logger.LogInformation("تم {StatusChange} العملة: {CurrencyCode}", 
                statusText,
                notification.Currency.Code);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند تغيير حالة العملة
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 