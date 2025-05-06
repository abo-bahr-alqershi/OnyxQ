using System;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لإضافة متغير جديد لأنماط الترميز.
    /// </summary>
    public class AddPatternVariableCommand
    {
        /// <summary>
        /// رمز المتغير (فريد)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم المتغير
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نوع المتغير
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
        /// اسم المستخدم الذي أنشأ المتغير
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
} 