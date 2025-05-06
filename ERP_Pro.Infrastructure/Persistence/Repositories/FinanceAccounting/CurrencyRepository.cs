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
    /// تنفيذ مستودع العملات
    /// </summary>
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CurrencyRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        #region Currency Operations

        public async Task<Currency> AddAsync(Currency currency)
        {
            await _dbContext.Currencies.AddAsync(currency);
            await _dbContext.SaveChangesAsync();
            return currency;
        }

        public async Task UpdateAsync(Currency currency)
        {
            _dbContext.Entry(currency).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var currency = await _dbContext.Currencies.FindAsync(id);
            if (currency != null)
            {
                _dbContext.Currencies.Remove(currency);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<Currency> GetByIdAsync(Guid id)
        {
            return await _dbContext.Currencies
                .Include(c => c.ExchangeRates)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Currency> GetByCodeAsync(string code)
        {
            return await _dbContext.Currencies
                .Include(c => c.ExchangeRates)
                .FirstOrDefaultAsync(c => c.Code == code);
        }

        public async Task<Currency> GetBaseCurrencyAsync()
        {
            return await _dbContext.Currencies
                .Include(c => c.ExchangeRates)
                .FirstOrDefaultAsync(c => c.IsBase);
        }

        public async Task<List<Currency>> GetAllAsync(bool? activeOnly = null, string searchTerm = null, int? pageNumber = null, int? pageSize = null)
        {
            IQueryable<Currency> query = _dbContext.Currencies;

            // تطبيق تصفية النتائج
            if (activeOnly.HasValue && activeOnly.Value)
            {
                query = query.Where(c => c.Status == ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Active);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                query = query.Where(c => c.Code.ToLower().Contains(searchTerm) ||
                                        c.Name.ToLower().Contains(searchTerm) ||
                                        c.Symbol.ToLower().Contains(searchTerm) ||
                                        c.IsoCode.ToLower().Contains(searchTerm));
            }

            // تطبيق الصفحات
            if (pageNumber.HasValue && pageSize.HasValue && pageSize.Value > 0)
            {
                query = query.Skip((pageNumber.Value - 1) * pageSize.Value)
                            .Take(pageSize.Value);
            }

            return await query.ToListAsync();
        }

        public async Task<bool> IsCodeUniqueAsync(string code, Guid? excludeId = null)
        {
            var query = _dbContext.Currencies.AsQueryable();
            
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            
            return await query.AllAsync(c => c.Code != code);
        }

        public async Task<bool> CanDeleteAsync(Guid id)
        {
            // تحقق من استخدام العملة في المعاملات أو التقارير قبل السماح بالحذف
            // هنا يمكن إضافة التحقق من الجداول المرتبطة بالعملة

            // للتبسيط، نفترض أنه يمكن حذف العملة إذا لم تكن هي العملة الأساسية
            var currency = await _dbContext.Currencies.FindAsync(id);
            
            if (currency == null)
                return false;
                
            return !currency.IsBase;
        }

        #endregion

        #region Rounding Rules Operations

        public async Task<CurrencyRoundingRule> AddRoundingRuleAsync(CurrencyRoundingRule rule)
        {
            await _dbContext.CurrencyRoundingRules.AddAsync(rule);
            await _dbContext.SaveChangesAsync();
            return rule;
        }

        public async Task UpdateRoundingRuleAsync(CurrencyRoundingRule rule)
        {
            _dbContext.Entry(rule).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteRoundingRuleAsync(Guid id)
        {
            var rule = await _dbContext.CurrencyRoundingRules.FindAsync(id);
            if (rule != null)
            {
                _dbContext.CurrencyRoundingRules.Remove(rule);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<CurrencyRoundingRule> GetRoundingRuleByIdAsync(Guid id)
        {
            return await _dbContext.CurrencyRoundingRules.FindAsync(id);
        }

        public async Task<List<CurrencyRoundingRule>> GetRoundingRulesAsync(Guid currencyId)
        {
            return await _dbContext.CurrencyRoundingRules
                .Where(r => r.CurrencyId == currencyId)
                .OrderBy(r => r.RoundingType)
                .ToListAsync();
        }

        #endregion

        #region Risk Limits Operations

        public async Task<CurrencyRiskLimit> AddRiskLimitAsync(CurrencyRiskLimit limit)
        {
            await _dbContext.CurrencyRiskLimits.AddAsync(limit);
            await _dbContext.SaveChangesAsync();
            return limit;
        }

        public async Task UpdateRiskLimitAsync(CurrencyRiskLimit limit)
        {
            _dbContext.Entry(limit).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteRiskLimitAsync(Guid id)
        {
            var limit = await _dbContext.CurrencyRiskLimits.FindAsync(id);
            if (limit != null)
            {
                _dbContext.CurrencyRiskLimits.Remove(limit);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<CurrencyRiskLimit> GetRiskLimitByIdAsync(Guid id)
        {
            return await _dbContext.CurrencyRiskLimits.FindAsync(id);
        }

        public async Task<List<CurrencyRiskLimit>> GetRiskLimitsAsync(Guid currencyId)
        {
            return await _dbContext.CurrencyRiskLimits
                .Where(r => r.CurrencyId == currencyId)
                .OrderByDescending(r => r.LastUpdated)
                .ToListAsync();
        }

        #endregion
    }
} 