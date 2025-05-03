using System;
using ERP_Pro.Domain.Common;
using System.Collections.Generic;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 52
    /// اسم الجدول القديم: S_ALRT_SYS_DTL
    /// يمثل تفاصيل نظام التنبيه.
    /// </summary>
    public class AlertSystemDetail : Entity
    {
        /** !#ALRT_NO رقم التنبيه */
        public long AlertNumber { get; private set; }
        /** !#ALRT_SLCT نص الاستعلام */
        public string AlertSelect { get; private set; }
        /** !#ALRT_SLCT_WHR شرط الاستعلام */
        public string AlertSelectWhere { get; private set; }
        /** !#ALRT_SLCT_ORDR ترتيب الاستعلام */
        public string AlertSelectOrder { get; private set; }
        /** !#ALRT_GRP_BY تجميع الاستعلام */
        public string AlertGroupBy { get; private set; }
        /** !#FLD_CNT عدد الحقول */
        public short? FieldCount { get; private set; }
        /** !#FLD_LBL تسميات الحقول */
        public string FieldLabel { get; private set; }
        /** !#FLD_WDTH عرض الحقول */
        public string FieldWidth { get; private set; }
        /** !#FLD_DIR اتجاه الحقول */
        public string FieldDirection { get; private set; }

        /** @#S_ALRT_SYS_MST علاقة رئيسية مع نظام التنبيه */
        public virtual AlertSystemMaster AlertSystemMaster { get; private set; }

        private AlertSystemDetail() { }
        public AlertSystemDetail(long alertNumber)
        {
            AlertNumber = alertNumber;
        }
    }
}