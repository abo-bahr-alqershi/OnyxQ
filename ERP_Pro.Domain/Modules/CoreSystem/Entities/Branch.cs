using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل الفرع في النظام ويحتوي على جميع بيانات الفرع الأساسية وعلاقاته.
    public class Branch : Entity<BranchId>
    {

        private Branch() { }

        public Branch(BranchId id, decimal? branchYear, decimal? branchUser)
        {
            Id = id;
            BranchYear = branchYear;
            BranchUser = branchUser;
        }

        // المعرف الفريد للفرع (مفتاح رئيسي).
        public BranchId Id { get; private set; }

        // مجموعة الشركة التابع لها الفرع.
        public decimal? CompanyGroup { get; private set; }

        // الرقم المختصر للشركة التابع لها الفرع.
        public decimal? CompanyNumberShort { get; private set; }

        // رقم الفرع.
        public decimal? BranchNumber { get; private set; }

        // سنة الفرع.
        public decimal? BranchYear { get; private set; }

        // المستخدم المسؤول عن الفرع.
        public decimal? BranchUser { get; private set; }

        // الاسم الأخير للفرع.
        public string BranchLastName { get; private set; }

        // الاسم الأول للفرع.
        public string BranchFirstName { get; private set; }

        #region Navigation Properties
        // مجموعة الفروع المرتبطة بهذا الفرع.
        public BranchGroup BranchGroup { get; private set; }
        // الشركة المرتبطة بهذا الفرع.
        public Company Company { get; private set; }
        // المحافظة المرتبطة بهذا الفرع.
        public Province Province { get; private set; }
        // المنطقة المرتبطة بهذا الفرع.
        public Region Region { get; private set; }
        // المدينة المرتبطة بهذا الفرع.
        public City City { get; private set; }
        // الدولة المرتبطة بهذا الفرع.
        public Country Country { get; private set; }
        #endregion

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
