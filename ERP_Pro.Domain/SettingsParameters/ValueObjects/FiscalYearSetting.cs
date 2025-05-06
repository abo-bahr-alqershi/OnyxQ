using System;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.SettingsParameters.ValueObjects
{
    /// <summary>
    /// كائن قيمة لإعدادات السنة المالية
    /// </summary>
    public class FiscalYearSetting : ValueObject
    {
        /// <summary>
        /// تاريخ بداية السنة المالية
        /// </summary>
        public DateTime StartDate { get; private set; }
        
        /// <summary>
        /// تاريخ نهاية السنة المالية
        /// </summary>
        public DateTime EndDate { get; private set; }
        
        /// <summary>
        /// عدد الفترات في السنة المالية
        /// </summary>
        public int NumberOfPeriods { get; private set; }
        
        /// <summary>
        /// هل الفترات متساوية؟
        /// </summary>
        public bool EqualPeriods { get; private set; }
        
        /// <summary>
        /// المنشئ الخاص للتسلسل
        /// </summary>
        private FiscalYearSetting()
        {
        }
        
        /// <summary>
        /// إنشاء إعدادات السنة المالية
        /// </summary>
        /// <param name="startDate">تاريخ البداية</param>
        /// <param name="endDate">تاريخ النهاية</param>
        /// <param name="numberOfPeriods">عدد الفترات</param>
        /// <param name="equalPeriods">هل الفترات متساوية؟</param>
        /// <returns>كائن إعدادات السنة المالية</returns>
        public static FiscalYearSetting Create(DateTime startDate, DateTime endDate, int numberOfPeriods, bool equalPeriods)
        {
            if (startDate >= endDate)
            {
                throw new ArgumentException("تاريخ البداية يجب أن يكون قبل تاريخ النهاية");
            }
            
            if (numberOfPeriods <= 0)
            {
                throw new ArgumentException("عدد الفترات يجب أن يكون أكبر من صفر");
            }
            
            return new FiscalYearSetting
            {
                StartDate = startDate,
                EndDate = endDate,
                NumberOfPeriods = numberOfPeriods,
                EqualPeriods = equalPeriods
            };
        }
        
        /// <summary>
        /// حساب طول الفترة بالأيام (إذا كانت الفترات متساوية)
        /// </summary>
        /// <returns>عدد الأيام في الفترة</returns>
        public int CalculatePeriodLengthInDays()
        {
            if (!EqualPeriods)
            {
                throw new InvalidOperationException("لا يمكن حساب طول الفترة للفترات غير المتساوية");
            }
            
            var totalDays = (EndDate - StartDate).TotalDays;
            return (int)Math.Ceiling(totalDays / NumberOfPeriods);
        }
        
        /// <summary>
        /// الحصول على مكونات المساواة
        /// </summary>
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return StartDate;
            yield return EndDate;
            yield return NumberOfPeriods;
            yield return EqualPeriods;
        }
    }
} 