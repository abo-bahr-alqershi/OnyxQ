using System;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Commands
{
    /// <summary>
    /// أمر تغيير حالة سنة مالية
    /// </summary>
    public class ChangeFiscalYearStatusCommand : IRequest<bool>
    {
        /// <summary>
        /// رقم التعريف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// الحالة الجديدة
        /// </summary>
        public FiscalYearStatusEnum NewStatus { get; set; }
    }
} 