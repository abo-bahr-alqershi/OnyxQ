namespace ERP_Pro.Shared.Enums.Domain
{
    public enum FiscalYearStatusEnum
    {
        /// <summary>
        /// قيد الإعداد - الإعداد الأولي للسنة المالية
        /// </summary>
        InPreparation = 0,
        
        /// <summary>
        /// مفتوحة - السنة المالية نشطة ويمكن إدخال قيود عليها
        /// </summary>
        Open = 1,
        
        /// <summary>
        /// مغلقة مؤقتاً - تم إقفال السنة المالية مع إمكانية إعادة فتحها
        /// </summary>
        TemporarilyClosed = 2,
        
        /// <summary>
        /// مغلقة نهائياً - تم إقفال السنة المالية بشكل نهائي
        /// </summary>
        PermanentlyClosed = 3
    }
} 