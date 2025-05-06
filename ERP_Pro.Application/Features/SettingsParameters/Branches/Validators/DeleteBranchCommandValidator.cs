using System;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.DeleteBranch;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Validators
{
    /// <summary>
    /// مدقق أمر حذف فرع
    /// </summary>
    public class DeleteBranchCommandValidator : AbstractValidator<DeleteBranchCommand>
    {
        private readonly IApplicationDbContext _context;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public DeleteBranchCommandValidator(IApplicationDbContext context)
        {
            _context = context;
            
            RuleFor(v => v.Id)
                .NotEmpty().WithMessage("معرف الفرع مطلوب")
                .MustAsync(BranchExists).WithMessage("الفرع غير موجود");
                
            RuleFor(v => v)
                .MustAsync(NoChildBranches).WithMessage("لا يمكن حذف الفرع لأنه يحتوي على فروع فرعية. يرجى حذف الفروع الفرعية أولاً.");
                
            RuleFor(v => v)
                .MustAsync(CanDeleteBranch).WithMessage("لا يمكن حذف الفرع. يرجى التأكد من أنه غير مستخدم في أماكن أخرى.");
                
            RuleFor(v => v)
                .MustAsync(HasNoDependents).WithMessage("لا يمكن حذف الفرع لأنه يحتوي على عناصر مرتبطة. يرجى تحديد خيار حذف التابعين.")
                .When(v => !v.DeleteDependents);
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
        /// التحقق من عدم وجود فروع فرعية
        /// </summary>
        private async Task<bool> NoChildBranches(DeleteBranchCommand command, CancellationToken cancellationToken)
        {
            return !await _context.Branches
                .AnyAsync(b => b.ParentBranchId == command.Id, cancellationToken);
        }
        
        /// <summary>
        /// التحقق من إمكانية حذف الفرع
        /// </summary>
        private async Task<bool> CanDeleteBranch(DeleteBranchCommand command, CancellationToken cancellationToken)
        {
            // التحقق من أن الفرع ليس هو الفرع الرئيسي الوحيد
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == command.Id, cancellationToken);
                
            if (branch == null)
            {
                return false;
            }
            
            if (branch.IsMainBranch)
            {
                // التحقق من وجود فروع أخرى للشركة
                var otherBranchesCount = await _context.Branches
                    .CountAsync(b => b.CompanyInfoId == branch.CompanyInfoId && b.Id != command.Id, cancellationToken);
                    
                if (otherBranchesCount == 0)
                {
                    // لا يمكن حذف الفرع الرئيسي الوحيد للشركة
                    return false;
                }
            }
            
            return true;
        }
        
        /// <summary>
        /// التحقق من عدم وجود عناصر تابعة للفرع
        /// </summary>
        private async Task<bool> HasNoDependents(DeleteBranchCommand command, CancellationToken cancellationToken)
        {
            // التحقق من عدم وجود مستودعات مرتبطة
            var hasWarehouses = await _context.Warehouses
                .AnyAsync(w => w.BranchId == command.Id, cancellationToken);
                
            if (hasWarehouses)
            {
                return false;
            }
            
            // التحقق من عدم وجود مستندات مرتبطة
            var hasBranchDocuments = await _context.Set<BranchDocument>()
                .AnyAsync(d => d.BranchId == command.Id, cancellationToken);
                
            if (hasBranchDocuments)
            {
                return false;
            }
            
            // التحقق من عدم وجود مستخدمين مرتبطين
            var hasBranchUsers = await _context.Set<BranchUser>()
                .AnyAsync(u => u.BranchId == command.Id, cancellationToken);
                
            if (hasBranchUsers)
            {
                return false;
            }
            
            return true;
        }
    }
} 