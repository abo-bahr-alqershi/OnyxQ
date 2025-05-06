using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.UpdateBranch;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Validators
{
    /// <summary>
    /// مدقق أمر تحديث بيانات فرع
    /// </summary>
    public class UpdateBranchCommandValidator : AbstractValidator<UpdateBranchCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public UpdateBranchCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.Id)
                .NotEmpty().WithMessage("معرف الفرع مطلوب")
                .MustAsync(BranchExists).WithMessage("الفرع غير موجود");
                
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
                .MustAsync(ParentBranchValid).WithMessage("الفرع الأب غير صالح")
                .When(v => v.ParentBranchId.HasValue);
                
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
                .EmailAddress().WithMessage("البريد الإلكتروني غير صحيح")
                .When(v => !string.IsNullOrWhiteSpace(v.Email));
                
            RuleFor(v => v.ManagerName)
                .MaximumLength(100).WithMessage("اسم المدير يجب ألا يتجاوز 100 حرف");
                
            RuleFor(v => v.ManagerEmail)
                .MaximumLength(100).WithMessage("البريد الإلكتروني للمدير يجب ألا يتجاوز 100 حرف")
                .EmailAddress().WithMessage("البريد الإلكتروني للمدير غير صحيح")
                .When(v => !string.IsNullOrWhiteSpace(v.ManagerEmail));
                
            RuleFor(v => v.ManagerPhone)
                .MaximumLength(20).WithMessage("رقم هاتف المدير يجب ألا يتجاوز 20 حرف");
                
            RuleFor(v => v.Notes)
                .MaximumLength(500).WithMessage("الملاحظات يجب ألا تتجاوز 500 حرف");
        }
        
        /// <summary>
        /// التحقق من وجود الفرع
        /// </summary>
        private async Task<bool> BranchExists(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Branches
                .AnyAsync(b => b.Id == id, cancellationToken);
        }
        
        /// <summary>
        /// التحقق من صحة الفرع الأب
        /// </summary>
        private async Task<bool> ParentBranchValid(UpdateBranchCommand command, Guid? parentBranchId, CancellationToken cancellationToken)
        {
            if (!parentBranchId.HasValue)
            {
                return true;
            }
            
            // التأكد من أن الفرع الأب موجود ومن نفس الشركة
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == command.Id, cancellationToken);
                
            if (branch == null)
            {
                return false;
            }
            
            // التأكد من أن الفرع الأب ليس هو نفس الفرع
            if (parentBranchId.Value == command.Id)
            {
                return false;
            }
            
            // التأكد من أن الفرع الأب موجود
            var parentBranch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == parentBranchId.Value, cancellationToken);
                
            if (parentBranch == null)
            {
                return false;
            }
            
            // التأكد من أن الفرع الأب من نفس الشركة
            if (parentBranch.CompanyInfoId != branch.CompanyInfoId)
            {
                return false;
            }
            
            // التأكد من عدم وجود دورة في هيكل الفروع (منع الفرع من أن يكون أبا لأحد أسلافه)
            return !await HasCyclicReference(command.Id, parentBranchId.Value, cancellationToken);
        }
        
        /// <summary>
        /// التحقق من عدم وجود إشارة دائرية في هيكل الفروع
        /// </summary>
        private async Task<bool> HasCyclicReference(Guid branchId, Guid parentBranchId, CancellationToken cancellationToken)
        {
            // البحث عن الفرع الأب
            var currentBranch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == parentBranchId, cancellationToken);
                
            if (currentBranch == null)
            {
                return false;
            }
            
            // التحقق مما إذا كان الفرع الحالي يشير إلى الفرع المراد تحديثه كأحد أسلافه
            while (currentBranch.ParentBranchId.HasValue)
            {
                if (currentBranch.ParentBranchId.Value == branchId)
                {
                    return true; // وجود إشارة دائرية
                }
                
                currentBranch = await _context.Branches
                    .FirstOrDefaultAsync(b => b.Id == currentBranch.ParentBranchId.Value, cancellationToken);
                    
                if (currentBranch == null)
                {
                    break;
                }
            }
            
            return false; // لا توجد إشارة دائرية
        }
    }
} 