using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a screen link entity in the system.
/// يمثل كيان رابط الشاشة في النظام
/// </summary>
public sealed class ScreenLink : AggregateRoot<ScreenLinkId>
{
    /// <summary>
    /// Gets the user ID.
    /// معرف المستخدم
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Gets the form number.
    /// رقم النموذج
    /// </summary>
    public int FormNumber { get; private set; }

    /// <summary>
    /// Gets the linked form number.
    /// رقم النموذج المرتبط
    /// </summary>
    public int LinkedFormNumber { get; private set; }

    /// <summary>
    /// Gets the order number.
    /// رقم الترتيب
    /// </summary>
    public int OrderNumber { get; private set; }

    /// <summary>
    /// Gets the system number.
    /// رقم النظام
    /// </summary>
    public int SystemNumber { get; private set; }

    /// <summary>
    /// Gets the added user ID.
    /// معرف المستخدم الذي أضاف السجل
    /// </summary>
    public int AddedUserId { get; private set; }

    /// <summary>
    /// Gets the addition date.
    /// تاريخ الإضافة
    /// </summary>
    public DateTime AddedDate { get; private set; }

    /// <summary>
    /// Gets the updated user ID.
    /// معرف المستخدم الذي قام بالتحديث
    /// </summary>
    public int UpdatedUserId { get; private set; }

    /// <summary>
    /// Gets the update date.
    /// تاريخ التحديث
    /// </summary>
    public DateTime UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the print report number.
    /// رقم تقرير الطباعة
    /// </summary>
    public int PrintReportNumber { get; private set; }

    /// <summary>
    /// Gets the update counter.
    /// عداد التحديث
    /// </summary>
    public int UpdateCounter { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was added.
    /// اسم الطرفية التي تمت إضافة السجل منها
    /// </summary>
    public string AddedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Navigation property for the related form.
    /// خاصية التنقل للنموذج المرتبط
    /// </summary>
    public FormDetail Form { get; private set; }

    /// <summary>
    /// Navigation property for the linked form.
    /// خاصية التنقل للنموذج المرتبط به
    /// </summary>
    public FormDetail LinkedForm { get; private set; }

    /// <summary>
    /// Navigation property for the user.
    /// خاصية التنقل للمستخدم
    /// </summary>
    public User User { get; private set; }

    private ScreenLink() { }

    private ScreenLink(
        ScreenLinkId id,
        int userId,
        int formNumber,
        int linkedFormNumber,
        int orderNumber,
        int systemNumber,
        int addedUserId,
        DateTime addedDate,
        int updatedUserId,
        DateTime updatedDate,
        int printReportNumber,
        int updateCounter,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        UserId = userId;
        FormNumber = formNumber;
        LinkedFormNumber = linkedFormNumber;
        OrderNumber = orderNumber;
        SystemNumber = systemNumber;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        UpdatedUserId = updatedUserId;
        UpdatedDate = updatedDate;
        PrintReportNumber = printReportNumber;
        UpdateCounter = updateCounter;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static ScreenLink Create(
        int userId,
        int formNumber,
        int linkedFormNumber,
        int orderNumber,
        int systemNumber,
        int addedUserId,
        int printReportNumber,
        string addedTerminalName)
    {
        var screenLink = new ScreenLink(
            ScreenLinkId.CreateUnique(),
            userId,
            formNumber,
            linkedFormNumber,
            orderNumber,
            systemNumber,
            addedUserId,
            DateTime.UtcNow,
            addedUserId,
            DateTime.UtcNow,
            printReportNumber,
            0,
            addedTerminalName,
            addedTerminalName);

        screenLink.RaiseDomainEvent(new ScreenLinkCreatedEvent(screenLink));

        return screenLink;
    }

    public void Update(
        int orderNumber,
        int systemNumber,
        int updatedUserId,
        int printReportNumber,
        string updatedTerminalName)
    {
        OrderNumber = orderNumber;
        SystemNumber = systemNumber;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        PrintReportNumber = printReportNumber;
        UpdateCounter++;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new ScreenLinkUpdatedEvent(this));
    }
} 