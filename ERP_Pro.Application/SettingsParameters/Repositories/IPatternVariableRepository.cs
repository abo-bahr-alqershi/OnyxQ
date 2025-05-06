using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Repositories
{
    /// <summary>
    /// مستودع لإدارة متغيرات أنماط الترميز (PatternVariable) والتعامل مع الأنماط المرتبطة بها.
    /// </summary>
    public interface IPatternVariableRepository
    {
        Task<IEnumerable<PatternVariable>> GetAllAsync(string variableType = null, string dataSource = null, string searchTerm = null);
        Task<PatternVariable> GetByCodeAsync(string code);
        Task AddAsync(PatternVariable variable);
        Task UpdateAsync(PatternVariable variable);
        Task DeleteAsync(string code);
        Task<bool> IsCodeUniqueAsync(string code);
    }
} 