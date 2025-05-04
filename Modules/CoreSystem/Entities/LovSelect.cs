using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// LovSelect Entity
/// </summary>
public class LovSelect : Entity<LovSelectId>
{
    private LovSelect() { }

    /// <summary>
    /// The unique identifier for the LovSelect
    /// المعرف الفريد لـ LovSelect
    /// </summary>
    public LovSelectId Id { get; private set; }

    /// <summary>
    /// LovNumber of the LovSelect
    /// LovNumber الخاص بـ LovSelect
    /// </summary>
    public decimal? LovNumber { get; private set; }

    /// <summary>
    /// LovName of the LovSelect
    /// LovName الخاص بـ LovSelect
    /// </summary>
    public string LovName { get; private set; }

    /// <summary>
    /// LovLabelNumber of the LovSelect
    /// LovLabelNumber الخاص بـ LovSelect
    /// </summary>
    public decimal? LovLabelNumber { get; private set; }

    /// <summary>
    /// LovSql of the LovSelect
    /// LovSql الخاص بـ LovSelect
    /// </summary>
    public string LovSql { get; private set; }

    /// <summary>
    /// LovPrevious of the LovSelect
    /// LovPrevious الخاص بـ LovSelect
    /// </summary>
    public string LovPrevious { get; private set; }

    /// <summary>
    /// GroupByShort of the LovSelect
    /// GroupByShort الخاص بـ LovSelect
    /// </summary>
    public string GroupByShort { get; private set; }

    /// <summary>
    /// LovColumnCount of the LovSelect
    /// LovColumnCount الخاص بـ LovSelect
    /// </summary>
    public decimal? LovColumnCount { get; private set; }

    /// <summary>
    /// LovColumnLabel of the LovSelect
    /// LovColumnLabel الخاص بـ LovSelect
    /// </summary>
    public string LovColumnLabel { get; private set; }

    /// <summary>
    /// LovColumnWidth of the LovSelect
    /// LovColumnWidth الخاص بـ LovSelect
    /// </summary>
    public string LovColumnWidth { get; private set; }

    /// <summary>
    /// LovColumnHide of the LovSelect
    /// LovColumnHide الخاص بـ LovSelect
    /// </summary>
    public string LovColumnHide { get; private set; }

    /// <summary>
    /// DfltOrdr of the LovSelect
    /// DfltOrdr الخاص بـ LovSelect
    /// </summary>
    public string DfltOrdr { get; private set; }

    /// <summary>
    /// LovColumnLeftToRight of the LovSelect
    /// LovColumnLeftToRight الخاص بـ LovSelect
    /// </summary>
    public string LovColumnLeftToRight { get; private set; }

    /// <summary>
    /// LovColumnRightToLeft of the LovSelect
    /// LovColumnRightToLeft الخاص بـ LovSelect
    /// </summary>
    public string LovColumnRightToLeft { get; private set; }

    /// <summary>
    /// ReportDependentWhere of the LovSelect
    /// ReportDependentWhere الخاص بـ LovSelect
    /// </summary>
    public string ReportDependentWhere { get; private set; }

    /// <summary>
    /// ReportReturnColumn of the LovSelect
    /// ReportReturnColumn الخاص بـ LovSelect
    /// </summary>
    public string ReportReturnColumn { get; private set; }

    /// <summary>
    /// LovSpecialFlag of the LovSelect
    /// LovSpecialFlag الخاص بـ LovSelect
    /// </summary>
    public decimal? LovSpecialFlag { get; private set; }
}
}
