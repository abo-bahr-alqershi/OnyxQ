using System;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels
{
    /// <summary>
    /// نموذج بيانات الفرع
    /// </summary>
    public class BranchDto
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
        /// رقم السجل التجاري
        /// </summary>
        public string CommercialRegistrationNo { get; set; }
        
        /// <summary>
        /// الرقم الضريبي
        /// </summary>
        public string TaxRegistrationNo { get; set; }
        
        /// <summary>
        /// تاريخ التأسيس
        /// </summary>
        public DateTime? EstablishmentDate { get; set; }
        
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
        /// الدولة
        /// </summary>
        public string Country { get; set; }
        
        /// <summary>
        /// الرمز البريدي
        /// </summary>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// رقم الهاتف
        /// </summary>
        public string Phone { get; set; }
        
        /// <summary>
        /// البريد الإلكتروني
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// اسم المدير
        /// </summary>
        public string ManagerName { get; set; }
        
        /// <summary>
        /// البريد الإلكتروني للمدير
        /// </summary>
        public string ManagerEmail { get; set; }
        
        /// <summary>
        /// رقم هاتف المدير
        /// </summary>
        public string ManagerPhone { get; set; }
        
        /// <summary>
        /// حالة الفرع
        /// </summary>
        public string Status { get; set; }
        
        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
        
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
        
        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// منشئ السجل
        /// </summary>
        public string CreatedBy { get; set; }
        
        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime? LastModifiedAt { get; set; }
        
        /// <summary>
        /// آخر من عدل السجل
        /// </summary>
        public string LastModifiedBy { get; set; }
    }
} 