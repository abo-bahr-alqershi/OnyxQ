using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Application.FinanceAccounting.Repositories
{
    /// <summary>
    /// مستودع لإدارة العملات في النظام
    /// </summary>
    public interface ICurrencyRepository
    {
        /// <summary>
        /// استرجاع جميع العملات مع إمكانية التصفية
        /// </summary>
        Task<IEnumerable<Currency>> GetAllAsync(bool? activeOnly = null, string searchTerm = null);
        
        /// <summary>
        /// استرجاع عملة محددة بالمعرف
        /// </summary>
        Task<Currency> GetByIdAsync(Guid id);
        
        /// <summary>
        /// استرجاع عملة محددة بالرمز
        /// </summary>
        Task<Currency> GetByCodeAsync(string code);
        
        /// <summary>
        /// استرجاع العملة الأساسية المحددة في النظام
        /// </summary>
        Task<Currency> GetBaseCurrencyAsync();
        
        /// <summary>
        /// إضافة عملة جديدة
        /// </summary>
        Task AddAsync(Currency currency);
        
        /// <summary>
        /// تحديث عملة موجودة
        /// </summary>
        Task UpdateAsync(Currency currency);
        
        /// <summary>
        /// حذف عملة
        /// </summary>
        Task DeleteAsync(Guid id);
        
        /// <summary>
        /// التحقق من تفرد رمز العملة
        /// </summary>
        Task<bool> IsCodeUniqueAsync(string code, Guid? excludeId = null);
        
        /// <summary>
        /// إضافة سعر صرف جديد لعملة
        /// </summary>
        Task AddExchangeRateAsync(CurrencyExchangeRate exchangeRate);
        
        /// <summary>
        /// تحديث سعر صرف لعملة
        /// </summary>
        Task UpdateExchangeRateAsync(CurrencyExchangeRate exchangeRate);
        
        /// <summary>
        /// حذف سعر صرف لعملة
        /// </summary>
        Task DeleteExchangeRateAsync(Guid id);
        
        /// <summary>
        /// الحصول على أسعار صرف عملة معينة
        /// </summary>
        Task<IEnumerable<CurrencyExchangeRate>> GetExchangeRatesAsync(Guid currencyId, DateTime? fromDate = null, DateTime? toDate = null, string rateType = null);
        
        /// <summary>
        /// الحصول على أحدث سعر صرف لعملة معينة
        /// </summary>
        Task<CurrencyExchangeRate> GetLatestExchangeRateAsync(Guid currencyId, string rateType = "Base");
    }
} 