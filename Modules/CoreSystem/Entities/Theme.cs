using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// Theme Entity
/// </summary>
public class Theme : Entity<ThemeId>
{
    private Theme() { }

    /// <summary>
    /// The unique identifier for the Theme
    /// المعرف الفريد لـ Theme
    /// </summary>
    public ThemeId Id { get; private set; }

    /// <summary>
    /// ThemeNumber of the Theme
    /// ThemeNumber الخاص بـ Theme
    /// </summary>
    public decimal? ThemeNumber { get; private set; }

    /// <summary>
    /// ThemeColorData of the Theme
    /// ThemeColorData الخاص بـ Theme
    /// </summary>
    public string ThemeColorData { get; private set; }

    /// <summary>
    /// ThemeColorUser of the Theme
    /// ThemeColorUser الخاص بـ Theme
    /// </summary>
    public string ThemeColorUser { get; private set; }

    /// <summary>
    /// ThemeCurrentRecordColor of the Theme
    /// ThemeCurrentRecordColor الخاص بـ Theme
    /// </summary>
    public string ThemeCurrentRecordColor { get; private set; }

    /// <summary>
    /// ThemePattern of the Theme
    /// ThemePattern الخاص بـ Theme
    /// </summary>
    public string ThemePattern { get; private set; }

    /// <summary>
    /// ThemeForegroundColor of the Theme
    /// ThemeForegroundColor الخاص بـ Theme
    /// </summary>
    public string ThemeForegroundColor { get; private set; }

    /// <summary>
    /// ThemeTextBackgroundData of the Theme
    /// ThemeTextBackgroundData الخاص بـ Theme
    /// </summary>
    public string ThemeTextBackgroundData { get; private set; }

    /// <summary>
    /// ThemeTextBackgroundUser of the Theme
    /// ThemeTextBackgroundUser الخاص بـ Theme
    /// </summary>
    public string ThemeTextBackgroundUser { get; private set; }

    /// <summary>
    /// ThemeFlag of the Theme
    /// ThemeFlag الخاص بـ Theme
    /// </summary>
    public decimal? ThemeFlag { get; private set; }
}
}
