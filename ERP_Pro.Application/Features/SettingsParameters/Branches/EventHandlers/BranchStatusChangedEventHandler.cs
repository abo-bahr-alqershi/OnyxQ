using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.EventHandlers
{
    /// <summary>
    /// معالج حدث تغيير حالة فرع
    /// </summary>
    public class BranchStatusChangedEventHandler : INotificationHandler<BranchStatusChangedEvent>
    {
        private readonly ILogger<BranchStatusChangedEventHandler> _logger;

        /// <summary>
        /// المنشئ
        /// </summary>
        public BranchStatusChangedEventHandler(ILogger<BranchStatusChangedEventHandler> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// معالجة الحدث
        /// </summary>
        public Task Handle(BranchStatusChangedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("تم تغيير حالة الفرع: {branchName} ({branchId}) من {oldStatus} إلى {newStatus}",
                notification.BranchName,
                notification.BranchId,
                notification.OldStatus,
                notification.NewStatus);
            
            // يمكن إضافة منطق إضافي مثل إرسال إشعارات، تحديث حالة المستودعات المرتبطة، إلخ
            
            return Task.CompletedTask;
        }
    }
} 