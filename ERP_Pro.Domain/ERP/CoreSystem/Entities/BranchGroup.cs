using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// Represents a branch group in the ERP system
    /// يمثل مجموعة الفروع في نظام تخطيط موارد المؤسسات
    /// اسم الجدول: S_BRN_GRPS
    /// Table name: S_BRN_GRPS
    /// </summary>
    public class BranchGroup : AuditableEntity, IAggregateRoot
    {
        private readonly List<Branch> _branches = new();

        #region Properties

        /// <summary>
        /// رقم المجموعة - المفتاح الرئيسي
        /// Group number - Primary Key
        /// </summary>
        public int GroupNumber { get; private set; } // GRP_NO

        /// <summary>
        /// اسم المجموعة باللغة المحلية
        /// Group name in local language
        /// </summary>
        public string LocalizedName { get; private set; } // GRP_L_NM

        /// <summary>
        /// اسم المجموعة باللغة الأجنبية
        /// Group name in foreign language
        /// </summary>
        public string ForeignName { get; private set; } // GRP_F_NM

        #endregion

        #region Navigation Properties

        /// <summary>
        /// الفروع في المجموعة
        /// Branches in the group
        /// </summary>
        public IReadOnlyCollection<Branch> Branches => _branches.AsReadOnly();

        #endregion

        #region Constructors

        private BranchGroup() { } // Required by EF Core

        public BranchGroup(
            int groupNumber,
            string localizedName,
            string foreignName)
        {
            GroupNumber = groupNumber;
            LocalizedName = localizedName;
            ForeignName = foreignName;

            AddDomainEvent(new BranchGroupCreatedEvent(this));
        }

        #endregion

        #region Methods

        /// <summary>
        /// تحديث معلومات المجموعة
        /// Update group information
        /// </summary>
        public void UpdateInformation(
            string localizedName,
            string foreignName)
        {
            LocalizedName = localizedName;
            ForeignName = foreignName;

            AddDomainEvent(new BranchGroupUpdatedEvent(this));
        }

        /// <summary>
        /// إضافة فرع للمجموعة
        /// Add branch to group
        /// </summary>
        public void AddBranch(Branch branch)
        {
            _branches.Add(branch);
            AddDomainEvent(new BranchAddedToGroupEvent(this, branch));
        }

        /// <summary>
        /// إزالة فرع من المجموعة
        /// Remove branch from group
        /// </summary>
        public void RemoveBranch(Branch branch)
        {
            _branches.Remove(branch);
            AddDomainEvent(new BranchRemovedFromGroupEvent(this, branch));
        }

        #endregion
    }
} 