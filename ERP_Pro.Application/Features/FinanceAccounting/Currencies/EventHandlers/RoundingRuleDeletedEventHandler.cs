using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث حذف قاعدة تقريب العملة
    /// </summary>
    public class RoundingRuleDeletedEventHandler : INotificationHandler<RoundingRuleDeletedEvent>
    {
        private readonly ILogger<RoundingRuleDeletedEventHandler> _logger;

        public RoundingRuleDeletedEventHandler(ILogger<RoundingRuleDeletedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(RoundingRuleDeletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم حذف قاعدة تقريب للعملة {CurrencyId} بالمعرف {RoundingRuleId}", 
                notification.CurrencyId,
                notification.RoundingRuleId);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند حذف قاعدة تقريب
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 