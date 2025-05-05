using System;

namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// أنواع تقريب العملة
    /// </summary>
    public enum CurrencyRoundingTypeEnum
    {
        /// <summary>
        /// تقريب رياضي (لأقرب قيمة)
        /// </summary>
        Mathematical = 1,
        
        /// <summary>
        /// تقريب لأعلى
        /// </summary>
        Up = 2,
        
        /// <summary>
        /// تقريب لأسفل
        /// </summary>
        Down = 3
    }
} 