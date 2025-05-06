using System;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.SettingsParameters.ValueObjects
{
    /// <summary>
    /// كائن قيمة لإعدادات التأمين
    /// </summary>
    public class LockSettings : ValueObject
    {
        /// <summary>
        /// تأمين تلقائي للفترات المغلقة
        /// </summary>
        public bool AutoLockClosedPeriods { get; private set; }

        /// <summary>
        /// السماح بإعادة فتح الفترات المغلقة من قبل المستخدمين المصرح لهم
        /// </summary>
        public bool AllowReopenByAuthorizedUsers { get; private set; }

        /// <summary>
        /// تأمين الفترات بعد مرور فترة محددة
        /// </summary>
        public bool LockPeriodsAfterDuration { get; private set; }

        /// <summary>
        /// المدة بالأيام قبل تأمين الفترة تلقائياً
        /// </summary>
        public int DaysBeforeAutoLock { get; private set; }

        /// <summary>
        /// إرسال تنبيهات قبل تأمين الفترات
        /// </summary>
        public bool SendNotificationsBeforeLocking { get; private set; }

        /// <summary>
        /// منع التعديل في الفترات المغلقة حتى للمسؤولين
        /// </summary>
        public bool PreventEditingInClosedPeriods { get; private set; }

        /// <summary>
        /// السماح بالإستثناءات في التأمين
        /// </summary>
        public bool AllowLockExceptions { get; private set; }

        /// <summary>
        /// المنشئ الافتراضي
        /// </summary>
        public LockSettings()
        {
            // القيم الافتراضية
            AutoLockClosedPeriods = true;
            AllowReopenByAuthorizedUsers = true;
            LockPeriodsAfterDuration = false;
            DaysBeforeAutoLock = 30;
            SendNotificationsBeforeLocking = true;
            PreventEditingInClosedPeriods = false;
            AllowLockExceptions = true;
        }

        /// <summary>
        /// المنشئ المخصص
        /// </summary>
        public LockSettings(
            bool autoLockClosedPeriods,
            bool allowReopenByAuthorizedUsers,
            bool lockPeriodsAfterDuration,
            int daysBeforeAutoLock,
            bool sendNotificationsBeforeLocking,
            bool preventEditingInClosedPeriods,
            bool allowLockExceptions)
        {
            AutoLockClosedPeriods = autoLockClosedPeriods;
            AllowReopenByAuthorizedUsers = allowReopenByAuthorizedUsers;
            LockPeriodsAfterDuration = lockPeriodsAfterDuration;
            DaysBeforeAutoLock = daysBeforeAutoLock > 0 ? daysBeforeAutoLock : 30;
            SendNotificationsBeforeLocking = sendNotificationsBeforeLocking;
            PreventEditingInClosedPeriods = preventEditingInClosedPeriods;
            AllowLockExceptions = allowLockExceptions;
        }

        /// <summary>
        /// إنشاء نسخة جديدة من كائن القيمة بالبيانات المحدثة
        /// </summary>
        public LockSettings WithChanges(
            bool? autoLockClosedPeriods = null,
            bool? allowReopenByAuthorizedUsers = null,
            bool? lockPeriodsAfterDuration = null,
            int? daysBeforeAutoLock = null,
            bool? sendNotificationsBeforeLocking = null,
            bool? preventEditingInClosedPeriods = null,
            bool? allowLockExceptions = null)
        {
            return new LockSettings(
                autoLockClosedPeriods ?? AutoLockClosedPeriods,
                allowReopenByAuthorizedUsers ?? AllowReopenByAuthorizedUsers,
                lockPeriodsAfterDuration ?? LockPeriodsAfterDuration,
                daysBeforeAutoLock ?? DaysBeforeAutoLock,
                sendNotificationsBeforeLocking ?? SendNotificationsBeforeLocking,
                preventEditingInClosedPeriods ?? PreventEditingInClosedPeriods,
                allowLockExceptions ?? AllowLockExceptions
            );
        }

        /// <summary>
        /// الحصول على عناصر المقارنة للمساواة
        /// </summary>
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return AutoLockClosedPeriods;
            yield return AllowReopenByAuthorizedUsers;
            yield return LockPeriodsAfterDuration;
            yield return DaysBeforeAutoLock;
            yield return SendNotificationsBeforeLocking;
            yield return PreventEditingInClosedPeriods;
            yield return AllowLockExceptions;
        }
    }
} 