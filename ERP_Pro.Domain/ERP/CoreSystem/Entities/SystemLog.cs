using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
    /// <summary>
    /// يمثل هذا الكيان سجلات النظام
    /// This entity represents system logs
    /// اسم الجدول: S_LOGS
    /// Table name: S_LOGS
    /// </summary>
    public class SystemLog : BaseEntity
    {
        /// <summary>
        /// رقم المستخدم المضيف
        /// Adding User ID
        /// </summary>
        public int AddedUserId { get; private set; }

        /// <summary>
        /// تاريخ الإضافة
        /// Adding Date
        /// </summary>
        public DateTime AddedDate { get; private set; }

        /// <summary>
        /// اسم المحطة المضيفة
        /// Adding Terminal Name
        /// </summary>
        public string AddedTerminalName { get; private set; }

        /// <summary>
        /// رقم النموذج
        /// Form Number
        /// </summary>
        public int FormNo { get; private set; }

        /// <summary>
        /// العلاقة مع المستخدم
        /// User Navigation Property
        /// </summary>
        public User User { get; private set; }

        private SystemLog() { }

        public static SystemLog Create(
            int addedUserId,
            DateTime addedDate,
            string addedTerminalName,
            int formNo)
        {
            var log = new SystemLog
            {
                AddedUserId = addedUserId,
                AddedDate = addedDate,
                AddedTerminalName = addedTerminalName,
                FormNo = formNo
            };

            log.AddDomainEvent(new SystemLogCreatedEvent(log));
            return log;
        }
    }
} 