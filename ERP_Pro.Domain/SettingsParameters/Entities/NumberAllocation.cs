using System;
using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.SettingsParameters.Entities
{
    /// <summary>
    /// كيان لتخصيص نطاق من الأرقام في التسلسل
    /// </summary>
    public class NumberAllocation : Entity<Guid>
    {
        /// <summary>
        /// معرف التسلسل المرتبط
        /// </summary>
        public Guid SequenceId { get; private set; }
        
        /// <summary>
        /// بداية النطاق المخصص
        /// </summary>
        public long RangeStart { get; private set; }
        
        /// <summary>
        /// نهاية النطاق المخصص
        /// </summary>
        public long RangeEnd { get; private set; }
        
        /// <summary>
        /// سبب تخصيص النطاق
        /// </summary>
        public string Reason { get; private set; }
        
        /// <summary>
        /// معرف المستخدم الذي قام بالتخصيص
        /// </summary>
        public Guid AllocatedByUserId { get; private set; }
        
        /// <summary>
        /// معرف الفرع المرتبط بالتخصيص (إن وجد)
        /// </summary>
        public Guid? BranchId { get; private set; }
        
        /// <summary>
        /// اسم الفرع المرتبط بالتخصيص
        /// </summary>
        public string BranchName { get; private set; }
        
        /// <summary>
        /// علاقة الفرع المرتبط بالتخصيص
        /// </summary>
        public virtual Branch Branch { get; private set; }
        
        /// <summary>
        /// تاريخ التخصيص
        /// </summary>
        public DateTime AllocationDate { get; private set; }
        
        /// <summary>
        /// تاريخ انتهاء صلاحية التخصيص (إن وجد)
        /// </summary>
        public DateTime? ExpiryDate { get; private set; }
        
        /// <summary>
        /// حالة التخصيص
        /// </summary>
        public ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum Status { get; private set; }
        
        /// <summary>
        /// الرقم الحالي ضمن النطاق المخصص
        /// </summary>
        public long CurrentNumber { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private NumberAllocation() { }

        /// <summary>
        /// إنشاء تخصيص جديد لنطاق من الأرقام
        /// </summary>
        public NumberAllocation(
            Guid id,
            Guid sequenceId,
            long rangeStart,
            long rangeEnd,
            string reason,
            Guid allocatedByUserId,
            Guid? branchId,
            string branchName,
            DateTime allocationDate,
            DateTime? expiryDate) : base(id)
        {
            SequenceId = sequenceId;
            RangeStart = rangeStart;
            RangeEnd = rangeEnd;
            Reason = reason;
            AllocatedByUserId = allocatedByUserId;
            BranchId = branchId;
            BranchName = branchName;
            AllocationDate = allocationDate;
            ExpiryDate = expiryDate;
            Status = ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum.Active;
            CurrentNumber = rangeStart;
        }

        /// <summary>
        /// الحصول على الرقم التالي من النطاق المخصص
        /// </summary>
        public long GetNextNumber()
        {
            if (Status != ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum.Active)
                throw new InvalidOperationException("لا يمكن الحصول على رقم من نطاق غير نشط");

            if (CurrentNumber > RangeEnd)
                throw new InvalidOperationException("تم استنفاد جميع الأرقام في النطاق المخصص");

            long number = CurrentNumber;
            CurrentNumber++;
            return number;
        }

        /// <summary>
        /// تمديد فترة صلاحية التخصيص
        /// </summary>
        public void ExtendExpiry(DateTime newExpiryDate)
        {
            if (newExpiryDate <= DateTime.UtcNow)
                throw new ArgumentException("تاريخ انتهاء الصلاحية الجديد يجب أن يكون في المستقبل", nameof(newExpiryDate));

            ExpiryDate = newExpiryDate;
        }

        /// <summary>
        /// تعليق النطاق المخصص
        /// </summary>
        public void Suspend()
        {
            if (Status == ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum.Active)
                Status = ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum.Suspended;
        }

        /// <summary>
        /// إعادة تنشيط النطاق المخصص
        /// </summary>
        public void Resume()
        {
            if (Status == ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum.Suspended)
                Status = ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum.Active;
        }

        /// <summary>
        /// إنهاء تخصيص النطاق
        /// </summary>
        public void Terminate()
        {
            Status = ERP_Pro.Shared.Enums.Domain.NumberAllocationStatusEnum.Terminated;
        }

        /// <summary>
        /// التحقق مما إذا كان الرقم ضمن النطاق المخصص
        /// </summary>
        public bool IsInRange(long number)
        {
            return number >= RangeStart && number <= RangeEnd;
        }
        
        /// <summary>
        /// ضبط معلومات الفرع
        /// </summary>
        public void SetBranchInfo(Guid? branchId, string branchName)
        {
            BranchId = branchId;
            BranchName = branchName;
        }
    }
} 