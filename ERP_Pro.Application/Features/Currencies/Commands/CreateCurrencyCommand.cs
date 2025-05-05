using System;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر إنشاء عملة جديدة
    /// </summary>
    public class CreateCurrencyCommand : IRequest<CurrencyDto>
    {
        /// <summary>
        /// رمز العملة
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// الرمز الدولي
        /// </summary>
        public string IsoCode { get; set; }

        /// <summary>
        /// الاسم بالعربية
        /// </summary>
        public string NameAr { get; set; }

        /// <summary>
        /// الاسم بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// الرمز المختصر
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// الدولة
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// هل هي العملة الأساسية
        /// </summary>
        public bool IsBaseCurrency { get; set; }

        /// <summary>
        /// عدد الخانات العشرية
        /// </summary>
        public int DecimalPlaces { get; set; } = 2;

        /// <summary>
        /// فاصل الآلاف
        /// </summary>
        public string ThousandsSeparator { get; set; } = ",";

        /// <summary>
        /// فاصل الكسور العشرية
        /// </summary>
        public string DecimalSeparator { get; set; } = ".";

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 