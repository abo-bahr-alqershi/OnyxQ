namespace ERP_Pro.Shared.Enums.Domain
{
    public enum ClosingTypeEnum
    {
        /// <summary>
        /// إغلاق مؤقت - يمكن إعادة فتحه لاحقاً
        /// </summary>
        Temporary = 0,
        
        /// <summary>
        /// إغلاق نهائي - لا يمكن إعادة فتحه
        /// </summary>
        Permanent = 1,
        
        /// <summary>
        /// إغلاق وترحيل أرصدة - إغلاق نهائي مع ترحيل الأرصدة للسنة التالية
        /// </summary>
        PermanentWithCarryOver = 2
    }
} 