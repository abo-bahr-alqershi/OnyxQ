using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
// كيان يمثل رسالة إعدادات النظام ويحتوي على جميع خصائص التنبيهات والرسائل الزمنية.
public class ParameterMessage : Entity<ParameterMessageId>
{
    private ParameterMessage() { }

    public ParameterMessage(ParameterMessageId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    // المعرف الفريد لرسالة الإعدادات (مفتاح رئيسي).
    public ParameterMessageId Id { get; private set; }

    // رقم الإعداد أو الباراميتر.
    public decimal? ParameterNumber { get; private set; }

    // ساعة إرسال تنبيه الشيكات.
    public decimal? HourSendChequeAlert { get; private set; }

    // ساعة إرسال رصيد العميل.
    public decimal? HourSendCustomerBalance { get; private set; }

    // ساعة إرسال رصيد الحساب.
    public decimal? HourSendAccountBalance { get; private set; }

    // تفعيل تنبيه الحساب.
    public decimal? GetAccountAlert { get; private set; }

    // فترة إرسال رصيد الحساب.
    public decimal? PeriodSendAccountBalance { get; private set; }

    // تفعيل تنبيه تفاصيل الحساب.
    public decimal? GetAccountDetailAlert { get; private set; }

    // فترة إرسال رصيد العميل.
    public decimal? PeriodSendCustomerBalance { get; private set; }

    // تفعيل تنبيه الشيكات المستحقة.
    public decimal? GetDueChequeAlert { get; private set; }

    // فترة تنبيه استحقاق الشيكات المقبوضة.
    public decimal? PeriodAlertReceiptDueCheque { get; private set; }

    // فترة تنبيه استحقاق الشيكات المصروفة.
    public decimal? PeriodAlertPaymentDueCheque { get; private set; }

    // دقيقة إرسال تنبيه الشيكات.
    public decimal? MinuteSendChequeAlert { get; private set; }

    // المنطقة الزمنية لإرسال تنبيه الشيكات.
    public string TimezoneSendChequeAlert { get; private set; }

    // دقيقة إرسال رصيد الحساب.
    public decimal? MinuteSendAccountBalance { get; private set; }

    // المنطقة الزمنية لإرسال رصيد الحساب.
    public string TimezoneSendAccountBalance { get; private set; }

    // دقيقة إرسال رصيد العميل.
    public decimal? MinuteSendCustomerBalance { get; private set; }

    // المنطقة الزمنية لإرسال رصيد العميل.
    public string TimezoneSendCustomerBalance { get; private set; }

    #region Methods
    // أضف هنا منطق الدومين الخاص برسالة الإعدادات
    #endregion
}
}
