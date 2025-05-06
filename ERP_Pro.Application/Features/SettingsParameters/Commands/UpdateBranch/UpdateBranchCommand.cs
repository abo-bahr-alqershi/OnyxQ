using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Commands.UpdateBranch
{
    /// <summary>
    /// أمر تحديث فرع
    /// </summary>
    public class UpdateBranchCommand : IRequest
    {
        public Guid Id { get; set; }
        
        // المعلومات الأساسية
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string BranchType { get; set; }
        public string CommercialRegistrationNo { get; set; }
        public string TaxRegistrationNo { get; set; }
        public DateTime? EstablishmentDate { get; set; }
        
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
        
        // حالة الفرع
        public string Status { get; set; }
        public bool IsMainBranch { get; set; }
    }

    /// <summary>
    /// معالج أمر تحديث فرع
    /// </summary>
    public class UpdateBranchCommandHandler : IRequestHandler<UpdateBranchCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public UpdateBranchCommandHandler(
            IApplicationDbContext context,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
        {
            _context = context;
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        public async Task<Unit> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Branches.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Branch), request.Id);
            }

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

            // إذا كان الطلب يتضمن تغيير الفرع الأب
            if (request.ParentBranchId.HasValue)
            {
                entity.ChangeParentBranch(request.ParentBranchId);
            }

            // إذا كان الطلب يتضمن تغيير حالة الفرع
            if (!string.IsNullOrEmpty(request.Status))
            {
                entity.ChangeStatus(request.Status);
            }

            // إذا كان الطلب يتضمن تغيير الفرع إلى فرع رئيسي
            if (request.IsMainBranch && !entity.IsMainBranch)
            {
                entity.SetAsMainBranch();
            }

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
} 