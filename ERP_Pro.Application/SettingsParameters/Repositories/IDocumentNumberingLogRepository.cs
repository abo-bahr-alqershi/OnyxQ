using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.SettingsParameters.Repositories
{
    /// <summary>
    /// مستودع لإدارة سجل توليد واستخدام رموز المستندات (DocumentNumberingLog) مع دعم التصفية والاستعلامات المتقدمة.
    /// </summary>
    public interface IDocumentNumberingLogRepository
    {
        Task<IEnumerable<DocumentNumberingLog>> GetAllAsync(string patternCode = null, string documentType = null, DateTime? fromDate = null, DateTime? toDate = null, string searchTerm = null);
        Task AddAsync(DocumentNumberingLog log);
        Task DeleteAsync(int id);
    }
} 