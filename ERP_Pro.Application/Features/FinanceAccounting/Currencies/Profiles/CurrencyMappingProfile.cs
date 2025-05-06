using AutoMapper;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Profiles
{
    /// <summary>
    /// ملف تعريف التحويلات للعملات
    /// </summary>
    public class CurrencyMappingProfile : Profile
    {
        public CurrencyMappingProfile()
        {
            // تحويل من كيان العملة إلى DTO عرض العملة
            CreateMap<Currency, CurrencyDto>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status == CurrencyStatusEnum.Active))
                .ForMember(dest => dest.IsBaseCurrency, opt => opt.MapFrom(src => src.IsBase))
                .ForMember(dest => dest.ExchangeRate, opt => opt.Ignore()) // يتم تعبئته لاحقاً في معالج الاستعلام
                .ForMember(dest => dest.LastExchangeRateUpdate, opt => opt.Ignore()); // يتم تعبئته لاحقاً في معالج الاستعلام

            // تحويل من كيان العملة إلى DTO تفاصيل العملة
            CreateMap<Currency, CurrencyDetailsDto>()
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Status == CurrencyStatusEnum.Active))
                .ForMember(dest => dest.IsBaseCurrency, opt => opt.MapFrom(src => src.IsBase))
                .ForMember(dest => dest.InternationalCode, opt => opt.MapFrom(src => src.IsoCode))
                .ForMember(dest => dest.SubUnit, opt => opt.MapFrom(src => src.FractionName))
                .ForMember(dest => dest.SubUnitValue, opt => opt.MapFrom(src => src.FractionValue))
                .ForMember(dest => dest.ShowDecimalZeros, opt => opt.MapFrom(src => src.ShowTrailingZeros))
                .ForMember(dest => dest.AddSpaceBetweenSymbolAndAmount, opt => opt.MapFrom(src => src.UseSpaceWithSymbol))
                .ForMember(dest => dest.AmountToWordsTemplateAr, opt => opt.MapFrom(src => src.ArWordsTemplate))
                .ForMember(dest => dest.AmountToWordsTemplateEn, opt => opt.MapFrom(src => src.EnWordsTemplate))
                .ForMember(dest => dest.SymbolPosition, opt => opt.MapFrom(src => src.SymbolPosition.ToString()))
                .ForMember(dest => dest.RoundingType, opt => opt.MapFrom(src => src.RoundingType.ToString()))
                .ForMember(dest => dest.ExchangeRates, opt => opt.Ignore()); // يتم تعبئته لاحقاً في معالج الاستعلام

            // تحويل من كيان سعر الصرف إلى DTO سعر الصرف
            CreateMap<CurrencyExchangeRate, CurrencyExchangeRateDto>();
            
            // تحويل من كيان سعر الصرف إلى DTO تاريخ سعر الصرف
            CreateMap<CurrencyExchangeRate, ExchangeRateHistoryDto>()
                .ForMember(dest => dest.RateDate, opt => opt.MapFrom(src => src.EffectiveDate))
                .ForMember(dest => dest.Notes, opt => opt.MapFrom(src => src.Notes))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                .ForMember(dest => dest.CurrencyCode, opt => opt.Ignore()); // يتم تعبئته في معالج الاستعلام
                
            // تحويل من كيان قاعدة التقريب إلى DTO قاعدة التقريب
            CreateMap<CurrencyRoundingRule, CurrencyRoundingRuleDto>()
                .ForMember(dest => dest.RoundingType, opt => opt.MapFrom(src => src.RoundingType.ToString()));
                
            // تحويل من كيان حد المخاطر إلى DTO حد المخاطر
            CreateMap<CurrencyRiskLimit, CurrencyRiskLimitDto>();

            // تحويل من أمر إنشاء عملة إلى كيان العملة
            CreateMap<CreateCurrencyCommand, Currency>()
                .ForMember(dest => dest.IsBase, opt => opt.MapFrom(src => src.IsBaseCurrency))
                .ForMember(dest => dest.IsoCode, opt => opt.MapFrom(src => src.InternationalCode))
                .ForMember(dest => dest.FractionName, opt => opt.MapFrom(src => src.SubUnit))
                .ForMember(dest => dest.FractionValue, opt => opt.MapFrom(src => src.SubUnitValue))
                .ForMember(dest => dest.ShowTrailingZeros, opt => opt.MapFrom(src => src.ShowDecimalZeros))
                .ForMember(dest => dest.UseSpaceWithSymbol, opt => opt.MapFrom(src => src.AddSpaceBetweenSymbolAndAmount));

            // تحويل من أمر تحديث عملة إلى كيان العملة
            CreateMap<UpdateCurrencyCommand, Currency>()
                .ForMember(dest => dest.IsBase, opt => opt.MapFrom(src => src.IsBaseCurrency))
                .ForMember(dest => dest.IsoCode, opt => opt.MapFrom(src => src.InternationalCode))
                .ForMember(dest => dest.FractionName, opt => opt.MapFrom(src => src.SubUnit))
                .ForMember(dest => dest.FractionValue, opt => opt.MapFrom(src => src.SubUnitValue))
                .ForMember(dest => dest.ShowTrailingZeros, opt => opt.MapFrom(src => src.ShowDecimalZeros))
                .ForMember(dest => dest.UseSpaceWithSymbol, opt => opt.MapFrom(src => src.AddSpaceBetweenSymbolAndAmount));
        }
    }
} 