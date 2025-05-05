namespace ERP_Pro.Shared.Enums.Domain
{
    public enum FiscalPeriodTypeEnum
    {
        /// <summary>
        /// فترة شهرية - تغطي شهر واحد
        /// </summary>
        Monthly = 0,
        
        /// <summary>
        /// فترة ربع سنوية - تغطي ثلاثة أشهر
        /// </summary>
        Quarterly = 1,
        
        /// <summary>
        /// فترة نصف سنوية - تغطي ستة أشهر
        /// </summary>
        SemiAnnually = 2,
        
        /// <summary>
        /// فترة مخصصة - بطول مخصص
        /// </summary>
        Custom = 3,
        
        /// <summary>
        /// فترة سنوية - تغطي سنة كاملة
        /// </summary>
        Annually = 4,
        
        /// <summary>
        /// فترة تسوية - للتسويات النهائية فقط
        /// </summary>
        Adjustment = 5
    }
} 