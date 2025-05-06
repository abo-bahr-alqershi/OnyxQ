using System;
using ERP_Pro.Application.Common.Interfaces;

namespace ERP_Pro.Infrastructure.Services
{
    /// <summary>
    /// خدمة التاريخ والوقت
    /// </summary>
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;
        public DateTime Today => DateTime.Today;
    }
} 