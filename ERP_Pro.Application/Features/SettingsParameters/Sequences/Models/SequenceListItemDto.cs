using System;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Models
{
    /// <summary>
    /// نموذج لعرض عنصر في قائمة التسلسلات
    /// </summary>
    public class SequenceListItemDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// الرمز
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// الاسم بالعربية
        /// </summary>
        public string NameAr { get; set; }
        
        /// <summary>
        /// الاسم بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }
        
        /// <summary>
        /// المجموعة
        /// </summary>
        public string Group { get; set; }
        
        /// <summary>
        /// نوع المستند
        /// </summary>
        public string DocumentType { get; set; }
        
        /// <summary>
        /// الحالة
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// النطاق الحالي
        /// </summary>
        public string CurrentRange { get; set; }
        
        /// <summary>
        /// الرقم الحالي
        /// </summary>
        public long CurrentNumber { get; set; }
        
        /// <summary>
        /// نسبة استخدام النطاق
        /// </summary>
        public double RangeUtilizationPercentage { get; set; }
    }
} 