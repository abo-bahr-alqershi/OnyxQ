using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل كيان البنك النقدي ويحتوي على جميع خصائص البنوك النقدية
/// </summary>
public class BankCash : Entity<BankCashId>
{

    private BankCash() { }

    public BankCash(BankCashId id, decimal? bankNumber)
    {
        Id = id;
        BankNumber = bankNumber;
    }

    /// <summary>
    /// معرف فريد للبنك النقدي
    /// </summary>
    public BankCashId Id { get; private set; }

    /// <summary>
    /// رقم البنك
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// اسم البنك
    /// </summary>
    public string BankName { get; private set; }

    /// <summary>
    /// اسم البنك بالإنجليزية
    /// </summary>
    public string BankNameEnglish { get; private set; }

    /// <summary>
    /// التسلسل البنكي
    /// </summary>
    public decimal? BankSerial { get; private set; }

    /// <summary>
    /// رقم الحساب المختصر للبنك
    /// </summary>
    public string BankAccountShort { get; private set; }

    /// <summary>
    /// رقم فرع الاتصال
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// هاتف البنك
    /// </summary>
    public string BankTelephone { get; private set; }

    /// <summary>
    /// فاكس البنك
    /// </summary>
    public string BankFax { get; private set; }

    /// <summary>
    /// صندوق البنك
    /// </summary>
    public string BankBox { get; private set; }

    /// <summary>
    /// عنوان البنك
    /// </summary>
    public string BankAddress { get; private set; }

    /// <summary>
    /// بريد البنك الإلكتروني
    /// </summary>
    public string BankEmail { get; private set; }

    /// <summary>
    /// موقع البنك الإلكتروني
    /// </summary>
    public string BankWebsite { get; private set; }

    /// <summary>
    /// رقم الدولة
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// رقم المدينة
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// علم الوسيط
    /// </summary>
    public decimal? MediatorFlag { get; private set; }

    /// <summary>
    /// حالة التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// سبب التعطيل
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// صورة البنك
    /// </summary>
    public string BankImage { get; private set; }

    /// <summary>
    /// خطاب الاستلام
    /// </summary>
    public string ReceiveLetter { get; private set; }

    /// <summary>
    /// خطاب الدفع
    /// </summary>
    public string PaymentLetter { get; private set; }

    /// <summary>
    /// عينة المندوب
    /// </summary>
    public decimal? RepSample { get; private set; }

    /// <summary>
    /// تاريخ آخر إعداد
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

    /// <summary>
    /// تسلسل الشيك التلقائي
    /// </summary>
    public decimal? OchkAutoSerial { get; private set; }

    /// <summary>
    /// كود البنك
    /// </summary>
    public decimal? BankCode { get; private set; }

    /// <summary>
    /// نوع تسلسل الإيصال
    /// </summary>
    public decimal? ReceiptSerialType { get; private set; }

    /// <summary>
    /// نوع الدفع الافتراضي
    /// </summary>
    public decimal? PaymentTypeNumberDefault { get; private set; }

    /// <summary>
    /// نوع الاستلام الافتراضي
    /// </summary>
    public decimal? ReceivedTypeNumberDefault { get; private set; }

    /// <summary>
    /// كود شبكة البنك
    /// </summary>
    public string BankNetworkCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع الحساب (متعدد إلى واحد)
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع حساب شيك الدفع الوسيط (متعدد إلى واحد)
    /// </summary>
    public Account AccountChqPayIntrmAc { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع مجموعة البنوك (متعدد إلى واحد)
    /// </summary>
    public BankGroup BankGroup { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

