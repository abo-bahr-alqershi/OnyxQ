using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Commands;
using ERP_Pro.Application.Features.Currencies.Dtos;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Commands
{
    /// <summary>
    /// معالج أمر إنشاء عملة جديدة
    /// </summary>
    public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand, CurrencyDto>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUser _currentUser;

        public CreateCurrencyCommandHandler(ICurrencyRepository currencyRepository, ICurrentUser currentUser)
        {
            _currencyRepository = currencyRepository;
            _currentUser = currentUser;
        }

        public async Task<CurrencyDto> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
        {
            // التحقق من عدم وجود عملة بنفس الرمز
            if (await _currencyRepository.ExistsByCodeAsync(request.Code))
            {
                throw new InvalidOperationException($"توجد عملة بالفعل بالرمز {request.Code}");
            }

            // التحقق من العملة الأساسية
            bool isBaseCurrency = request.IsBaseCurrency;
            if (isBaseCurrency && await _currencyRepository.ExistsBaseCurrencyAsync())
            {
                throw new InvalidOperationException("توجد عملة أساسية بالفعل. يجب تغيير العملة الأساسية بدلاً من إنشاء عملة أساسية جديدة.");
            }

            // إنشاء كيان العملة
            var currency = new Currency(
                CurrencyId.CreateUnique(),
                request.Code,
                request.NameAr,
                request.NameEn,
                request.Symbol,
                request.DecimalPlaces,
                isBaseCurrency);

            // تعيين القيم الإضافية
            if (!string.IsNullOrEmpty(request.IsoCode))
            {
                // تستخدم الكلمة المحجوزة this ولذلك نحتاج للوصول للكيان بطريقة أخرى
                typeof(Currency).GetProperty("IsoCode").SetValue(currency, request.IsoCode);
            }

            if (!string.IsNullOrEmpty(request.Country))
            {
                typeof(Currency).GetProperty("Country").SetValue(currency, request.Country);
            }

            if (!string.IsNullOrEmpty(request.ThousandsSeparator))
            {
                typeof(Currency).GetProperty("ThousandsSeparator").SetValue(currency, request.ThousandsSeparator);
            }

            if (!string.IsNullOrEmpty(request.DecimalSeparator))
            {
                typeof(Currency).GetProperty("DecimalSeparator").SetValue(currency, request.DecimalSeparator);
            }

            if (!string.IsNullOrEmpty(request.Notes))
            {
                typeof(Currency).GetProperty("Notes").SetValue(currency, request.Notes);
            }

            // تعيين معلومات المستخدم
            typeof(Currency).GetProperty("CreatedBy").SetValue(currency, _currentUser.UserId);
            typeof(Currency).GetProperty("LastModifiedBy").SetValue(currency, _currentUser.UserId);

            // حفظ العملة
            var result = await _currencyRepository.AddAsync(currency);
            await _currencyRepository.SaveChangesAsync();

            // إعادة DTO للعملة
            return new CurrencyDto
            {
                Id = result.Id.Value,
                Code = result.Code,
                IsoCode = result.IsoCode,
                NameAr = result.NameAr,
                NameEn = result.NameEn,
                Symbol = result.Symbol,
                Country = result.Country,
                IsBaseCurrency = result.IsBaseCurrency,
                Status = result.Status,
                DecimalPlaces = result.DecimalPlaces,
                ThousandsSeparator = result.ThousandsSeparator,
                DecimalSeparator = result.DecimalSeparator,
                Notes = result.Notes
            };
        }
    }
} 