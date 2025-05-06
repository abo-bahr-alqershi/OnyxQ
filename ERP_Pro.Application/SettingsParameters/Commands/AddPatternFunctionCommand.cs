using System;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لإضافة دالة جديدة لأنماط الترميز.
    /// </summary>
    public class AddPatternFunctionCommand
    {
        /// <summary>
        /// اسم الدالة (فريد)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// وصف الدالة
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// نوع الدالة
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
        /// حالة الدالة
        /// </summary>
        public FunctionStatus Status { get; set; }

        /// <summary>
        /// اسم المستخدم الذي أنشأ الدالة
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; set; }
    }
} 