using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using ERP_Pro.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace ERP_Pro.Infrastructure.Persistence.Repositories.FinanceAccounting
{
    /// <summary>
    /// تنفيذ مستودع أسعار صرف العملات
    /// </summary>
    public class CurrencyExchangeRateRepository : ICurrencyExchangeRateRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CurrencyExchangeRateRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        /// <summary>
        /// الحصول على سجل سعر صرف بالمعرف
        /// </summary>
        public async Task<CurrencyExchangeRate> GetByIdAsync(Guid id)
        {
            return await _dbContext.CurrencyExchangeRates
                .FindAsync(id);
        }

        /// <summary>
        /// إضافة سعر صرف جديد
        /// </summary>
        public async Task<CurrencyExchangeRate> AddAsync(CurrencyExchangeRate exchangeRate)
        {
            if (exchangeRate == null)
                throw new ArgumentNullException(nameof(exchangeRate));

            await _dbContext.CurrencyExchangeRates.AddAsync(exchangeRate);
            await _dbContext.SaveChangesAsync();
            
            return exchangeRate;
        }

        /// <summary>
        /// تحديث سعر صرف
        /// </summary>
        public async Task UpdateAsync(CurrencyExchangeRate exchangeRate)
        {
            if (exchangeRate == null)
                throw new ArgumentNullException(nameof(exchangeRate));

            _dbContext.Entry(exchangeRate).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// حذف سعر صرف
        /// </summary>
        public async Task DeleteAsync(Guid id)
        {
            var exchangeRate = await _dbContext.CurrencyExchangeRates.FindAsync(id);
            if (exchangeRate != null)
            {
                _dbContext.CurrencyExchangeRates.Remove(exchangeRate);
                await _dbContext.SaveChangesAsync();
            }
        }

        /// <summary>
        /// الحصول على تاريخ أسعار صرف عملة معينة
        /// </summary>
        public async Task<IEnumerable<CurrencyExchangeRate>> GetExchangeRateHistoryAsync(
            Guid currencyId, 
            DateTime? startDate = null, 
            DateTime? endDate = null, 
            string rateType = null,
            int? pageNumber = null,
            int? pageSize = null)
        {
            IQueryable<CurrencyExchangeRate> query = _dbContext.CurrencyExchangeRates
                .Where(r => r.CurrencyId == currencyId);
                
            if (startDate.HasValue)
            {
                query = query.Where(r => r.EffectiveDate >= startDate.Value);
            }
            
            if (endDate.HasValue)
            {
                query = query.Where(r => r.EffectiveDate <= endDate.Value);
            }
            
            if (!string.IsNullOrWhiteSpace(rateType))
            {
                query = query.Where(r => r.RateType == rateType);
            }
            
            query = query.OrderByDescending(r => r.EffectiveDate);

            // تطبيق الصفحات إذا كانت محددة
            if (pageNumber.HasValue && pageSize.HasValue && pageSize.Value > 0)
            {
                int skip = (pageNumber.Value - 1) * pageSize.Value;
                query = query.Skip(skip).Take(pageSize.Value);
            }
            
            return await query.ToListAsync();
        }

        /// <summary>
        /// الحصول على أحدث سعر صرف لعملة معينة
        /// </summary>
        public async Task<CurrencyExchangeRate> GetLatestExchangeRateAsync(Guid currencyId, string rateType = null)
        {
            IQueryable<CurrencyExchangeRate> query = _dbContext.CurrencyExchangeRates
                .Where(r => r.CurrencyId == currencyId);
                
            if (!string.IsNullOrWhiteSpace(rateType))
            {
                query = query.Where(r => r.RateType == rateType);
            }
            
            return await query
                .OrderByDescending(r => r.EffectiveDate)
                .FirstOrDefaultAsync();
        }
    }
} 