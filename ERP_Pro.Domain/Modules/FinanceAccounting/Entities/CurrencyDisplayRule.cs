using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// قاعدة عرض العملة
    /// </summary>
    public class CurrencyDisplayRule : Entity<CurrencyDisplayRuleId>
    {
        // Private constructor for EF Core
        private CurrencyDisplayRule() { }

        /// <summary>
        /// إنشاء قاعدة عرض جديدة
        /// </summary>
        public CurrencyDisplayRule(
            CurrencyDisplayRuleId id,
            CurrencyId currencyId,
            CurrencySymbolPositionEnum symbolPosition,
            bool useSpace,
            bool showTrailingZeros,
            string negativeFormat,
            string language)
        {
            Id = id;
            CurrencyId = currencyId;
            SymbolPosition = symbolPosition;
            UseSpace = useSpace;
            ShowTrailingZeros = showTrailingZeros;
            NegativeFormat = negativeFormat;
            Language = language;
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public CurrencyId CurrencyId { get; private set; }

        /// <summary>
        /// موقع رمز العملة
        /// </summary>
        public CurrencySymbolPositionEnum SymbolPosition { get; private set; }

        /// <summary>
        /// استخدام فراغ بين الرمز والقيمة
        /// </summary>
        public bool UseSpace { get; private set; }

        /// <summary>
        /// إظهار الأصفار العشرية
        /// </summary>
        public bool ShowTrailingZeros { get; private set; }

        /// <summary>
        /// تنسيق القيم السالبة
        /// </summary>
        public string NegativeFormat { get; private set; }

        /// <summary>
        /// اللغة المستخدمة
        /// </summary>
        public string Language { get; private set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ القاعدة
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime LastModifiedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل
        /// </summary>
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// تحديث القاعدة
        /// </summary>
        public void Update(
            CurrencySymbolPositionEnum symbolPosition,
            bool useSpace,
            bool showTrailingZeros,
            string negativeFormat)
        {
            SymbolPosition = symbolPosition;
            UseSpace = useSpace;
            ShowTrailingZeros = showTrailingZeros;
            NegativeFormat = negativeFormat;
            LastModifiedOn = DateTime.UtcNow;
        }
    }
} 