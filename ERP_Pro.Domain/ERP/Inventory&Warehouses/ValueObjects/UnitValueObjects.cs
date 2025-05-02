using System;
using ERP_Pro.Domain.Common;

namespace ERP_Pro.Domain.ERP.Inventory_Warehouses.ValueObjects
{
    public record UnitInfo
    {
        public string? MeasureCode { get; }
        public string? MeasureArabicName { get; }
        public string? MeasureEnglishName { get; }
        public int? MeasureNo { get; }
        public string? MeasureImage { get; }
        public string? MeasureDescription { get; }

        private UnitInfo(string? measureCode, string? measureArabicName, string? measureEnglishName, 
            int? measureNo, string? measureImage, string? measureDescription)
        {
            MeasureCode = measureCode;
            MeasureArabicName = measureArabicName;
            MeasureEnglishName = measureEnglishName;
            MeasureNo = measureNo;
            MeasureImage = measureImage;
            MeasureDescription = measureDescription;
        }

        public static UnitInfo Create(string? measureCode, string? measureArabicName, string? measureEnglishName, 
            int? measureNo, string? measureImage, string? measureDescription)
        {
            return new UnitInfo(measureCode, measureArabicName, measureEnglishName, measureNo, measureImage, measureDescription);
        }
    }

    public record UnitConversionInfo
    {
        public string? FromMeasureCode { get; }
        public string? ToMeasureCode { get; }
        public int? ConversionFactor { get; }
        public int? ArgumentNo { get; }

        private UnitConversionInfo(string? fromMeasureCode, string? toMeasureCode, int? conversionFactor, int? argumentNo)
        {
            FromMeasureCode = fromMeasureCode;
            ToMeasureCode = toMeasureCode;
            ConversionFactor = conversionFactor;
            ArgumentNo = argumentNo;
        }

        public static UnitConversionInfo Create(string? fromMeasureCode, string? toMeasureCode, int? conversionFactor, int? argumentNo)
        {
            return new UnitConversionInfo(fromMeasureCode, toMeasureCode, conversionFactor, argumentNo);
        }
    }
} 