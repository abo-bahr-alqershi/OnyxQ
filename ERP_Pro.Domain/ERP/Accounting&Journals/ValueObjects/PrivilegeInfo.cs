using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects
{
    public record PrivilegeInfo
    {
        /// <summary> صلاحية الإضافة </summary>
        public bool CanAdd { get; }
        /// <summary> صلاحية العرض </summary>
        public bool CanView { get; }

        private PrivilegeInfo(bool canAdd, bool canView)
        {
            CanAdd = canAdd;
            CanView = canView;
        }

        public static PrivilegeInfo Create(bool canAdd = false, bool canView = true) =>
            new(canAdd, canView);
    }
} 