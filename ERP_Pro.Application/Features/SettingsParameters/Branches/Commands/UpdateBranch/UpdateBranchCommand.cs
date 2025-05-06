using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.UpdateBranch
{
    /// <summary>
    /// أمر تحديث بيانات فرع
    /// </summary>
    public class UpdateBranchCommand : IRequest
    {
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid Id { get; set; }
        
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
        /// معرف الفرع الأب
        /// </summary>
        public Guid? ParentBranchId { get; set; }
        
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
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
    
    /// <summary>
    /// معالج أمر تحديث بيانات فرع
    /// </summary>
    public class UpdateBranchCommandHandler : IRequestHandler<UpdateBranchCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDomainEventService _domainEventService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public UpdateBranchCommandHandler(
            IApplicationDbContext context, 
            IMapper mapper,
            IDomainEventService domainEventService)
        {
            _context = context;
            _mapper = mapper;
            _domainEventService = domainEventService;
        }
        
        /// <summary>
        /// معالجة الأمر
        /// </summary>
        public async Task<Unit> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            // البحث عن الفرع في قاعدة البيانات
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);
                
            if (branch == null)
            {
                throw new NotFoundException(nameof(Branch), request.Id);
            }
            
            // تجميع الحقول التي تم تعديلها
            var updatedFields = new List<string>();
            
            // تحديث معلومات الفرع الأساسية
            if (branch.NameAr != request.NameAr || 
                branch.NameEn != request.NameEn || 
                branch.BranchType != request.BranchType || 
                branch.CommercialRegistrationNo != request.CommercialRegistrationNo ||
                branch.TaxRegistrationNo != request.TaxRegistrationNo ||
                branch.EstablishmentDate != request.EstablishmentDate)
            {
                updatedFields.AddRange(new[] { "NameAr", "NameEn", "BranchType", "CommercialRegistrationNo", "TaxRegistrationNo", "EstablishmentDate" });
                
                branch.UpdateBasicInfo(
                    request.NameAr,
                    request.NameEn,
                    request.BranchType,
                    request.CommercialRegistrationNo,
                    request.TaxRegistrationNo,
                    request.EstablishmentDate);
            }
                
            // تحديث معلومات الاتصال
            if (branch.Address != request.Address ||
                branch.City != request.City ||
                branch.Region != request.Region ||
                branch.Country != request.Country ||
                branch.PostalCode != request.PostalCode ||
                branch.Phone != request.Phone ||
                branch.Email != request.Email)
            {
                updatedFields.AddRange(new[] { "Address", "City", "Region", "Country", "PostalCode", "Phone", "Email" });
                
                branch.UpdateContactInfo(
                    request.Address,
                    request.City,
                    request.Region,
                    request.Country,
                    request.PostalCode,
                    request.Phone,
                    request.Email);
            }
                
            // تحديث المعلومات الإدارية
            if (branch.ManagerName != request.ManagerName ||
                branch.ManagerEmail != request.ManagerEmail ||
                branch.ManagerPhone != request.ManagerPhone ||
                branch.Notes != request.Notes)
            {
                updatedFields.AddRange(new[] { "ManagerName", "ManagerEmail", "ManagerPhone", "Notes" });
                
                branch.UpdateAdministrativeInfo(
                    request.ManagerName,
                    request.ManagerEmail,
                    request.ManagerPhone,
                    request.Notes);
            }
                
            // تحديث الفرع الأب إذا كان مختلفاً
            if (branch.ParentBranchId != request.ParentBranchId)
            {
                updatedFields.Add("ParentBranchId");
                branch.ChangeParentBranch(request.ParentBranchId);
            }
            
            // نشر حدث تحديث الفرع إذا كانت هناك تغييرات
            if (updatedFields.Any())
            {
                await _domainEventService.Publish(new BranchUpdatedEvent(
                    branch.Id,
                    branch.Code,
                    branch.NameAr,
                    branch.CompanyInfoId,
                    updatedFields.Distinct().ToArray()));
            }
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
} 