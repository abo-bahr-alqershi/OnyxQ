using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a ParameterMessage entity for system messaging configuration
/// يمثل كيان رسالة المعلمات لإعدادات رسائل النظام
/// </summary>
public class ParameterMessage : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the ParameterMessage
    /// المعرف الفريد لرسالة المعلمات
    /// !# PARA_NO
    /// </summary>
    public ParameterMessageId Id { get; private set; }

    /// <summary>
    /// Gets the hour to send check alerts
    /// ساعة إرسال تنبيهات الشيكات
    /// !# HOUR_SEND_CHQ_ALRT
    /// </summary>
    public byte HourToSendCheckAlerts { get; private set; }

    /// <summary>
    /// Gets the hour to send customer balance
    /// ساعة إرسال رصيد العميل
    /// !# HOUR_SEND_CST_BLNC
    /// </summary>
    public byte HourToSendCustomerBalance { get; private set; }

    /// <summary>
    /// Gets the hour to send account balance
    /// ساعة إرسال رصيد الحساب
    /// !# HOUR_SEND_ACCNT_BLNC
    /// </summary>
    public byte HourToSendAccountBalance { get; private set; }

    /// <summary>
    /// Gets whether to get account alerts
    /// الحصول على تنبيهات الحساب
    /// !# GET_ACCNT_ALRT
    /// </summary>
    public bool GetAccountAlerts { get; private set; }

    /// <summary>
    /// Gets the period to send account balance
    /// فترة إرسال رصيد الحساب
    /// !# PRD_SEND_ACCNT_BLNC
    /// </summary>
    public byte PeriodToSendAccountBalance { get; private set; }

    /// <summary>
    /// Gets whether to get account detail alerts
    /// الحصول على تنبيهات تفاصيل الحساب
    /// !# GET_ACCNT_DTL_ALRT
    /// </summary>
    public bool GetAccountDetailAlerts { get; private set; }

    /// <summary>
    /// Gets the period to send customer balance
    /// فترة إرسال رصيد العميل
    /// !# PRD_SEND_CST_BLNC
    /// </summary>
    public byte PeriodToSendCustomerBalance { get; private set; }

    /// <summary>
    /// Gets whether to get due check alerts
    /// الحصول على تنبيهات الشيكات المستحقة
    /// !# GET_DUE_CHQ_ALRT
    /// </summary>
    public bool GetDueCheckAlerts { get; private set; }

    /// <summary>
    /// Gets the period for receipt due check alerts
    /// فترة تنبيهات الشيكات المستحقة للقبض
    /// !# PRD_ALRT_RCPT_DUE_CHQ
    /// </summary>
    public byte PeriodForReceiptDueCheckAlerts { get; private set; }

    /// <summary>
    /// Gets the period for payment due check alerts
    /// فترة تنبيهات الشيكات المستحقة للدفع
    /// !# PRD_ALRT_PYMNT_DUE_CHQ
    /// </summary>
    public byte PeriodForPaymentDueCheckAlerts { get; private set; }

    /// <summary>
    /// Gets the minutes to send check alerts
    /// دقائق إرسال تنبيهات الشيكات
    /// !# MINT_SEND_CHQ_ALRT
    /// </summary>
    public byte MinutesToSendCheckAlerts { get; private set; }

    /// <summary>
    /// Gets the timezone for sending check alerts
    /// المنطقة الزمنية لإرسال تنبيهات الشيكات
    /// !# TZ_SEND_CHQ_ALRT
    /// </summary>
    public string TimezoneForCheckAlerts { get; private set; }

    /// <summary>
    /// Gets the minutes to send account balance
    /// دقائق إرسال رصيد الحساب
    /// !# MINT_SEND_ACCNT_BLNC
    /// </summary>
    public byte MinutesToSendAccountBalance { get; private set; }

    /// <summary>
    /// Gets the timezone for sending account balance
    /// المنطقة الزمنية لإرسال رصيد الحساب
    /// !# TZ_SEND_ACCNT_BLNC
    /// </summary>
    public string TimezoneForAccountBalance { get; private set; }

    /// <summary>
    /// Gets the minutes to send customer balance
    /// دقائق إرسال رصيد العميل
    /// !# MINT_SEND_CST_BLNC
    /// </summary>
    public byte MinutesToSendCustomerBalance { get; private set; }

    /// <summary>
    /// Gets the timezone for sending customer balance
    /// المنطقة الزمنية لإرسال رصيد العميل
    /// !# TZ_SEND_CST_BLNC
    /// </summary>
    public string TimezoneForCustomerBalance { get; private set; }

    /// <summary>
    /// Gets the user ID who last updated
    /// معرف المستخدم الذي قام بآخر تحديث
    /// !# UP_U_ID
    /// </summary>
    public int? UpdatedByUserId { get; private set; }

    /// <summary>
    /// Gets the last update date
    /// تاريخ آخر تحديث
    /// !# UP_DATE
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the update count
    /// عدد مرات التحديث
    /// !# UP_CNT
    /// </summary>
    public long? UpdateCount { get; private set; }

    /// <summary>
    /// Gets the terminal name for last update
    /// اسم الجهاز لآخر تحديث
    /// !# UP_TRMNL_NM
    /// </summary>
    public string UpdatedTerminalName { get; private set; }

    /// <summary>
    /// Gets the report print count
    /// عدد مرات طباعة التقرير
    /// !# PR_REP
    /// </summary>
    public long? PrintReportCount { get; private set; }

    private ParameterMessage() { } // For EF Core

    public ParameterMessage(
        byte parameterNumber,
        byte hourToSendCheckAlerts,
        byte hourToSendCustomerBalance,
        byte hourToSendAccountBalance,
        bool getAccountAlerts,
        byte periodToSendAccountBalance,
        bool getAccountDetailAlerts,
        byte periodToSendCustomerBalance,
        bool getDueCheckAlerts,
        byte periodForReceiptDueCheckAlerts,
        byte periodForPaymentDueCheckAlerts,
        byte minutesToSendCheckAlerts,
        string timezoneForCheckAlerts,
        byte minutesToSendAccountBalance,
        string timezoneForAccountBalance,
        byte minutesToSendCustomerBalance,
        string timezoneForCustomerBalance,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName,
        long? printReportCount)
    {
        Id = new ParameterMessageId(parameterNumber);
        HourToSendCheckAlerts = hourToSendCheckAlerts;
        HourToSendCustomerBalance = hourToSendCustomerBalance;
        HourToSendAccountBalance = hourToSendAccountBalance;
        GetAccountAlerts = getAccountAlerts;
        PeriodToSendAccountBalance = periodToSendAccountBalance;
        GetAccountDetailAlerts = getAccountDetailAlerts;
        PeriodToSendCustomerBalance = periodToSendCustomerBalance;
        GetDueCheckAlerts = getDueCheckAlerts;
        PeriodForReceiptDueCheckAlerts = periodForReceiptDueCheckAlerts;
        PeriodForPaymentDueCheckAlerts = periodForPaymentDueCheckAlerts;
        MinutesToSendCheckAlerts = minutesToSendCheckAlerts;
        TimezoneForCheckAlerts = timezoneForCheckAlerts;
        MinutesToSendAccountBalance = minutesToSendAccountBalance;
        TimezoneForAccountBalance = timezoneForAccountBalance;
        MinutesToSendCustomerBalance = minutesToSendCustomerBalance;
        TimezoneForCustomerBalance = timezoneForCustomerBalance;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        PrintReportCount = printReportCount;
        AddDomainEvent(new ParameterMessageCreatedEvent(this));
    }

    public void Update(
        byte hourToSendCheckAlerts,
        byte hourToSendCustomerBalance,
        byte hourToSendAccountBalance,
        bool getAccountAlerts,
        byte periodToSendAccountBalance,
        bool getAccountDetailAlerts,
        byte periodToSendCustomerBalance,
        bool getDueCheckAlerts,
        byte periodForReceiptDueCheckAlerts,
        byte periodForPaymentDueCheckAlerts,
        byte minutesToSendCheckAlerts,
        string timezoneForCheckAlerts,
        byte minutesToSendAccountBalance,
        string timezoneForAccountBalance,
        byte minutesToSendCustomerBalance,
        string timezoneForCustomerBalance,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName,
        long? printReportCount)
    {
        HourToSendCheckAlerts = hourToSendCheckAlerts;
        HourToSendCustomerBalance = hourToSendCustomerBalance;
        HourToSendAccountBalance = hourToSendAccountBalance;
        GetAccountAlerts = getAccountAlerts;
        PeriodToSendAccountBalance = periodToSendAccountBalance;
        GetAccountDetailAlerts = getAccountDetailAlerts;
        PeriodToSendCustomerBalance = periodToSendCustomerBalance;
        GetDueCheckAlerts = getDueCheckAlerts;
        PeriodForReceiptDueCheckAlerts = periodForReceiptDueCheckAlerts;
        PeriodForPaymentDueCheckAlerts = periodForPaymentDueCheckAlerts;
        MinutesToSendCheckAlerts = minutesToSendCheckAlerts;
        TimezoneForCheckAlerts = timezoneForCheckAlerts;
        MinutesToSendAccountBalance = minutesToSendAccountBalance;
        TimezoneForAccountBalance = timezoneForAccountBalance;
        MinutesToSendCustomerBalance = minutesToSendCustomerBalance;
        TimezoneForCustomerBalance = timezoneForCustomerBalance;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        PrintReportCount = printReportCount;
        AddDomainEvent(new ParameterMessageUpdatedEvent(this));
    }

    public void Delete()
    {
        AddDomainEvent(new ParameterMessageDeletedEvent(this));
    }
} 