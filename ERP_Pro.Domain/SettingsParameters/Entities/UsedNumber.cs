using System;
using ERP_Pro.Domain.Common.Entities;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان لتتبع الأرقام المستخدمة في التسلسلات
    /// </summary>
    public class UsedNumber : Entity<Guid>
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
        /// تاريخ استخدام الرقم
        /// </summary>
        public DateTime UsageDate { get; private set; }
        
        /// <summary>
        /// معرف المستخدم الذي استخدم الرقم
        /// </summary>
        public Guid? UserId { get; private set; }
        
        /// <summary>
        /// معرف المستند المرتبط بالرقم
        /// </summary>
        public Guid? DocumentId { get; private set; }
        
        /// <summary>
        /// نوع المستند المرتبط
        /// </summary>
        public string DocumentType { get; private set; }
        
        /// <summary>
        /// معرف الفرع المستخدم للرقم
        /// </summary>
        public Guid? BranchId { get; private set; }
        
        /// <summary>
        /// علاقة الفرع المستخدم للرقم
        /// </summary>
        public virtual Branch Branch { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private UsedNumber() { }

        /// <summary>
        /// إنشاء سجل رقم مستخدم جديد
        /// </summary>
        public UsedNumber(
            Guid id,
            Guid sequenceId,
            string formattedNumber,
            long rawNumber,
            DateTime usageDate,
            Guid? userId = null,
            Guid? documentId = null,
            string documentType = null,
            Guid? branchId = null) : base(id)
        {
            SequenceId = sequenceId;
            FormattedNumber = formattedNumber;
            RawNumber = rawNumber;
            UsageDate = usageDate;
            UserId = userId;
            DocumentId = documentId;
            DocumentType = documentType;
            BranchId = branchId;
        }

        /// <summary>
        /// ربط الرقم بمستند
        /// </summary>
        public void LinkToDocument(Guid documentId, string documentType)
        {
            DocumentId = documentId;
            DocumentType = documentType;
        }

        /// <summary>
        /// ربط الرقم بفرع
        /// </summary>
        public void LinkToBranch(Guid branchId)
        {
            BranchId = branchId;
        }
    }
} 