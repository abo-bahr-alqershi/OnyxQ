using System.Collections.Generic;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Shared.Events.Base;
using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.Events;

namespace ERP_Pro.Domain.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان سعر صرف العملة - يمثل سعر صرف محدد لعملة معينة في وقت محدد
    /// </summary>
    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    public class CurrencyExchangeRate : Entity
    {
        public Guid CurrencyId { get; private set; }
        public DateTime EffectiveDate { get; private set; }
        public string RateType { get; private set; } // أساسي، بيع، شراء
        public decimal Rate { get; private set; }
        public string Source { get; private set; } // يدوي، API، بنك مركزي
        public string Notes { get; private set; }
        
        // علاقات
        public virtual Currency Currency { get; private set; }
        
        // محفوظة للقراءة فقط
        public DateTime CreatedAt { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime? LastModifiedAt { get; private set; }
        public string LastModifiedBy { get; private set; }
        
        // المُنشئ الخاص - لا يُستخدم مباشرة
        private CurrencyExchangeRate() { }
        
        /// <summary>
        /// إنشاء كيان سعر صرف جديد
        /// </summary>
        public static CurrencyExchangeRate Create(
            Guid currencyId,
            DateTime effectiveDate,
            string rateType,
            decimal rate,
            string source = "Manual",
            string notes = null,
            string createdBy = null)
        {
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));
            
            if (rate <= 0)
                throw new ArgumentException("سعر الصرف يجب أن يكون أكبر من صفر", nameof(rate));
            
            if (string.IsNullOrWhiteSpace(rateType))
                throw new ArgumentException("نوع سعر الصرف مطلوب", nameof(rateType));

            var exchangeRate = new CurrencyExchangeRate
            {
                Id = Guid.NewGuid(),
                CurrencyId = currencyId,
                EffectiveDate = effectiveDate,
                RateType = rateType,
                Rate = rate,
                Source = source ?? "Manual",
                Notes = notes,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = createdBy
            };
            
            // إضافة حدث إنشاء سعر صرف جديد
            exchangeRate.AddDomainEvent(new ExchangeRateCreatedEvent(exchangeRate));
            
            return exchangeRate;
        }
        
        /// <summary>
        /// تحديث سعر الصرف
        /// </summary>
        public void Update(
            decimal rate,
            string source = "Manual",
            string notes = null,
            string modifiedBy = null)
        {
            if (rate <= 0)
                throw new ArgumentException("سعر الصرف يجب أن يكون أكبر من صفر", nameof(rate));
            
            Rate = rate;
            Source = source ?? "Manual";
            Notes = notes;
            LastModifiedAt = DateTime.UtcNow;
            LastModifiedBy = modifiedBy;
            
            // إضافة حدث تحديث سعر الصرف
            AddDomainEvent(new ExchangeRateUpdatedEvent(this));
        }
        
        /// <summary>
        /// حذف سعر الصرف
        /// </summary>
        public void Delete()
        {
            // إضافة حدث حذف سعر الصرف
            AddDomainEvent(new ExchangeRateDeletedEvent(Id, CurrencyId));
        }
    }
} 
    /// <summary>
    /// إضافة حدث نطاق
    /// </summary>
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    /// <summary>
    /// إزالة حدث نطاق
    /// </summary>
    public void RemoveDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }

    /// <summary>
    /// مسح أحداث النطاق
    /// </summary>
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }