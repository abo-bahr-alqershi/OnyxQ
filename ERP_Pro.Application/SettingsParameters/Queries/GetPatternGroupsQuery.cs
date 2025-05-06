namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع مجموعات أنماط الترميز.
    /// </summary>
    public class GetPatternGroupsQuery
    {
        /// <summary>
        /// تصفية حسب الحالة
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// تصفية حسب النوع
        /// </summary>
        public string GroupType { get; set; }

        /// <summary>
        /// البحث عن مجموعة محددة
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