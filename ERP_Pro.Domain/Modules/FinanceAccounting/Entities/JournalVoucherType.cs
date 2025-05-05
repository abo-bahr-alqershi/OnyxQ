using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل نوع قيد اليومية ويحتوي على جميع خصائص أنواع قيود اليومية
/// </summary>
public class JournalVoucherType : Entity<JournalVoucherTypeId>
{

    private JournalVoucherType() { }

    public JournalVoucherType(JournalVoucherTypeId id, decimal? journalVoucherTypeFull)
    {
        Id = id;
        JournalVoucherTypeFull = journalVoucherTypeFull;
    }

    /// <summary>
    /// معرف فريد لنوع قيد اليومية
    /// </summary>
    public JournalVoucherTypeId Id { get; private set; }

    /// <summary>
    /// نوع قيد اليومية الكامل
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// اسم قيد اليومية
    /// </summary>
    public string JournalVoucherName { get; private set; }

    /// <summary>
    /// اسم قيد اليومية بالإنجليزية
    /// </summary>
    public string JournalVoucherNameEnglish { get; private set; }

    /// <summary>
    /// علم التسلسل
    /// </summary>
    public decimal? SequencedFlag { get; private set; }

    /// <summary>
    /// إيصال الدفع
    /// </summary>
    public decimal? PaymentReceipt { get; private set; }

    /// <summary>
    /// نوع المجموعة الكامل
    /// </summary>
    public decimal? GroupTypeFull { get; private set; }

    /// <summary>
    /// نموذج التقرير
    /// </summary>
    public decimal? RepSample { get; private set; }

    /// <summary>
    /// طلب ربط قيد اليومية
    /// </summary>
    public decimal? ConnectionJournalVoucherRequest { get; private set; }

    /// <summary>
    /// نوع Kimb
    /// </summary>
    public decimal? KimbType { get; private set; }

    /// <summary>
    /// تصحيح ضريبة القيمة المضافة
    /// </summary>
    public decimal? VatCorrection { get; private set; }

    /// <summary>
    /// مزود ضريبة القيمة المضافة المؤجلة
    /// </summary>
    public decimal? VatDeferredProvider { get; private set; }

    /// <summary>
    /// عكس مزود ضريبة القيمة المضافة
    /// </summary>
    public decimal? VatProviderReverse { get; private set; }

    /// <summary>
    /// علم ضريبة المصروفات
    /// </summary>
    public decimal? ExpenseTaxFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

