using System;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لنسخ نمط ترميز مستندات موجود كأساس لنمط جديد.
    /// </summary>
    public class CopyDocumentNumberingPatternCommand
    {
        /// <summary>
        /// الرمز الفريد للنمط الأصلي المراد نسخه
        /// </summary>
        public string SourcePatternCode { get; set; }

        /// <summary>
        /// الرمز الفريد للنمط الجديد
        /// </summary>
        public string NewPatternCode { get; set; }

        /// <summary>
        /// اسم النمط الجديد
        /// </summary>
        public string NewNameAR { get; set; }
        public string NewNameEN { get; set; }

        /// <summary>
        /// وصف النمط الجديد
        /// </summary>
        public string NewDescription { get; set; }

        /// <summary>
        /// اسم المستخدم الذي أنشأ النسخة
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
} 