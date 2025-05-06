using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Repositories
{
    /// <summary>
    /// مستودع لإدارة قوالب أنماط الترميز (PatternTemplate) والتعامل مع الأنماط المرتبطة بها.
    /// </summary>
    public interface IPatternTemplateRepository
    {
        Task<IEnumerable<PatternTemplate>> GetAllAsync(string category = null, string documentType = null, string searchTerm = null);
        Task<PatternTemplate> GetByIdAsync(int id);
        Task AddAsync(PatternTemplate template);
        Task UpdateAsync(PatternTemplate template);
        Task DeleteAsync(int id);
        Task<bool> IsNameUniqueAsync(string name);
    }
} 