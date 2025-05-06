using System;
using System.Collections.Generic;
using AutoMapper;
using ERP_Pro.Application.Common.Mappings;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Queries.GetBranches
{
    /// <summary>
    /// نموذج عرض الفرع
    /// </summary>
    public class BranchDto : IMapFrom<Branch>
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BranchType { get; set; }
        public bool IsMainBranch { get; set; }
        public string Status { get; set; }
        
        // معلومات الاتصال
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        // معلومات إدارية
        public string ManagerName { get; set; }
        
        // العلاقات
        public Guid CompanyInfoId { get; set; }
        public Guid? ParentBranchId { get; set; }
        public string ParentBranchName { get; set; }
        
        // معلومات إضافية
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Branch, BranchDto>();
        }
    }
    
    /// <summary>
    /// نموذج عرض الفرع المفصل
    /// </summary>
    public class BranchDetailsDto : BranchDto
    {
        // معلومات إضافية
        public string CommercialRegistrationNo { get; set; }
        public string TaxRegistrationNo { get; set; }
        public DateTime? EstablishmentDate { get; set; }
        
        // معلومات الاتصال المفصلة
        public string Address { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        
        // معلومات إدارية مفصلة
        public string ManagerEmail { get; set; }
        public string ManagerPhone { get; set; }
        public string Notes { get; set; }
        
        // المستودعات التابعة للفرع
        public IList<WarehouseDto> Warehouses { get; set; }
        
        public new void Mapping(Profile profile)
        {
            profile.CreateMap<Branch, BranchDetailsDto>()
                .ForMember(d => d.Warehouses, opt => opt.MapFrom(s => s.Warehouses));
        }
    }
    
    /// <summary>
    /// نموذج عرض المستودع المبسط
    /// </summary>
    public class WarehouseDto : IMapFrom<ERP_Pro.Domain.InventoryWarehousing.Entities.Warehouse>
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string WarehouseType { get; set; }
        public string Status { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ERP_Pro.Domain.InventoryWarehousing.Entities.Warehouse, WarehouseDto>();
        }
    }
} 