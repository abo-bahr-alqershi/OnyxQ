using AutoMapper;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.CreateSequence;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.UpdateSequence;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Models;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Shared.Enums.Domain;
using System;
using System.Linq;

namespace ERP_Pro.Application.Common.Mappings
{
    /// <summary>
    /// نموذج خرائط التحويل لكيانات التسلسلات
    /// </summary>
    public class SequencesMappingProfile : Profile
    {
        /// <summary>
        /// المنشئ
        /// </summary>
        public SequencesMappingProfile()
        {
            CreateMap<SequenceDefinition, SequenceListItemDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.CurrentRange, opt => opt.MapFrom(src => $"{src.StartNumber}-{src.EndNumber}"))
                .ForMember(dest => dest.RangeUtilizationPercentage, opt => opt.MapFrom(src => 
                    CalculateRangeUtilization(src.StartNumber, src.EndNumber, src.CurrentNumber)));
                
            CreateMap<SequenceDefinition, SequenceDetailsDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.NumberConfiguration, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.RangeSettings, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.PermissionSettings, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.UsageStatistics, opt => opt.MapFrom(src => src))
                .ForMember(dest => dest.NumberAllocations, opt => opt.MapFrom(src => src.NumberAllocations));
                
            CreateMap<SequenceDefinition, NumberConfigurationDto>()
                .ForMember(dest => dest.ExampleNumber, opt => opt.MapFrom(src => GenerateExampleNumber(src)));
                
            CreateMap<SequenceDefinition, RangeSettingsDto>();
            
            CreateMap<SequenceDefinition, PermissionSettingsDto>();
            
            CreateMap<SequenceDefinition, UsageStatisticsDto>()
                .ForMember(dest => dest.UsedNumbersCount, opt => opt.MapFrom(src => src.UsedNumbers.Count))
                .ForMember(dest => dest.CanceledNumbersCount, opt => opt.MapFrom(src => src.CanceledNumbers.Count))
                .ForMember(dest => dest.GapsCount, opt => opt.MapFrom(src => src.NumberGaps.Count))
                .ForMember(dest => dest.AllocationsCount, opt => opt.MapFrom(src => src.NumberAllocations.Count))
                .ForMember(dest => dest.LastUsedNumber, opt => opt.MapFrom(src => GetLastUsedNumber(src)))
                .ForMember(dest => dest.LastUsageDate, opt => opt.MapFrom(src => GetLastUsageDate(src)))
                .ForMember(dest => dest.DailyUsageRate, opt => opt.MapFrom(src => CalculateDailyUsageRate(src)));
                
            CreateMap<NumberAllocation, NumberAllocationDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.RangeSize, opt => opt.MapFrom(src => src.EndNumber - src.StartNumber + 1))
                .ForMember(dest => dest.UtilizationPercentage, opt => opt.MapFrom(src => 
                    CalculateRangeUtilization(src.StartNumber, src.EndNumber, src.CurrentNumber)));
                    
            CreateMap<CreateSequenceCommand, SequenceDefinition>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => SequenceStatusEnum.Active))
                .ForMember(dest => dest.NumberAllocations, opt => opt.Ignore())
                .ForMember(dest => dest.UsedNumbers, opt => opt.Ignore())
                .ForMember(dest => dest.CanceledNumbers, opt => opt.Ignore())
                .ForMember(dest => dest.NumberGaps, opt => opt.Ignore())
                .ForMember(dest => dest.SequenceAudits, opt => opt.Ignore());
                
            CreateMap<UpdateSequenceCommand, SequenceDefinition>()
                .ForMember(dest => dest.NumberAllocations, opt => opt.Ignore())
                .ForMember(dest => dest.UsedNumbers, opt => opt.Ignore())
                .ForMember(dest => dest.CanceledNumbers, opt => opt.Ignore())
                .ForMember(dest => dest.NumberGaps, opt => opt.Ignore())
                .ForMember(dest => dest.SequenceAudits, opt => opt.Ignore());
        }
        
        private static double CalculateRangeUtilization(long startNumber, long endNumber, long currentNumber)
        {
            if (endNumber <= startNumber) return 0;
            
            double totalRange = endNumber - startNumber;
            double used = currentNumber - startNumber;
            
            return Math.Round((used / totalRange) * 100, 2);
        }
        
        private static string GenerateExampleNumber(SequenceDefinition sequence)
        {
            // إنشاء مثال للرقم بناءً على إعدادات التسلسل
            string prefix = sequence.Prefix ?? string.Empty;
            string suffix = sequence.Suffix ?? string.Empty;
            string separator = sequence.PrefixSeparator ?? "-";
            string numberPart = sequence.PadWithZeros 
                ? sequence.CurrentNumber.ToString().PadLeft(sequence.NumberLength, '0') 
                : sequence.CurrentNumber.ToString();
                
            string result = string.Empty;
            
            if (!string.IsNullOrEmpty(prefix))
            {
                result += prefix + separator;
            }
            
            if (sequence.IncludeFiscalYearCode)
            {
                result += "YY" + separator;
            }
            
            if (sequence.IncludeBranchCode)
            {
                result += "BR" + separator;
            }
            
            result += numberPart;
            
            if (!string.IsNullOrEmpty(suffix))
            {
                result += separator + suffix;
            }
            
            return result;
        }
        
        private static string GetLastUsedNumber(SequenceDefinition sequence)
        {
            var lastUsed = sequence.UsedNumbers
                .OrderByDescending(n => n.CreatedAt)
                .FirstOrDefault();
                
            return lastUsed?.FormattedNumber ?? "-";
        }
        
        private static DateTime? GetLastUsageDate(SequenceDefinition sequence)
        {
            var lastUsed = sequence.UsedNumbers
                .OrderByDescending(n => n.CreatedAt)
                .FirstOrDefault();
                
            return lastUsed?.CreatedAt;
        }
        
        private static double CalculateDailyUsageRate(SequenceDefinition sequence)
        {
            if (!sequence.UsedNumbers.Any()) return 0;
            
            var usedNumbersList = sequence.UsedNumbers.ToList();
            if (usedNumbersList.Count < 2) return usedNumbersList.Count;
            
            var firstUsage = usedNumbersList.Min(n => n.CreatedAt);
            var lastUsage = usedNumbersList.Max(n => n.CreatedAt);
            
            var totalDays = (lastUsage - firstUsage).TotalDays;
            if (totalDays <= 0) return usedNumbersList.Count;
            
            return Math.Round(usedNumbersList.Count / totalDays, 2);
        }
    }
} 