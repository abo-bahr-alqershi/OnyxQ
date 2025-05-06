using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.ChangeBranchStatus;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Validators
{
    /// <summary>
    /// مدقق أمر تغيير حالة فرع
    /// </summary>
    public class ChangeBranchStatusValidator : AbstractValidator<ChangeBranchStatusCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ChangeBranchStatusValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.Id)
                .NotEmpty().WithMessage("معرف الفرع مطلوب")
                .MustAsync(BranchExists).WithMessage("الفرع غير موجود");
                
            RuleFor(v => v.Status)
                .NotEmpty().WithMessage("الحالة مطلوبة")
                .Must(BeValidStatus).WithMessage("الحالة غير صالحة. القيم المسموحة: Active, Inactive, Closed");
                
            RuleFor(v => v)
                .MustAsync(CanChangeStatus).WithMessage("لا يمكن تغيير حالة الفرع لأنه يحتوي على فروع فرعية نشطة")
                .When(v => v.Status == "Inactive" || v.Status == "Closed");
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
        /// التحقق من صحة الحالة
        /// </summary>
        private bool BeValidStatus(string status)
        {
            return !string.IsNullOrWhiteSpace(status) && 
                   (status == "Active" || status == "Inactive" || status == "Closed");
        }
        
        /// <summary>
        /// التحقق من إمكانية تغيير حالة الفرع
        /// </summary>
        private async Task<bool> CanChangeStatus(ChangeBranchStatusCommand command, CancellationToken cancellationToken)
        {
            // إذا كانت الحالة المطلوبة هي "نشط" فيمكن تغييرها دائماً
            if (command.Status == "Active")
            {
                return true;
            }
            
            // التحقق من عدم وجود فروع فرعية نشطة
            var hasActiveChildBranches = await _context.Branches
                .AnyAsync(b => b.ParentBranchId == command.Id && b.Status == "Active", cancellationToken);
                
            if (hasActiveChildBranches)
            {
                return false;
            }
            
            // التحقق من عدم وجود مستودعات نشطة مرتبطة بالفرع
            if (command.Status == "Closed")
            {
                var hasActiveWarehouses = await _context.Warehouses
                    .AnyAsync(w => w.BranchId == command.Id && w.Status == "Active", cancellationToken);
                    
                if (hasActiveWarehouses)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
} 