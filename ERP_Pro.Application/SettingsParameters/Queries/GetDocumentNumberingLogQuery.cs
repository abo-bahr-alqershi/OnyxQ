namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع سجل توليد واستخدام رموز المستندات.
    /// </summary>
    public class GetDocumentNumberingLogQuery
    {
        /// <summary>
        /// تصفية حسب نمط الترميز
        /// </summary>
        public string PatternCode { get; set; }

        /// <summary>
        /// تصفية حسب نوع المستند
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// تصفية حسب الفترة الزمنية (من)
        /// </summary>
        public string FromDate { get; set; }

        /// <summary>
        /// تصفية حسب الفترة الزمنية (إلى)
        /// </summary>
        public string ToDate { get; set; }

        /// <summary>
        /// البحث عن رمز أو مستند محدد
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