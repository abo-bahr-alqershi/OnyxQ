using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل النقدية باليد ويحتوي على جميع خصائص صناديق النقدية
/// </summary>
public class HandCash : Entity<HandCashId>
{

    private HandCash() { }

    public HandCash(HandCashId id, decimal? cashNumber)
    {
        Id = id;
        CashNumber = cashNumber;
    }

    /// <summary>
    /// معرف فريد للنقدية باليد
    /// </summary>
    public HandCashId Id { get; private set; }

    /// <summary>
    /// رقم الصندوق النقدي
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// اسم الصندوق النقدي
    /// </summary>
    public string CashName { get; private set; }

    /// <summary>
    /// اسم الصندوق النقدي بالإنجليزية
    /// </summary>
    public string CashNameEnglish { get; private set; }

    /// <summary>
    /// التسلسل النقدي
    /// </summary>
    public decimal? CashSerial { get; private set; }

    /// <summary>
    /// نوع الصندوق النقدي
    /// </summary>
    public decimal? CashType { get; private set; }

    /// <summary>
    /// استخدام الصندوق للإيرادات
    /// </summary>
    public decimal? UseCashIncome { get; private set; }

    /// <summary>
    /// علم نظام نقاط البيع
    /// </summary>
    public decimal? PosSystemFlag { get; private set; }

    /// <summary>
    /// رقم فرع الاتصال
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// تاريخ آخر إعداد
    /// </summary>
    public DateTime? ConfigLastDate { get; private set; }

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
    /// علم الوسيط
    /// </summary>
    public decimal? MediatorFlag { get; private set; }

    /// <summary>
    /// رقم المجموعة
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع الحساب (متعدد إلى واحد)
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
