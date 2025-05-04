using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل تسوية البنك ويحتوي على جميع خصائص تفاصيل تسويات البنوك
/// </summary>
public class BankAdjustmentDetail : Entity<BankAdjustmentDetailId>
{

    private BankAdjustmentDetail() { }

    public BankAdjustmentDetail(BankAdjustmentDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// معرف فريد لتفاصيل تسوية البنك
    /// </summary>
    public BankAdjustmentDetailId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// رقم فرع البنك
    /// </summary>
    public decimal? BranchBankNumber { get; private set; }

    /// <summary>
    /// رصيد البنك
    /// </summary>
    public decimal? BankBalance { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// مبلغ القيد
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// مبلغ القيد بالعملة الأجنبية
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

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

    /// <summary>
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// رقم مستند الفرع
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// نوع المستند المرجعي
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// نوع قيد اليومية المرجعي
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// رقم المستند المرجعي
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند المرجعي
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// تسلسل المستند المرجعي
    /// </summary>
    public decimal? DocSqRef { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// سعر الصرف
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// كود فرعي لتفاصيل الحساب
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع عملة الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع مستند تسوية البنك (متعدد إلى واحد)
    /// </summary>
    public BankAdjustmentMaster BankAdjustmentMaster { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع تفاصيل النقدية في البنك (متعدد إلى واحد)
    /// </summary>
    public CashAtBankDetail CashAtBankDetail { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
