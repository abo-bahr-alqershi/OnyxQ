using System;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels
{
    /// <summary>
    /// نموذج مستودع الفرع
    /// </summary>
    public class BranchWarehouseDto
    {
        /// <summary>
        /// المعرف الفريد للمستودع
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// رمز المستودع
        /// </summary>
        public string Code { get; set; }
        
        /// <summary>
        /// اسم المستودع بالعربية
        /// </summary>
        public string NameAr { get; set; }
        
        /// <summary>
        /// اسم المستودع بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }
        
        /// <summary>
        /// نوع المستودع
        /// </summary>
        public string WarehouseType { get; set; }
        
        /// <summary>
        /// هل هو المستودع الرئيسي
        /// </summary>
        public bool IsPrimary { get; set; }
        
        /// <summary>
        /// تاريخ الربط
        /// </summary>
        public DateTime LinkDate { get; set; }
        
        /// <summary>
        /// حالة الربط
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid BranchId { get; set; }
        
        /// <summary>
        /// العنوان
        /// </summary>
        public string Address { get; set; }
        
        /// <summary>
        /// المدينة
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// المنطقة
        /// </summary>
        public string Region { get; set; }
        
        /// <summary>
        /// اسم أمين المستودع
        /// </summary>
        public string KeeperName { get; set; }
    }
} 