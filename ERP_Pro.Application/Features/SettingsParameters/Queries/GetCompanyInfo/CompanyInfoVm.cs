using System;
using System.Collections.Generic;
using AutoMapper;
using ERP_Pro.Application.Common.Mappings;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Queries.GetCompanyInfo
{
    /// <summary>
    /// نموذج عرض معلومات الشركة
    /// </summary>
    public class CompanyInfoVm : IMapFrom<CompanyInfo>
    {
        public Guid Id { get; set; }
        
        // المعلومات الأساسية
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string LogoPath { get; set; }
        public string CommercialRegistrationNo { get; set; }
        public DateTime? CommercialRegistrationDate { get; set; }
        public string TaxRegistrationNo { get; set; }
        public DateTime? TaxRegistrationDate { get; set; }
        public string LegalForm { get; set; }
        public decimal Capital { get; set; }
        public string CapitalCurrencyCode { get; set; }
        
        // معلومات الاتصال
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string POBox { get; set; }
        public string Phone { get; set; }
        public string AlternatePhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        
        // معلومات الممثل القانوني
        public string LegalRepresentativeName { get; set; }
        public string LegalRepresentativePosition { get; set; }
        public string LegalRepresentativeIdNo { get; set; }
        public string LegalRepresentativeIdType { get; set; }
        public string LegalRepresentativePhone { get; set; }
        public string LegalRepresentativeEmail { get; set; }
        
        // إعدادات النظام
        public string BaseCurrencyCode { get; set; }
        public string FiscalYearType { get; set; }
        public int AccountingPeriods { get; set; }
        public int DecimalPlaces { get; set; }
        public string RoundingPolicy { get; set; }
        public string BalanceDisplayMethod { get; set; }
        public bool EnforceJournalBalance { get; set; }
        public bool PreventUnbalancedJournals { get; set; }
        public string DefaultLanguage { get; set; }
        
        // معلومات إضافية
        public DateTime? EstablishmentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }
        
        // العلاقات
        public IList<BranchDto> Branches { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CompanyInfo, CompanyInfoVm>()
                .ForMember(d => d.Branches, opt => opt.MapFrom(s => s.Branches));
        }
    }
    
    /// <summary>
    /// نموذج عرض الفرع المبسط
    /// </summary>
    public class BranchDto : IMapFrom<Branch>
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BranchType { get; set; }
        public bool IsMainBranch { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Branch, BranchDto>();
        }
    }
} 