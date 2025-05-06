using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.EventHandlers
{
    /// <summary>
    /// معالج حدث إنشاء فرع
    /// </summary>
    public class BranchCreatedEventHandler : INotificationHandler<BranchCreatedEvent>
    {
        private readonly ILogger<BranchCreatedEventHandler> _logger;

        /// <summary>
        /// المنشئ
        /// </summary>
        public BranchCreatedEventHandler(ILogger<BranchCreatedEventHandler> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// معالجة الحدث
        /// </summary>
        public Task Handle(BranchCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("تم إنشاء فرع جديد: {branchName} ({branchId})", notification.BranchName, notification.BranchId);
            
            // يمكن إضافة منطق إضافي مثل إرسال إشعارات، تحديث فهارس البحث، إلخ
            
            return Task.CompletedTask;
        }
    }
} 