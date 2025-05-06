using System;
using System.Collections.Generic;
using AutoMapper;
using ERP_Pro.Application.Common.Mappings;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Application.Features.InventoryWarehousing.Queries.GetWarehouses
{
    /// <summary>
    /// نموذج عرض المستودع
    /// </summary>
    public class WarehouseDto : IMapFrom<Warehouse>
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string WarehouseType { get; set; }
        public string Status { get; set; }
        
        // معلومات الموقع
        public string City { get; set; }
        public string Country { get; set; }
        
        // معلومات إدارية
        public string KeeperName { get; set; }
        
        // العلاقات
        public Guid BranchId { get; set; }
        public string BranchName { get; set; }
        
        // معلومات إضافية
        public DateTime CreatedAt { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Warehouse, WarehouseDto>();
        }
    }
    
    /// <summary>
    /// نموذج عرض المستودع المفصل
    /// </summary>
    public class WarehouseDetailsDto : WarehouseDto
    {
        // معلومات إضافية
        public decimal Area { get; set; }
        public decimal Capacity { get; set; }
        public DateTime? OperationDate { get; set; }
        
        // معلومات الموقع المفصلة
        public string Address { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        
        // معلومات إدارية مفصلة
        public string KeeperPhone { get; set; }
        public string KeeperEmail { get; set; }
        public string Notes { get; set; }
        
        public new void Mapping(Profile profile)
        {
            profile.CreateMap<Warehouse, WarehouseDetailsDto>();
        }
    }
} 