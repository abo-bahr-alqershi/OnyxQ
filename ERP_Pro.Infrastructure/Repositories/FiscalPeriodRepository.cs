using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Infrastructure.Data.Context;
using ERP_Pro.Shared.Enums.Domain;
using Microsoft.EntityFrameworkCore;

namespace ERP_Pro.Infrastructure.Repositories
{
    /// <summary>
    /// تنفيذ واجهة مستودع الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodRepository : IFiscalPeriodRepository
    {
        private readonly ApplicationDbContext _context;

        public FiscalPeriodRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// إضافة فترة محاسبية جديدة
        /// </summary>
        public async Task<FiscalPeriod> AddAsync(FiscalPeriod fiscalPeriod)
        {
            await _context.Set<FiscalPeriod>().AddAsync(fiscalPeriod);
            return fiscalPeriod;
        }

        /// <summary>
        /// تحديث بيانات فترة محاسبية
        /// </summary>
        public async Task<FiscalPeriod> UpdateAsync(FiscalPeriod fiscalPeriod)
        {
            _context.Set<FiscalPeriod>().Update(fiscalPeriod);
            return await Task.FromResult(fiscalPeriod);
        }

        /// <summary>
        /// حذف فترة محاسبية
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
        /// الحصول على فترة محاسبية بواسطة الرقم التعريفي
        /// </summary>
        public async Task<FiscalPeriod> GetByIdAsync(FiscalPeriodId id)
        {
            return await _context.Set<FiscalPeriod>()
                .Include(fp => fp.FiscalYear)
                .FirstOrDefaultAsync(fp => fp.Id == id);
        }

        /// <summary>
        /// الحصول على فترة محاسبية بواسطة الرمز
        /// </summary>
        public async Task<FiscalPeriod> GetByCodeAsync(string code)
        {
            return await _context.Set<FiscalPeriod>()
                .Include(fp => fp.FiscalYear)
                .FirstOrDefaultAsync(fp => fp.Code == code);
        }

        /// <summary>
        /// الحصول على فترة محاسبية تشمل تاريخ محدد
        /// </summary>
        public async Task<FiscalPeriod> GetByDateAsync(DateTime date, FiscalYearId fiscalYearId = null)
        {
            var query = _context.Set<FiscalPeriod>()
                .Include(fp => fp.FiscalYear)
                .Where(fp => date >= fp.StartDate && date <= fp.EndDate);

            if (fiscalYearId != null)
            {
                query = query.Where(fp => fp.FiscalYearId == fiscalYearId);
            }
            else
            {
                // إذا لم يتم تحديد سنة مالية، يتم البحث في السنة المالية الافتراضية أولاً
                var defaultFiscalYear = await _context.Set<FiscalYear>()
                    .FirstOrDefaultAsync(fy => fy.IsDefault);

                if (defaultFiscalYear != null)
                {
                    query = query.Where(fp => fp.FiscalYearId == defaultFiscalYear.Id);
                }
            }

            return await query.FirstOrDefaultAsync();
        }

        /// <summary>
        /// الحصول على الفترة المحاسبية الحالية
        /// </summary>
        public async Task<FiscalPeriod> GetCurrentPeriodAsync(FiscalYearId fiscalYearId = null)
        {
            var currentDate = DateTime.Now;
            return await GetByDateAsync(currentDate, fiscalYearId);
        }

        /// <summary>
        /// الحصول على قائمة بالفترات المحاسبية لسنة مالية
        /// </summary>
        public async Task<List<FiscalPeriod>> GetAllAsync(
            FiscalYearId fiscalYearId,
            FiscalPeriodStatusEnum? status = null,
            FiscalPeriodTypeEnum? periodType = null,
            string orderBy = null,
            string orderDirection = null)
        {
            var query = _context.Set<FiscalPeriod>()
                .Where(fp => fp.FiscalYearId == fiscalYearId);

            // التصفية
            if (status.HasValue)
            {
                query = query.Where(fp => fp.Status == status.Value);
            }

            if (periodType.HasValue)
            {
                query = query.Where(fp => fp.PeriodType == periodType.Value);
            }

            // الترتيب
            if (!string.IsNullOrEmpty(orderBy))
            {
                var isDescending = orderDirection?.ToUpper() == "DESC";

                switch (orderBy.ToLower())
                {
                    case "code":
                        query = isDescending ? query.OrderByDescending(fp => fp.Code) : query.OrderBy(fp => fp.Code);
                        break;
                    case "namear":
                        query = isDescending ? query.OrderByDescending(fp => fp.NameAr) : query.OrderBy(fp => fp.NameAr);
                        break;
                    case "nameen":
                        query = isDescending ? query.OrderByDescending(fp => fp.NameEn) : query.OrderBy(fp => fp.NameEn);
                        break;
                    case "startdate":
                        query = isDescending ? query.OrderByDescending(fp => fp.StartDate) : query.OrderBy(fp => fp.StartDate);
                        break;
                    case "enddate":
                        query = isDescending ? query.OrderByDescending(fp => fp.EndDate) : query.OrderBy(fp => fp.EndDate);
                        break;
                    case "status":
                        query = isDescending ? query.OrderByDescending(fp => fp.Status) : query.OrderBy(fp => fp.Status);
                        break;
                    case "periodnumber":
                        query = isDescending ? query.OrderByDescending(fp => fp.PeriodNumber) : query.OrderBy(fp => fp.PeriodNumber);
                        break;
                    default:
                        query = isDescending ? query.OrderByDescending(fp => fp.PeriodNumber) : query.OrderBy(fp => fp.PeriodNumber);
                        break;
                }
            }
            else
            {
                // ترتيب افتراضي
                query = query.OrderBy(fp => fp.PeriodNumber);
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// فحص ما إذا كان رمز الفترة المحاسبية موجوداً
        /// </summary>
        public async Task<bool> IsCodeExistsAsync(string code, FiscalPeriodId excludeId = null)
        {
            var query = _context.Set<FiscalPeriod>().AsQueryable();

            if (excludeId != null)
            {
                query = query.Where(fp => fp.Id != excludeId);
            }

            return await query.AnyAsync(fp => fp.Code == code);
        }

        /// <summary>
        /// التحقق من تداخل تواريخ الفترة المحاسبية مع فترات أخرى
        /// </summary>
        public async Task<bool> IsDateRangeOverlapAsync(
            FiscalYearId fiscalYearId,
            DateTime startDate,
            DateTime endDate,
            FiscalPeriodId excludeId = null)
        {
            var query = _context.Set<FiscalPeriod>()
                .Where(fp => fp.FiscalYearId == fiscalYearId);

            if (excludeId != null)
            {
                query = query.Where(fp => fp.Id != excludeId);
            }

            return await query.AnyAsync(fp =>
                (startDate >= fp.StartDate && startDate <= fp.EndDate) ||
                (endDate >= fp.StartDate && endDate <= fp.EndDate) ||
                (startDate <= fp.StartDate && endDate >= fp.EndDate));
        }

        /// <summary>
        /// الحصول على عدد الفترات المحاسبية لسنة مالية
        /// </summary>
        public async Task<int> GetCountAsync(
            FiscalYearId fiscalYearId,
            FiscalPeriodStatusEnum? status = null,
            FiscalPeriodTypeEnum? periodType = null)
        {
            var query = _context.Set<FiscalPeriod>()
                .Where(fp => fp.FiscalYearId == fiscalYearId);

            if (status.HasValue)
            {
                query = query.Where(fp => fp.Status == status.Value);
            }

            if (periodType.HasValue)
            {
                query = query.Where(fp => fp.PeriodType == periodType.Value);
            }

            return await query.CountAsync();
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