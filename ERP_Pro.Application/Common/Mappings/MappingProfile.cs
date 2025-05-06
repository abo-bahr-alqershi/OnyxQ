using System;
using System.Linq;
using AutoMapper;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels;

namespace ERP_Pro.Application.Common.Mappings
{
    /// <summary>
    /// ملف التعيين الرئيسي للنماذج
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        public MappingProfile()
        {
            // تعيينات نماذج الفروع
            CreateMap<Branch, BranchDto>()
                .ForMember(dest => dest.ParentBranchName, opt => opt.Ignore())
                .ForMember(dest => dest.WarehousesCount, opt => opt.Ignore());
            
            CreateMap<Branch, BranchListItemDto>()
                .ForMember(dest => dest.ParentBranchName, opt => opt.Ignore())
                .ForMember(dest => dest.WarehousesCount, opt => opt.Ignore());
            
            CreateMap<Branch, BranchDetailsDto>()
                .ForMember(dest => dest.CompanyName, opt => opt.Ignore())
                .ForMember(dest => dest.ParentBranchName, opt => opt.Ignore())
                .ForMember(dest => dest.ChildBranches, opt => opt.Ignore())
                .ForMember(dest => dest.Warehouses, opt => opt.MapFrom(src => src.Warehouses))
                .ForMember(dest => dest.Documents, opt => opt.Ignore());
            
            CreateMap<Branch, BranchHierarchyItemDto>()
                .ForMember(dest => dest.Level, opt => opt.Ignore())
                .ForMember(dest => dest.WarehousesCount, opt => opt.Ignore())
                .ForMember(dest => dest.Children, opt => opt.Ignore());
            
            // تعيينات نماذج المستودعات
            CreateMap<Warehouse, BranchWarehouseDto>();
            
            // تعيينات أخرى يمكن إضافتها حسب الحاجة
        }
    }
} 