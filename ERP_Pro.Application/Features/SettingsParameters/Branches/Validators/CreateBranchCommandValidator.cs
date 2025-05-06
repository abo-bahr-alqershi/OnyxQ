using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.CreateBranch;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Validators
{
    /// <summary>
    /// مدقق أمر إنشاء فرع جديد
    /// </summary>
    public class CreateBranchCommandValidator : AbstractValidator<CreateBranchCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public CreateBranchCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.CompanyInfoId)
                .NotEmpty().WithMessage("معرف الشركة مطلوب")
                .MustAsync(CompanyExists).WithMessage("الشركة غير موجودة");
                
            RuleFor(v => v.Code)
                .NotEmpty().WithMessage("رمز الفرع مطلوب")
                .MaximumLength(20).WithMessage("رمز الفرع يجب ألا يتجاوز 20 حرف")
                .MustAsync(CodeIsUnique).WithMessage("رمز الفرع موجود بالفعل");
                
            RuleFor(v => v.NameAr)
                .NotEmpty().WithMessage("اسم الفرع بالعربية مطلوب")
                .MaximumLength(100).WithMessage("اسم الفرع بالعربية يجب ألا يتجاوز 100 حرف");
                
            RuleFor(v => v.NameEn)
                .NotEmpty().WithMessage("اسم الفرع بالإنجليزية مطلوب")
                .MaximumLength(100).WithMessage("اسم الفرع بالإنجليزية يجب ألا يتجاوز 100 حرف");
                
            RuleFor(v => v.BranchType)
                .NotEmpty().WithMessage("نوع الفرع مطلوب")
                .MaximumLength(50).WithMessage("نوع الفرع يجب ألا يتجاوز 50 حرف");
                
            RuleFor(v => v.ParentBranchId)
                .MustAsync(ParentBranchExists).WithMessage("الفرع الأب غير موجود")
                .When(v => v.ParentBranchId.HasValue);
                
            RuleFor(v => v.IsMainBranch)
                .MustAsync(NoOtherMainBranch).WithMessage("يوجد فرع رئيسي آخر للشركة")
                .When(v => v.IsMainBranch);
                
            RuleFor(v => v.CommercialRegistrationNo)
                .MaximumLength(50).WithMessage("رقم السجل التجاري يجب ألا يتجاوز 50 حرف");
                
            RuleFor(v => v.TaxRegistrationNo)
                .MaximumLength(50).WithMessage("الرقم الضريبي يجب ألا يتجاوز 50 حرف");
                
            RuleFor(v => v.Address)
                .MaximumLength(200).WithMessage("العنوان يجب ألا يتجاوز 200 حرف");
                
            RuleFor(v => v.City)
                .MaximumLength(50).WithMessage("المدينة يجب ألا تتجاوز 50 حرف");
                
            RuleFor(v => v.Region)
                .MaximumLength(50).WithMessage("المنطقة يجب ألا تتجاوز 50 حرف");
                
            RuleFor(v => v.Country)
                .MaximumLength(50).WithMessage("الدولة يجب ألا تتجاوز 50 حرف");
                
            RuleFor(v => v.PostalCode)
                .MaximumLength(20).WithMessage("الرمز البريدي يجب ألا يتجاوز 20 حرف");
                
            RuleFor(v => v.Phone)
                .MaximumLength(20).WithMessage("رقم الهاتف يجب ألا يتجاوز 20 حرف");
                
            RuleFor(v => v.Email)
                .MaximumLength(100).WithMessage("البريد الإلكتروني يجب ألا يتجاوز 100 حرف")
                .EmailAddress().WithMessage("البريد الإلكتروني غير صحيح");
                
            RuleFor(v => v.ManagerName)
                .MaximumLength(100).WithMessage("اسم المدير يجب ألا يتجاوز 100 حرف");
                
            RuleFor(v => v.ManagerEmail)
                .MaximumLength(100).WithMessage("البريد الإلكتروني للمدير يجب ألا يتجاوز 100 حرف")
                .EmailAddress().WithMessage("البريد الإلكتروني للمدير غير صحيح");
                
            RuleFor(v => v.ManagerPhone)
                .MaximumLength(20).WithMessage("رقم هاتف المدير يجب ألا يتجاوز 20 حرف");
                
            RuleFor(v => v.Notes)
                .MaximumLength(500).WithMessage("الملاحظات يجب ألا تتجاوز 500 حرف");
        }
        
        /// <summary>
        /// التحقق من وجود الشركة
        /// </summary>
        private async Task<bool> CompanyExists(Guid companyId, CancellationToken cancellationToken)
        {
            return await _context.CompanyInfo
                .AnyAsync(c => c.Id == companyId, cancellationToken);
        }
        
        /// <summary>
        /// التحقق من أن الرمز فريد
        /// </summary>
        private async Task<bool> CodeIsUnique(CreateBranchCommand command, string code, CancellationToken cancellationToken)
        {
            return !await _context.Branches
                .AnyAsync(b => b.Code == code && b.CompanyInfoId == command.CompanyInfoId, cancellationToken);
        }
        
        /// <summary>
        /// التحقق من وجود الفرع الأب
        /// </summary>
        private async Task<bool> ParentBranchExists(CreateBranchCommand command, Guid? parentBranchId, CancellationToken cancellationToken)
        {
            if (!parentBranchId.HasValue)
            {
                return true;
            }
            
            return await _context.Branches
                .AnyAsync(b => b.Id == parentBranchId.Value && b.CompanyInfoId == command.CompanyInfoId, cancellationToken);
        }
        
        /// <summary>
        /// التحقق من عدم وجود فرع رئيسي آخر
        /// </summary>
        private async Task<bool> NoOtherMainBranch(CreateBranchCommand command, bool isMainBranch, CancellationToken cancellationToken)
        {
            if (!isMainBranch)
            {
                return true;
            }
            
            return !await _context.Branches
                .AnyAsync(b => b.CompanyInfoId == command.CompanyInfoId && b.IsMainBranch, cancellationToken);
        }
    }
} 