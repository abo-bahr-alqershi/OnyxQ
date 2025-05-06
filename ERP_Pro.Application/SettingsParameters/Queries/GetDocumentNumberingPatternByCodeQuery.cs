namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع تفاصيل نمط ترميز محدد برمزه.
    /// </summary>
    public class GetDocumentNumberingPatternByCodeQuery
    {
        /// <summary>
        /// الرمز الفريد للنمط المطلوب
        /// </summary>
        public string PatternCode { get; set; }
    }
} 