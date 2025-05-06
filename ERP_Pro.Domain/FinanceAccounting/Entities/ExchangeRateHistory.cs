using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان تاريخ سعر الصرف - يسجل قيم أسعار صرف العملات عبر الزمن
    /// </summary>
    public class ExchangeRateHistory : Entity
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; private set; }

        /// <summary>
        /// تاريخ سعر الصرف
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// نوع سعر الصرف (أساسي، بيع، شراء)
        /// </summary>
        public ExchangeRateTypeEnum RateType { get; private set; }

        /// <summary>
        /// قيمة سعر الصرف
        /// </summary>
        public decimal Rate { get; private set; }

        /// <summary>
        /// العملة المقابلة (إذا كان سعر الصرف ليس مقابل العملة الأساسية)
        /// </summary>
        public string ToCurrencyCode { get; private set; }

        /// <summary>
        /// مصدر سعر الصرف (يدوي، API، بنك مركزي)
        /// </summary>
        public string Source { get; private set; }

        /// <summary>
        /// معدل التقلب
        /// </summary>
        public decimal? VolatilityRate { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// العملة (علاقة)
        /// </summary>
        public Currency Currency { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private ExchangeRateHistory() { }

        /// <summary>
        /// إنشاء كيان تاريخ سعر صرف جديد
        /// </summary>
        public static ExchangeRateHistory Create(
            Guid currencyId,
            DateTime date,
            ExchangeRateTypeEnum rateType,
            decimal rate,
            string toCurrencyCode = null,
            string source = "Manual",
            decimal? volatilityRate = null,
            string notes = null)
        {
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));

            if (rate <= 0)
                throw new ArgumentException("قيمة سعر الصرف يجب أن تكون موجبة", nameof(rate));

            return new ExchangeRateHistory
            {
                Id = Guid.NewGuid(),
                CurrencyId = currencyId,
                Date = date,
                RateType = rateType,
                Rate = rate,
                ToCurrencyCode = toCurrencyCode,
                Source = source,
                VolatilityRate = volatilityRate,
                Notes = notes
            };
        }

        /// <summary>
        /// تحديث قيمة سعر الصرف
        /// </summary>
        public void UpdateRate(decimal rate, string source = null, string notes = null)
        {
            if (rate <= 0)
                throw new ArgumentException("قيمة سعر الصرف يجب أن تكون موجبة", nameof(rate));

            Rate = rate;
            
            if (source != null)
                Source = source;
                
            if (notes != null)
                Notes = notes;
        }

        /// <summary>
        /// تحديث معدل التقلب
        /// </summary>
        public void UpdateVolatilityRate(decimal volatilityRate)
        {
            VolatilityRate = volatilityRate;
        }

        /// <summary>
        /// تحديث الملاحظات
        /// </summary>
        public void UpdateNotes(string notes)
        {
            Notes = notes;
        }
    }
} 