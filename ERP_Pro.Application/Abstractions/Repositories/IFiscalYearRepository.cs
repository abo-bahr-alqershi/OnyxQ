using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Abstractions.Repositories
{
    /// <summary>
    /// واجهة مستودع السنة المالية
    /// </summary>
    public interface IFiscalYearRepository
    {
        /// <summary>
        /// إضافة سنة مالية جديدة
        /// </summary>
        Task<FiscalYear> AddAsync(FiscalYear fiscalYear);

        /// <summary>
        /// تحديث بيانات سنة مالية
        /// </summary>
        Task<FiscalYear> UpdateAsync(FiscalYear fiscalYear);

        /// <summary>
        /// حذف سنة مالية
        /// </summary>
        Task<bool> DeleteAsync(FiscalYearId id);

        /// <summary>
        /// الحصول على سنة مالية بواسطة الرقم التعريفي
        /// </summary>
        Task<FiscalYear> GetByIdAsync(FiscalYearId id, bool includePeriods = false);

        /// <summary>
        /// الحصول على سنة مالية بواسطة الرمز
        /// </summary>
        Task<FiscalYear> GetByCodeAsync(string code, bool includePeriods = false);

        /// <summary>
        /// الحصول على قائمة بالسنوات المالية حسب معايير محددة
        /// </summary>
        Task<List<FiscalYear>> GetAllAsync(
            string searchKeyword = null,
            FiscalYearStatusEnum? status = null,
            bool? isDefault = null,
            string orderBy = null,
            string orderDirection = null,
            int? skip = null,
            int? take = null,
            bool includePeriods = false);

        /// <summary>
        /// الحصول على السنة المالية الافتراضية
        /// </summary>
        Task<FiscalYear> GetDefaultAsync(bool includePeriods = false);

        /// <summary>
        /// الحصول على عدد السنوات المالية حسب معايير محددة
        /// </summary>
        Task<int> GetCountAsync(
            string searchKeyword = null,
            FiscalYearStatusEnum? status = null,
            bool? isDefault = null);

        /// <summary>
        /// فحص ما إذا كان رمز السنة المالية موجوداً
        /// </summary>
        Task<bool> IsCodeExistsAsync(string code, FiscalYearId excludeId = null);

        /// <summary>
        /// التحقق من وجود سنة مالية افتراضية
        /// </summary>
        Task<bool> IsDefaultExistsAsync();

        /// <summary>
        /// التحقق من تداخل تواريخ السنة المالية مع سنوات أخرى
        /// </summary>
        Task<bool> IsDateRangeOverlapAsync(DateTime startDate, DateTime endDate, FiscalYearId excludeId = null);

        /// <summary>
        /// الحصول على الفترات المحاسبية لسنة مالية
        /// </summary>
        Task<List<FiscalPeriod>> GetPeriodsAsync(FiscalYearId fiscalYearId, FiscalPeriodStatusEnum? status = null);

        /// <summary>
        /// حفظ التغييرات
        /// </summary>
        Task<int> SaveChangesAsync();
    }
} 