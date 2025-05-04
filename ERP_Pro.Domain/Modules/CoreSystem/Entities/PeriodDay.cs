using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل يوم الفترة ويحتوي على جميع خصائص اليوم ضمن الفترات المالية.
    public class PeriodDay : Entity<PeriodDayId>
    {

        private PeriodDay() { }

        public PeriodDay(PeriodDayId id, DateTime? periodDate)
        {
            Id = id;
            PeriodDate = periodDate;
        }

        // المعرف الفريد ليوم الفترة (مفتاح رئيسي).
        public PeriodDayId Id { get; private set; }

        // نوع الفترة لليوم.
        public decimal? PeriodTypeShort { get; private set; }

        // تاريخ اليوم ضمن الفترة.
        public DateTime? PeriodDate { get; private set; }

        // رقم السنة المالية.
        public decimal? YearNumber { get; private set; }

        // علم التعطيل البديل لليوم.
        public decimal? InactiveFlagAlt { get; private set; }

        #region Navigation Properties
        // تفاصيل الفترة المرتبطة بهذا اليوم.
        public PeriodDetail PeriodDetail { get; private set; }
        #endregion

        #region Methods
        // Add domain logic methods here
        #endregion
    }
}
