using System.Collections.Generic;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل دالة تُستخدم في معالجة متغيرات الترميز.
    /// </summary>
    public class PatternFunction
    {
        /// <summary>
        /// معرف الدالة (مفتاح أساسي)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// اسم الدالة (فريد)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// وصف الدالة
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// نوع الدالة (تنسيق نصوص، أرقام، تواريخ...)
        /// </summary>
        public FunctionType FunctionType { get; set; }

        /// <summary>
        /// معلمات الدالة (JSON أو قائمة)
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// نوع المخرجات
        /// </summary>
        public string ReturnType { get; set; }

        /// <summary>
        /// الشيفرة البرمجية لتنفيذ الدالة
        /// </summary>
        public string Implementation { get; set; }

        /// <summary>
        /// حالة الدالة (نشطة/معطلة)
        /// </summary>
        public FunctionStatus Status { get; set; }

        /// <summary>
        /// قائمة الأنماط التي تستخدم هذه الدالة (علاقة متعدد إلى متعدد)
        /// </summary>
        public List<DocumentNumberingPattern> Patterns { get; set; }
    }

    /// <summary>
    /// أنواع الدوال الممكنة
    /// </summary>
    public enum FunctionType
    {
        Text = 1,
        Number = 2,
        Date = 3,
        Custom = 4
    }

    /// <summary>
    /// حالة الدالة
    /// </summary>
    public enum FunctionStatus
    {
        Active = 1,
        Inactive = 2
    }
} 