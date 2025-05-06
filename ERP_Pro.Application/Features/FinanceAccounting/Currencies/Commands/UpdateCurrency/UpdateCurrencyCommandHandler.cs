using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.FinanceAccounting.Repositories;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateCurrency
{
    /// <summary>
    /// معالج أمر تحديث بيانات العملة
    /// </summary>
    public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public UpdateCurrencyCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<bool> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByIdAsync(request.Id);
            if (currency == null)
            {
                throw new Exception($"العملة برقم {request.Id} غير موجودة");
            }

            // التحقق من تفرد رمز العملة إذا تم تغييره
            if (currency.Code != request.Code && !await _currencyRepository.IsCodeUniqueAsync(request.Code, request.Id))
            {
                throw new Exception($"رمز العملة '{request.Code}' مستخدم بالفعل");
            }

            // التحقق من وجود عملة أساسية أخرى إذا كانت هذه العملة أساسية
            if (request.IsBaseCurrency && !currency.IsBaseCurrency)
            {
                var existingBaseCurrency = await _currencyRepository.GetBaseCurrencyAsync();
                if (existingBaseCurrency != null && existingBaseCurrency.Id != request.Id)
                {
                    // إلغاء كون العملة الأخرى أساسية
                    existingBaseCurrency.UnsetAsBaseCurrency();
                    await _currencyRepository.UpdateAsync(existingBaseCurrency);
                }
                
                currency.SetAsBaseCurrency();
            }
            else if (!request.IsBaseCurrency && currency.IsBaseCurrency)
            {
                throw new Exception("لا يمكن إلغاء كون العملة الأساسية دون تحديد عملة أساسية بديلة");
            }

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

            // تحديث قواعد التقريب
            currency.UpdateRoundingRules(
                request.RoundingType,
                request.RoundingUnit,
                request.RoundingAppliedTo,
                request.MinRoundingAmount,
                request.MaxRoundingAmount,
                request.RoundingDifferenceAccountId);

            // تحديث إعدادات تحويل المبالغ إلى كلمات
            currency.UpdateAmountToWordsSettings(
                request.AmountToWordsTemplateAr,
                request.AmountToWordsTemplateEn,
                request.WriteSubUnitInWords,
                request.SubUnitSeparator,
                request.GenderOptions);

            // تحديث الحسابات المرتبطة
            currency.UpdateLinkedAccounts(
                request.ExchangeRateGainAccountId,
                request.ExchangeRateLossAccountId,
                request.CurrencyRevaluationAccountId,
                request.RoundingAccountId,
                request.CurrencySettlementAccountId);

            // تحديث العملة في قاعدة البيانات
            await _currencyRepository.UpdateAsync(currency);

            return true;
        }
    }
} 