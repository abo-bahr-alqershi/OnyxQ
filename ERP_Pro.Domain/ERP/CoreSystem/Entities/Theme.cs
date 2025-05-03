using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a Theme entity
/// يمثل كيان السمة
/// </summary>
public class Theme : AuditableEntity
{
    /// <summary>
    /// Gets the unique identifier for the Theme
    /// المعرف الفريد للسمة
    /// !# THM_NO
    /// </summary>
    public ThemeId Id { get; private set; }

    /// <summary>
    /// Gets the theme color data
    /// بيانات لون السمة
    /// !# THM_COLR_DATA
    /// </summary>
    public string ThemeColorData { get; private set; }

    /// <summary>
    /// Gets the theme color user
    /// لون المستخدم للسمة
    /// !# THM_COLR_USR
    /// </summary>
    public string ThemeColorUser { get; private set; }

    /// <summary>
    /// Gets the theme current record color
    /// لون السجل الحالي للسمة
    /// !# THM_CRNT_RCRD_COLR
    /// </summary>
    public string ThemeCurrentRecordColor { get; private set; }

    /// <summary>
    /// Gets the theme pattern
    /// نمط السمة
    /// !# THM_PATTERN
    /// </summary>
    public string ThemePattern { get; private set; }

    /// <summary>
    /// Gets the theme foreground color
    /// لون المقدمة للسمة
    /// !# THM_FRGRNDCLR
    /// </summary>
    public string ThemeForegroundColor { get; private set; }

    /// <summary>
    /// Gets the theme text background data
    /// بيانات خلفية النص للسمة
    /// !# THM_TXT_BG_DATA
    /// </summary>
    public string ThemeTextBackgroundData { get; private set; }

    /// <summary>
    /// Gets the theme text background user
    /// خلفية نص المستخدم للسمة
    /// !# THM_TXT_BG_USR
    /// </summary>
    public string ThemeTextBackgroundUser { get; private set; }

    /// <summary>
    /// Gets the theme flag
    /// علم السمة
    /// !# THM_FLG
    /// </summary>
    public bool ThemeFlag { get; private set; }

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
    /// Gets the print report
    /// تقرير الطباعة
    /// !# PR_REP
    /// </summary>
    public long? PrintReport { get; private set; }

    private Theme() { }

    public Theme(
        int themeNumber,
        string themeColorData,
        string themeColorUser,
        string themeCurrentRecordColor,
        string themePattern,
        string themeForegroundColor,
        string themeTextBackgroundData,
        string themeTextBackgroundUser,
        bool themeFlag,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName,
        long? printReport)
    {
        Id = new ThemeId(themeNumber);
        ThemeColorData = themeColorData;
        ThemeColorUser = themeColorUser;
        ThemeCurrentRecordColor = themeCurrentRecordColor;
        ThemePattern = themePattern;
        ThemeForegroundColor = themeForegroundColor;
        ThemeTextBackgroundData = themeTextBackgroundData;
        ThemeTextBackgroundUser = themeTextBackgroundUser;
        ThemeFlag = themeFlag;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        PrintReport = printReport;
        AddDomainEvent(new ThemeCreated(this));
    }

    public void Update(
        string themeColorData,
        string themeColorUser,
        string themeCurrentRecordColor,
        string themePattern,
        string themeForegroundColor,
        string themeTextBackgroundData,
        string themeTextBackgroundUser,
        bool themeFlag,
        int? updatedByUserId,
        DateTime? updatedDate,
        long? updateCount,
        string updatedTerminalName,
        long? printReport)
    {
        ThemeColorData = themeColorData;
        ThemeColorUser = themeColorUser;
        ThemeCurrentRecordColor = themeCurrentRecordColor;
        ThemePattern = themePattern;
        ThemeForegroundColor = themeForegroundColor;
        ThemeTextBackgroundData = themeTextBackgroundData;
        ThemeTextBackgroundUser = themeTextBackgroundUser;
        ThemeFlag = themeFlag;
        UpdatedByUserId = updatedByUserId;
        UpdatedDate = updatedDate;
        UpdateCount = updateCount;
        UpdatedTerminalName = updatedTerminalName;
        PrintReport = printReport;
        AddDomainEvent(new ThemeUpdated(this));
    }

    public void Delete()
    {
        AddDomainEvent(new ThemeDeleted(this));
    }
} 