namespace ERP_Pro.Shared.Enums.Domain
{
    public enum AdjustmentTypeEnum
    {
        /// <summary>
        /// تسوية عادية - تسويات محاسبية عامة
        /// </summary>
        Standard = 0,
        
        /// <summary>
        /// تسوية استحقاق - تسويات الاستحقاق المحاسبي
        /// </summary>
        Accrual = 1,
        
        /// <summary>
        /// تسوية مخصصات - تسويات خاصة بالمخصصات
        /// </summary>
        Provision = 2,
        
        /// <summary>
        /// تسوية عملات - تسويات فروق أسعار العملات
        /// </summary>
        CurrencyExchange = 3,
        
        /// <summary>
        /// تسوية نهاية الفترة - التسويات النهائية للفترة
        /// </summary>
        EndOfPeriod = 4,
        
        /// <summary>
        /// تسوية نهاية السنة - التسويات النهائية للسنة المالية
        /// </summary>
        EndOfYear = 5
    }
} 