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
    /// تنفيذ واجهة مستودع السنة المالية
    /// </summary>
    public class FiscalYearRepository : IFiscalYearRepository
    {
        private readonly ApplicationDbContext _context;

        public FiscalYearRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// إضافة سنة مالية جديدة
        /// </summary>
        public async Task<FiscalYear> AddAsync(FiscalYear fiscalYear)
        {
            await _context.Set<FiscalYear>().AddAsync(fiscalYear);
            return fiscalYear;
        }

        /// <summary>
        /// تحديث بيانات سنة مالية
        /// </summary>
        public async Task<FiscalYear> UpdateAsync(FiscalYear fiscalYear)
        {
            _context.Set<FiscalYear>().Update(fiscalYear);
            return await Task.FromResult(fiscalYear);
        }

        /// <summary>
        /// حذف سنة مالية
        /// </summary>
        public async Task<bool> DeleteAsync(FiscalYearId id)
        {
            var fiscalYear = await _context.Set<FiscalYear>().FindAsync(id);
            if (fiscalYear == null)
                return false;

            _context.Set<FiscalYear>().Remove(fiscalYear);
            return true;
        }

        /// <summary>
        /// الحصول على سنة مالية بواسطة الرقم التعريفي
        /// </summary>
        public async Task<FiscalYear> GetByIdAsync(FiscalYearId id, bool includePeriods = false)
        {
            var query = _context.Set<FiscalYear>().AsQueryable();

            if (includePeriods)
            {
                query = query.Include(fy => fy.FiscalPeriods);
            }

            return await query.FirstOrDefaultAsync(fy => fy.Id == id);
        }

        /// <summary>
        /// الحصول على سنة مالية بواسطة الرمز
        /// </summary>
        public async Task<FiscalYear> GetByCodeAsync(string code, bool includePeriods = false)
        {
            var query = _context.Set<FiscalYear>().AsQueryable();

            if (includePeriods)
            {
                query = query.Include(fy => fy.FiscalPeriods);
            }

            return await query.FirstOrDefaultAsync(fy => fy.Code == code);
        }

        /// <summary>
        /// الحصول على قائمة بالسنوات المالية حسب معايير محددة
        /// </summary>
        public async Task<List<FiscalYear>> GetAllAsync(
            string searchKeyword = null,
            FiscalYearStatusEnum? status = null,
            bool? isDefault = null,
            string orderBy = null,
            string orderDirection = null,
            int? skip = null,
            int? take = null,
            bool includePeriods = false)
        {
            var query = _context.Set<FiscalYear>().AsQueryable();

            // التصفية
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                query = query.Where(fy =>
                    fy.Code.Contains(searchKeyword) ||
                    fy.NameAr.Contains(searchKeyword) ||
                    fy.NameEn.Contains(searchKeyword));
            }

            if (status.HasValue)
            {
                query = query.Where(fy => fy.Status == status.Value);
            }

            if (isDefault.HasValue)
            {
                query = query.Where(fy => fy.IsDefault == isDefault.Value);
            }

            // الترتيب
            if (!string.IsNullOrEmpty(orderBy))
            {
                var isDescending = orderDirection?.ToUpper() == "DESC";

                switch (orderBy.ToLower())
                {
                    case "code":
                        query = isDescending ? query.OrderByDescending(fy => fy.Code) : query.OrderBy(fy => fy.Code);
                        break;
                    case "namear":
                        query = isDescending ? query.OrderByDescending(fy => fy.NameAr) : query.OrderBy(fy => fy.NameAr);
                        break;
                    case "nameen":
                        query = isDescending ? query.OrderByDescending(fy => fy.NameEn) : query.OrderBy(fy => fy.NameEn);
                        break;
                    case "startdate":
                        query = isDescending ? query.OrderByDescending(fy => fy.StartDate) : query.OrderBy(fy => fy.StartDate);
                        break;
                    case "enddate":
                        query = isDescending ? query.OrderByDescending(fy => fy.EndDate) : query.OrderBy(fy => fy.EndDate);
                        break;
                    case "status":
                        query = isDescending ? query.OrderByDescending(fy => fy.Status) : query.OrderBy(fy => fy.Status);
                        break;
                    case "creationdate":
                        query = isDescending ? query.OrderByDescending(fy => fy.CreationDate) : query.OrderBy(fy => fy.CreationDate);
                        break;
                    default:
                        query = isDescending ? query.OrderByDescending(fy => fy.StartDate) : query.OrderBy(fy => fy.StartDate);
                        break;
                }
            }
            else
            {
                // ترتيب افتراضي
                query = query.OrderByDescending(fy => fy.StartDate);
            }

            // تضمين الفترات المحاسبية
            if (includePeriods)
            {
                query = query.Include(fy => fy.FiscalPeriods);
            }

            // الصفحات
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// الحصول على السنة المالية الافتراضية
        /// </summary>
        public async Task<FiscalYear> GetDefaultAsync(bool includePeriods = false)
        {
            var query = _context.Set<FiscalYear>().AsQueryable();

            if (includePeriods)
            {
                query = query.Include(fy => fy.FiscalPeriods);
            }

            return await query.FirstOrDefaultAsync(fy => fy.IsDefault);
        }

        /// <summary>
        /// الحصول على عدد السنوات المالية حسب معايير محددة
        /// </summary>
        public async Task<int> GetCountAsync(
            string searchKeyword = null,
            FiscalYearStatusEnum? status = null,
            bool? isDefault = null)
        {
            var query = _context.Set<FiscalYear>().AsQueryable();

            // التصفية
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                query = query.Where(fy =>
                    fy.Code.Contains(searchKeyword) ||
                    fy.NameAr.Contains(searchKeyword) ||
                    fy.NameEn.Contains(searchKeyword));
            }

            if (status.HasValue)
            {
                query = query.Where(fy => fy.Status == status.Value);
            }

            if (isDefault.HasValue)
            {
                query = query.Where(fy => fy.IsDefault == isDefault.Value);
            }

            return await query.CountAsync();
        }

        /// <summary>
        /// التحقق من تفرد رمز السنة المالية
        /// </summary>
        public async Task<bool> IsCodeExistsAsync(string code, FiscalYearId excludeId = null)
        {
            var query = _context.Set<FiscalYear>().AsQueryable();

            if (excludeId != null)
            {
                query = query.Where(fy => fy.Id != excludeId);
            }

            return await query.AnyAsync(fy => fy.Code == code);
        }

        /// <summary>
        /// التحقق من وجود سنة مالية افتراضية
        /// </summary>
        public async Task<bool> IsDefaultExistsAsync()
        {
            return await _context.Set<FiscalYear>().AnyAsync(fy => fy.IsDefault);
        }

        /// <summary>
        /// التحقق من تداخل الفترة الزمنية مع سنوات مالية أخرى
        /// </summary>
        public async Task<bool> IsDateRangeOverlapAsync(DateTime startDate, DateTime endDate, FiscalYearId excludeId = null)
        {
            var query = _context.Set<FiscalYear>().AsQueryable();

            if (excludeId != null)
            {
                query = query.Where(fy => fy.Id != excludeId);
            }

            // التحقق من وجود تداخل بين التواريخ
            return await query.AnyAsync(fy =>
                (startDate <= fy.EndDate && endDate >= fy.StartDate));
        }

        /// <summary>
        /// الحصول على الفترات المحاسبية للسنة المالية
        /// </summary>
        public async Task<List<FiscalPeriod>> GetPeriodsAsync(FiscalYearId fiscalYearId, FiscalPeriodStatusEnum? status = null)
        {
            var query = _context.Set<FiscalPeriod>()
                .Where(fp => fp.FiscalYearId == fiscalYearId);

            if (status.HasValue)
            {
                query = query.Where(fp => fp.Status == status.Value);
            }

            return await query.ToListAsync();
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