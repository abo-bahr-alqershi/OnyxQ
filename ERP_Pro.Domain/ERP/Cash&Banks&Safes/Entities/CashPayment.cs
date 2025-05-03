using System;

namespace ERP_Pro.Domain.ERP.Cash_Banks_Safes.Entities
{
    /// <summary>
    /// كلاس سندات الصرف الذي يمثل جدول CASH_PAYMENT في قاعدة البيانات
    /// </summary>
    public class CashPayment
    {
        #region Basic Info
        /// <summary> رقم السند </summary>
        public long PaymentNumber { get; private set; }
        /// <summary> رقم تسلسلي </summary>
        public long? PaymentSerial { get; private set; }
        /// <summary> تاريخ السند </summary>
        public DateTime PaymentDate { get; private set; }
        /// <summary> وصف السند </summary>
        public string? PaymentDescription { get; private set; }
        /// <summary> رقم مرجعي </summary>
        public string? ReferenceNumber { get; private set; }
        /// <summary> المبلغ </summary>
        public decimal Amount { get; private set; }
        /// <summary> المبلغ بالعملة الأجنبية </summary>
        public decimal? ForeignAmount { get; private set; }
        /// <summary> سعر الصرف </summary>
        public decimal? ExchangeRate { get; private set; }
        #endregion

        #region References
        /// <summary> كود المورد </summary>
        public string? VendorCode { get; private set; }
        /// <summary> كود النشاط </summary>
        public string? ActivityCode { get; private set; }
        #endregion

        #region Status
        /// <summary> تم الترحيل </summary>
        public bool? Posted { get; private set; }
        /// <summary> عمليات معلقة </summary>
        public bool? Suspended { get; private set; }
        #endregion

        #region Company Info
        /// <summary> رقم الشركة </summary>
        public short CompanyNumber { get; private set; }
        /// <summary> رقم الفرع </summary>
        public int BranchNumber { get; private set; }
        /// <summary> السنة المالية للفرع </summary>
        public short? BranchYear { get; private set; }
        /// <summary> مستخدم الفرع </summary>
        public short? BranchUser { get; private set; }
        #endregion

        #region Audit Info
        /// <summary> المستخدم الذي أضاف السطر </summary>
        public int? AddedUserId { get; private set; }
        /// <summary> تاريخ الإضافة </summary>
        public DateTime? AddedDate { get; private set; }
        /// <summary> المستخدم الذي عدل السطر </summary>
        public int? UpdatedUserId { get; private set; }
        /// <summary> تاريخ آخر تعديل </summary>
        public DateTime? UpdatedDate { get; private set; }
        /// <summary> عدد مرات التحديث </summary>
        public long? UpdateCount { get; private set; }
        /// <summary> أولوية التقرير </summary>
        public long? ReportPriority { get; private set; }
        /// <summary> اسم الجهاز عند الإضافة </summary>
        public string? AddedTerminal { get; private set; }
        /// <summary> اسم الجهاز عند التعديل </summary>
        public string? UpdatedTerminal { get; private set; }
        #endregion

        #region Navigation Properties
        /// <summary> علاقة مع المورد </summary>
        public virtual Vendor Vendor { get; private set; }
        /// <summary> علاقة مع النشاط </summary>
        public virtual IasActvty Activity { get; private set; }
        #endregion

        private CashPayment() { } // للاستخدام من قبل EF Core

        // يمكن إضافة باقي الأساليب والمنطق هنا
    }
} 