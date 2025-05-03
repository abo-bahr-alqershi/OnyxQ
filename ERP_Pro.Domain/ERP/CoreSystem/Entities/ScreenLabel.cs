using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a screen label entity in the system.
/// يمثل كيان تسمية الشاشة في النظام
/// </summary>
public sealed class ScreenLabel : AggregateRoot<ScreenLabelId>
{
    /// <summary>
    /// Gets the language number.
    /// رقم اللغة
    /// </summary>
    public int LanguageNumber { get; private set; }

    /// <summary>
    /// Gets the form number.
    /// رقم النموذج
    /// </summary>
    public int FormNumber { get; private set; }

    /// <summary>
    /// Gets the object name.
    /// اسم الكائن
    /// </summary>
    public string ObjectName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the field name.
    /// اسم الحقل
    /// </summary>
    public string FieldName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the label text.
    /// نص التسمية
    /// </summary>
    public string LabelText { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the field number.
    /// رقم الحقل
    /// </summary>
    public int FieldNumber { get; private set; }

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

    private ScreenLabel() { }

    private ScreenLabel(
        ScreenLabelId id,
        int languageNumber,
        int formNumber,
        string objectName,
        string fieldName,
        string labelText,
        int fieldNumber,
        DateTime addedDate,
        int updatedUserId,
        DateTime updatedDate,
        int updateCounter,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        LanguageNumber = languageNumber;
        FormNumber = formNumber;
        ObjectName = objectName;
        FieldName = fieldName;
        LabelText = labelText;
        FieldNumber = fieldNumber;
        AddedDate = addedDate;
        UpdatedUserId = updatedUserId;
        UpdatedDate = updatedDate;
        UpdateCounter = updateCounter;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static ScreenLabel Create(
        int languageNumber,
        int formNumber,
        string objectName,
        string fieldName,
        string labelText,
        int fieldNumber,
        int updatedUserId,
        string addedTerminalName)
    {
        var screenLabel = new ScreenLabel(
            ScreenLabelId.CreateUnique(),
            languageNumber,
            formNumber,
            objectName,
            fieldName,
            labelText,
            fieldNumber,
            DateTime.UtcNow,
            updatedUserId,
            DateTime.UtcNow,
            0,
            addedTerminalName,
            addedTerminalName);

        screenLabel.RaiseDomainEvent(new ScreenLabelCreatedEvent(screenLabel));

        return screenLabel;
    }

    public void Update(
        string labelText,
        int updatedUserId,
        string updatedTerminalName)
    {
        LabelText = labelText;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdateCounter++;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new ScreenLabelUpdatedEvent(this));
    }
} 