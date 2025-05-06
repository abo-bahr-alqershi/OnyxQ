using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.FinanceAccounting.Events
{
    /// <summary>
    /// حدث تغيير حالة العملة (تفعيل/تعطيل)
    /// </summary>
    public class CurrencyStatusChangedEvent : DomainEvent
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; }
        
        /// <summary>
        /// العملة التي تم تغيير حالتها
        /// </summary>
        public Currency Currency { get; }
        
        /// <summary>
        /// الحالة الجديدة للعملة (نشطة أو غير نشطة)
        /// </summary>
        public bool IsActive { get; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public CurrencyStatusChangedEvent(Currency currency)
        {
            if (currency == null)
                throw new ArgumentNullException(nameof(currency));
                
            CurrencyId = currency.Id;
            Currency = currency;
            IsActive = currency.IsActive;
        }
    }
}