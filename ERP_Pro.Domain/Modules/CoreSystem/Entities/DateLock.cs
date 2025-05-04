using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    // كيان يمثل قفل التاريخ ويحتوي على تواريخ القفل المختلفة للعمليات.
    public class DateLock : Entity<DateLockId>
    {
        private DateLock() { }

        public DateLock(DateLockId id)
        {
            Id = id;
        }

        // المعرف الفريد لقفل التاريخ (مفتاح رئيسي).
        public DateLockId Id { get; private set; }

        // تاريخ قفل UfdFlag.
        public DateTime? UfdFlag { get; private set; }

        // تاريخ قفل UtdFlag.
        public DateTime? UtdFlag { get; private set; }

        // تاريخ قفل LfdFlag.
        public DateTime? LfdFlag { get; private set; }

        // تاريخ قفل LtdFlag.
        public DateTime? LtdFlag { get; private set; }

        #region Methods
        // أضف هنا منطق الدومين الخاص بقفل التاريخ
        #endregion
    }
}
