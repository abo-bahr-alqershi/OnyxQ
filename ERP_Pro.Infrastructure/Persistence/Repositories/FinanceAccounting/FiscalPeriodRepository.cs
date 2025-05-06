using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Infrastructure.Persistence.Context;
using ERP_Pro.Shared.Enums.Domain;
using Microsoft.EntityFrameworkCore;

namespace ERP_Pro.Infrastructure.Persistence.Repositories.FinanceAccounting
{
    /// <summary>
    /// تنفيذ واجهة مستودع الفترة المالية
    /// </summary>
    public class FiscalPeriodRepository : IFiscalPeriodRepository
    {
        private readonly ApplicationDbContext _context;

        public FiscalPeriodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// إضافة فترة مالية جديدة
        /// </summary>
        public async Task<FiscalPeriod> AddAsync(FiscalPeriod fiscalPeriod)
        {
            await _context.Set<FiscalPeriod>().AddAsync(fiscalPeriod);
            return fiscalPeriod;
        }

        /// <summary>
        /// إضافة مجموعة من الفترات المالية دفعة واحدة
        /// </summary>
        public async Task<IEnumerable<FiscalPeriod>> AddRangeAsync(IEnumerable<FiscalPeriod> fiscalPeriods)
        {
            await _context.Set<FiscalPeriod>().AddRangeAsync(fiscalPeriods);
            return fiscalPeriods;
        }

        /// <summary>
        /// تحديث فترة مالية
        /// </summary>
        public async Task<FiscalPeriod> UpdateAsync(FiscalPeriod fiscalPeriod)
        {
            _context.Set<FiscalPeriod>().Update(fiscalPeriod);
            return await Task.FromResult(fiscalPeriod);
        }

        /// <summary>
        /// تحديث مجموعة من الفترات المالية دفعة واحدة
        /// </summary>
        public Task UpdateRangeAsync(IEnumerable<FiscalPeriod> fiscalPeriods)
        {
            _context.Set<FiscalPeriod>().UpdateRange(fiscalPeriods);
            return Task.CompletedTask;
        }

        /// <summary>
        /// حذف فترة مالية
        /// </summary>
        public async Task<bool> DeleteAsync(FiscalPeriodId id)
        {
            var fiscalPeriod = await _context.Set<FiscalPeriod>().FindAsync(id);
            if (fiscalPeriod == null)
                return false;

            _context.Set<FiscalPeriod>().Remove(fiscalPeriod);
            return true;
        }

