namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع الدوال المتاحة للاستخدام في أنماط الترميز.
    /// </summary>
    public class GetPatternFunctionsQuery
    {
        /// <summary>
        /// تصفية حسب النوع
        /// </summary>
        public string FunctionType { get; set; }

        /// <summary>
        /// تصفية حسب نوع المخرجات
        /// </summary>
        public string ReturnType { get; set; }

        /// <summary>
        /// البحث عن دالة محددة
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