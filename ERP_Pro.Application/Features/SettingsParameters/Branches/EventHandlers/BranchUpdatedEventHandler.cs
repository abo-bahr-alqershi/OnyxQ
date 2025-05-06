using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.EventHandlers
{
    /// <summary>
    /// معالج حدث تحديث فرع
    /// </summary>
    public class BranchUpdatedEventHandler : INotificationHandler<BranchUpdatedEvent>
    {
        private readonly ILogger<BranchUpdatedEventHandler> _logger;

        /// <summary>
        /// المنشئ
        /// </summary>
        public BranchUpdatedEventHandler(ILogger<BranchUpdatedEventHandler> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// معالجة الحدث
        /// </summary>
        public Task Handle(BranchUpdatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("تم تحديث بيانات الفرع: {branchName} ({branchId}) - الحقول المحدثة: {updatedFields}",
                notification.BranchName,
                notification.BranchId,
                string.Join(", ", notification.UpdatedFields));
            
            // يمكن إضافة منطق إضافي مثل إرسال إشعارات، تحديث فهارس البحث، إلخ
            
            return Task.CompletedTask;
        }
    }
}