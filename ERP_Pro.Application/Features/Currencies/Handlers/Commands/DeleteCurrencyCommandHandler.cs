using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Commands
{
    /// <summary>
    /// معالج أمر حذف عملة
    /// </summary>
    public class DeleteCurrencyCommandHandler : IRequestHandler<DeleteCurrencyCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public DeleteCurrencyCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<bool> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.Id));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.Id} غير موجودة");
            }

            // التحقق من أن العملة ليست هي العملة الأساسية
            if (currency.IsBaseCurrency)
            {
                throw new InvalidOperationException("لا يمكن حذف العملة الأساسية");
            }

            // التحقق من إمكانية حذف العملة
            if (!await _currencyRepository.CanDeleteAsync(currency.Id))
            {
                throw new InvalidOperationException("لا يمكن حذف هذه العملة لأنها مستخدمة في معاملات أخرى");
            }

            // حذف العملة
            var result = await _currencyRepository.DeleteAsync(currency.Id);
            await _currencyRepository.SaveChangesAsync();

            return result;
        }
    }
} 