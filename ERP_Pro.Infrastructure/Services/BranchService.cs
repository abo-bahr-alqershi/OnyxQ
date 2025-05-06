using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Services
{
    /// <summary>
    /// تنفيذ خدمة الفروع
    /// </summary>
    public class BranchService : IBranchService
    {
        private readonly IApplicationDbContext _context;

        public BranchService(IApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// الحصول على فرع بواسطة المعرف
        /// </summary>
        public async Task<Branch> GetBranchByIdAsync(Guid branchId, CancellationToken cancellationToken = default)
        {
            return await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == branchId, cancellationToken);
        }

        /// <summary>
        /// الحصول على اسم الفرع بواسطة المعرف
        /// </summary>
        public async Task<string> GetBranchNameAsync(Guid branchId, CancellationToken cancellationToken = default)
        {
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == branchId, cancellationToken);
            
            return branch?.NameAr;
        }

        /// <summary>
        /// التحقق من وجود الفرع
        /// </summary>
        public async Task<bool> BranchExistsAsync(Guid branchId, CancellationToken cancellationToken = default)
        {
            return await _context.Branches
                .AnyAsync(b => b.Id == branchId, cancellationToken);
        }

        /// <summary>
        /// الحصول على رمز الفرع بواسطة المعرف
        /// </summary>
        public async Task<string> GetBranchCodeAsync(Guid branchId, CancellationToken cancellationToken = default)
        {
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == branchId, cancellationToken);
            
            return branch?.Code;
        }

        /// <summary>
        /// التحقق من أن الفرع نشط
        /// </summary>
        public async Task<bool> IsBranchActiveAsync(Guid branchId, CancellationToken cancellationToken = default)
        {
            var branch = await _context.Branches
                .FirstOrDefaultAsync(b => b.Id == branchId, cancellationToken);
            
            return branch != null && branch.Status == "Active";
        }
    }
} 