using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.Common.Interfaces;

namespace ERP_Pro.Infrastructure.Services
{
    /// <summary>
    /// خدمة أحداث النطاق
    /// </summary>
    public class DomainEventService : IDomainEventService
    {
        private readonly ILogger<DomainEventService> _logger;
        private readonly IDomainEventDispatcher _dispatcher;

        /// <summary>
        /// المنشئ
        /// </summary>
        public DomainEventService(
            ILogger<DomainEventService> logger,
            IDomainEventDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        /// <summary>
        /// نشر حدث نطاق
        /// </summary>
        public async Task Publish(IDomainEvent domainEvent)
        {
            _logger.LogInformation("نشر حدث نطاق من نوع {eventType}", domainEvent.GetType().Name);
            
            try
            {
                await _dispatcher.DispatchAsync(domainEvent);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "حدث خطأ أثناء معالجة حدث النطاق {eventType}", domainEvent.GetType().Name);
                throw;
            }
        }
    }
} 