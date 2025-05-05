using System;
using MediatR;

namespace ERP_Pro.Application.Features.Currencies.Commands
{
    /// <summary>
    /// أمر تحديث عملة
    /// </summary>
    public class UpdateCurrencyCommand : IRequest<bool>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid Id { get; set; }

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
        /// عدد الخانات العشرية
        /// </summary>
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 