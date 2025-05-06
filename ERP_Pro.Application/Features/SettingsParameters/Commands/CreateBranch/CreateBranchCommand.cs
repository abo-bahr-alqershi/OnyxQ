using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Commands.CreateBranch
{
    /// <summary>
    /// أمر إنشاء فرع جديد
    /// </summary>
    public class CreateBranchCommand : IRequest<Guid>
    {
        // المعلومات الأساسية
        public Guid CompanyInfoId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BranchType { get; set; }
        public string CommercialRegistrationNo { get; set; }
        public string TaxRegistrationNo { get; set; }
        public DateTime? EstablishmentDate { get; set; }
        public bool IsMainBranch { get; set; }
        
        // معلومات الاتصال
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        // معلومات إدارية
        public string ManagerName { get; set; }
        public string ManagerEmail { get; set; }
        public string ManagerPhone { get; set; }
        public string Notes { get; set; }
        
        // العلاقات
        public Guid? ParentBranchId { get; set; }
    }

    /// <summary>
    /// معالج أمر إنشاء فرع جديد
    /// </summary>
    public class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public CreateBranchCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
        {
            _context = context;
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public async Task<Guid> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            var entity = Branch.Create(
                request.CompanyInfoId,
                request.Code,
                request.NameAr,
                request.NameEn,
                request.BranchType,
                request.IsMainBranch,
                request.ParentBranchId);

            // تحديث المعلومات الأساسية
            entity.UpdateBasicInfo(
                request.NameAr,
                request.NameEn,
                request.BranchType,
                request.CommercialRegistrationNo,
                request.TaxRegistrationNo,
                request.EstablishmentDate);

            // تحديث معلومات الاتصال
            entity.UpdateContactInfo(
                request.Address,
                request.City,
                request.Region,
                request.Country,
                request.PostalCode,
                request.Phone,
                request.Email);

            // تحديث معلومات إدارية
            entity.UpdateAdministrativeInfo(
                request.ManagerName,
                request.ManagerEmail,
                request.ManagerPhone,
                request.Notes);

            // إضافة الفرع إلى الشركة
            var company = await _context.CompanyInfo.FindAsync(request.CompanyInfoId);
            if (company != null)
            {
                company.AddBranch(entity);
            }

            // إضافة الكيان للسياق
            _context.Branches.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
} 