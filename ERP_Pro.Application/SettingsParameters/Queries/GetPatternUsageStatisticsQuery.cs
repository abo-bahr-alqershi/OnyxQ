namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع إحصائيات استخدام أنماط الترميز.
    /// </summary>
    public class GetPatternUsageStatisticsQuery
    {
        /// <summary>
        /// تصفية حسب نمط الترميز
        /// </summary>
        public string PatternCode { get; set; }

        /// <summary>
        /// تصفية حسب الفترة الزمنية (من)
        /// </summary>
        public string FromDate { get; set; }

        /// <summary>
        /// تصفية حسب الفترة الزمنية (إلى)
        /// </summary>
        public string ToDate { get; set; }
    }
} 