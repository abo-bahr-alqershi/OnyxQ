using System;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل سجل عمليات توليد واستخدام الرموز لنمط ترميز معين.
    /// </summary>
    public class DocumentNumberingLog
    {
        /// <summary>
        /// معرف السجل (مفتاح أساسي)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// الرمز المولد
        /// </summary>
        public string GeneratedCode { get; set; }

        /// <summary>
        /// رمز النمط المستخدم (مفتاح أجنبي)
        /// </summary>
        public string PatternCode { get; set; }

        /// <summary>
        /// نوع المستند
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// معرف المستند
        /// </summary>
        public string DocumentID { get; set; }

        /// <summary>
        /// تاريخ التوليد
        /// </summary>
        public DateTime GenerationDate { get; set; }

        /// <summary>
        /// معرف المستخدم
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// معلومات إضافية (JSON)
        /// </summary>
        public string AdditionalInfo { get; set; }
    }
} 