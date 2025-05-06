using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث تحديث حد مخاطر العملة
    /// </summary>
    public class RiskLimitUpdatedEventHandler : INotificationHandler<RiskLimitUpdatedEvent>
    {
        private readonly ILogger<RiskLimitUpdatedEventHandler> _logger;

        public RiskLimitUpdatedEventHandler(ILogger<RiskLimitUpdatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(RiskLimitUpdatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم تحديث حد مخاطر للعملة {CurrencyId} بالمعرف {RiskLimitId} إلى حدود [{MinRate} - {MaxRate}]", 
                notification.CurrencyId,
                notification.RiskLimitId,
                notification.RiskLimit.MinRate,
                notification.RiskLimit.MaxRate);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند تحديث حد مخاطر
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 