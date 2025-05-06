namespace ERP_Pro.Shared.Enums.Domain
{
    /// <summary>
    /// حالة التسلسل
    /// </summary>
    public enum SequenceStatusEnum
    {
        /// <summary>
        /// نشط - يمكن استخدام التسلسل لإنشاء أرقام جديدة
        /// </summary>
        Active = 1,
        
        /// <summary>
        /// غير نشط - لا يمكن استخدام التسلسل لإنشاء أرقام جديدة
        /// </summary>
        Inactive = 2,
        
        /// <summary>
        /// متوقف مؤقتاً - تم تعليق استخدام التسلسل مؤقتاً
        /// </summary>
        Suspended = 3,
        
        /// <summary>
        /// أرشيف - تم نقل التسلسل إلى الأرشيف
        /// </summary>
        Archived = 4
    }

    /// <summary>
    /// حالة تخصيص النطاق
    /// </summary>
    public enum NumberAllocationStatusEnum
    {
        /// <summary>
        /// نشط - النطاق قيد الاستخدام
        /// </summary>
        Active = 1,
        
        /// <summary>
        /// معلق - تم تعليق استخدام النطاق مؤقتاً
        /// </summary>
        Suspended = 2,
        
        /// <summary>
        /// منتهي - انتهت صلاحية النطاق
        /// </summary>
        Expired = 3,
        
        /// <summary>
        /// مستنفد - تم استخدام جميع الأرقام في النطاق
        /// </summary>
        Exhausted = 4,
        
        /// <summary>
        /// منتهي - تم إنهاء استخدام النطاق
        /// </summary>
        Terminated = 5
    }

    /// <summary>
    /// حالة الرقم الملغى
    /// </summary>
    public enum CanceledNumberStatusEnum
    {
        /// <summary>
        /// ملغى - تم إلغاء الرقم
        /// </summary>
        Canceled = 1,
        
        /// <summary>
        /// متاح لإعادة الاستخدام - يمكن إعادة استخدام الرقم
        /// </summary>
        AvailableForReuse = 2,
        
        /// <summary>
        /// معاد استخدامه - تم إعادة استخدام الرقم
        /// </summary>
        Reused = 3
    }

    /// <summary>
    /// حالة معالجة الفجوة
    /// </summary>
    public enum NumberGapResolutionStatusEnum
    {
        /// <summary>
        /// مكتشفة - تم اكتشاف الفجوة
        /// </summary>
        Detected = 1,
        
        /// <summary>
        /// قيد المعالجة - جاري معالجة الفجوة
        /// </summary>
        InProgress = 2,
        
        /// <summary>
        /// تم حلها - تم معالجة الفجوة
        /// </summary>
        Resolved = 3,
        
        /// <summary>
        /// متجاهلة - تم تجاهل الفجوة
        /// </summary>
        Ignored = 4
    }

    /// <summary>
    /// نوع حدث تدقيق التسلسل
    /// </summary>
    public enum SequenceAuditTypeEnum
    {
        /// <summary>
        /// إنشاء تسلسل
        /// </summary>
        SequenceCreated = 1,
        
        /// <summary>
        /// تحديث تسلسل
        /// </summary>
        SequenceUpdated = 2,
        
        /// <summary>
        /// حذف تسلسل
        /// </summary>
        SequenceDeleted = 3,
        
        /// <summary>
        /// تغيير حالة التسلسل
        /// </summary>
        StatusChanged = 4,
        
        /// <summary>
        /// إنشاء رقم
        /// </summary>
        NumberGenerated = 5,
        
        /// <summary>
        /// إلغاء رقم
        /// </summary>
        NumberCanceled = 6,
        
        /// <summary>
        /// حجز نطاق
        /// </summary>
        RangeReserved = 7,
        
        /// <summary>
        /// إعادة تعيين العداد
        /// </summary>
        CounterReset = 8,
        
        /// <summary>
        /// تكوين قالب الترقيم
        /// </summary>
        PatternConfigured = 9,
        
        /// <summary>
        /// ضبط سياسة إعادة الاستخدام
        /// </summary>
        ReusePolicyChanged = 10
    }
} 