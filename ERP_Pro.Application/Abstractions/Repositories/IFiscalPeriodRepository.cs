using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Abstractions.Repositories
{
    /// <summary>
    /// واجهة مستودع الفترة المحاسبية
    /// </summary>
    public interface IFiscalPeriodRepository
    {
        /// <summary>
        /// إضافة فترة محاسبية جديدة
        /// </summary>
        Task<FiscalPeriod> AddAsync(FiscalPeriod fiscalPeriod);

        /// <summary>
        /// تحديث بيانات فترة محاسبية
        /// </summary>
        Task<FiscalPeriod> UpdateAsync(FiscalPeriod fiscalPeriod);

        /// <summary>
        /// حذف فترة محاسبية
        /// </summary>
        Task<bool> DeleteAsync(FiscalPeriodId id);

        /// <summary>
        /// الحصول على فترة محاسبية بواسطة الرقم التعريفي
        /// </summary>
        Task<FiscalPeriod> GetByIdAsync(FiscalPeriodId id);

        /// <summary>
        /// الحصول على فترة محاسبية بواسطة الرمز
        /// </summary>
        Task<FiscalPeriod> GetByCodeAsync(string code);

        /// <summary>
        /// الحصول على فترة محاسبية تشمل تاريخ محدد
        /// </summary>
        Task<FiscalPeriod> GetByDateAsync(DateTime date, FiscalYearId fiscalYearId = null);

        /// <summary>
        /// الحصول على الفترة المحاسبية الحالية
        /// </summary>
        Task<FiscalPeriod> GetCurrentPeriodAsync(FiscalYearId fiscalYearId = null);

        /// <summary>
        /// الحصول على قائمة بالفترات المحاسبية لسنة مالية
        /// </summary>
        Task<List<FiscalPeriod>> GetAllAsync(
            FiscalYearId fiscalYearId,
            FiscalPeriodStatusEnum? status = null,
            FiscalPeriodTypeEnum? periodType = null,
            string orderBy = null,
            string orderDirection = null);

        /// <summary>
        /// فحص ما إذا كان رمز الفترة المحاسبية موجوداً
        /// </summary>
        Task<bool> IsCodeExistsAsync(string code, FiscalPeriodId excludeId = null);

        /// <summary>
        /// التحقق من تداخل تواريخ الفترة المحاسبية مع فترات أخرى
        /// </summary>
        Task<bool> IsDateRangeOverlapAsync(
            FiscalYearId fiscalYearId,
            DateTime startDate,
            DateTime endDate,
            FiscalPeriodId excludeId = null);

        /// <summary>
        /// الحصول على عدد الفترات المحاسبية لسنة مالية
        /// </summary>
        Task<int> GetCountAsync(
            FiscalYearId fiscalYearId,
            FiscalPeriodStatusEnum? status = null,
            FiscalPeriodTypeEnum? periodType = null);

        /// <summary>
        /// حفظ التغييرات
        /// </summary>
        Task<int> SaveChangesAsync();
    }
}