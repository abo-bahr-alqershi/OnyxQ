using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MediatR;
using ERP_Pro.Domain.Common.Interfaces;

namespace ERP_Pro.Infrastructure.Services
{
    /// <summary>
    /// موزع أحداث النطاق
    /// </summary>
    public class DomainEventDispatcher : IDomainEventDispatcher
    {
        private readonly ILogger<DomainEventDispatcher> _logger;
        private readonly IPublisher _mediator;

        /// <summary>
        /// المنشئ
        /// </summary>
        public DomainEventDispatcher(
            ILogger<DomainEventDispatcher> logger,
            IPublisher mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        /// <summary>
        /// توزيع حدث النطاق
        /// </summary>
        public async Task DispatchAsync(IDomainEvent domainEvent)
        {
            _logger.LogDebug("إرسال حدث نطاق: {eventType}", domainEvent.GetType().Name);
            
            try
            {
                await _mediator.Publish(domainEvent);
                _logger.LogDebug("تم إرسال حدث النطاق بنجاح: {eventType}", domainEvent.GetType().Name);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "حدث خطأ أثناء إرسال حدث النطاق: {eventType}", domainEvent.GetType().Name);
                throw;
            }
        }
    }
} 