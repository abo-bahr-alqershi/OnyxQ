using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث إنشاء حد مخاطر جديد للعملة
    /// </summary>
    public class RiskLimitCreatedEventHandler : INotificationHandler<RiskLimitCreatedEvent>
    {
        private readonly ILogger<RiskLimitCreatedEventHandler> _logger;

        public RiskLimitCreatedEventHandler(ILogger<RiskLimitCreatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(RiskLimitCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم إنشاء حد مخاطر جديد للعملة {CurrencyId} بحدود [{MinRate} - {MaxRate}]", 
                notification.CurrencyId,
                notification.RiskLimit.MinRate,
                notification.RiskLimit.MaxRate);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند إنشاء حد مخاطر جديد
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 