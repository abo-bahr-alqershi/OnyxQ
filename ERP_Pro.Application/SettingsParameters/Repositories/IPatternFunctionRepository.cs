using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Repositories
{
    /// <summary>
    /// مستودع لإدارة دوال أنماط الترميز (PatternFunction) والتعامل مع الأنماط المرتبطة بها.
    /// </summary>
    public interface IPatternFunctionRepository
    {
        Task<IEnumerable<PatternFunction>> GetAllAsync(string functionType = null, string returnType = null, string searchTerm = null);
        Task<PatternFunction> GetByNameAsync(string name);
        Task AddAsync(PatternFunction function);
        Task UpdateAsync(PatternFunction function);
        Task DeleteAsync(string name);
        Task<bool> IsNameUniqueAsync(string name);
    }
} 