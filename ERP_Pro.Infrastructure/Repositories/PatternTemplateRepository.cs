using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Repositories
{
    /// <summary>
    /// مستودع لإدارة قوالب أنماط الترميز (PatternTemplate) والتعامل مع الأنماط المرتبطة بها.
    /// </summary>
    public interface IPatternTemplateRepository
    {
        /// <summary>
        /// استرجاع جميع القوالب مع إمكانية التصفية.
        /// </summary>
        Task<IEnumerable<PatternTemplate>> GetAllAsync(string category = null, string documentType = null, string searchTerm = null);

        /// <summary>
        /// استرجاع قالب محدد بمعرفه.
        /// </summary>
        Task<PatternTemplate> GetByIdAsync(int id);

        /// <summary>
        /// إضافة قالب جديد.
        /// </summary>
        Task AddAsync(PatternTemplate template);

        /// <summary>
        /// تحديث قالب موجود.
        /// </summary>
        Task UpdateAsync(PatternTemplate template);

        /// <summary>
        /// حذف قالب.
        /// </summary>
        Task DeleteAsync(int id);

        /// <summary>
        /// التحقق من تفرد اسم القالب.
        /// </summary>
        Task<bool> IsNameUniqueAsync(string name);
    }
} 