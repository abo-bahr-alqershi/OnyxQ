using System;
using ERP_Pro.Domain.Common.Models;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a zone entity in the system.
/// يمثل كيان المنطقة في النظام
/// </summary>
public sealed class Zone : AggregateRoot<ZoneId>
{
    /// <summary>
    /// Gets the zone code.
    /// رمز المنطقة
    /// </summary>
    public string ZoneCode { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the zone name.
    /// اسم المنطقة
    /// </summary>
    public string ZoneName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the zone name in Arabic.
    /// اسم المنطقة بالعربية
    /// </summary>
    public string ZoneNameAr { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the zone description.
    /// وصف المنطقة
    /// </summary>
    public string ZoneDescription { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the zone description in Arabic.
    /// وصف المنطقة بالعربية
    /// </summary>
    public string ZoneDescriptionAr { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the parent zone ID.
    /// معرف المنطقة الأم
    /// </summary>
    public int? ParentZoneId { get; private set; }

    /// <summary>
    /// Gets the zone level.
    /// مستوى المنطقة
    /// </summary>
    public int ZoneLevel { get; private set; }

    /// <summary>
    /// Gets the zone order.
    /// ترتيب المنطقة
    /// </summary>
    public int ZoneOrder { get; private set; }

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

    /// <summary>
    /// Navigation property for the parent zone.
    /// خاصية التنقل للمنطقة الأم
    /// </summary>
    public Zone ParentZone { get; private set; }

    private Zone() { }

    private Zone(
        ZoneId id,
        string zoneCode,
        string zoneName,
        string zoneNameAr,
        string zoneDescription,
        string zoneDescriptionAr,
        int? parentZoneId,
        int zoneLevel,
        int zoneOrder,
        int addedUserId,
        DateTime addedDate,
        string addedTerminalName,
        string updatedTerminalName)
        : base(id)
    {
        ZoneCode = zoneCode;
        ZoneName = zoneName;
        ZoneNameAr = zoneNameAr;
        ZoneDescription = zoneDescription;
        ZoneDescriptionAr = zoneDescriptionAr;
        ParentZoneId = parentZoneId;
        ZoneLevel = zoneLevel;
        ZoneOrder = zoneOrder;
        AddedUserId = addedUserId;
        AddedDate = addedDate;
        AddedTerminalName = addedTerminalName;
        UpdatedTerminalName = updatedTerminalName;
    }

    public static Zone Create(
        string zoneCode,
        string zoneName,
        string zoneNameAr,
        string zoneDescription,
        string zoneDescriptionAr,
        int? parentZoneId,
        int zoneLevel,
        int zoneOrder,
        int addedUserId,
        string addedTerminalName)
    {
        var zone = new Zone(
            ZoneId.CreateUnique(),
            zoneCode,
            zoneName,
            zoneNameAr,
            zoneDescription,
            zoneDescriptionAr,
            parentZoneId,
            zoneLevel,
            zoneOrder,
            addedUserId,
            DateTime.UtcNow,
            addedTerminalName,
            addedTerminalName);

        zone.RaiseDomainEvent(new ZoneCreatedEvent(zone));

        return zone;
    }

    public void Update(
        string zoneName,
        string zoneNameAr,
        string zoneDescription,
        string zoneDescriptionAr,
        int? parentZoneId,
        int zoneLevel,
        int zoneOrder,
        int updatedUserId,
        string updatedTerminalName)
    {
        ZoneName = zoneName;
        ZoneNameAr = zoneNameAr;
        ZoneDescription = zoneDescription;
        ZoneDescriptionAr = zoneDescriptionAr;
        ParentZoneId = parentZoneId;
        ZoneLevel = zoneLevel;
        ZoneOrder = zoneOrder;
        UpdatedUserId = updatedUserId;
        UpdatedDate = DateTime.UtcNow;
        UpdatedTerminalName = updatedTerminalName;

        RaiseDomainEvent(new ZoneUpdatedEvent(this));
    }
} 