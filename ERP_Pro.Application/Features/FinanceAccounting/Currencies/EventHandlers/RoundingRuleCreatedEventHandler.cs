using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث إنشاء قاعدة تقريب جديدة للعملة
    /// </summary>
    public class RoundingRuleCreatedEventHandler : INotificationHandler<RoundingRuleCreatedEvent>
    {
        private readonly ILogger<RoundingRuleCreatedEventHandler> _logger;

        public RoundingRuleCreatedEventHandler(ILogger<RoundingRuleCreatedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(RoundingRuleCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم إنشاء قاعدة تقريب جديدة للعملة {CurrencyId} بنوع {RoundingType} ووحدة {RoundingUnit}", 
                notification.CurrencyId,
                notification.RoundingRule.RoundingType,
                notification.RoundingRule.RoundingUnit);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند إنشاء قاعدة تقريب جديدة
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 