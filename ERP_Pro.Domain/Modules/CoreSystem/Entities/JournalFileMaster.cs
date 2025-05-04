using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل ملف اليومية الرئيسي ويحتوي على جميع خصائص وتفاصيل القيد الرئيسي.
public class JournalFileMaster : Entity<JournalFileMasterId>
{
    // المعرف الفريد لملف اليومية الرئيسي (مفتاح رئيسي).
    public JournalFileMasterId Id { get; private set; }
    // نوع الملف.
    public decimal? FileType { get; private set; }
    // نوع المستند.
    public decimal? DocType { get; private set; }
    // نوع قيد اليومية الكامل.
    public decimal? JournalVoucherTypeFull { get; private set; }
    // رقم مستند اليومية.
    public decimal? JournalDocumentNumber { get; private set; }
    // تسلسل اليومية.
    public decimal? JournalSerial { get; private set; }
    // تاريخ اليومية.
    public DateTime? JournalDate { get; private set; }
    // قيمة الدفعة.
    public decimal? BatchValue { get; private set; }
    // رقم المرجع.
    public string ReferenceNumber { get; private set; }
    // رقم المرفق.
    public decimal? AttachmentNumber { get; private set; }
    // وصف إضافي.
    public string TDescription { get; private set; }
    // علم الاستعداد.
    public decimal? StandByFlag { get; private set; }
    // رصيد حساب الصفر.
    public decimal? ClassZeroAccountBalance { get; private set; }
    // مرجع التدقيق.
    public decimal? AuditReference { get; private set; }
    // وصف مرجع التدقيق.
    public string AuditReferenceDescription { get; private set; }
    // معرف مستخدم مرجع التدقيق.
    public decimal? AuditReferenceUserId { get; private set; }
    // تاريخ مرجع التدقيق.
    public DateTime? AuditReferenceDate { get; private set; }
    // علم ترحيل اليومية.
    public decimal? JournalPostFlag { get; private set; }
    // معرف المستخدم المرحل.
    public decimal? PostUserId { get; private set; }
    // تاريخ الترحيل.
    public DateTime? PostDate { get; private set; }
    // معرف المستخدم الذي ألغى الترحيل.
    public decimal? UnpostUserId { get; private set; }
    // تاريخ إلغاء الترحيل.
    public DateTime? UnpostDate { get; private set; }
    // علم المعالجة البديل.
    public decimal? ProcessedFlagAlt { get; private set; }
    // علم الموافقة.
    public decimal? ApprovedFlag { get; private set; }
    // معرف المستخدم الموافق.
    public decimal? ApprovalUserId { get; private set; }
    // تاريخ الموافقة.
    public DateTime? ApprovalDate { get; private set; }
    // وصف الموافقة.
    public string ApprovalDescription { get; private set; }
    // علم التعطيل.
    public decimal? InactiveFlag { get; private set; }
    // سبب التعطيل.
    public string InactiveReason { get; private set; }
    // معرف المستخدم الذي قام بالتعطيل.
    public decimal? InactivatedByUserId { get; private set; }
    // تاريخ التعطيل.
    public DateTime? InactiveDate { get; private set; }
    // رقم الشركة المختصر.
    public decimal? CompanyNumberShort { get; private set; }
    // رقم الفرع.
    public decimal? BranchNumber { get; private set; }
    // سنة الفرع.
    public decimal? BranchYear { get; private set; }
    // المستخدم المسؤول عن الفرع.
    public decimal? BranchUser { get; private set; }
    // نوع المستند المرجعي.
    public decimal? DocTypRef { get; private set; }
    // رقم المستند المرجعي.
    public decimal? DocNoRef { get; private set; }
    // تسلسل المستند المرجعي.
    public decimal? DocSrlRef { get; private set; }
    // حقل إضافي 1.
    public string Field1 { get; private set; }
    // حقل إضافي 2.
    public string Field2 { get; private set; }
    // حقل إضافي 3.
    public string Field3 { get; private set; }
    // حقل إضافي 4.
    public string Field4 { get; private set; }
    // حقل إضافي 5.
    public string Field5 { get; private set; }
    // حقل إضافي 6.
    public string Field6 { get; private set; }
    // حقل إضافي 7.
    public string Field7 { get; private set; }
    // حقل إضافي 8.
    public string Field8 { get; private set; }
    // حقل إضافي 9.
    public string Field9 { get; private set; }
    // حقل إضافي 10.
    public string Field10 { get; private set; }
    #region Methods
    // أضف هنا منطق الدومين الخاص بملف اليومية الرئيسي
    #endregion
}
}
