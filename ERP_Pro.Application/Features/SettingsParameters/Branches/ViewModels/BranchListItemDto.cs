using System;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels
{
    /// <summary>
    /// نموذج عنصر قائمة الفروع
    /// </summary>
    public class BranchListItemDto
    {
        /// <summary>
        /// المعرف الفريد للفرع
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// رمز الفرع
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// اسم الفرع بالعربية
        /// </summary>
        public string NameAr { get; set; }
        
        /// <summary>
        /// اسم الفرع بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }
        
        /// <summary>
        /// نوع الفرع
        /// </summary>
        public string BranchType { get; set; }
        
        /// <summary>
        /// هل هو الفرع الرئيسي
        /// </summary>
        public bool IsMainBranch { get; set; }
        
        /// <summary>
        /// المدينة
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// الدولة
        /// </summary>
        public string Country { get; set; }
        
        /// <summary>
        /// اسم المدير
        /// </summary>
        public string ManagerName { get; set; }
        
        /// <summary>
        /// حالة الفرع
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// معرف الشركة
        /// </summary>
        public Guid CompanyInfoId { get; set; }
        
        /// <summary>
        /// معرف الفرع الأب
        /// </summary>
        public Guid? ParentBranchId { get; set; }
        
        /// <summary>
        /// اسم الفرع الأب
        /// </summary>
        public string ParentBranchName { get; set; }
        
        /// <summary>
        /// عدد المستودعات
        /// </summary>
        public int WarehousesCount { get; set; }
    }
} 