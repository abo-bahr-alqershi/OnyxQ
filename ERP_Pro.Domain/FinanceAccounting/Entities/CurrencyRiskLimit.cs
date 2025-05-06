using System.Collections.Generic;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.Interfaces;
using ERP_Pro.Shared.Events.Base;
using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.Events;
using ERP_Pro.Domain.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Entities
{
    /// <summary>
    private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    /// كيان حد مخاطر العملة - يحدد الحدود المقبولة لأسعار صرف العملة
    /// </summary>
    public class CurrencyRiskLimit : Entity
    {
        /// <summary>
        /// معرف العملة المرتبطة
        /// </summary>
        public Guid CurrencyId { get; private set; }
        
        /// <summary>
        /// الحد الأدنى لسعر الصرف
        /// </summary>
        public decimal MinRate { get; private set; }
        
        /// <summary>
        /// الحد الأعلى لسعر الصرف
        /// </summary>
        public decimal MaxRate { get; private set; }
        
        /// <summary>
        /// نسبة التحذير (%)
        /// </summary>
        public decimal WarningThreshold { get; private set; }
        
        /// <summary>
        /// سعر المستهدف
        /// </summary>
        public decimal TargetRate { get; private set; }
        
        /// <summary>
        /// هل التنبيه مفعل
        /// </summary>
        public bool AlertEnabled { get; private set; }
        
        /// <summary>
        /// تاريخ آخر تحديث
        /// </summary>
        public DateTime LastUpdated { get; private set; }
        
        /// <summary>
        /// محدث بواسطة
        /// </summary>
        public string UpdatedBy { get; private set; }
        
        /// <summary>
        /// العملة (علاقة)
        /// </summary>
        public virtual Currency Currency { get; private set; }
        
        // المُنشئ الخاص - لا يُستخدم مباشرة
        private CurrencyRiskLimit() { }
        
        /// <summary>
        /// إنشاء حد مخاطر جديد
        /// </summary>
        public static CurrencyRiskLimit Create(
            Guid currencyId,
            decimal minRate,
            decimal maxRate,
            decimal warningThreshold,
            decimal targetRate,
            bool alertEnabled,
            string updatedBy)
        {
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));
                
            if (minRate <= 0)
                throw new ArgumentException("الحد الأدنى لسعر الصرف يجب أن يكون موجباً", nameof(minRate));
                
            if (maxRate <= minRate)
                throw new ArgumentException("الحد الأعلى يجب أن يكون أكبر من الحد الأدنى", nameof(maxRate));
                
            if (warningThreshold <= 0 || warningThreshold >= 100)
                throw new ArgumentException("نسبة التحذير يجب أن تكون بين 0 و 100", nameof(warningThreshold));
                
            if (targetRate < minRate || targetRate > maxRate)
                throw new ArgumentException("السعر المستهدف يجب أن يكون بين الحد الأدنى والحد الأعلى", nameof(targetRate));
            
            var riskLimit = new CurrencyRiskLimit
            {
                Id = Guid.NewGuid(),
                CurrencyId = currencyId,
                MinRate = minRate,
                MaxRate = maxRate,
                WarningThreshold = warningThreshold,
                TargetRate = targetRate,
                AlertEnabled = alertEnabled,
                LastUpdated = DateTime.UtcNow,
                UpdatedBy = updatedBy
            };
            
            // إضافة حدث إنشاء حد مخاطر جديد
            riskLimit.AddDomainEvent(new RiskLimitCreatedEvent(riskLimit));
            
            return riskLimit;
        }
        
        /// <summary>
        /// تحديث حد المخاطر
        /// </summary>
        public void Update(
            decimal minRate,
            decimal maxRate,
            decimal warningThreshold,
            decimal targetRate,
            bool alertEnabled,
            string updatedBy)
        {
            if (minRate <= 0)
                throw new ArgumentException("الحد الأدنى لسعر الصرف يجب أن يكون موجباً", nameof(minRate));
                
            if (maxRate <= minRate)
                throw new ArgumentException("الحد الأعلى يجب أن يكون أكبر من الحد الأدنى", nameof(maxRate));
                
            if (warningThreshold <= 0 || warningThreshold >= 100)
                throw new ArgumentException("نسبة التحذير يجب أن تكون بين 0 و 100", nameof(warningThreshold));
                
            if (targetRate < minRate || targetRate > maxRate)
                throw new ArgumentException("السعر المستهدف يجب أن يكون بين الحد الأدنى والحد الأعلى", nameof(targetRate));
            
            MinRate = minRate;
            MaxRate = maxRate;
            WarningThreshold = warningThreshold;
            TargetRate = targetRate;
            AlertEnabled = alertEnabled;
            LastUpdated = DateTime.UtcNow;
            UpdatedBy = updatedBy;
            
            // إضافة حدث تحديث حد المخاطر
            AddDomainEvent(new RiskLimitUpdatedEvent(this));
        }
        
        /// <summary>
        /// تفعيل أو تعطيل التنبيهات
        /// </summary>
        public void SetAlertEnabled(bool alertEnabled, string updatedBy)
        {
            AlertEnabled = alertEnabled;
            LastUpdated = DateTime.UtcNow;
            UpdatedBy = updatedBy;
            
            // إضافة حدث تحديث حد المخاطر
            AddDomainEvent(new RiskLimitUpdatedEvent(this));
        }
        
        /// <summary>
        /// حذف حد المخاطر
        /// </summary>
        public void Delete()
        {
            // إضافة حدث حذف حد المخاطر
            AddDomainEvent(new RiskLimitDeletedEvent(Id, CurrencyId));
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