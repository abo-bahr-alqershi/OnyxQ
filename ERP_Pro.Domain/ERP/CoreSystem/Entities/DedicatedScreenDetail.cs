using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a dedicated screen detail entity in the system.
/// يمثل كيان تفاصيل الشاشة المخصصة في النظام
/// </summary>
public sealed class DedicatedScreenDetail : AggregateRoot<DedicatedScreenDetailId>
{
    /// <summary>
    /// Gets the screen number.
    /// رقم الشاشة
    /// </summary>
    public int ScreenNumber { get; private set; }

    /// <summary>
    /// Gets the field name.
    /// اسم الحقل
    /// </summary>
    public string FieldName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the field type.
    /// نوع الحقل
    /// </summary>
    public int FieldType { get; private set; }

    /// <summary>
    /// Gets the field length.
    /// طول الحقل
    /// </summary>
    public int FieldLength { get; private set; }

    /// <summary>
    /// Gets the field order.
    /// ترتيب الحقل
    /// </summary>
    public int FieldOrder { get; private set; }

    /// <summary>
    /// Gets a value indicating whether the field is required.
    /// يحدد ما إذا كان الحقل مطلوباً
    /// </summary>
    public bool IsRequired { get; private set; }

    /// <summary>
    /// Gets a value indicating whether the field is visible.
    /// يحدد ما إذا كان الحقل مرئياً
    /// </summary>
    public bool IsVisible { get; private set; }

    /// <summary>
    /// Gets a value indicating whether the field is enabled.
    /// يحدد ما إذا كان الحقل مفعلاً
    /// </summary>
    public bool IsEnabled { get; private set; }

    /// <summary>
    /// Gets the field default value.
    /// القيمة الافتراضية للحقل
    /// </summary>
    public string DefaultValue { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the field validation rule.
    /// قاعدة التحقق من صحة الحقل
    /// </summary>
    public string ValidationRule { get; private set; } = string.Empty;

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
    /// Gets the terminal name where the record was added.
    /// اسم الطرفية التي تمت إضافة السجل منها
    /// </summary>
    public string AddedTerminalName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the updated user ID.
    /// معرف المستخدم الذي قام بالتحديث
    /// </summary>
    public int? UpdatedUserId { get; private set; }

    /// <summary>
    /// Gets the update date.
    /// تاريخ التحديث
    /// </summary>
    public DateTime? UpdatedDate { get; private set; }

    /// <summary>
    /// Gets the terminal name where the record was last updated.
    /// اسم الطرفية التي تم تحديث السجل منها
    /// </summary>
    public string UpdatedTerminalName { get; private set; } = string.Empty;

    private DedicatedScreenDetail() { }

    private DedicatedScreenDetail(
        DedicatedScreenDetailId id,
        int screenNumber,
        string fieldName,
        int fieldType,
        int fieldLength,
        int fieldOrder,
        bool isRequired,
        bool isVisible,
        bool isEnabled,
        string defaultValue,
        string validationRule,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        ScreenNumber = screenNumber;
        FieldName = fieldName;
        FieldType = fieldType;
        FieldLength = fieldLength;
        FieldOrder = fieldOrder;
        IsRequired = isRequired;
        IsVisible = isVisible;
        IsEnabled = isEnabled;
        DefaultValue = defaultValue;
        ValidationRule = validationRule;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static DedicatedScreenDetail Create(
        int screenNumber,
        string fieldName,
        int fieldType,
        int fieldLength,
        int fieldOrder,
        bool isRequired,
        bool isVisible,
        bool isEnabled,
        string defaultValue,
        string validationRule,
        int addedUserId,
        string addedTerminalName)
    {
        var dedicatedScreenDetail = new DedicatedScreenDetail(
            DedicatedScreenDetailId.CreateUnique(),
            screenNumber,
            fieldName,
            fieldType,
            fieldLength,
            fieldOrder,
            isRequired,
            isVisible,
            isEnabled,
            defaultValue,
            validationRule,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName,
            addedTerminalName);

        dedicatedScreenDetail.RaiseDomainEvent(new DedicatedScreenDetailCreatedEvent(dedicatedScreenDetail));

        return dedicatedScreenDetail;
    }

    public void Update(
        string fieldName,
        int fieldType,
        int fieldLength,
        int fieldOrder,
        bool isRequired,
        bool isVisible,
        bool isEnabled,
        string defaultValue,
        string validationRule,
        int updatedUserId,
        string updatedTerminalName)
    {
        FieldName = fieldName;
        FieldType = fieldType;
        FieldLength = fieldLength;
        FieldOrder = fieldOrder;
        IsRequired = isRequired;
        IsVisible = isVisible;
        IsEnabled = isEnabled;
        DefaultValue = defaultValue;
        ValidationRule = validationRule;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new DedicatedScreenDetailUpdatedEvent(this));
    }
} 