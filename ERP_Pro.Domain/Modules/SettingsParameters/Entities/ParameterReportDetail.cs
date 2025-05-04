using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// ParameterReportDetail Entity
/// </summary>
public class ParameterReportDetail : Entity<ParameterReportDetailId>
{

    private ParameterReportDetail() { }

    public ParameterReportDetail(ParameterReportDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ParameterReportDetail
    /// المعرف الفريد لـ ParameterReportDetail
    /// </summary>
    public ParameterReportDetailId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterReportDetail
    /// ParameterNumber الخاص بـ ParameterReportDetail
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// CondType of the ParameterReportDetail
    /// CondType الخاص بـ ParameterReportDetail
    /// </summary>
    public string CondType { get; private set; }

    /// <summary>
    /// ColumnName of the ParameterReportDetail
    /// ColumnName الخاص بـ ParameterReportDetail
    /// </summary>
    public string ColumnName { get; private set; }

    /// <summary>
    /// Operator of the ParameterReportDetail
    /// Operator الخاص بـ ParameterReportDetail
    /// </summary>
    public string Operator { get; private set; }

    /// <summary>
    /// Value1 of the ParameterReportDetail
    /// Value1 الخاص بـ ParameterReportDetail
    /// </summary>
    public string Value1 { get; private set; }

    /// <summary>
    /// Value2 of the ParameterReportDetail
    /// Value2 الخاص بـ ParameterReportDetail
    /// </summary>
    public string Value2 { get; private set; }

    /// <summary>
    /// MustValue of the ParameterReportDetail
    /// MustValue الخاص بـ ParameterReportDetail
    /// </summary>
    public decimal? MustValue { get; private set; }

    /// <summary>
    /// ColumnType of the ParameterReportDetail
    /// ColumnType الخاص بـ ParameterReportDetail
    /// </summary>
    public string ColumnType { get; private set; }

    /// <summary>
    /// ColumnCommentShort of the ParameterReportDetail
    /// ColumnCommentShort الخاص بـ ParameterReportDetail
    /// </summary>
    public string ColumnCommentShort { get; private set; }

    /// <summary>
    /// RowCondition of the ParameterReportDetail
    /// RowCondition الخاص بـ ParameterReportDetail
    /// </summary>
    public string RowCondition { get; private set; }

    /// <summary>
    /// RowDescription of the ParameterReportDetail
    /// RowDescription الخاص بـ ParameterReportDetail
    /// </summary>
    public string RowDescription { get; private set; }

    /// <summary>
    /// RecordNumber of the ParameterReportDetail
    /// RecordNumber الخاص بـ ParameterReportDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the ParameterReportDetail
    /// BranchNumber الخاص بـ ParameterReportDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ParameterReportDetail
    /// BranchYear الخاص بـ ParameterReportDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ParameterReportDetail
    /// CompanyNumberShort الخاص بـ ParameterReportDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the ParameterReportDetail
    /// BranchUser الخاص بـ ParameterReportDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ParameterReportMaster ParameterReportMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
