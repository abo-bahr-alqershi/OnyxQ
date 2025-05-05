namespace ERP_Pro.Shared.Enums.Domain
{
    public enum FiscalPeriodStatusEnum
    {
        /// <summary>
        /// مفتوحة - يمكن إدخال قيود في هذه الفترة
        /// </summary>
        Open = 0,
        
        /// <summary>
        /// مقفلة مؤقتاً - مقفلة مع إمكانية إعادة فتحها
        /// </summary>
        TemporarilyLocked = 1,
        
        /// <summary>
        /// مقفلة نهائياً - مقفلة بشكل نهائي
        /// </summary>
        PermanentlyLocked = 2
    }
} 