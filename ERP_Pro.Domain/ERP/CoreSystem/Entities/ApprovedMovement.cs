using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 56
    /// اسم الجدول القديم: S_APPRVD_MOV
    /// يمثل حركة الموافقة.
    /// </summary>
    public class ApprovedMovement : Entity
    {
        /** !#LVL_NO رقم المستوى */
        public short LevelNumber { get; private set; }
        /** !#DOC_TYP نوع المستند */
        public int DocumentType { get; private set; }
        /** !#DOC_SER رقم التسلسل */
        public long DocumentSerial { get; private set; }
        /** !#DOC_NO رقم المستند */
        public long? DocumentNumber { get; private set; }
        /** !#DOC_JV_TYP نوع قيد اليومية */
        public short? DocumentJournalVoucherType { get; private set; }
        /** !#DOC_DATE تاريخ المستند */
        public DateTime? DocumentDate { get; private set; }
        /** !#APPRVD حالة الموافقة */
        public bool? Approved { get; private set; }
        /** !#APPRVD_U_ID رقم المستخدم الموافق */
        public int? ApprovedUserId { get; private set; }
        /** !#APPRVD_DATE تاريخ الموافقة */
        public DateTime? ApprovedDate { get; private set; }
        /** !#APPRVD_DESC وصف الموافقة */
        public string ApprovedDescription { get; private set; }
        /** !#ORDR_NO رقم الترتيب */
        public short? OrderNumber { get; private set; }
        /** !#CMP_NO رقم الشركة */
        public short? CompanyNumber { get; private set; }
        /** !#BRN_NO رقم الفرع */
        public int? BranchNumber { get; private set; }
        /** !#BRN_YEAR سنة الفرع */
        public short? BranchYear { get; private set; }
        /** !#BRN_USR مستخدم الفرع */
        public short? BranchUser { get; private set; }
        /** !#AD_U_ID رقم المستخدم المنشئ */
        public int? AddUserId { get; private set; }
        /** !#AD_DATE تاريخ الإضافة */
        public DateTime? AddDate { get; private set; }
        /** !#UP_U_ID رقم المستخدم المعدل */
        public int? UpdateUserId { get; private set; }
        /** !#UP_DATE تاريخ التعديل */
        public DateTime? UpdateDate { get; private set; }
        /** !#AD_TRMNL_NM اسم جهاز الإضافة */
        public string AddTerminalName { get; private set; }
        /** !#UP_TRMNL_NM اسم جهاز التعديل */
        public string UpdateTerminalName { get; private set; }
        /** !#DOC_AMT مبلغ المستند */
        public decimal? DocumentAmount { get; private set; }
        /** !#EXTERNAL_POST ترحيل خارجي */
        public int? ExternalPost { get; private set; }

        /** @#S_APPRVD_LVL علاقة مع مستوى الموافقة */
        public virtual ApprovedLevel ApprovedLevel { get; private set; }
        /** @#USER_R علاقة مع المستخدم الموافق */
        public virtual User ApprovedUser { get; private set; }

        private ApprovedMovement() { }
        public ApprovedMovement(short levelNumber, int documentType, long documentSerial)
        {
            LevelNumber = levelNumber;
            DocumentType = documentType;
            DocumentSerial = documentSerial;
        }
    }
}