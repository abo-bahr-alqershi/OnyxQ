using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ScreenCss Entity
/// </summary>
public class ScreenCss : Entity<ScreenCssId>
{
    private ScreenCss() { }

    /// <summary>
    /// The unique identifier for the ScreenCss
    /// المعرف الفريد لـ ScreenCss
    /// </summary>
    public ScreenCssId Id { get; private set; }

    /// <summary>
    /// SystemNumber of the ScreenCss
    /// SystemNumber الخاص بـ ScreenCss
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// ScreenNumber of the ScreenCss
    /// ScreenNumber الخاص بـ ScreenCss
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// LabelNumber of the ScreenCss
    /// LabelNumber الخاص بـ ScreenCss
    /// </summary>
    public decimal? LabelNumber { get; private set; }

    /// <summary>
    /// ScreenParentNumberShort of the ScreenCss
    /// ScreenParentNumberShort الخاص بـ ScreenCss
    /// </summary>
    public decimal? ScreenParentNumberShort { get; private set; }

    /// <summary>
    /// InactiveFlag of the ScreenCss
    /// InactiveFlag الخاص بـ ScreenCss
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// DfltFlg of the ScreenCss
    /// DfltFlg الخاص بـ ScreenCss
    /// </summary>
    public decimal? DfltFlg { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ScreenCss
    /// OrderNumberShort الخاص بـ ScreenCss
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// ScreenType of the ScreenCss
    /// ScreenType الخاص بـ ScreenCss
    /// </summary>
    public decimal? ScreenType { get; private set; }

    /// <summary>
    /// FileNameShort of the ScreenCss
    /// FileNameShort الخاص بـ ScreenCss
    /// </summary>
    public string FileNameShort { get; private set; }

    /// <summary>
    /// ScreenIcon of the ScreenCss
    /// ScreenIcon الخاص بـ ScreenCss
    /// </summary>
    public string ScreenIcon { get; private set; }

    /// <summary>
    /// ScreenColor of the ScreenCss
    /// ScreenColor الخاص بـ ScreenCss
    /// </summary>
    public string ScreenColor { get; private set; }
}
}
