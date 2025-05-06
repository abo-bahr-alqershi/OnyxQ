using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.FinanceAccounting.Repositories;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrency
{
    /// <summary>
    /// معالج أمر إنشاء عملة جديدة
    /// </summary>
    public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CreateCurrencyCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<Guid> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
        {
            // التحقق من تفرد رمز العملة
            if (!await _currencyRepository.IsCodeUniqueAsync(request.Code))
            {
                throw new Exception($"رمز العملة '{request.Code}' مستخدم بالفعل");
            }

            // التحقق من وجود عملة أساسية أخرى إذا كانت هذه العملة أساسية
            if (request.IsBaseCurrency)
            {
                var existingBaseCurrency = await _currencyRepository.GetBaseCurrencyAsync();
                if (existingBaseCurrency != null)
                {
                    // إلغاء كون العملة الأخرى أساسية
                    existingBaseCurrency.UnsetAsBaseCurrency();
                    await _currencyRepository.UpdateAsync(existingBaseCurrency);
                }
            }

            // إنشاء كيان العملة
            var currency = Currency.Create(
                request.Code,
                request.NameAr,
                request.NameEn,
                request.Symbol,
                request.Country,
                request.IsBaseCurrency,
                request.DecimalPlaces);

            // تحديث المعلومات الأساسية
            currency.UpdateBasicInfo(
                request.NameAr,
                request.NameEn,
                request.InternationalCode,
                request.Symbol,
                request.Country,
                request.Notes);

            // تحديث خصائص العملة
            currency.UpdateCurrencyProperties(
                request.DecimalPlaces,
                request.ThousandsSeparator,
                request.DecimalSeparator,
                request.SymbolPosition,
                request.SubUnit,
                request.SubUnitValue,
                request.ShowDecimalZeros,
                request.AddSpaceBetweenSymbolAndAmount);

            // إضافة العملة إلى قاعدة البيانات
            await _currencyRepository.AddAsync(currency);

            // إذا تم تحديد سعر صرف، إضافته
            if (request.ExchangeRate != 1 || !request.IsBaseCurrency)
            {
                var exchangeRate = CurrencyExchangeRate.Create(
                    currency.Id,
                    DateTime.UtcNow,
                    "Base",
                    request.ExchangeRate);

                await _currencyRepository.AddExchangeRateAsync(exchangeRate);
            }

            return currency.Id;
        }
    }
} 