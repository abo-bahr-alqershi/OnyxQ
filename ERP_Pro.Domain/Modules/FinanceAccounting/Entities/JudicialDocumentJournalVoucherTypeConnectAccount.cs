using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل ربط نوع قيد اليومية للمستند القضائي مع الحسابات ويحتوي على جميع خصائص الربط
/// </summary>
public class JudicialDocumentJournalVoucherTypeConnectAccount : Entity<JudicialDocumentJournalVoucherTypeConnectAccountId>
{

    private JudicialDocumentJournalVoucherTypeConnectAccount() { }

    public JudicialDocumentJournalVoucherTypeConnectAccount(JudicialDocumentJournalVoucherTypeConnectAccountId id, decimal? docTyp, decimal? journalVoucherType, decimal? branchNumber)
    {
        Id = id;
        DocTyp = docTyp;
        JournalVoucherType = journalVoucherType;
        BranchNumber = branchNumber;
    }

    /// <summary>
    /// معرف فريد للربط
    /// </summary>
    public JudicialDocumentJournalVoucherTypeConnectAccountId Id { get; private set; }

    /// <summary>
    /// نوع المستند
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// نوع قيد اليومية
    /// </summary>
    public decimal? JournalVoucherType { get; private set; }

    /// <summary>
    /// كود الحساب
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// حالة كود الحساب
    /// </summary>
    public decimal? AccountCodeStatus { get; private set; }

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
