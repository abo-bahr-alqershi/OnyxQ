using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Repositories
{
    /// <summary>
    /// مستودع لإدارة دوال أنماط الترميز (PatternFunction) والتعامل مع الأنماط المرتبطة بها.
    /// </summary>
    public interface IPatternFunctionRepository
    {
        /// <summary>
        /// استرجاع جميع الدوال مع إمكانية التصفية.
        /// </summary>
        Task<IEnumerable<PatternFunction>> GetAllAsync(string functionType = null, string returnType = null, string searchTerm = null);

        /// <summary>
        /// استرجاع دالة محددة باسمها.
        /// </summary>
        Task<PatternFunction> GetByNameAsync(string name);

        /// <summary>
        /// إضافة دالة جديدة.
        /// </summary>
        Task AddAsync(PatternFunction function);

        /// <summary>
        /// تحديث دالة موجودة.
        /// </summary>
        Task UpdateAsync(PatternFunction function);

        /// <summary>
        /// حذف دالة.
        /// </summary>
        Task DeleteAsync(string name);

        /// <summary>
        /// التحقق من تفرد اسم الدالة.
        /// </summary>
        Task<bool> IsNameUniqueAsync(string name);
    }
} 