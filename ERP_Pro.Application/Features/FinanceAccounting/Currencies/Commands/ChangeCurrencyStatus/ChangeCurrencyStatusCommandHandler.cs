using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.FinanceAccounting.Repositories;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.ChangeCurrencyStatus
{
    /// <summary>
    /// معالج أمر تغيير حالة عملة (تفعيل/تعطيل)
    /// </summary>
    public class ChangeCurrencyStatusCommandHandler : IRequestHandler<ChangeCurrencyStatusCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public ChangeCurrencyStatusCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<bool> Handle(ChangeCurrencyStatusCommand request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByIdAsync(request.Id);
            if (currency == null)
            {
                throw new Exception($"العملة برقم {request.Id} غير موجودة");
            }

            try
            {
                if (request.Activate)
                {
                    currency.Activate();
                }
                else
                {
                    if (currency.IsBase)
                    {
                        throw new Exception("لا يمكن تعطيل العملة الأساسية");
                    }

                    currency.Deactivate();
                }

                await _currencyRepository.UpdateAsync(currency);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"حدث خطأ أثناء تغيير حالة العملة: {ex.Message}", ex);
            }
        }
    }
} 