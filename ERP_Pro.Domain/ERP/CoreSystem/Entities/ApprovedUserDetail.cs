using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 60
    /// اسم الجدول القديم: S_APPRVD_USR_DTL
    /// يمثل تفاصيل المستخدم المعتمد.
    /// </summary>
    public class ApprovedUserDetail : Entity
    {
        /** !#U_ID رقم المستخدم */
        public int UserId { get; private set; }
        /** !#LVL_NO رقم المستوى */
        public short LevelNumber { get; private set; }
        /** !#DOC_TYP نوع المستند */
        public int DocumentType { get; private set; }
        /** !#TYP_NO رقم النوع */
        public int TypeNumber { get; private set; }
        /** !#PRV_FLG علم الصلاحية */
        public bool? PrivilegeFlag { get; private set; }
        /** !#F_AMT من مبلغ */
        public decimal? FromAmount { get; private set; }
        /** !#T_AMT إلى مبلغ */
        public decimal? ToAmount { get; private set; }

        /** @#S_APPRVD_USR علاقة مع المستخدم المعتمد */
        public virtual ApprovedUser ApprovedUser { get; private set; }

        private ApprovedUserDetail() { }
        public ApprovedUserDetail(int userId, short levelNumber, int documentType, int typeNumber)
        {
            UserId = userId;
            LevelNumber = levelNumber;
            DocumentType = documentType;
            TypeNumber = typeNumber;
        }
    }
}