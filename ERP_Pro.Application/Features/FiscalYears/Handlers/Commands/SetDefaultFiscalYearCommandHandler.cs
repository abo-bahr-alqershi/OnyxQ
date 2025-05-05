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
    /// معالج أمر تعيين السنة المالية الافتراضية
    /// </summary>
    public class SetDefaultFiscalYearCommandHandler : IRequestHandler<SetDefaultFiscalYearCommand, bool>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;
        private readonly ICurrentUserService _currentUserService;

        public SetDefaultFiscalYearCommandHandler(
            IFiscalYearRepository fiscalYearRepository,
            ICurrentUserService currentUserService)
        {
            _fiscalYearRepository = fiscalYearRepository;
            _currentUserService = currentUserService;
        }

        public async Task<bool> Handle(SetDefaultFiscalYearCommand request, CancellationToken cancellationToken)
        {
            // الحصول على السنة المالية
            var fiscalYearId = FiscalYearId.Create(request.Id);
            var fiscalYear = await _fiscalYearRepository.GetByIdAsync(fiscalYearId);
            
            if (fiscalYear == null)
            {
                throw new Exception("السنة المالية غير موجودة");
            }

            // إلغاء تعيين السنة المالية الافتراضية الحالية (إن وجدت)
            var currentDefault = await _fiscalYearRepository.GetDefaultAsync();
            if (currentDefault != null && currentDefault.Id != fiscalYearId)
            {
                currentDefault.UnsetDefault(_currentUserService.UserId);
                await _fiscalYearRepository.UpdateAsync(currentDefault);
            }

            // تعيين السنة المالية الحالية كافتراضية
            if (!fiscalYear.IsDefault)
            {
                fiscalYear.SetAsDefault(_currentUserService.UserId);
                await _fiscalYearRepository.UpdateAsync(fiscalYear);
            }

            // حفظ التغييرات
            var result = await _fiscalYearRepository.SaveChangesAsync();

            return result > 0;
        }
    }
} 