using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// رقم الموديل: 57
    /// اسم الجدول القديم: S_APPRVD_SHW_DOC
    /// يمثل مستند العرض المعتمد.
    /// </summary>
    public class ApprovedShowDocument : Entity
    {
        /** !#DOC_TYP نوع المستند */
        public int DocumentType { get; private set; }
        /** !#FLD_CNT عدد الحقول */
        public short? FieldCount { get; private set; }
        /** !#DOC_SLCT نص الاستعلام */
        public string DocumentSelect { get; private set; }
        /** !#DOC_SLCT_WHR شرط الاستعلام */
        public string DocumentSelectWhere { get; private set; }
        /** !#DOC_GRP_BY تجميع الاستعلام */
        public string DocumentGroupBy { get; private set; }
        /** !#DOC_SLCT_ORDR ترتيب الاستعلام */
        public string DocumentSelectOrder { get; private set; }
        /** !#FLD_LBL تسميات الحقول */
        public string FieldLabel { get; private set; }
        /** !#FLD_WDTH عرض الحقول */
        public string FieldWidth { get; private set; }
        /** !#FLD_DIR اتجاه الحقول */
        public string FieldDirection { get; private set; }
        /** !#AD_TRMNL_NM اسم جهاز الإضافة */
        public string AddTerminalName { get; private set; }
        /** !#UP_TRMNL_NM اسم جهاز التعديل */
        public string UpdateTerminalName { get; private set; }

        private ApprovedShowDocument() { }
        public ApprovedShowDocument(int documentType)
        {
            DocumentType = documentType;
        }
    }
}