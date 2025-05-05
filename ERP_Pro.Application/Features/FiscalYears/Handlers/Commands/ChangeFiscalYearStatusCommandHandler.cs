using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.FiscalYears.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Handlers.Commands
{
    /// <summary>
    /// معالج أمر تغيير حالة سنة مالية
    /// </summary>
    public class ChangeFiscalYearStatusCommandHandler : IRequestHandler<ChangeFiscalYearStatusCommand, bool>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;
        private readonly ICurrentUserService _currentUserService;

        public ChangeFiscalYearStatusCommandHandler(
            IFiscalYearRepository fiscalYearRepository,
            ICurrentUserService currentUserService)
        {
            _fiscalYearRepository = fiscalYearRepository;
            _currentUserService = currentUserService;
        }

        public async Task<bool> Handle(ChangeFiscalYearStatusCommand request, CancellationToken cancellationToken)
        {
            // الحصول على السنة المالية
            var fiscalYearId = FiscalYearId.Create(request.Id);
            var fiscalYear = await _fiscalYearRepository.GetByIdAsync(fiscalYearId, true);
            
            if (fiscalYear == null)
            {
                throw new Exception("السنة المالية غير موجودة");
            }

            // تغيير حالة السنة المالية
            // ملاحظة: منطق التحقق من صحة تغيير الحالة موجود في كيان السنة المالية
            try
            {
                fiscalYear.ChangeStatus(request.NewStatus, _currentUserService.UserId);
            }
            catch (Exception ex)
            {
                throw new Exception($"فشل تغيير حالة السنة المالية: {ex.Message}");
            }

            // حفظ التغييرات
            await _fiscalYearRepository.UpdateAsync(fiscalYear);
            var result = await _fiscalYearRepository.SaveChangesAsync();

            return result > 0;
        }
    }
} 