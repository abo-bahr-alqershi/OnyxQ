using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 54
    /// اسم الجدول القديم: S_APPROVL_APP_DVC
    /// يمثل جهاز الموافقة على التطبيق.
    /// </summary>
    public class ApprovalAppDevice : Entity
    {
        /** !#DOC_NO رقم المستند */
        public long DocumentNumber { get; private set; }
        /** !#DOC_DATE تاريخ المستند */
        public DateTime? DocumentDate { get; private set; }
        /** !#USR_TYP نوع المستخدم */
        public int? UserType { get; private set; }
        /** !#SYS_NO رقم النظام */
        public int? SystemNumber { get; private set; }
        /** !#MOD_ID معرف الوحدة */
        public string ModuleId { get; private set; }
        /** !#EMP_NO رقم الموظف */
        public int? EmployeeNumber { get; private set; }
        /** !#U_ID رقم المستخدم */
        public int? UserId { get; private set; }
        /** !#C_CODE كود العميل */
        public string CustomerCode { get; private set; }
        /** !#MOBILE_OS نظام تشغيل الجوال */
        public string MobileOS { get; private set; }
        /** !#MOBILE_SRL رقم تسلسلي للجوال */
        public string MobileSerial { get; private set; }
        /** !#APPROVED حالة الموافقة */
        public bool? Approved { get; private set; }
        /** !#APRV_U_ID رقم المستخدم الموافق */
        public int? ApprovedUserId { get; private set; }
        /** !#APRV_DATE تاريخ الموافقة */
        public DateTime? ApprovedDate { get; private set; }
        /** !#APRV_DSC وصف الموافقة */
        public string ApprovedDescription { get; private set; }
        /** !#AD_DATE تاريخ الإضافة */
        public DateTime? AddDate { get; private set; }
        /** !#AD_U_ID رقم المستخدم المنشئ */
        public int? AddUserId { get; private set; }
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
        /** !#BRN_YEAR سنة الفرع */
        public short? BranchYear { get; private set; }
        /** !#BRN_USR مستخدم الفرع */
        public short? BranchUser { get; private set; }

        /** @#S_EMP علاقة مع الموظف */
        public virtual Employee Employee { get; private set; }
        /** @#CUSTOMER علاقة مع العميل */
        public virtual Customer Customer { get; private set; }
        /** @#USER_R علاقة مع المستخدم */
        public virtual User User { get; private set; }

        private ApprovalAppDevice() { }
        public ApprovalAppDevice(long documentNumber)
        {
            DocumentNumber = documentNumber;
        }
    }
}