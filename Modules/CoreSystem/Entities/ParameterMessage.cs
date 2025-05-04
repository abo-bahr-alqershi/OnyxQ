using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ParameterMessage Entity
/// </summary>
public class ParameterMessage : Entity<ParameterMessageId>
{
    private ParameterMessage() { }

    /// <summary>
    /// The unique identifier for the ParameterMessage
    /// المعرف الفريد لـ ParameterMessage
    /// </summary>
    public ParameterMessageId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterMessage
    /// ParameterNumber الخاص بـ ParameterMessage
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// HourSendChequeAlert of the ParameterMessage
    /// HourSendChequeAlert الخاص بـ ParameterMessage
    /// </summary>
    public decimal? HourSendChequeAlert { get; private set; }

    /// <summary>
    /// HourSendCustomerBalance of the ParameterMessage
    /// HourSendCustomerBalance الخاص بـ ParameterMessage
    /// </summary>
    public decimal? HourSendCustomerBalance { get; private set; }

    /// <summary>
    /// HourSendAccountBalance of the ParameterMessage
    /// HourSendAccountBalance الخاص بـ ParameterMessage
    /// </summary>
    public decimal? HourSendAccountBalance { get; private set; }

    /// <summary>
    /// GetAccountAlert of the ParameterMessage
    /// GetAccountAlert الخاص بـ ParameterMessage
    /// </summary>
    public decimal? GetAccountAlert { get; private set; }

    /// <summary>
    /// PeriodSendAccountBalance of the ParameterMessage
    /// PeriodSendAccountBalance الخاص بـ ParameterMessage
    /// </summary>
    public decimal? PeriodSendAccountBalance { get; private set; }

    /// <summary>
    /// GetAccountDetailAlert of the ParameterMessage
    /// GetAccountDetailAlert الخاص بـ ParameterMessage
    /// </summary>
    public decimal? GetAccountDetailAlert { get; private set; }

    /// <summary>
    /// PeriodSendCustomerBalance of the ParameterMessage
    /// PeriodSendCustomerBalance الخاص بـ ParameterMessage
    /// </summary>
    public decimal? PeriodSendCustomerBalance { get; private set; }

    /// <summary>
    /// GetDueChequeAlert of the ParameterMessage
    /// GetDueChequeAlert الخاص بـ ParameterMessage
    /// </summary>
    public decimal? GetDueChequeAlert { get; private set; }

    /// <summary>
    /// PeriodAlertReceiptDueCheque of the ParameterMessage
    /// PeriodAlertReceiptDueCheque الخاص بـ ParameterMessage
    /// </summary>
    public decimal? PeriodAlertReceiptDueCheque { get; private set; }

    /// <summary>
    /// PeriodAlertPaymentDueCheque of the ParameterMessage
    /// PeriodAlertPaymentDueCheque الخاص بـ ParameterMessage
    /// </summary>
    public decimal? PeriodAlertPaymentDueCheque { get; private set; }

    /// <summary>
    /// MinuteSendChequeAlert of the ParameterMessage
    /// MinuteSendChequeAlert الخاص بـ ParameterMessage
    /// </summary>
    public decimal? MinuteSendChequeAlert { get; private set; }

    /// <summary>
    /// TimezoneSendChequeAlert of the ParameterMessage
    /// TimezoneSendChequeAlert الخاص بـ ParameterMessage
    /// </summary>
    public string TimezoneSendChequeAlert { get; private set; }

    /// <summary>
    /// MinuteSendAccountBalance of the ParameterMessage
    /// MinuteSendAccountBalance الخاص بـ ParameterMessage
    /// </summary>
    public decimal? MinuteSendAccountBalance { get; private set; }

    /// <summary>
    /// TimezoneSendAccountBalance of the ParameterMessage
    /// TimezoneSendAccountBalance الخاص بـ ParameterMessage
    /// </summary>
    public string TimezoneSendAccountBalance { get; private set; }

    /// <summary>
    /// MinuteSendCustomerBalance of the ParameterMessage
    /// MinuteSendCustomerBalance الخاص بـ ParameterMessage
    /// </summary>
    public decimal? MinuteSendCustomerBalance { get; private set; }

    /// <summary>
    /// TimezoneSendCustomerBalance of the ParameterMessage
    /// TimezoneSendCustomerBalance الخاص بـ ParameterMessage
    /// </summary>
    public string TimezoneSendCustomerBalance { get; private set; }
}
}
