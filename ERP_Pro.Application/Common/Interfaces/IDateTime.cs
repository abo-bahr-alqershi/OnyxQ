using System;

namespace ERP_Pro.Application.Common.Interfaces
{
    /// <summary>
    /// واجهة خدمة التاريخ والوقت
    /// </summary>
    public interface IDateTime
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
        DateTime Today { get; }
    }
} 