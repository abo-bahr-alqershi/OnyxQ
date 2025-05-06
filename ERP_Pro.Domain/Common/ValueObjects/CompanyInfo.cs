using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Shared.Exceptions.Base;

namespace ERP_Pro.Domain.Common.ValueObjects
{
    public record CompanyInfo
    {
        /// <summary> رقم الشركة </summary>
        public int CompanyId { get; }
        /// <summary> اسم الشركة </summary>
        public string CompanyName { get; }
        /// <summary> رقم الفرع </summary>
        public int BranchId { get; }
        /// <summary> اسم الفرع </summary>
        public string BranchName { get; }
        /// <summary> السنة المالية </summary>
        public int FiscalYear { get; }
        /// <summary> الفترة المالية </summary>
        public int FiscalPeriod { get; }

        private CompanyInfo(
            int companyId,
            string companyName,
            int branchId,
            string branchName,
            int fiscalYear,
            int fiscalPeriod)
        {
            if (companyId <= 0)
                throw new DomainException("Company ID must be greater than zero");

            if (string.IsNullOrWhiteSpace(companyName))
                throw new DomainException("Company name is required");

            if (branchId <= 0)
                throw new DomainException("Branch ID must be greater than zero");

            if (string.IsNullOrWhiteSpace(branchName))
                throw new DomainException("Branch name is required");

            if (fiscalYear <= 0)
                throw new DomainException("Fiscal year must be greater than zero");

            if (fiscalPeriod <= 0)
                throw new DomainException("Fiscal period must be greater than zero");

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