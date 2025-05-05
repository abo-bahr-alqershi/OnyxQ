using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// نوع تقريب العملة
    /// </summary>
    public enum CurrencyRoundingTypeEnum
    {
        /// <summary>
        /// تقريب رياضي (لأقرب)
        /// </summary>
        Mathematical = 0,

        /// <summary>
        /// تقريب للأعلى
        /// </summary>
        Up = 1,

        /// <summary>
        /// تقريب للأسفل
        /// </summary>
        Down = 2
    }
} 