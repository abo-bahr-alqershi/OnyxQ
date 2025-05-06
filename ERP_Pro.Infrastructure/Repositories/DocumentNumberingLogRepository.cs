using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Repositories
{
    /// <summary>
    /// مستودع لإدارة سجل توليد واستخدام رموز المستندات (DocumentNumberingLog) مع دعم التصفية والاستعلامات المتقدمة.
    /// </summary>
    public interface IDocumentNumberingLogRepository
    {
        /// <summary>
        /// استرجاع جميع السجلات مع إمكانية التصفية.
        /// </summary>
        Task<IEnumerable<DocumentNumberingLog>> GetAllAsync(string patternCode = null, string documentType = null, DateTime? fromDate = null, DateTime? toDate = null, string searchTerm = null);

        /// <summary>
        /// إضافة سجل جديد.
        /// </summary>
        Task AddAsync(DocumentNumberingLog log);

        /// <summary>
        /// حذف سجل.
        /// </summary>
        Task DeleteAsync(int id);
    }
} 