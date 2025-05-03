using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 53
    /// اسم الجدول القديم: S_ALRT_SYS_MST
    /// يمثل نظام التنبيه الرئيسي.
    /// </summary>
    public class AlertSystemMaster : Entity
    {
        /** !#ALRT_NO رقم التنبيه */
        public long AlertNumber { get; private set; }
        /** !#ALRT_TYP نوع التنبيه */
        public short? AlertType { get; private set; }
        /** !#LBL_NO رقم التسمية */
        public int? LabelNumber { get; private set; }
        /** !#ORDR_NO رقم الطلب */
        public long? OrderNumber { get; private set; }
        /** !#ALRT_DAY يوم التنبيه */
        public int? AlertDay { get; private set; }
        /** !#MSG_NO رقم الرسالة */
        public int? MessageNumber { get; private set; }
        /** !#SYS_NO رقم النظام */
        public int? SystemNumber { get; private set; }
        /** !#ALRT_SLCT نص الاستعلام */
        public string AlertSelect { get; private set; }
        /** !#ALRT_ACTN إجراء التنبيه */
        public bool? AlertAction { get; private set; }
        /** !#ALRT_PRD_TYP نوع فترة التنبيه */
        public short? AlertPeriodType { get; private set; }
        /** !#ALRT_SLCT_WHR شرط الاستعلام */
        public string AlertSelectWhere { get; private set; }
        /** !#ALRT_SLCT_ORDR ترتيب الاستعلام */
        public string AlertSelectOrder { get; private set; }
        /** !#INACTIVE غير نشط */
        public bool? Inactive { get; private set; }
        /** !#INACTIVE_DATE تاريخ عدم النشاط */
        public DateTime? InactiveDate { get; private set; }
        /** !#INACTIVE_RES سبب عدم النشاط */
        public string InactiveReason { get; private set; }
        /** !#INACTIVE_U_ID رقم مستخدم عدم النشاط */
        public int? InactiveUserId { get; private set; }
        /** !#UP_U_ID رقم المستخدم المعدل */
        public int? UpdateUserId { get; private set; }
        /** !#UP_DATE تاريخ التعديل */
        public DateTime? UpdateDate { get; private set; }
        /** !#UP_CNT عدد التعديلات */
        public int? UpdateCount { get; private set; }
        /** !#PR_REP تقرير الطباعة */
        public int? PrintReport { get; private set; }
        /** !#AD_U_ID رقم المستخدم المنشئ */
        public int? AddUserId { get; private set; }
        /** !#AD_DATE تاريخ الإنشاء */
        public DateTime? AddDate { get; private set; }
        /** !#ALRT_ST حالة التنبيه */
        public bool? AlertStatus { get; private set; }
        /** !#ALRT_GRP_BY تجميع الاستعلام */
        public string AlertGroupBy { get; private set; }
        /** !#ALRT_HIDE إخفاء التنبيه */
        public bool? AlertHide { get; private set; }
        /** !#ALRT_HIDE_WHR شرط الإخفاء */
        public string AlertHideWhere { get; private set; }
        /** !#RPRT_NM اسم التقرير */
        public string ReportName { get; private set; }
        /** !#AD_TRMNL_NM اسم جهاز الإنشاء */
        public string AddTerminalName { get; private set; }
        /** !#UP_TRMNL_NM اسم جهاز التعديل */
        public string UpdateTerminalName { get; private set; }
        /** !#FORM_NO رقم النموذج */
        public int? FormNumber { get; private set; }
        /** !#SHW_ALRT_AFTR_LGN إظهار التنبيه بعد الدخول */
        public bool? ShowAlertAfterLogin { get; private set; }

        /** @#S_ALRT_SYS_DTL تفاصيل النظام (جمع) */
        public virtual ICollection<AlertSystemDetail> AlertSystemDetails { get; private set; } = new List<AlertSystemDetail>();

        private AlertSystemMaster() { }
        public AlertSystemMaster(long alertNumber)
        {
            AlertNumber = alertNumber;
        }
    }
}