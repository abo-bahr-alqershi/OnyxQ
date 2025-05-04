using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ScreenLabel Entity
/// </summary>
public class ScreenLabel : Entity<ScreenLabelId>
{
    private ScreenLabel() { }

    /// <summary>
    /// The unique identifier for the ScreenLabel
    /// المعرف الفريد لـ ScreenLabel
    /// </summary>
    public ScreenLabelId Id { get; private set; }

    /// <summary>
    /// LanguageNumber of the ScreenLabel
    /// LanguageNumber الخاص بـ ScreenLabel
    /// </summary>
    public decimal? LanguageNumber { get; private set; }

    /// <summary>
    /// FormNumber of the ScreenLabel
    /// FormNumber الخاص بـ ScreenLabel
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// ObjectNameShort of the ScreenLabel
    /// ObjectNameShort الخاص بـ ScreenLabel
    /// </summary>
    public string ObjectNameShort { get; private set; }

    /// <summary>
    /// FieldNameShort of the ScreenLabel
    /// FieldNameShort الخاص بـ ScreenLabel
    /// </summary>
    public string FieldNameShort { get; private set; }

    /// <summary>
    /// LabelText of the ScreenLabel
    /// LabelText الخاص بـ ScreenLabel
    /// </summary>
    public string LabelText { get; private set; }

    /// <summary>
    /// FieldNumber of the ScreenLabel
    /// FieldNumber الخاص بـ ScreenLabel
    /// </summary>
    public decimal? FieldNumber { get; private set; }
}
}
