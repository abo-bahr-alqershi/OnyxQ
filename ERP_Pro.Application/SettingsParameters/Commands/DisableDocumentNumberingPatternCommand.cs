using System;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لتعطيل نمط ترميز مستندات.
    /// </summary>
    public class DisableDocumentNumberingPatternCommand
    {
        /// <summary>
        /// الرمز الفريد للنمط المراد تعطيله
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم المستخدم الذي قام بالتعطيل
        /// </summary>
        public string DisabledBy { get; set; }

        /// <summary>
        /// تاريخ التعطيل
        /// </summary>
        public DateTime DisabledOn { get; set; }

        /// <summary>
        /// سبب التعطيل
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// رمز النمط البديل للمستندات الجديدة (اختياري)
        /// </summary>
        public string AlternativePatternCode { get; set; }
    }
} 