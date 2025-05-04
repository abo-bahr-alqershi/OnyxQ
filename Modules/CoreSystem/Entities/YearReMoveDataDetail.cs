using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// YearReMoveDataDetail Entity
/// </summary>
public class YearReMoveDataDetail : Entity<YearReMoveDataDetailId>
{
    private YearReMoveDataDetail() { }

    /// <summary>
    /// The unique identifier for the YearReMoveDataDetail
    /// المعرف الفريد لـ YearReMoveDataDetail
    /// </summary>
    public YearReMoveDataDetailId Id { get; private set; }

    /// <summary>
    /// OrderNumber of the YearReMoveDataDetail
    /// OrderNumber الخاص بـ YearReMoveDataDetail
    /// </summary>
    public decimal? OrderNumber { get; private set; }

    /// <summary>
    /// IasUser of the YearReMoveDataDetail
    /// IasUser الخاص بـ YearReMoveDataDetail
    /// </summary>
    public string IasUser { get; private set; }

    /// <summary>
    /// TableNameMaster of the YearReMoveDataDetail
    /// TableNameMaster الخاص بـ YearReMoveDataDetail
    /// </summary>
    public string TableNameMaster { get; private set; }

    /// <summary>
    /// TableNameShort of the YearReMoveDataDetail
    /// TableNameShort الخاص بـ YearReMoveDataDetail
    /// </summary>
    public string TableNameShort { get; private set; }

    /// <summary>
    /// BasicWhere of the YearReMoveDataDetail
    /// BasicWhere الخاص بـ YearReMoveDataDetail
    /// </summary>
    public string BasicWhere { get; private set; }

    /// <summary>
    /// RemoveFlag of the YearReMoveDataDetail
    /// RemoveFlag الخاص بـ YearReMoveDataDetail
    /// </summary>
    public decimal? RemoveFlag { get; private set; }

    /// <summary>
    /// RemoveUserId of the YearReMoveDataDetail
    /// RemoveUserId الخاص بـ YearReMoveDataDetail
    /// </summary>
    public decimal? RemoveUserId { get; private set; }

    /// <summary>
    /// RemoveDate of the YearReMoveDataDetail
    /// RemoveDate الخاص بـ YearReMoveDataDetail
    /// </summary>
    public DateTime? RemoveDate { get; private set; }

    /// <summary>
    /// RemoveCount of the YearReMoveDataDetail
    /// RemoveCount الخاص بـ YearReMoveDataDetail
    /// </summary>
    public decimal? RemoveCount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to YearReMoveDataMaster
    /// </summary>
    public YearReMoveDataMaster YearReMoveDataMaster { get; private set; }
    #endregion
}
}
