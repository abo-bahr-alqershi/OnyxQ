using System.Collections.Generic;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لاختبار نمط ترميز وتوليد أمثلة للرموز.
    /// </summary>
    public class TestDocumentNumberingPatternCommand
    {
        /// <summary>
        /// الرمز الفريد للنمط المراد اختباره
        /// </summary>
        public string PatternCode { get; set; }

        /// <summary>
        /// قائمة القيم التجريبية للمتغيرات
        /// </summary>
        public Dictionary<string, string> VariableTestValues { get; set; }

        /// <summary>
        /// اسم المستخدم الذي يجري الاختبار
        /// </summary>
        public string TestedBy { get; set; }
    }
} 