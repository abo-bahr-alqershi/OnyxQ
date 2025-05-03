using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 51
    /// اسم الجدول القديم: S_ALRT_DATA_TMP
    /// يمثل بيانات التنبيه المؤقتة.
    /// </summary>
    public class AlertDataTemp : Entity
    {
        /** !#ALRT_NO رقم التنبيه */
        public long AlertNumber { get; private set; }
        /** !#MSG_NO رقم الرسالة */
        public int? MessageNumber { get; private set; }
        /** !#LBL_NO رقم التسمية */
        public int? LabelNumber { get; private set; }
        /** !#ORDR_NO رقم الطلب */
        public long? OrderNumber { get; private set; }
        /** !#U_ID رقم المستخدم */
        public int? UserId { get; private set; }
        /** !#SYS_NO رقم النظام */
        public int? SystemNumber { get; private set; }
        /** !#ALRT_SLCT_DTL تفاصيل الاستعلام */
        public string AlertSelectDetail { get; private set; }
        /** !#ALRT_SLCT_WHR شرط الاستعلام */
        public string AlertSelectWhere { get; private set; }
        /** !#ALRT_SLCT_ORDR ترتيب الاستعلام */
        public string AlertSelectOrder { get; private set; }
        /** !#ALRT_HIDE إخفاء التنبيه */
        public bool? AlertHide { get; private set; }
        /** !#ALRT_HIDE_WHR شرط الإخفاء */
        public string AlertHideWhere { get; private set; }
        /** !#RPRT_NM اسم التقرير */
        public string ReportName { get; private set; }
        /** !#FLD_CNT عدد الحقول */
        public short? FieldCount { get; private set; }
        /** !#FLD_LBL تسميات الحقول */
        public string FieldLabel { get; private set; }
        /** !#FLD_WDTH عرض الحقول */
        public string FieldWidth { get; private set; }
        /** !#FLD_DIR اتجاه الحقول */
        public string FieldDirection { get; private set; }
        /** !#ALRT_DAY يوم التنبيه */
        public int? AlertDay { get; private set; }
        /** !#ALRT_CNT عدد التنبيهات */
        public int? AlertCount { get; private set; }
        /** !#ALRT_PRD_TYP نوع فترة التنبيه */
        public short? AlertPeriodType { get; private set; }
        /** !#MSG_DSC وصف الرسالة */
        public string MessageDescription { get; private set; }
        /** !#DOC_TYP نوع المستند */
        public int? DocumentType { get; private set; }
        /** !#FORM_NO رقم النموذج */
        public int? FormNumber { get; private set; }

        private AlertDataTemp() { }
        public AlertDataTemp(long alertNumber)
        {
            AlertNumber = alertNumber;
        }
    }
}