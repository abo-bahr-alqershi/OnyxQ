using System;
using System.Collections.Generic;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لتحديث نمط ترميز مستندات موجود.
    /// </summary>
    public class UpdateDocumentNumberingPatternCommand
    {
        /// <summary>
        /// الرمز الفريد للنمط (مطلوب لتحديد النمط)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم النمط بالعربية
        /// </summary>
        public string NameAR { get; set; }

        /// <summary>
        /// اسم النمط بالإنجليزية
        /// </summary>
        public string NameEN { get; set; }

        /// <summary>
        /// نوع المستند المرتبط
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// رمز مجموعة النمط (اختياري)
        /// </summary>
        public string PatternGroupCode { get; set; }

        /// <summary>
        /// معرف قالب النمط (اختياري)
        /// </summary>
        public int? PatternTemplateID { get; set; }

        /// <summary>
        /// حالة النمط
        /// </summary>
        public PatternStatus Status { get; set; }

        /// <summary>
        /// وصف النمط
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// قائمة مكونات النمط
        /// </summary>
        public List<PatternComponent> Components { get; set; }

        /// <summary>
        /// قائمة المتغيرات المستخدمة
        /// </summary>
        public List<int> VariableIDs { get; set; }

        /// <summary>
        /// قائمة الدوال المستخدمة
        /// </summary>
        public List<int> FunctionIDs { get; set; }

        /// <summary>
        /// قائمة القواعد المرتبطة بالنمط
        /// </summary>
        public List<DocumentNumberingRule> Rules { get; set; }

        /// <summary>
        /// اسم المستخدم الذي عدل النمط
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// تاريخ التعديل
        /// </summary>
        public DateTime ModifiedOn { get; set; }
    }
} 