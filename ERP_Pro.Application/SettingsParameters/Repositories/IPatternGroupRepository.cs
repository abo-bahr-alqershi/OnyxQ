using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Repositories
{
    /// <summary>
    /// مستودع لإدارة مجموعات أنماط الترميز (PatternGroup) والتعامل مع الأنماط المرتبطة بها.
    /// </summary>
    public interface IPatternGroupRepository
    {
        Task<IEnumerable<PatternGroup>> GetAllAsync(string status = null, string groupType = null, string searchTerm = null);
        Task<PatternGroup> GetByCodeAsync(string code);
        Task AddAsync(PatternGroup group);
        Task UpdateAsync(PatternGroup group);
        Task DeleteAsync(string code);
        Task<bool> IsCodeUniqueAsync(string code);
    }
} 