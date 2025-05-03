using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 59
    /// اسم الجدول القديم: S_APPRVD_USR
    /// يمثل المستخدم المعتمد.
    /// </summary>
    public class ApprovedUser : Entity
    {
        /** !#LVL_NO رقم المستوى */
        public short LevelNumber { get; private set; }
        /** !#DOC_TYP نوع المستند */
        public int DocumentType { get; private set; }
        /** !#U_ID رقم المستخدم */
        public int UserId { get; private set; }
        /** !#PRV_FLG علم الصلاحية */
        public bool? PrivilegeFlag { get; private set; }
        /** !#AD_U_ID رقم المستخدم المنشئ */
        public int? AddUserId { get; private set; }
        /** !#AD_DATE تاريخ الإضافة */
        public DateTime? AddDate { get; private set; }
        /** !#AD_TRMNL_NM اسم جهاز الإضافة */
        public string AddTerminalName { get; private set; }
        /** !#UP_TRMNL_NM اسم جهاز التعديل */
        public string UpdateTerminalName { get; private set; }
        /** !#F_AMT من مبلغ */
        public decimal? FromAmount { get; private set; }
        /** !#T_AMT إلى مبلغ */
        public decimal? ToAmount { get; private set; }

        /** @#S_APPRVD_LVL علاقة مع مستوى الموافقة */
        public virtual ApprovedLevel ApprovedLevel { get; private set; }
        /** @#USER_R علاقة مع المستخدم */
        public virtual User User { get; private set; }
        /** @#S_APPRVD_USR_DTL تفاصيل المستخدم (جمع) */
        public virtual ICollection<ApprovedUserDetail> ApprovedUserDetails { get; private set; } = new List<ApprovedUserDetail>();

        private ApprovedUser() { }
        public ApprovedUser(short levelNumber, int documentType, int userId)
        {
            LevelNumber = levelNumber;
            DocumentType = documentType;
            UserId = userId;
        }
    }
}