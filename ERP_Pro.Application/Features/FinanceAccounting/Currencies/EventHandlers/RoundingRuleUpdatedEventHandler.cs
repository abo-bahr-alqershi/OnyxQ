using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث تحديث قاعدة تقريب العملة
    /// </summary>
    public class RoundingRuleUpdatedEventHandler : INotificationHandler<RoundingRuleUpdatedEvent>
    {
        private readonly ILogger<RoundingRuleUpdatedEventHandler> _logger;

        public RoundingRuleUpdatedEventHandler(ILogger<RoundingRuleUpdatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(RoundingRuleUpdatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم تحديث قاعدة تقريب للعملة {CurrencyId} بالمعرف {RoundingRuleId} إلى نوع {RoundingType} ووحدة {RoundingUnit}", 
                notification.CurrencyId,
                notification.RoundingRuleId,
                notification.RoundingRule.RoundingType,
                notification.RoundingRule.RoundingUnit);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند تحديث قاعدة تقريب
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 