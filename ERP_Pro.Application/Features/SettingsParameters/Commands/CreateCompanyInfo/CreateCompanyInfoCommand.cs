using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Commands.CreateCompanyInfo
{
    /// <summary>
    /// أمر إنشاء معلومات الشركة الجديدة
    /// </summary>
    public class CreateCompanyInfoCommand : IRequest<Guid>
    {
        // المعلومات الأساسية
        public string NameAr { get; set; }
        public string NameEn { get; set; }
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
    }

    /// <summary>
    /// معالج أمر إنشاء معلومات الشركة
    /// </summary>
    public class CreateCompanyInfoCommandHandler : IRequestHandler<CreateCompanyInfoCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public CreateCompanyInfoCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
        {
            _context = context;
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public async Task<Guid> Handle(CreateCompanyInfoCommand request, CancellationToken cancellationToken)
        {
            var entity = CompanyInfo.Create(
                request.NameAr,
                request.NameEn,
                request.TaxRegistrationNo,
                request.BaseCurrencyCode);

            // تحديث المعلومات الأساسية
            entity.UpdateBasicInfo(
                request.NameAr,
                request.NameEn,
                request.CommercialRegistrationNo,
                request.CommercialRegistrationDate,
                request.TaxRegistrationNo,
                request.TaxRegistrationDate,
                request.LegalForm,
                request.Capital,
                request.CapitalCurrencyCode);

            // تحديث معلومات الاتصال
            entity.UpdateContactInfo(
                request.Address,
                request.City,
                request.Region,
                request.Country,
                request.PostalCode,
                request.POBox,
                request.Phone,
                request.AlternatePhone,
                request.Fax,
                request.Email,
                request.Website);

            // تحديث معلومات الممثل القانوني
            entity.UpdateLegalRepresentative(
                request.LegalRepresentativeName,
                request.LegalRepresentativePosition,
                request.LegalRepresentativeIdNo,
                request.LegalRepresentativeIdType,
                request.LegalRepresentativePhone,
                request.LegalRepresentativeEmail);

            // تحديث إعدادات النظام
            entity.UpdateSystemSettings(
                request.BaseCurrencyCode,
                request.FiscalYearType,
                request.AccountingPeriods,
                request.DecimalPlaces,
                request.RoundingPolicy,
                request.BalanceDisplayMethod,
                request.EnforceJournalBalance,
                request.PreventUnbalancedJournals,
                request.DefaultLanguage);

            // تحديث معلومات الإنشاء
            var createdAt = _dateTime.Now;
            var createdBy = _currentUserService.UserId;

            // إضافة الكيان للسياق
            _context.CompanyInfo.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
} 