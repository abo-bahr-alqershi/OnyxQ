using System.Collections.Generic;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لتوليد رمز جديد لمستند باستخدام نمط ترميز محدد.
    /// </summary>
    public class GenerateDocumentNumberCommand
    {
        /// <summary>
        /// الرمز الفريد لنمط الترقيم المطلوب استخدامه
        /// </summary>
        public string PatternCode { get; set; }

        /// <summary>
        /// نوع المستند
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// معرف المستند (اختياري)
        /// </summary>
        public string DocumentID { get; set; }

        /// <summary>
        /// القيم الفعلية للمتغيرات المستخدمة في النمط
        /// </summary>
        public Dictionary<string, string> VariableValues { get; set; }

        /// <summary>
        /// اسم المستخدم الذي يطلب التوليد
        /// </summary>
        public string RequestedBy { get; set; }
    }
} 