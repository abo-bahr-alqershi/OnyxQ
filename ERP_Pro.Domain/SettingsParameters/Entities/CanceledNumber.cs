using System;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان لتتبع الأرقام الملغاة في التسلسلات
    /// </summary>
    public class CanceledNumber : Entity<Guid>
    {
        /// <summary>
        /// معرف التسلسل المرتبط
        /// </summary>
        public Guid SequenceId { get; private set; }
        
        /// <summary>
        /// الرقم المنسق (الرقم كاملاً بما في ذلك البادئة واللاحقة)
        /// </summary>
        public string FormattedNumber { get; private set; }
        
        /// <summary>
        /// الرقم الخام (الرقم المجرد بدون بادئة أو لاحقة)
        /// </summary>
        public long RawNumber { get; private set; }
        
        /// <summary>
        /// سبب إلغاء الرقم
        /// </summary>
        public string CancellationReason { get; private set; }
        
        /// <summary>
        /// معرف المستخدم الذي قام بالإلغاء
        /// </summary>
        public Guid CanceledByUserId { get; private set; }
        
        /// <summary>
        /// تاريخ إلغاء الرقم
        /// </summary>
        public DateTime CancellationDate { get; private set; }
        
        /// <summary>
        /// تاريخ إمكانية إعادة استخدام الرقم
        /// </summary>
        public DateTime? ReuseDate { get; private set; }
        
        /// <summary>
        /// حالة الرقم الملغى
        /// </summary>
        public ERP_Pro.Shared.Enums.Domain.CanceledNumberStatusEnum Status { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private CanceledNumber() { }

        /// <summary>
        /// إنشاء سجل رقم ملغى جديد
        /// </summary>
        public CanceledNumber(
            Guid id,
            Guid sequenceId,
            string formattedNumber,
            long rawNumber,
            string cancellationReason,
            Guid canceledByUserId,
            DateTime cancellationDate) : base(id)
        {
            SequenceId = sequenceId;
            FormattedNumber = formattedNumber;
            RawNumber = rawNumber;
            CancellationReason = cancellationReason;
            CanceledByUserId = canceledByUserId;
            CancellationDate = cancellationDate;
            Status = ERP_Pro.Shared.Enums.Domain.CanceledNumberStatusEnum.Canceled;
        }

        /// <summary>
        /// تعيين تاريخ إعادة استخدام الرقم
        /// </summary>
        public void SetReuseDate(DateTime reuseDate)
        {
            ReuseDate = reuseDate;
        }

        /// <summary>
        /// تحديث حالة الرقم الملغى
        /// </summary>
        public void UpdateStatus(ERP_Pro.Shared.Enums.Domain.CanceledNumberStatusEnum newStatus)
        {
            Status = newStatus;
        }

        /// <summary>
        /// تحديث سبب الإلغاء
        /// </summary>
        public void UpdateCancellationReason(string reason)
        {
            CancellationReason = reason;
        }
    }
} 