using System;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels
{
    /// <summary>
    /// نموذج مستند الفرع
    /// </summary>
    public class BranchDocumentDto
    {
        /// <summary>
        /// المعرف الفريد للمستند
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid BranchId { get; set; }
        
        /// <summary>
        /// نوع المستند
        /// </summary>
        public string DocumentType { get; set; }
        
        /// <summary>
        /// رقم المستند
        /// </summary>
        public string DocumentNumber { get; set; }
        
        /// <summary>
        /// تاريخ الإصدار
        /// </summary>
        public DateTime IssueDate { get; set; }
        
        /// <summary>
        /// تاريخ الانتهاء
        /// </summary>
        public DateTime? ExpiryDate { get; set; }
        
        /// <summary>
        /// الجهة المصدرة
        /// </summary>
        public string IssuingAuthority { get; set; }
        
        /// <summary>
        /// مسار الملف
        /// </summary>
        public string FilePath { get; set; }
        
        /// <summary>
        /// حالة المستند
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
        
        /// <summary>
        /// الأيام المتبقية للانتهاء
        /// </summary>
        public int? DaysToExpiry { get; set; }
    }
}