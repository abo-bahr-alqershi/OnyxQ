using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Repositories
{
    /// <summary>
    /// مستودع لإدارة مجموعات أنماط الترميز (PatternGroup) والتعامل مع الأنماط المرتبطة بها.
    /// </summary>
    public interface IPatternGroupRepository
    {
        /// <summary>
        /// استرجاع جميع المجموعات مع إمكانية التصفية.
        /// </summary>
        Task<IEnumerable<PatternGroup>> GetAllAsync(string status = null, string groupType = null, string searchTerm = null);

        /// <summary>
        /// استرجاع مجموعة محددة برمزها.
        /// </summary>
        Task<PatternGroup> GetByCodeAsync(string code);

        /// <summary>
        /// إضافة مجموعة جديدة.
        /// </summary>
        Task AddAsync(PatternGroup group);

        /// <summary>
        /// تحديث مجموعة موجودة.
        /// </summary>
        Task UpdateAsync(PatternGroup group);

        /// <summary>
        /// حذف مجموعة.
        /// </summary>
        Task DeleteAsync(string code);

        /// <summary>
        /// التحقق من تفرد رمز المجموعة.
        /// </summary>
        Task<bool> IsCodeUniqueAsync(string code);
    }
} 