        /// <summary>
        /// الحصول على فترة مالية بواسطة المعرف
        /// </summary>
        public async Task<FiscalPeriod> GetByIdAsync(FiscalPeriodId id)
        {
            return await _context.Set<FiscalPeriod>()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        /// <summary>
        /// الحصول على فترة مالية بواسطة الرمز
        /// </summary>
        public async Task<FiscalPeriod> GetByCodeAsync(string code)
        {
            return await _context.Set<FiscalPeriod>()
                .FirstOrDefaultAsync(p => p.Code == code);
        }

        /// <summary>
        /// الحصول على قائمة بالفترات المالية حسب السنة المالية
        /// </summary>
        public async Task<List<FiscalPeriod>> GetByFiscalYearIdAsync(
            FiscalYearId fiscalYearId,
            FiscalPeriodStatusEnum? status = null,
            string orderBy = null,
            string orderDirection = null)
        {
            var query = _context.Set<FiscalPeriod>()
                .Where(p => p.FiscalYearId == fiscalYearId);

            if (status.HasValue)
            {
                query = query.Where(p => p.Status == status.Value);
            }

            // الترتيب
            if (!string.IsNullOrEmpty(orderBy))
            {
                var isDescending = orderDirection?.ToUpper() == "DESC";

                switch (orderBy.ToLower())
                {
                    case "code":
                        query = isDescending ? query.OrderByDescending(p => p.Code) : query.OrderBy(p => p.Code);
                        break;
                    case "namear":
                        query = isDescending ? query.OrderByDescending(p => p.NameAr) : query.OrderBy(p => p.NameAr);
                        break;
                    case "nameen":
                        query = isDescending ? query.OrderByDescending(p => p.NameEn) : query.OrderBy(p => p.NameEn);
                        break;
                    case "startdate":
                        query = isDescending ? query.OrderByDescending(p => p.StartDate) : query.OrderBy(p => p.StartDate);
                        break;
                    case "enddate":
                        query = isDescending ? query.OrderByDescending(p => p.EndDate) : query.OrderBy(p => p.EndDate);
                        break;
                    case "status":
                        query = isDescending ? query.OrderByDescending(p => p.Status) : query.OrderBy(p => p.Status);
                        break;
                    default:
                        query = query.OrderBy(p => p.StartDate);
                        break;
                }
            }
            else
            {
                // ترتيب افتراضي
                query = query.OrderBy(p => p.StartDate);
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// الحصول على الفترة المالية الحالية
        /// </summary>
        public async Task<FiscalPeriod> GetCurrentPeriodAsync()
        {
            var today = DateTime.Today;

            return await _context.Set<FiscalPeriod>()
                .Where(p => p.Status == FiscalPeriodStatusEnum.Open)
                .Where(p => today >= p.StartDate && today <= p.EndDate)
                .OrderByDescending(p => p.EndDate)
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// الحصول على الفترة المالية لتاريخ معين
        /// </summary>
        public async Task<FiscalPeriod> GetPeriodForDateAsync(DateTime date)
        {
            return await _context.Set<FiscalPeriod>()
                .Where(p => date >= p.StartDate && date <= p.EndDate)
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// التحقق من وجود فترات مالية مغلقة بعد تاريخ معين
        /// </summary>
        public async Task<bool> HasLockedPeriodsAfterDateAsync(DateTime date)
        {
            return await _context.Set<FiscalPeriod>()
                .AnyAsync(p =>
                    p.StartDate > date && 
                    (p.Status == FiscalPeriodStatusEnum.Closed || p.Status == FiscalPeriodStatusEnum.Locked));
        }

        /// <summary>
        /// التحقق من وجود فترات مالية مفتوحة قبل تاريخ معين
        /// </summary>
        public async Task<bool> HasOpenPeriodsBeforeDateAsync(DateTime date)
        {
            return await _context.Set<FiscalPeriod>()
                .AnyAsync(p =>
                    p.EndDate < date && 
                    p.Status == FiscalPeriodStatusEnum.Open);
        }

        /// <summary>
        /// التحقق من تداخل الفترة مع فترات أخرى
        /// </summary>
        public async Task<bool> IsDateRangeOverlapAsync(
            DateTime startDate,
            DateTime endDate,
            FiscalYearId fiscalYearId,
            FiscalPeriodId excludeId = null)
        {
            var query = _context.Set<FiscalPeriod>()
                .Where(p => p.FiscalYearId == fiscalYearId);

            if (excludeId != null)
            {
                query = query.Where(p => p.Id != excludeId);
            }

            return await query.AnyAsync(p =>
                (startDate <= p.EndDate && endDate >= p.StartDate));
        }

        /// <summary>
        /// التحقق من تفرد رمز الفترة
        /// </summary>
        public async Task<bool> IsCodeExistsAsync(string code, FiscalPeriodId excludeId = null)
        {
            var query = _context.Set<FiscalPeriod>().AsQueryable();

            if (excludeId != null)
            {
                query = query.Where(p => p.Id != excludeId);
            }

            return await query.AnyAsync(p => p.Code == code);
        }

        /// <summary>
        /// الحصول على الفترات المالية السابقة للفترة المحددة
        /// </summary>
        public async Task<List<FiscalPeriod>> GetPreviousPeriodsAsync(FiscalPeriodId periodId)
        {
            var period = await GetByIdAsync(periodId);
            if (period == null)
            {
                return new List<FiscalPeriod>();
            }

            return await _context.Set<FiscalPeriod>()
                .Where(p => p.FiscalYearId == period.FiscalYearId && p.EndDate < period.StartDate)
                .OrderByDescending(p => p.EndDate)
                .ToListAsync();
        }

        /// <summary>
        /// الحصول على الفترات المالية اللاحقة للفترة المحددة
        /// </summary>
        public async Task<List<FiscalPeriod>> GetNextPeriodsAsync(FiscalPeriodId periodId)
        {
            var period = await GetByIdAsync(periodId);
            if (period == null)
            {
                return new List<FiscalPeriod>();
            }

            return await _context.Set<FiscalPeriod>()
                .Where(p => p.FiscalYearId == period.FiscalYearId && p.StartDate > period.EndDate)
                .OrderBy(p => p.StartDate)
                .ToListAsync();
        }

        /// <summary>
        /// حفظ التغييرات
        /// </summary>
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
} 