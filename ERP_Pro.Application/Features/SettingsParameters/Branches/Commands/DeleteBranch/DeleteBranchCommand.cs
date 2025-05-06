using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.DeleteBranch
{
    /// <summary>
    /// أمر حذف فرع
    /// </summary>
    public class DeleteBranchCommand : IRequest
    {
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// هل يتم حذف التابعين (مثل المستودعات والمستندات) أم نقلهم للفرع الأب
        /// </summary>
        public bool DeleteDependents { get; set; } = false;
    }
    
    /// <summary>
    /// معالج أمر حذف فرع
    /// </summary>
    public class DeleteBranchCommandHandler : IRequestHandler<DeleteBranchCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDomainEventService _domainEventService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public DeleteBranchCommandHandler(
            IApplicationDbContext context,
            IDomainEventService domainEventService)
        {
            _context = context;
            _domainEventService = domainEventService;
        }
        
        /// <summary>
        /// معالجة الأمر
        /// </summary>
        public async Task<Unit> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            // البحث عن الفرع في قاعدة البيانات
            var branch = await _context.Branches
                .Include(b => b.Warehouses)
                .FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);
                
            if (branch == null)
            {
                throw new NotFoundException(nameof(Branch), request.Id);
            }
            
            // التحقق من وجود فروع فرعية
            var hasChildBranches = await _context.Branches
                .AnyAsync(b => b.ParentBranchId == request.Id, cancellationToken);
            
            if (hasChildBranches)
            {
                throw new ValidationException("لا يمكن حذف الفرع لأنه يحتوي على فروع فرعية. يرجى حذف الفروع الفرعية أولاً.");
            }
            
            // التحقق من وجود مستندات مرتبطة
            var hasBranchDocuments = await _context.Set<BranchDocument>()
                .AnyAsync(d => d.BranchId == request.Id, cancellationToken);
                
            if (hasBranchDocuments && !request.DeleteDependents)
            {
                throw new ValidationException("لا يمكن حذف الفرع لأنه يحتوي على مستندات مرتبطة. يرجى تحديد خيار حذف التابعين.");
            }
            
            // التحقق من وجود مستخدمين مرتبطين
            var hasBranchUsers = await _context.Set<BranchUser>()
                .AnyAsync(u => u.BranchId == request.Id, cancellationToken);
                
            if (hasBranchUsers && !request.DeleteDependents)
            {
                throw new ValidationException("لا يمكن حذف الفرع لأنه يحتوي على مستخدمين مرتبطين. يرجى تحديد خيار حذف التابعين.");
            }
            
            // حذف المستودعات المرتبطة إذا تم تحديد خيار حذف التابعين
            if (request.DeleteDependents)
            {
                foreach (var warehouse in branch.Warehouses)
                {
                    _context.Warehouses.Remove(warehouse);
                }
                
                // حذف المستندات المرتبطة
                var branchDocuments = await _context.Set<BranchDocument>()
                    .Where(d => d.BranchId == request.Id)
                    .ToListAsync(cancellationToken);
                    
                foreach (var document in branchDocuments)
                {
                    _context.Set<BranchDocument>().Remove(document);
                }
                
                // حذف المستخدمين المرتبطين
                var branchUsers = await _context.Set<BranchUser>()
                    .Where(u => u.BranchId == request.Id)
                    .ToListAsync(cancellationToken);
                    
                foreach (var user in branchUsers)
                {
                    _context.Set<BranchUser>().Remove(user);
                }
            }
            else
            {
                // التحقق من وجود مستودعات مرتبطة
                if (branch.Warehouses.Any())
                {
                    throw new ValidationException("لا يمكن حذف الفرع لأنه يحتوي على مستودعات مرتبطة. يرجى تحديد خيار حذف التابعين.");
                }
            }
            
            // نشر حدث حذف الفرع
            await _domainEventService.Publish(new BranchDeletedEvent(
                branch.Id,
                branch.Code,
                branch.NameAr,
                branch.CompanyInfoId,
                request.DeleteDependents));
                
            // حذف الفرع
            _context.Branches.Remove(branch);
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
} 