using System;

namespace ERP_Pro.Application.SettingsParameters.Commands
{
    /// <summary>
    /// أمر لحذف نمط ترميز مستندات.
    /// </summary>
    public class DeleteDocumentNumberingPatternCommand
    {
        /// <summary>
        /// الرمز الفريد للنمط المراد حذفه
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم المستخدم الذي قام بالحذف
        /// </summary>
        public string DeletedBy { get; set; }

        /// <summary>
        /// تاريخ الحذف
        /// </summary>
        public DateTime DeletedOn { get; set; }

        /// <summary>
        /// سبب الحذف
        /// </summary>
        public string Reason { get; set; }
    }
} 