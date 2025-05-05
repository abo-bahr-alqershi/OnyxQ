using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.FiscalYears.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Handlers.Commands
{
    /// <summary>
    /// معالج أمر حذف سنة مالية
    /// </summary>
    public class DeleteFiscalYearCommandHandler : IRequestHandler<DeleteFiscalYearCommand, bool>
    {
        private readonly IFiscalYearRepository _fiscalYearRepository;

        public DeleteFiscalYearCommandHandler(IFiscalYearRepository fiscalYearRepository)
        {
            _fiscalYearRepository = fiscalYearRepository;
        }

        public async Task<bool> Handle(DeleteFiscalYearCommand request, CancellationToken cancellationToken)
        {
            // الحصول على السنة المالية
            var fiscalYearId = FiscalYearId.Create(request.Id);
            var fiscalYear = await _fiscalYearRepository.GetByIdAsync(fiscalYearId, true);
            
            if (fiscalYear == null)
            {
                throw new Exception("السنة المالية غير موجودة");
            }

            // التحقق من حالة السنة المالية
            if (fiscalYear.Status != FiscalYearStatusEnum.InPreparation)
            {
                throw new Exception("لا يمكن حذف سنة مالية إلا إذا كانت في حالة قيد الإعداد");
            }

            // التحقق من وجود فترات محاسبية
            if (fiscalYear.FiscalPeriods.Any())
            {
                throw new Exception("لا يمكن حذف سنة مالية تحتوي على فترات محاسبية");
            }

            // التحقق من وجود إعدادات للسنة المالية
            if (fiscalYear.FiscalYearSettings.Any())
            {
                throw new Exception("لا يمكن حذف سنة مالية تحتوي على إعدادات");
            }

            // حذف السنة المالية
            await _fiscalYearRepository.DeleteAsync(fiscalYearId);
            var result = await _fiscalYearRepository.SaveChangesAsync();

            return result > 0;
        }
    }
} 