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
    /// معالج أمر إضافة حد مخاطر للعملة
    /// </summary>
    public class AddCurrencyRiskLimitCommandHandler : IRequestHandler<AddCurrencyRiskLimitCommand, CurrencyRiskLimitDto>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUser _currentUser;

        public AddCurrencyRiskLimitCommandHandler(ICurrencyRepository currencyRepository, ICurrentUser currentUser)
        {
            _currencyRepository = currencyRepository;
            _currentUser = currentUser;
        }

        public async Task<CurrencyRiskLimitDto> Handle(AddCurrencyRiskLimitCommand request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.CurrencyId));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // إنشاء معرف فريد لحد المخاطر
            var riskLimitId = CurrencyRiskLimitId.CreateUnique();

            // إنشاء حد مخاطر جديد
            var riskLimit = new CurrencyRiskLimit(
                riskLimitId,
                currency.Id,
                request.MaxDailyFluctuation,
                request.AlertThreshold,
                request.MaxExposure,
                request.Notes);

            // تعيين معلومات المستخدم
            typeof(CurrencyRiskLimit).GetProperty("CreatedBy").SetValue(riskLimit, _currentUser.UserId);
            typeof(CurrencyRiskLimit).GetProperty("LastModifiedBy").SetValue(riskLimit, _currentUser.UserId);

            // حفظ حد المخاطر الجديد
            var createdRiskLimit = await _currencyRepository.AddRiskLimitAsync(riskLimit);
            await _currencyRepository.SaveChangesAsync();

            // إعادة DTO
            return new CurrencyRiskLimitDto
            {
                Id = createdRiskLimit.Id.Value,
                CurrencyId = createdRiskLimit.CurrencyId.Value,
                CurrencyCode = currency.Code,
                CurrencyName = currency.NameAr,
                MaxDailyFluctuation = createdRiskLimit.MaxDailyFluctuation,
                AlertThreshold = createdRiskLimit.AlertThreshold,
                MaxExposure = createdRiskLimit.MaxExposure,
                IsActive = createdRiskLimit.IsActive,
                Notes = createdRiskLimit.Notes,
                CreatedOn = createdRiskLimit.CreatedOn,
                CreatedBy = createdRiskLimit.CreatedBy,
                LastModifiedOn = createdRiskLimit.LastModifiedOn,
                LastModifiedBy = createdRiskLimit.LastModifiedBy
            };
        }
    }
} 