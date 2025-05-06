using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Base;

namespace ERP_Pro.Domain.InventoryWarehousing.Entities
{
    /// <summary>
    /// كيان المستودع - يمثل مستودع من مستودعات الشركة
    /// </summary>
    public class Warehouse : Entity
    {
        // المعلومات الأساسية
        public string Code { get; private set; }
        public string NameAr { get; private set; }
        public string NameEn { get; private set; }
        public string WarehouseType { get; private set; }
        public decimal Area { get; private set; }
        public decimal Capacity { get; private set; }
        public DateTime? OperationDate { get; private set; }
        
        // معلومات الموقع
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
        
        // معلومات إدارية
        public string KeeperName { get; private set; }
        public string KeeperPhone { get; private set; }
        public string KeeperEmail { get; private set; }
        public string Status { get; private set; }
        public string Notes { get; private set; }
        
        // العلاقات
        public Guid BranchId { get; private set; }
        
        // محفوظة للقراءة فقط
        public DateTime CreatedAt { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime? LastModifiedAt { get; private set; }
        public string LastModifiedBy { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private Warehouse() { }

        /// <summary>
        /// إنشاء كيان مستودع جديد
        /// </summary>
        public static Warehouse Create(
            Guid branchId,
            string code,
            string nameAr,
            string nameEn,
            string warehouseType)
        {
            if (branchId == Guid.Empty)
                throw new ArgumentException("معرف الفرع غير صالح", nameof(branchId));
                
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("رمز المستودع مطلوب", nameof(code));
                
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم المستودع بالعربية مطلوب", nameof(nameAr));
            
            if (string.IsNullOrWhiteSpace(warehouseType))
                throw new ArgumentException("نوع المستودع مطلوب", nameof(warehouseType));

            return new Warehouse
            {
                Id = Guid.NewGuid(),
                BranchId = branchId,
                Code = code,
                NameAr = nameAr,
                NameEn = nameEn ?? nameAr,
                WarehouseType = warehouseType,
                Status = "Active",
                CreatedAt = DateTime.UtcNow
            };
        }

        /// <summary>
        /// تحديث المعلومات الأساسية للمستودع
        /// </summary>
        public void UpdateBasicInfo(
            string nameAr,
            string nameEn,
            string warehouseType,
            decimal area,
            decimal capacity,
            DateTime? operationDate)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم المستودع بالعربية مطلوب", nameof(nameAr));
            
            if (string.IsNullOrWhiteSpace(warehouseType))
                throw new ArgumentException("نوع المستودع مطلوب", nameof(warehouseType));
            
            if (area < 0)
                throw new ArgumentException("مساحة المستودع يجب أن تكون قيمة موجبة", nameof(area));
                
            if (capacity < 0)
                throw new ArgumentException("سعة المستودع يجب أن تكون قيمة موجبة", nameof(capacity));
            
            NameAr = nameAr;
            NameEn = nameEn;
            WarehouseType = warehouseType;
            Area = area;
            Capacity = capacity;
            OperationDate = operationDate;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث معلومات الموقع للمستودع
        /// </summary>
        public void UpdateLocationInfo(
            string address,
            string city,
            string region,
            string country,
            string postalCode)
        {
            Address = address;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث معلومات إدارية للمستودع
        /// </summary>
        public void UpdateAdministrativeInfo(
            string keeperName,
            string keeperPhone,
            string keeperEmail,
            string notes)
        {
            KeeperName = keeperName;
            KeeperPhone = keeperPhone;
            KeeperEmail = keeperEmail;
            Notes = notes;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تغيير الفرع التابع له المستودع
        /// </summary>
        public void ChangeBranch(Guid branchId)
        {
            if (branchId == Guid.Empty)
                throw new ArgumentException("معرف الفرع غير صالح", nameof(branchId));
                
            BranchId = branchId;
            
            LastModifiedAt = DateTime.UtcNow;
        }

        /// <summary>
        /// تغيير حالة المستودع
        /// </summary>
        public void ChangeStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
                throw new ArgumentException("حالة المستودع مطلوبة", nameof(status));
                
            if (status != "Active" && status != "Inactive" && status != "Maintenance")
                throw new ArgumentException("حالة المستودع غير صالحة. القيم المسموحة: Active, Inactive, Maintenance", nameof(status));
                
            Status = status;
            
            LastModifiedAt = DateTime.UtcNow;
        }
    }
} 