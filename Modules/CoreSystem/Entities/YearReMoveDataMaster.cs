using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// YearReMoveDataMaster Entity
/// </summary>
public class YearReMoveDataMaster : Entity<YearReMoveDataMasterId>
{
    private YearReMoveDataMaster() { }

    /// <summary>
    /// The unique identifier for the YearReMoveDataMaster
    /// المعرف الفريد لـ YearReMoveDataMaster
    /// </summary>
    public YearReMoveDataMasterId Id { get; private set; }

    /// <summary>
    /// OrderNumber of the YearReMoveDataMaster
    /// OrderNumber الخاص بـ YearReMoveDataMaster
    /// </summary>
    public decimal? OrderNumber { get; private set; }

    /// <summary>
    /// FormNumber of the YearReMoveDataMaster
    /// FormNumber الخاص بـ YearReMoveDataMaster
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// IasUser of the YearReMoveDataMaster
    /// IasUser الخاص بـ YearReMoveDataMaster
    /// </summary>
    public string IasUser { get; private set; }

    /// <summary>
    /// TableNameShort of the YearReMoveDataMaster
    /// TableNameShort الخاص بـ YearReMoveDataMaster
    /// </summary>
    public string TableNameShort { get; private set; }

    /// <summary>
    /// BasicWhere of the YearReMoveDataMaster
    /// BasicWhere الخاص بـ YearReMoveDataMaster
    /// </summary>
    public string BasicWhere { get; private set; }

    /// <summary>
    /// RowCount of the YearReMoveDataMaster
    /// RowCount الخاص بـ YearReMoveDataMaster
    /// </summary>
    public decimal? RowCount { get; private set; }

    /// <summary>
    /// InactiveFlagShort of the YearReMoveDataMaster
    /// InactiveFlagShort الخاص بـ YearReMoveDataMaster
    /// </summary>
    public decimal? InactiveFlagShort { get; private set; }

    /// <summary>
    /// InactiveColumnName of the YearReMoveDataMaster
    /// InactiveColumnName الخاص بـ YearReMoveDataMaster
    /// </summary>
    public string InactiveColumnName { get; private set; }

    /// <summary>
    /// InactiveListName of the YearReMoveDataMaster
    /// InactiveListName الخاص بـ YearReMoveDataMaster
    /// </summary>
    public string InactiveListName { get; private set; }

    /// <summary>
    /// InactiveListSelect of the YearReMoveDataMaster
    /// InactiveListSelect الخاص بـ YearReMoveDataMaster
    /// </summary>
    public string InactiveListSelect { get; private set; }

    /// <summary>
    /// RemoveFlag of the YearReMoveDataMaster
    /// RemoveFlag الخاص بـ YearReMoveDataMaster
    /// </summary>
    public decimal? RemoveFlag { get; private set; }

    /// <summary>
    /// RemoveUserId of the YearReMoveDataMaster
    /// RemoveUserId الخاص بـ YearReMoveDataMaster
    /// </summary>
    public decimal? RemoveUserId { get; private set; }

    /// <summary>
    /// RemoveDate of the YearReMoveDataMaster
    /// RemoveDate الخاص بـ YearReMoveDataMaster
    /// </summary>
    public DateTime? RemoveDate { get; private set; }

    /// <summary>
    /// RemoveCount of the YearReMoveDataMaster
    /// RemoveCount الخاص بـ YearReMoveDataMaster
    /// </summary>
    public decimal? RemoveCount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: YearReMoveDataMaster to YearReMoveDataDetail
    /// </summary>
    public IReadOnlyCollection<YearReMoveDataDetail> YearReMoveDataDetails { get; private set; }
    #endregion
}
}
