using System.Collections.Generic;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل متغير يُستخدم في أنماط ترميز المستندات.
    /// </summary>
    public class PatternVariable
    {
        /// <summary>
        /// معرف المتغير (مفتاح أساسي)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// رمز المتغير (فريد)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم المتغير
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نوع المتغير (نظام، مؤسسة، مستند، عميل...)
        /// </summary>
        public VariableType VariableType { get; set; }

        /// <summary>
        /// وصف المتغير
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// صيغة القيمة (تنسيق)
        /// </summary>
        public string ValueFormat { get; set; }

        /// <summary>
        /// القيمة الافتراضية
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// مصدر البيانات للمتغير
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// شروط استخدام المتغير
        /// </summary>
        public string UsageConditions { get; set; }

        /// <summary>
        /// قائمة الأنماط التي تستخدم هذا المتغير (علاقة متعدد إلى متعدد)
        /// </summary>
        public List<DocumentNumberingPattern> Patterns { get; set; }
    }

    /// <summary>
    /// أنواع المتغيرات الممكنة
    /// </summary>
    public enum VariableType
    {
        System = 1,
        Organization = 2,
        Document = 3,
        Customer = 4,
        FiscalYear = 5,
        Custom = 6
    }
} 