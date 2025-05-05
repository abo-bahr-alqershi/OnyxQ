using System;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Commands
{
    /// <summary>
    /// أمر تعيين السنة المالية الافتراضية
    /// </summary>
    public class SetDefaultFiscalYearCommand : IRequest<bool>
    {
        /// <summary>
        /// رقم التعريف
        /// </summary>
        public Guid Id { get; set; }
    }
} 