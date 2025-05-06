namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع قوالب أنماط الترميز الجاهزة.
    /// </summary>
    public class GetPatternTemplatesQuery
    {
        /// <summary>
        /// تصفية حسب الفئة
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// تصفية حسب نوع المستند
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// البحث عن قالب محدد
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// رقم الصفحة
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// حجم الصفحة
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
} 