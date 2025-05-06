using System;
using System.Collections.Generic;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels
{
    /// <summary>
    /// نموذج عنصر الهيكل الهرمي للفروع
    /// </summary>
    public class BranchHierarchyItemDto
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
        /// مستوى الفرع في الهيكل
        /// </summary>
        public int Level { get; set; }
        
        /// <summary>
        /// حالة الفرع
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// معرف الفرع الأب
        /// </summary>
        public Guid? ParentBranchId { get; set; }
        
        /// <summary>
        /// عدد المستودعات
        /// </summary>
        public int WarehousesCount { get; set; }
        
        /// <summary>
        /// قائمة الفروع الفرعية
        /// </summary>
        public List<BranchHierarchyItemDto> Children { get; set; } = new List<BranchHierarchyItemDto>();
    }
} 