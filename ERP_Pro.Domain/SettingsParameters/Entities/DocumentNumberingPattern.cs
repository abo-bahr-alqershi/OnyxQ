using System;
using System.Collections.Generic;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل نمط ترميز المستندات ويحتوي على جميع المعلومات المتعلقة بالنمط، علاقاته، حالته، وتواريخ الإنشاء والتعديل.
    /// </summary>
    public class DocumentNumberingPattern
    {
        /// <summary>
        /// الرمز الفريد للنمط (مفتاح أساسي)
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
        /// نوع المستند المرتبط بالنمط
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// رمز مجموعة النمط (علاقة اختيارية مع PatternGroup)
        /// </summary>
        public string PatternGroupCode { get; set; }

        /// <summary>
        /// معرف قالب النمط (علاقة اختيارية مع PatternTemplate)
        /// </summary>
        public int? PatternTemplateID { get; set; }

        /// <summary>
        /// حالة النمط (نشط/معطل)
        /// </summary>
        public PatternStatus Status { get; set; }

        /// <summary>
        /// وصف تفصيلي للنمط
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// اسم المستخدم الذي أنشأ النمط
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// اسم المستخدم الذي عدل النمط آخر مرة
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// ملاحظات إضافية حول النمط
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// قائمة مكونات النمط (علاقة واحد إلى متعدد)
        /// </summary>
        public List<PatternComponent> Components { get; set; }

        /// <summary>
        /// قائمة قواعد الترميز المرتبطة بالنمط
        /// </summary>
        public List<DocumentNumberingRule> Rules { get; set; }

        /// <summary>
        /// قائمة سجلات توليد الرموز لهذا النمط
        /// </summary>
        public List<DocumentNumberingLog> Logs { get; set; }

        /// <summary>
        /// قائمة المتغيرات المستخدمة في النمط (علاقة متعدد إلى متعدد)
        /// </summary>
        public List<PatternVariable> Variables { get; set; }

        /// <summary>
        /// قائمة الدوال المستخدمة في النمط (علاقة متعدد إلى متعدد)
        /// </summary>
        public List<PatternFunction> Functions { get; set; }
    }

    /// <summary>
    /// حالة نمط الترميز
    /// </summary>
    public enum PatternStatus
    {
        Active = 1,
        Inactive = 2
    }
} 