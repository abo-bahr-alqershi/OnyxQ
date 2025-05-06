using System.Collections.Generic;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// يمثل مجموعة من أنماط الترميز مع إعدادات وقواعد مشتركة.
    /// </summary>
    public class PatternGroup
    {
        /// <summary>
        /// رمز المجموعة (مفتاح أساسي)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم المجموعة
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// وصف المجموعة
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// الإعدادات المشتركة للمجموعة (JSON)
        /// </summary>
        public string SharedSettings { get; set; }

        /// <summary>
        /// قواعد التصميم المشتركة (JSON)
        /// </summary>
        public string DesignRules { get; set; }

        /// <summary>
        /// حالة المجموعة (نشطة/معطلة)
        /// </summary>
        public GroupStatus Status { get; set; }

        /// <summary>
        /// قائمة الأنماط المنتمية لهذه المجموعة
        /// </summary>
        public List<DocumentNumberingPattern> Patterns { get; set; }
    }

    /// <summary>
    /// حالة المجموعة
    /// </summary>
    public enum GroupStatus
    {
        Active = 1,
        Inactive = 2
    }
} 