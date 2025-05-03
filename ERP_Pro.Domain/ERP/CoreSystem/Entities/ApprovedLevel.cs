using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 55
    /// اسم الجدول القديم: S_APPRVD_LVL
    /// يمثل مستوى الموافقة.
    /// </summary>
    public class ApprovedLevel : Entity
    {
        /** !#LVL_NO رقم المستوى */
        public short LevelNumber { get; private set; }
        /** !#LVL_NM اسم المستوى */
        public string LevelName { get; private set; }
        /** !#DOC_TYP نوع المستند */
        public int DocumentType { get; private set; }
        /** !#ORDR_NO رقم الترتيب */
        public short? OrderNumber { get; private set; }
        /** !#FORM_NO رقم النموذج */
        public int? FormNumber { get; private set; }
        /** !#AD_U_ID رقم المستخدم المنشئ */
        public int? AddUserId { get; private set; }
        /** !#AD_DATE تاريخ الإضافة */
        public DateTime? AddDate { get; private set; }
        /** !#UP_U_ID رقم المستخدم المعدل */
        public int? UpdateUserId { get; private set; }
        /** !#UP_DATE تاريخ التعديل */
        public DateTime? UpdateDate { get; private set; }
        /** !#UP_CNT عدد التعديلات */
        public int? UpdateCount { get; private set; }
        /** !#PR_REP تقرير الطباعة */
        public int? PrintReport { get; private set; }
        /** !#AD_TRMNL_NM اسم جهاز الإضافة */
        public string AddTerminalName { get; private set; }
        /** !#UP_TRMNL_NM اسم جهاز التعديل */
        public string UpdateTerminalName { get; private set; }

        /** @#S_APPRVD_MOV الحركات المرتبطة (جمع) */
        public virtual ICollection<ApprovedMovement> ApprovedMovements { get; private set; } = new List<ApprovedMovement>();
        /** @#S_APPRVD_USR المستخدمون المرتبطون (جمع) */
        public virtual ICollection<ApprovedUser> ApprovedUsers { get; private set; } = new List<ApprovedUser>();

        private ApprovedLevel() { }
        public ApprovedLevel(short levelNumber, int documentType)
        {
            LevelNumber = levelNumber;
            DocumentType = documentType;
        }
    }
}