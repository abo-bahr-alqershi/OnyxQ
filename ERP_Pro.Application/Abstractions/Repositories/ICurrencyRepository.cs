using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Abstractions.Repositories
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
        Task<bool> UpdateAsync(Currency currency);

        /// <summary>
        /// حذف عملة
        /// </summary>
        Task<bool> DeleteAsync(CurrencyId id);

        /// <summary>
        /// الحصول على عملة بالمعرف
        /// </summary>
        Task<Currency> GetByIdAsync(CurrencyId id);

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
        Task<List<Currency>> ListAsync(string searchTerm = null, bool? activeOnly = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// التحقق من وجود عملة بالرمز
        /// </summary>
        Task<bool> ExistsByCodeAsync(string code);

        /// <summary>
        /// التحقق من وجود عملة أساسية
        /// </summary>
        Task<bool> ExistsBaseCurrencyAsync();

        /// <summary>
        /// التحقق من إمكانية حذف العملة
        /// </summary>
        Task<bool> CanDeleteAsync(CurrencyId id);

        /// <summary>
        /// إضافة سجل تاريخي لسعر الصرف
        /// </summary>
        Task<ExchangeRateHistory> AddExchangeRateHistoryAsync(ExchangeRateHistory history);

        /// <summary>
        /// الحصول على تاريخ أسعار الصرف لعملة معينة
        /// </summary>
        Task<List<ExchangeRateHistory>> GetExchangeRateHistoryAsync(CurrencyId currencyId, DateTime? startDate = null, DateTime? endDate = null, int? pageNumber = null, int? pageSize = null);

        /// <summary>
        /// إضافة قاعدة تقريب للعملة
        /// </summary>
        Task<CurrencyRoundingRule> AddRoundingRuleAsync(CurrencyRoundingRule rule);

        /// <summary>
        /// الحصول على قواعد تقريب العملة
        /// </summary>
        Task<List<CurrencyRoundingRule>> GetRoundingRulesAsync(CurrencyId currencyId);

        /// <summary>
        /// إضافة حساب للعملة
        /// </summary>
        Task<CurrencyAccount> AddCurrencyAccountAsync(CurrencyAccount account);

        /// <summary>
        /// الحصول على حسابات العملة
        /// </summary>
        Task<List<CurrencyAccount>> GetCurrencyAccountsAsync(CurrencyId currencyId);

        /// <summary>
        /// إضافة حد مخاطر للعملة
        /// </summary>
        Task<CurrencyRiskLimit> AddRiskLimitAsync(CurrencyRiskLimit riskLimit);

        /// <summary>
        /// تحديث حد مخاطر للعملة
        /// </summary>
        Task<bool> UpdateRiskLimitAsync(CurrencyRiskLimit riskLimit);

        /// <summary>
        /// الحصول على حد مخاطر العملة بالمعرف
        /// </summary>
        Task<CurrencyRiskLimit> GetRiskLimitByIdAsync(CurrencyRiskLimitId id);

        /// <summary>
        /// الحصول على حدود مخاطر العملة
        /// </summary>
        Task<List<CurrencyRiskLimit>> GetRiskLimitsAsync(CurrencyId currencyId, bool? activeOnly = null);

        /// <summary>
        /// حفظ التغييرات
        /// </summary>
        Task<int> SaveChangesAsync();
    }
} 