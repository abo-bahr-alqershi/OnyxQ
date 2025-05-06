using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.FinanceAccounting.Entities;

namespace ERP_Pro.Application.Contracts.Persistence.FinanceAccounting
{
    /// <summary>
    /// واجهة مستودع أسعار صرف العملات
    /// </summary>
    public interface ICurrencyExchangeRateRepository
    {
        /// <summary>
        /// الحصول على سجل سعر صرف بالمعرف
        /// </summary>
        Task<CurrencyExchangeRate> GetByIdAsync(Guid id);

        /// <summary>
        /// إضافة سعر صرف جديد
        /// </summary>
        Task<CurrencyExchangeRate> AddAsync(CurrencyExchangeRate exchangeRate);

        /// <summary>
        /// تحديث سعر صرف
        /// </summary>
        Task UpdateAsync(CurrencyExchangeRate exchangeRate);

        /// <summary>
        /// حذف سعر صرف
        /// </summary>
        Task DeleteAsync(Guid id);

        /// <summary>
        /// الحصول على تاريخ أسعار صرف عملة معينة
        /// </summary>
        Task<IEnumerable<CurrencyExchangeRate>> GetExchangeRateHistoryAsync(
            Guid currencyId, 
            DateTime? startDate = null, 
            DateTime? endDate = null, 
            string rateType = null,
            int? pageNumber = null,
            int? pageSize = null);

        /// <summary>
        /// الحصول على أحدث سعر صرف لعملة معينة
        /// </summary>
        Task<CurrencyExchangeRate> GetLatestExchangeRateAsync(Guid currencyId, string rateType = null);
    }
} 