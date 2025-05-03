using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a system type entity in the system.
/// يمثل كيان نوع النظام في النظام
/// </summary>
public sealed class SystemType : AggregateRoot<SystemTypeId>
{
    /// <summary>
    /// Gets the type code.
    /// رمز النوع
    /// </summary>
    public string TypeCode { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the type name.
    /// اسم النوع
    /// </summary>
    public string TypeName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the type name in Arabic.
    /// اسم النوع بالعربية
    /// </summary>
    public string TypeNameAr { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the type description.
    /// وصف النوع
    /// </summary>
    public string TypeDescription { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the type description in Arabic.
    /// وصف النوع بالعربية
    /// </summary>
    public string TypeDescriptionAr { get; private set; } = string.Empty;

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

    private SystemType() { }

    private SystemType(
        SystemTypeId id,
        string typeCode,
        string typeName,
        string typeNameAr,
        string typeDescription,
        string typeDescriptionAr,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        TypeCode = typeCode;
        TypeName = typeName;
        TypeNameAr = typeNameAr;
        TypeDescription = typeDescription;
        TypeDescriptionAr = typeDescriptionAr;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static SystemType Create(
        string typeCode,
        string typeName,
        string typeNameAr,
        string typeDescription,
        string typeDescriptionAr,
        int addedUserId,
        string addedTerminalName)
    {
        var systemType = new SystemType(
            SystemTypeId.CreateUnique(),
            typeCode,
            typeName,
            typeNameAr,
            typeDescription,
            typeDescriptionAr,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName,
            addedTerminalName);

        systemType.RaiseDomainEvent(new SystemTypeCreatedEvent(systemType));

        return systemType;
    }

    public void Update(
        string typeName,
        string typeNameAr,
        string typeDescription,
        string typeDescriptionAr,
        int updatedUserId,
        string updatedTerminalName)
    {
        TypeName = typeName;
        TypeNameAr = typeNameAr;
        TypeDescription = typeDescription;
        TypeDescriptionAr = typeDescriptionAr;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new SystemTypeUpdatedEvent(this));
    }
} 