using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Repositories
{
    /// <summary>
    /// مستودع لإدارة أنماط ترميز المستندات (DocumentNumberingPattern) والتعامل مع العلاقات المرتبطة بها.
    /// </summary>
    public interface IDocumentNumberingPatternRepository
    {
        Task<IEnumerable<DocumentNumberingPattern>> GetAllAsync(string status = null, string documentType = null, string groupCode = null, string searchTerm = null);
        Task<DocumentNumberingPattern> GetByCodeAsync(string code);
        Task AddAsync(DocumentNumberingPattern pattern);
        Task UpdateAsync(DocumentNumberingPattern pattern);
        Task DeleteAsync(string code);
        Task<bool> IsCodeUniqueAsync(string code);
    }
} 