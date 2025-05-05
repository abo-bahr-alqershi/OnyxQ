using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان يمثل الإعدادات المتقدمة للسنة المالية
    /// </summary>
    public class FiscalYearSetting : Entity<FiscalYearSettingId>
    {
        private FiscalYearSetting() { }

        public FiscalYearSetting(
            FiscalYearSettingId id,
            FiscalYearId fiscalYearId,
            string settingType,
            string settingName,
            string settingValue,
            string description)
        {
            Id = id;
            FiscalYearId = fiscalYearId;
            SettingType = settingType;
            SettingName = settingName;
            SettingValue = settingValue;
            Description = description;
            Status = true; // نشط افتراضياً
            CreatedBy = string.Empty;
            CreationDate = DateTime.Now;
        }

        /// <summary>
        /// رقم التعريف
        /// </summary>
        public FiscalYearSettingId Id { get; private set; }

        /// <summary>
        /// رقم السنة المالية
        /// </summary>
        public FiscalYearId FiscalYearId { get; private set; }

        /// <summary>
        /// نوع الإعداد
        /// </summary>
        public string SettingType { get; private set; }

        /// <summary>
        /// اسم الإعداد
        /// </summary>
        public string SettingName { get; private set; }

        /// <summary>
        /// قيمة الإعداد
        /// </summary>
        public string SettingValue { get; private set; }

        /// <summary>
        /// وصف الإعداد
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// تاريخ التطبيق
        /// </summary>
        public DateTime? EffectiveDate { get; private set; }

        /// <summary>
        /// حالة الإعداد
        /// </summary>
        public bool Status { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ الإعداد
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ إنشاء الإعداد
        /// </summary>
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل للإعداد
        /// </summary>
        public string UpdatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل للإعداد
        /// </summary>
        public DateTime? UpdateDate { get; private set; }

        /// <summary>
        /// السنة المالية التي ينتمي إليها الإعداد
        /// </summary>
        public FiscalYear FiscalYear { get; private set; }

        #region Methods

        /// <summary>
        /// تحديث بيانات الإعداد
        /// </summary>
        public void Update(
            string settingType,
            string settingName,
            string settingValue,
            string description,
            DateTime? effectiveDate,
            bool status,
            string updatedBy)
        {
            SettingType = settingType;
            SettingName = settingName;
            SettingValue = settingValue;
            Description = description;
            EffectiveDate = effectiveDate;
            Status = status;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تفعيل الإعداد
        /// </summary>
        public void Activate(string updatedBy)
        {
            Status = true;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        /// <summary>
        /// تعطيل الإعداد
        /// </summary>
        public void Deactivate(string updatedBy)
        {
            Status = false;
            UpdatedBy = updatedBy;
            UpdateDate = DateTime.Now;
        }

        #endregion
    }
} 