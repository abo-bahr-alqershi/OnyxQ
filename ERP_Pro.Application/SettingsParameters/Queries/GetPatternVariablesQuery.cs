namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع المتغيرات المتاحة للاستخدام في أنماط الترميز.
    /// </summary>
    public class GetPatternVariablesQuery
    {
        /// <summary>
        /// تصفية حسب النوع
        /// </summary>
        public string VariableType { get; set; }

        /// <summary>
        /// تصفية حسب مصدر البيانات
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// البحث عن متغير محدد
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