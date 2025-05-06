using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Events;

namespace ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.ChangeBranchStatus
{
    /// <summary>
    /// أمر تغيير حالة فرع
    /// </summary>
    public class ChangeBranchStatusCommand : IRequest
    {
        /// <summary>
        /// معرف الفرع
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// الحالة الجديدة (Active, Inactive, Closed)
        /// </summary>
        public string Status { get; set; }
    }
    
    /// <summary>
    /// معالج أمر تغيير حالة فرع
    /// </summary>
    public class ChangeBranchStatusCommandHandler : IRequestHandler<ChangeBranchStatusCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IDomainEventService _domainEventService;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public ChangeBranchStatusCommandHandler(
            IApplicationDbContext context,
            IDomainEventService domainEventService)
        {
            _context = context;
            _domainEventService = domainEventService;
        }
        
        /// <summary>
        /// معالجة الأمر
        /// </summary>
        public async Task<Unit> Handle(ChangeBranchStatusCommand request, CancellationToken cancellationToken)
        {
            // التحقق من صحة الحالة
            if (string.IsNullOrWhiteSpace(request.Status) ||
                (request.Status != "Active" && request.Status != "Inactive" && request.Status != "Closed"))
            {
                throw new ValidationException("الحالة غير صالحة. القيم المسموحة: Active, Inactive, Closed");
            }
            
            // البحث عن الفرع في قاعدة البيانات
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == request.Id, cancellationToken);
                
            if (branch == null)
            {
                throw new NotFoundException(nameof(Branch), request.Id);
            }
            
            // حفظ الحالة القديمة للفرع
            string oldStatus = branch.Status;
            
            // تغيير حالة الفرع
            branch.ChangeStatus(request.Status);
            
            // نشر حدث تغيير حالة الفرع
            await _domainEventService.Publish(new BranchStatusChangedEvent(
                branch.Id,
                branch.Code,
                branch.NameAr,
                oldStatus,
                request.Status));
            
            // حفظ التغييرات
            await _context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }
} 