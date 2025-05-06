using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteRiskLimit
{
    /// <summary>
    /// معالج أمر حذف حد مخاطر
    /// </summary>
    public class DeleteRiskLimitCommandHandler : IRequestHandler<DeleteRiskLimitCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public DeleteRiskLimitCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<bool> Handle(DeleteRiskLimitCommand request, CancellationToken cancellationToken)
        {
            // التحقق من وجود حد المخاطر
            var riskLimit = await _currencyRepository.GetRiskLimitByIdAsync(request.Id);
            if (riskLimit == null)
            {
                throw new KeyNotFoundException($"حد المخاطر بالمعرف {request.Id} غير موجود");
            }

            // حذف حد المخاطر
            await _currencyRepository.DeleteRiskLimitAsync(request.Id);

            return true;
        }
    }
} 