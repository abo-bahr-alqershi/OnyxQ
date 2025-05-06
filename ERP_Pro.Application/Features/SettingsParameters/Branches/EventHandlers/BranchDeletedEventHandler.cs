using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.EventHandlers
{
    /// <summary>
    /// معالج حدث حذف فرع
    /// </summary>
    public class BranchDeletedEventHandler : INotificationHandler<BranchDeletedEvent>
    {
        private readonly ILogger<BranchDeletedEventHandler> _logger;

        /// <summary>
        /// المنشئ
        /// </summary>
        public BranchDeletedEventHandler(ILogger<BranchDeletedEventHandler> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// معالجة الحدث
        /// </summary>
        public Task Handle(BranchDeletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("تم حذف الفرع: {branchName} ({branchId}) - حذف التابعين: {deleteDependents}",
                notification.BranchName,
                notification.BranchId,
                notification.DeleteDependents);
            
            // يمكن إضافة منطق إضافي مثل إرسال إشعارات، تحديث الإحصائيات، إلخ
            
            return Task.CompletedTask;
        }
    }
} 