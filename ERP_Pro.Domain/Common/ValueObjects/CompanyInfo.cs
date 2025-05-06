using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.Common.Exceptions;

namespace ERP_Pro.Domain.Common.ValueObjects
{
    public record CompanyInfo
    {
        /// <summary> رقم الشركة </summary>
        public int CompanyId { get; init; }
        /// <summary> اسم الشركة </summary>
        public string CompanyName { get; init; }
        /// <summary> رقم الفرع </summary>
        public int BranchId { get; init; }
        /// <summary> اسم الفرع </summary>
        public string BranchName { get; init; }
        /// <summary> السنة المالية </summary>
        public int FiscalYear { get; init; }
        /// <summary> الفترة المالية </summary>
        public int FiscalPeriod { get; init; }

        private CompanyInfo(
            int companyId,
            string companyName,
            int branchId,
            string branchName,
            int fiscalYear,
            int fiscalPeriod)
        {
            if (companyId <= 0)
                throw new ValueObjectValidationException("Company ID must be greater than zero");

            if (string.IsNullOrWhiteSpace(companyName))
                throw new ValueObjectValidationException("Company name is required");

            if (branchId <= 0)
                throw new ValueObjectValidationException("Branch ID must be greater than zero");

            if (string.IsNullOrWhiteSpace(branchName))
                throw new ValueObjectValidationException("Branch name is required");

            if (fiscalYear <= 0)
                throw new ValueObjectValidationException("Fiscal year must be greater than zero");

            if (fiscalPeriod <= 0)
                throw new ValueObjectValidationException("Fiscal period must be greater than zero");

            CompanyId = companyId;
            CompanyName = companyName;
            BranchId = branchId;
            BranchName = branchName;
            FiscalYear = fiscalYear;
            FiscalPeriod = fiscalPeriod;
        }

        public static CompanyInfo Create(
            int companyId,
            string companyName,
            int branchId,
            string branchName,
            int fiscalYear,
            int fiscalPeriod) =>
            new(companyId, companyName, branchId, branchName, fiscalYear, fiscalPeriod);
    }
} 