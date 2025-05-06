using System;
using System.Collections.Generic;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لإنشاء مجموعة جديدة لأنماط الترميز.
    /// </summary>
    public class CreatePatternGroupCommand
    {
        /// <summary>
        /// رمز المجموعة (فريد)
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
        /// حالة المجموعة
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// قائمة الأنماط المنتمية للمجموعة (اختياري)
        /// </summary>
        public List<string> PatternCodes { get; set; }

        /// <summary>
        /// اسم المستخدم الذي أنشأ المجموعة
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
} 