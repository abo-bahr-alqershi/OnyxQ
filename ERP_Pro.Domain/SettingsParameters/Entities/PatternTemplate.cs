using System;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل قالب نمط ترميز جاهز للاستخدام كأساس للأنماط الجديدة.
    /// </summary>
    public class PatternTemplate
    {
        /// <summary>
        /// معرف القالب (مفتاح أساسي)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// اسم القالب
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// وصف القالب
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// محتوى القالب (صيغة النمط)
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// نوع المستند المرتبط بالقالب
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// فئة القالب (تصنيف)
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// اسم المستخدم الذي أنشأ القالب
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// اسم المستخدم الذي عدل القالب آخر مرة
        /// </summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime? ModifiedOn { get; set; }
    }
} 