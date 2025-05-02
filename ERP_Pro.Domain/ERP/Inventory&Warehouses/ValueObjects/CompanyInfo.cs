using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public class CompanyInfo : ValueObject
    {
        public short CompanyNumber { get; private set; }
        public int BranchNumber { get; private set; }
        public short? BranchYear { get; private set; }
        public short? BranchUser { get; private set; }

        private CompanyInfo() { } // For EF Core

        public CompanyInfo(
            short companyNumber,
            int branchNumber,
            short? branchYear = null,
            short? branchUser = null)
        {
            CompanyNumber = companyNumber;
            BranchNumber = branchNumber;
            BranchYear = branchYear;
            BranchUser = branchUser;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return CompanyNumber;
            yield return BranchNumber;
            yield return BranchYear ?? 0;
            yield return BranchUser ?? 0;
        }

        public CompanyInfo Update(
            short? branchYear = null,
            short? branchUser = null)
        {
            return new CompanyInfo(
                CompanyNumber,
                BranchNumber,
                branchYear ?? BranchYear,
                branchUser ?? BranchUser
            );
        }
    }
} 