namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل قاعدة من قواعد الترميز المرتبطة بنمط معين.
    /// </summary>
    public class DocumentNumberingRule
    {
        /// <summary>
        /// معرف القاعدة (مفتاح أساسي)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// رمز النمط المرتبط (مفتاح أجنبي)
        /// </summary>
        public string PatternCode { get; set; }

        /// <summary>
        /// نوع القاعدة (توليد، تحقق، تعديل، استثناء)
        /// </summary>
        public RuleType RuleType { get; set; }

        /// <summary>
        /// شرط تطبيق القاعدة
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// أولوية القاعدة
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// إجراء القاعدة (ما الذي يحدث عند تحقق الشرط)
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// حالة القاعدة (نشطة/معطلة)
        /// </summary>
        public RuleStatus Status { get; set; }
    }

    /// <summary>
    /// أنواع القواعد الممكنة
    /// </summary>
    public enum RuleType
    {
        Generation = 1,
        Validation = 2,
        Modification = 3,
        Exception = 4
    }

    /// <summary>
    /// حالة القاعدة
    /// </summary>
    public enum RuleStatus
    {
        Active = 1,
        Inactive = 2
    }
} 