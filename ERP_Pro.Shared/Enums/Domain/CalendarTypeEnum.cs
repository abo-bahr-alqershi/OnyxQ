namespace ERP_Pro.Shared.Enums.Domain
{
    public enum CalendarTypeEnum
    {
        /// <summary>
        /// تقويم ميلادي - الذي يبدأ في 1 يناير وينتهي في 31 ديسمبر
        /// </summary>
        Gregorian = 0,
        
        /// <summary>
        /// تقويم هجري - الذي يعتمد على التقويم الهجري
        /// </summary>
        Hijri = 1,
        
        /// <summary>
        /// تقويم مالي مخصص - الذي يبدأ وينتهي في تواريخ مخصصة
        /// </summary>
        Custom = 2
    }
} 