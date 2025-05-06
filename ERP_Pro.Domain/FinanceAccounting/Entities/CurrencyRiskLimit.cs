using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان حد مخاطر العملة - يحدد حدود المخاطر المالية المرتبطة بالعملة
    /// </summary>
    public class CurrencyRiskLimit : Entity
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; private set; }

        /// <summary>
        /// نوع حد المخاطر
        /// </summary>
        public CurrencyRiskLimitTypeEnum LimitType { get; private set; }

        /// <summary>
        /// قيمة الحد
        /// </summary>
        public decimal LimitValue { get; private set; }

        /// <summary>
        /// تاريخ البدء
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// تاريخ الانتهاء (اختياري)
        /// </summary>
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// ينطبق على الفروع (رموز الفروع مفصولة بفواصل، إذا كان فارغاً ينطبق على كل الفروع)
        /// </summary>
        public string ApplicableBranches { get; private set; }

        /// <summary>
        /// مستوى التنبيه (نسبة مئوية من قيمة الحد)
        /// </summary>
        public decimal? AlertThreshold { get; private set; }

        /// <summary>
        /// مستوى التحذير (نسبة مئوية من قيمة الحد)
        /// </summary>
        public decimal? WarningThreshold { get; private set; }

        /// <summary>
        /// هل يتم منع العمليات عند تجاوز الحد؟
        /// </summary>
        public bool BlockTransactionsWhenExceeded { get; private set; }

        /// <summary>
        /// الإجراء المطلوب عند تجاوز الحد
        /// </summary>
        public string ActionWhenExceeded { get; private set; }

        /// <summary>
        /// حالة حد المخاطر
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// العملة (علاقة)
        /// </summary>
        public Currency Currency { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private CurrencyRiskLimit() { }

        /// <summary>
        /// إنشاء كيان حد مخاطر عملة جديد
        /// </summary>
        public static CurrencyRiskLimit Create(
            Guid currencyId,
            CurrencyRiskLimitTypeEnum limitType,
            decimal limitValue,
            DateTime startDate,
            DateTime? endDate = null,
            string applicableBranches = null,
            decimal? alertThreshold = null,
            decimal? warningThreshold = null,
            bool blockTransactionsWhenExceeded = false,
            string actionWhenExceeded = null,
            bool isActive = true,
            string notes = null)
        {
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));

            if (limitValue <= 0)
                throw new ArgumentException("قيمة الحد يجب أن تكون موجبة", nameof(limitValue));

            if (endDate.HasValue && startDate > endDate.Value)
                throw new ArgumentException("تاريخ البدء يجب أن يكون قبل تاريخ الانتهاء", nameof(startDate));

            if (alertThreshold.HasValue && (alertThreshold.Value <= 0 || alertThreshold.Value > 100))
                throw new ArgumentException("مستوى التنبيه يجب أن يكون بين 1 و 100", nameof(alertThreshold));

            if (warningThreshold.HasValue && (warningThreshold.Value <= 0 || warningThreshold.Value > 100))
                throw new ArgumentException("مستوى التحذير يجب أن يكون بين 1 و 100", nameof(warningThreshold));

            if (alertThreshold.HasValue && warningThreshold.HasValue && alertThreshold.Value < warningThreshold.Value)
                throw new ArgumentException("مستوى التنبيه يجب أن يكون أكبر من أو يساوي مستوى التحذير", nameof(alertThreshold));

            return new CurrencyRiskLimit
            {
                Id = Guid.NewGuid(),
                CurrencyId = currencyId,
                LimitType = limitType,
                LimitValue = limitValue,
                StartDate = startDate,
                EndDate = endDate,
                ApplicableBranches = applicableBranches,
                AlertThreshold = alertThreshold,
                WarningThreshold = warningThreshold,
                BlockTransactionsWhenExceeded = blockTransactionsWhenExceeded,
                ActionWhenExceeded = actionWhenExceeded,
                IsActive = isActive,
                Notes = notes
            };
        }

        /// <summary>
        /// تحديث حد المخاطر
        /// </summary>
        public void Update(
            decimal limitValue,
            DateTime? endDate = null,
            string applicableBranches = null,
            decimal? alertThreshold = null,
            decimal? warningThreshold = null,
            bool? blockTransactionsWhenExceeded = null,
            string actionWhenExceeded = null,
            string notes = null)
        {
            if (limitValue <= 0)
                throw new ArgumentException("قيمة الحد يجب أن تكون موجبة", nameof(limitValue));

            if (endDate.HasValue && StartDate > endDate.Value)
                throw new ArgumentException("تاريخ البدء يجب أن يكون قبل تاريخ الانتهاء", nameof(endDate));

            if (alertThreshold.HasValue && (alertThreshold.Value <= 0 || alertThreshold.Value > 100))
                throw new ArgumentException("مستوى التنبيه يجب أن يكون بين 1 و 100", nameof(alertThreshold));

            if (warningThreshold.HasValue && (warningThreshold.Value <= 0 || warningThreshold.Value > 100))
                throw new ArgumentException("مستوى التحذير يجب أن يكون بين 1 و 100", nameof(warningThreshold));

            if (alertThreshold.HasValue && warningThreshold.HasValue && alertThreshold.Value < warningThreshold.Value)
                throw new ArgumentException("مستوى التنبيه يجب أن يكون أكبر من أو يساوي مستوى التحذير", nameof(alertThreshold));

            LimitValue = limitValue;
            
            if (endDate.HasValue)
                EndDate = endDate;
                
            if (applicableBranches != null)
                ApplicableBranches = applicableBranches;
                
            if (alertThreshold.HasValue)
                AlertThreshold = alertThreshold;
                
            if (warningThreshold.HasValue)
                WarningThreshold = warningThreshold;
                
            if (blockTransactionsWhenExceeded.HasValue)
                BlockTransactionsWhenExceeded = blockTransactionsWhenExceeded.Value;
                
            if (actionWhenExceeded != null)
                ActionWhenExceeded = actionWhenExceeded;
                
            if (notes != null)
                Notes = notes;
        }

        /// <summary>
        /// تفعيل حد المخاطر
        /// </summary>
        public void Activate()
        {
            IsActive = true;
        }

        /// <summary>
        /// تعطيل حد المخاطر
        /// </summary>
        public void Deactivate()
        {
            IsActive = false;
        }

        /// <summary>
        /// التحقق من صلاحية حد المخاطر في تاريخ معين
        /// </summary>
        public bool IsValid(DateTime date)
        {
            if (date < StartDate)
                return false;

            if (EndDate.HasValue && date > EndDate.Value)
                return false;

            return IsActive;
        }

        /// <summary>
        /// التحقق من تجاوز حد المخاطر
        /// </summary>
        public bool IsExceeded(decimal currentValue)
        {
            return currentValue > LimitValue;
        }

        /// <summary>
        /// التحقق من وصول الحد إلى مستوى التنبيه
        /// </summary>
        public bool IsAlertTriggered(decimal currentValue)
        {
            if (!AlertThreshold.HasValue)
                return false;

            return currentValue >= (LimitValue * AlertThreshold.Value / 100);
        }

        /// <summary>
        /// التحقق من وصول الحد إلى مستوى التحذير
        /// </summary>
        public bool IsWarningTriggered(decimal currentValue)
        {
            if (!WarningThreshold.HasValue)
                return false;

            return currentValue >= (LimitValue * WarningThreshold.Value / 100);
        }

        /// <summary>
        /// التحقق من تطبيق حد المخاطر على فرع معين
        /// </summary>
        public bool IsApplicableToBranch(string branchCode)
        {
            if (string.IsNullOrWhiteSpace(ApplicableBranches))
                return true;

            return ApplicableBranches.Contains(branchCode);
        }
    }
} 