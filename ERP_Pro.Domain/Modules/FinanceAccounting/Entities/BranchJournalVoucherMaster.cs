using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل مستند قيد اليومية للفرع ويحتوي على جميع خصائص قيود اليومية الخاصة بالفروع
/// </summary>
public class BranchJournalVoucherMaster : Entity<BranchJournalVoucherMasterId>
{

    private BranchJournalVoucherMaster() { }

    public BranchJournalVoucherMaster(BranchJournalVoucherMasterId id, decimal? journalSerial)
    {
        Id = id;
        JournalSerial = journalSerial;
    }

    /// <summary>
    /// معرف فريد لمستند قيد اليومية للفرع
    /// </summary>
    public BranchJournalVoucherMasterId Id { get; private set; }

    /// <summary>
    /// نوع قيد اليومية الكامل
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// رقم مستند اليومية
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// تسلسل اليومية
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// علم ترحيل اليومية
    /// </summary>
    public decimal? JournalPostFlag { get; private set; }

    /// <summary>
    /// تاريخ اليومية
    /// </summary>
    public DateTime? JournalDate { get; private set; }

    /// <summary>
    /// قيمة الدفعة
    /// </summary>
    public decimal? BatchValue { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// قيد عكسي
    /// </summary>
    public decimal? ReverseJournal { get; private set; }

    /// <summary>
    /// قيد دوري
    /// </summary>
    public decimal? PeriodicalJournal { get; private set; }

    /// <summary>
    /// احتياطي نقدي
    /// </summary>
    public decimal? CashReserve { get; private set; }

    /// <summary>
    /// علم الاستعداد
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// علم استخدام الربط
    /// </summary>
    public decimal? LinkUseFlag { get; private set; }

    /// <summary>
    /// رقم المرفق
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// اسم المستفيد
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// اسم المستلم
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// وصف إضافي
    /// </summary>
    public string TDescription { get; private set; }

    /// <summary>
    /// مرجع التدقيق
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// وصف مرجع التدقيق
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// رقم مستخدم مرجع التدقيق
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// تاريخ مرجع التدقيق
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// رصيد حساب الصفر
    /// </summary>
    public decimal? ClassZeroAccountBalance { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// رقم مستخدم الترحيل
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// تاريخ الترحيل
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// رقم مستخدم إلغاء الترحيل
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// تاريخ إلغاء الترحيل
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// حقل إضافي 1
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// حقل إضافي 2
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// حقل إضافي 3
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// حقل إضافي 4
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// حقل إضافي 5
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// حقل إضافي 6
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// حقل إضافي 7
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// حقل إضافي 8
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// حقل إضافي 9
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// حقل إضافي 10
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// رقم الشركة المختصر
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// مستخدم الفرع
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
