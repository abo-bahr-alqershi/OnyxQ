using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Application.Contracts.Persistence.FinanceAccounting
{
    /// <summary>
    /// واجهة مستودع العملات
    /// </summary>
    public interface ICurrencyRepository
    {
        /// <summary>
        /// إضافة عملة جديدة
        /// </summary>
        Task<Currency> AddAsync(Currency currency);

        /// <summary>
        /// تحديث عملة
        /// </summary>
        Task UpdateAsync(Currency currency);

        /// <summary>
        /// حذف عملة
        /// </summary>
        Task DeleteAsync(Guid id);

        /// <summary>
        /// الحصول على عملة بالمعرف
        /// </summary>
        Task<Currency> GetByIdAsync(Guid id);

        /// <summary>
        /// الحصول على عملة بالرمز
        /// </summary>
        Task<Currency> GetByCodeAsync(string code);

        /// <summary>
        /// الحصول على العملة الأساسية
        /// </summary>
        Task<Currency> GetBaseCurrencyAsync();

        /// <summary>
        /// الحصول على قائمة العملات
        /// </summary>
        Task<List<Currency>> GetAllAsync(bool? activeOnly = null, string searchTerm = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// التحقق من تفرد رمز العملة
        /// </summary>
        Task<bool> IsCodeUniqueAsync(string code, Guid? excludeId = null);

        /// <summary>
        /// التحقق من إمكانية حذف العملة
        /// </summary>
        Task<bool> CanDeleteAsync(Guid id);

        // قواعد التقريب

        /// <summary>
        /// إضافة قاعدة تقريب للعملة
        /// </summary>
        Task<CurrencyRoundingRule> AddRoundingRuleAsync(CurrencyRoundingRule rule);

        /// <summary>
        /// تحديث قاعدة تقريب للعملة
        /// </summary>
        Task UpdateRoundingRuleAsync(CurrencyRoundingRule rule);

        /// <summary>
        /// حذف قاعدة تقريب للعملة
        /// </summary>
        Task DeleteRoundingRuleAsync(Guid id);

        /// <summary>
        /// الحصول على قاعدة تقريب معينة
        /// </summary>
        Task<CurrencyRoundingRule> GetRoundingRuleByIdAsync(Guid id);

        /// <summary>
        /// الحصول على قواعد تقريب العملة
        /// </summary>
        Task<List<CurrencyRoundingRule>> GetRoundingRulesAsync(Guid currencyId);

        // حدود المخاطر

        /// <summary>
        /// إضافة حد مخاطر للعملة
        /// </summary>
        Task<CurrencyRiskLimit> AddRiskLimitAsync(CurrencyRiskLimit limit);

        /// <summary>
        /// تحديث حد مخاطر للعملة
        /// </summary>
        Task UpdateRiskLimitAsync(CurrencyRiskLimit limit);

        /// <summary>
        /// حذف حد مخاطر للعملة
        /// </summary>
        Task DeleteRiskLimitAsync(Guid id);

        /// <summary>
        /// الحصول على حد مخاطر معين
        /// </summary>
        Task<CurrencyRiskLimit> GetRiskLimitByIdAsync(Guid id);

        /// <summary>
        /// الحصول على حدود مخاطر العملة
        /// </summary>
        Task<List<CurrencyRiskLimit>> GetRiskLimitsAsync(Guid currencyId);
    }
} 