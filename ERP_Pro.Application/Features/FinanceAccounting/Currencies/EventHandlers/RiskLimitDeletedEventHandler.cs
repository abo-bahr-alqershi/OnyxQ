using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.EventHandlers
{
    /// <summary>
    /// معالج حدث حذف حد مخاطر العملة
    /// </summary>
    public class RiskLimitDeletedEventHandler : INotificationHandler<RiskLimitDeletedEvent>
    {
        private readonly ILogger<RiskLimitDeletedEventHandler> _logger;

        public RiskLimitDeletedEventHandler(ILogger<RiskLimitDeletedEventHandler> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public Task Handle(RiskLimitDeletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation(
                "تم حذف حد مخاطر للعملة {CurrencyId} بالمعرف {RiskLimitId}", 
                notification.CurrencyId,
                notification.RiskLimitId);

            // يمكن هنا إضافة أي منطق إضافي يجب تنفيذه عند حذف حد مخاطر
            // مثل إرسال إشعارات أو تحديث بيانات أخرى
            
            return Task.CompletedTask;
        }
    }
} 