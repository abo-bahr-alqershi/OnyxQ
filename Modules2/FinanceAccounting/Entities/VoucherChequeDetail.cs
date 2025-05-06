using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل شيكات السندات المالية ويحتوي على جميع خصائص الشيكات المرتبطة بالسندات
/// </summary>
public class VoucherChequeDetail : Entity<VoucherChequeDetailId>
{

    private VoucherChequeDetail() { }

    public VoucherChequeDetail(VoucherChequeDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// معرف فريد لتفاصيل شيك السند
    /// </summary>
    public VoucherChequeDetailId Id { get; private set; }

    /// <summary>
    /// نوع السند الكامل
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// رقم النقدية
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// رقم البنك
    /// </summary>
    public decimal? BankNumber { get; private set; }

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
    /// عملة الحساب
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// رقم النقدية/البنك
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// وصف الحساب المختصر
    /// </summary>
    public string AccountDescriptionShort { get; private set; }

    /// <summary>
    /// مبلغ الحساب
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// مبلغ الحساب بالعملة الأجنبية
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// سعر الصرف
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

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
    /// رقم فرع المستند
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع العميل (متعدد إلى واحد)
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع تفاصيل السند (متعدد إلى واحد)
    /// </summary>
    public VoucherDetail VoucherDetail { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع تفاصيل السندات (متعدد إلى واحد)
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

