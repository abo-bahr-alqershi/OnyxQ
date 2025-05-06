using System;

namespace ERP_Pro.Domain.SettingsParameters.Enums
{
    /// <summary>
    /// تعداد أنواع التأمين
    /// </summary>
    public enum LockTypeEnum
    {
        /// <summary>
        /// تأمين عادي
        /// </summary>
        Normal = 1,

        /// <summary>
        /// تأمين لفترة محددة
        /// </summary>
        Temporary = 2,

        /// <summary>
        /// تأمين جزئي (لبعض العمليات)
        /// </summary>
        Partial = 3,

        /// <summary>
        /// تأمين كامل
        /// </summary>
        Full = 4,

        /// <summary>
        /// تأمين تلقائي
        /// </summary>
        Automatic = 5,

        /// <summary>
        /// تأمين للإغلاق النهائي
        /// </summary>
        FinalClosing = 6
    }
} 