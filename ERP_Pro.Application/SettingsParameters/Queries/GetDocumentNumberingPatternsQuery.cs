using System.Collections.Generic;

namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع قائمة أنماط ترميز المستندات المعرفة في النظام.
    /// </summary>
    public class GetDocumentNumberingPatternsQuery
    {
        /// <summary>
        /// تصفية حسب الحالة (الكل، النشطة، المعطلة)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// تصفية حسب نوع المستند
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// تصفية حسب المجموعة
        /// </summary>
        public string PatternGroupCode { get; set; }

        /// <summary>
        /// البحث حسب الرمز أو الاسم
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// رقم الصفحة للنتائج
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// حجم الصفحة (عدد العناصر في كل صفحة)
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
} 