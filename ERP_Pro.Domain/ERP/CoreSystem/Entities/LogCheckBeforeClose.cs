using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a log check before close record in the ERP system
/// يمثل سجل التحقق قبل الإغلاق في نظام تخطيط موارد المؤسسات
/// Table name: S_LOG_CHK_BFR_CLS
/// </summary>
public class LogCheckBeforeClose : AuditableEntity
{
    /// <summary>
    /// Gets or sets the message number
    /// رقم الرسالة
    /// </summary>
    public int MessageNumber { get; private set; }

    /// <summary>
    /// Gets or sets the fixed message text
    /// نص الرسالة الثابت
    /// </summary>
    public string MessageTextFixed { get; private set; }

    /// <summary>
    /// Gets or sets the report name
    /// اسم التقرير
    /// </summary>
    public string ReportName { get; private set; }

    /// <summary>
    /// Gets or sets the report where clause
    /// شرط التقرير
    /// </summary>
    public string ReportWhereClause { get; private set; }

    /// <summary>
    /// Gets or sets the addition date
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AdditionDate { get; private set; }

    #region Constructors

    private LogCheckBeforeClose() { }

    public LogCheckBeforeClose(
        int messageNumber,
        string messageTextFixed,
        string reportName,
        string reportWhereClause,
        DateTime additionDate)
    {
        MessageNumber = messageNumber;
        MessageTextFixed = messageTextFixed;
        ReportName = reportName;
        ReportWhereClause = reportWhereClause;
        AdditionDate = additionDate;

        AddDomainEvent(new LogCheckBeforeCloseCreatedEvent(this));
    }

    #endregion

    #region Methods

    public void UpdateMessageText(string newMessageText)
    {
        if (string.IsNullOrWhiteSpace(newMessageText))
            throw new ArgumentException("Message text cannot be empty", nameof(newMessageText));

        MessageTextFixed = newMessageText;
        AddDomainEvent(new LogCheckBeforeCloseUpdatedEvent(this));
    }

    public void UpdateReportDetails(string reportName, string whereClause)
    {
        if (string.IsNullOrWhiteSpace(reportName))
            throw new ArgumentException("Report name cannot be empty", nameof(reportName));

        ReportName = reportName;
        ReportWhereClause = whereClause;
        AddDomainEvent(new LogCheckBeforeCloseReportUpdatedEvent(this));
    }

    #endregion
} 