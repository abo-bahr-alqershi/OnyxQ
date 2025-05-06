using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.CreateBranch
{
    /// <summary>
    /// أمر إنشاء فرع جديد
    /// </summary>
    public class CreateBranchCommand : IRequest<Guid>
    {
        /// <summary>
        /// معرف الشركة
        /// </summary>
        public Guid CompanyInfoId { get; set; }
        
        /// <summary>
        /// رمز الفرع
        /// </summary>
        public string Code { get; set; }
        
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
        /// هل هو الفرع الرئيسي
        /// </summary>
        public bool IsMainBranch { get; set; }
        
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
    /// معالج أمر إنشاء فرع جديد
    /// </summary>
    public class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, Guid>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDomainEventService _domainEventService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public CreateBranchCommandHandler(
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
        public async Task<Guid> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            // إنشاء كيان الفرع الجديد
            var branch = Branch.Create(
                request.CompanyInfoId,
                request.Code,
                request.NameAr,
                request.NameEn,
                request.BranchType,
                request.IsMainBranch,
                request.ParentBranchId);
            
            // تحديث معلومات الفرع الإضافية
            branch.UpdateBasicInfo(
                request.NameAr,
                request.NameEn,
                request.BranchType,
                request.CommercialRegistrationNo,
                request.TaxRegistrationNo,
                request.EstablishmentDate);
                
            branch.UpdateContactInfo(
                request.Address,
                request.City,
                request.Region,
                request.Country,
                request.PostalCode,
                request.Phone,
                request.Email);
                
            branch.UpdateAdministrativeInfo(
                request.ManagerName,
                request.ManagerEmail,
                request.ManagerPhone,
                request.Notes);
                
            // إضافة الفرع إلى قاعدة البيانات
            _context.Branches.Add(branch);
            
            // نشر حدث إنشاء الفرع
            await _domainEventService.Publish(new BranchCreatedEvent(
                branch.Id,
                branch.Code,
                branch.NameAr,
                branch.CompanyInfoId,
                branch.IsMainBranch));
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            return branch.Id;
        }
    }
} 