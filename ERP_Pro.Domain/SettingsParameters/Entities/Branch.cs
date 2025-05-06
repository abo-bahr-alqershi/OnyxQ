using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان الفرع - يمثل فرع من فروع الشركة
    /// </summary>
    public class Branch : Entity
    {
        // المعلومات الأساسية
        public string Code { get; private set; }
        public string NameAr { get; private set; }
        public string NameEn { get; private set; }
        public string BranchType { get; private set; }
        public string CommercialRegistrationNo { get; private set; }
        public string TaxRegistrationNo { get; private set; }
        public DateTime? EstablishmentDate { get; private set; }
        public bool IsMainBranch { get; private set; }
        
        // معلومات الاتصال
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        
        // معلومات إدارية
        public string ManagerName { get; private set; }
        public string ManagerEmail { get; private set; }
        public string ManagerPhone { get; private set; }
        public string Status { get; private set; }
        public string Notes { get; private set; }
        
        // العلاقات
        public Guid CompanyInfoId { get; private set; }
        public Guid? ParentBranchId { get; private set; }
        
        private readonly List<Warehouse> _warehouses = new List<Warehouse>();
        public IReadOnlyCollection<Warehouse> Warehouses => _warehouses.AsReadOnly();
        
        // محفوظة للقراءة فقط
        public DateTime CreatedAt { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime? LastModifiedAt { get; private set; }
        public string LastModifiedBy { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private Branch() { }

        /// <summary>
        /// إنشاء كيان فرع جديد
        /// </summary>
        public static Branch Create(
            Guid companyInfoId,
            string code,
            string nameAr,
            string nameEn,
            string branchType,
            bool isMainBranch = false,
            Guid? parentBranchId = null)
        {
            if (companyInfoId == Guid.Empty)
                throw new ArgumentException("معرف الشركة غير صالح", nameof(companyInfoId));
                
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("رمز الفرع مطلوب", nameof(code));
                
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم الفرع بالعربية مطلوب", nameof(nameAr));
            
            if (string.IsNullOrWhiteSpace(branchType))
                throw new ArgumentException("نوع الفرع مطلوب", nameof(branchType));
                
            // التحقق من عدم وجود فرع رئيسي آخر إذا كان هذا الفرع رئيسي
            if (isMainBranch && parentBranchId.HasValue)
                throw new ArgumentException("لا يمكن أن يكون الفرع الرئيسي تابعاً لفرع آخر");

            return new Branch
            {
                Id = Guid.NewGuid(),
                CompanyInfoId = companyInfoId,
                Code = code,
                NameAr = nameAr,
                NameEn = nameEn ?? nameAr,
                BranchType = branchType,
                IsMainBranch = isMainBranch,
                ParentBranchId = parentBranchId,
                Status = "Active",
                CreatedAt = DateTime.UtcNow
            };
        }

        /// <summary>
        /// تحديث المعلومات الأساسية للفرع
        /// </summary>
        public void UpdateBasicInfo(
            string nameAr,
            string nameEn,
            string branchType,
            string commercialRegistrationNo,
            string taxRegistrationNo,
            DateTime? establishmentDate)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم الفرع بالعربية مطلوب", nameof(nameAr));
            
            if (string.IsNullOrWhiteSpace(branchType))
                throw new ArgumentException("نوع الفرع مطلوب", nameof(branchType));
            
            NameAr = nameAr;
            NameEn = nameEn;
            BranchType = branchType;
            CommercialRegistrationNo = commercialRegistrationNo;
            TaxRegistrationNo = taxRegistrationNo;
            EstablishmentDate = establishmentDate;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث معلومات الاتصال للفرع
        /// </summary>
        public void UpdateContactInfo(
            string address,
            string city,
            string region,
            string country,
            string postalCode,
            string phone,
            string email)
        {
            Address = address;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
            Phone = phone;
            Email = email;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث معلومات إدارية للفرع
        /// </summary>
        public void UpdateAdministrativeInfo(
            string managerName,
            string managerEmail,
            string managerPhone,
            string notes)
        {
            ManagerName = managerName;
            ManagerEmail = managerEmail;
            ManagerPhone = managerPhone;
            Notes = notes;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تعيين كفرع رئيسي
        /// </summary>
        public void SetAsMainBranch()
        {
            IsMainBranch = true;
            ParentBranchId = null;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تغيير الفرع الأب
        /// </summary>
        public void ChangeParentBranch(Guid? parentBranchId)
        {
            if (IsMainBranch && parentBranchId.HasValue)
                throw new InvalidOperationException("لا يمكن أن يكون الفرع الرئيسي تابعاً لفرع آخر");
                
            ParentBranchId = parentBranchId;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تغيير حالة الفرع
        /// </summary>
        public void ChangeStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("حالة الفرع مطلوبة", nameof(status));
                
            if (status != "Active" && status != "Inactive" && status != "Closed")
                throw new ArgumentException("حالة الفرع غير صالحة. القيم المسموحة: Active, Inactive, Closed", nameof(status));
                
            Status = status;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// إضافة مستودع للفرع
        /// </summary>
        public void AddWarehouse(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));
                
            _warehouses.Add(warehouse);
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// إزالة مستودع من الفرع
        /// </summary>
        public void RemoveWarehouse(Warehouse warehouse)
        {
            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));
                
            _warehouses.Remove(warehouse);
            LastModifiedAt = DateTime.UtcNow;
        }
    }
} 