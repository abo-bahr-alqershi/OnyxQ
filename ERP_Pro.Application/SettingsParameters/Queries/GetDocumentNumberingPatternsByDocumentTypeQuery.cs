namespace ERP_Pro.Application.SettingsParameters.Queries
{
    /// <summary>
    /// استعلام لاسترجاع أنماط الترميز المرتبطة بنوع مستند محدد.
    /// </summary>
    public class GetDocumentNumberingPatternsByDocumentTypeQuery
    {
        /// <summary>
        /// نوع المستند المطلوب
        /// </summary>
        public string DocumentType { get; set; }
    }
} 