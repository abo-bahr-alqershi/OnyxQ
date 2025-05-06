using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Common.Interfaces
{
    /// <summary>
    /// واجهة خدمة الفروع
    /// </summary>
    public interface IBranchService
    {
        /// <summary>
        /// الحصول على فرع بواسطة المعرف
        /// </summary>
        Task<Branch> GetBranchByIdAsync(Guid branchId, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// الحصول على اسم الفرع بواسطة المعرف
        /// </summary>
        Task<string> GetBranchNameAsync(Guid branchId, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// التحقق من وجود الفرع
        /// </summary>
        Task<bool> BranchExistsAsync(Guid branchId, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// الحصول على رمز الفرع بواسطة المعرف
        /// </summary>
        Task<string> GetBranchCodeAsync(Guid branchId, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// التحقق من أن الفرع نشط
        /// </summary>
        Task<bool> IsBranchActiveAsync(Guid branchId, CancellationToken cancellationToken = default);
    }
} 