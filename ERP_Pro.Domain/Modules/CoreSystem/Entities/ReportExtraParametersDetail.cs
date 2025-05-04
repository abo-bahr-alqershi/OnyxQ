using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ReportExtraParametersDetail Entity
/// </summary>
public class ReportExtraParametersDetail : Entity<ReportExtraParametersDetailId>
{

    private ReportExtraParametersDetail() { }

    public ReportExtraParametersDetail(ReportExtraParametersDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ReportExtraParametersDetail
    /// المعرف الفريد لـ ReportExtraParametersDetail
    /// </summary>
    public ReportExtraParametersDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the ReportExtraParametersDetail
    /// DocNo الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// RecordNumber of the ReportExtraParametersDetail
    /// RecordNumber الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// JoinOperator of the ReportExtraParametersDetail
    /// JoinOperator الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public string JoinOperator { get; private set; }

    /// <summary>
    /// ColumnNameShort of the ReportExtraParametersDetail
    /// ColumnNameShort الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public string ColumnNameShort { get; private set; }

    /// <summary>
    /// ColumnComment of the ReportExtraParametersDetail
    /// ColumnComment الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public string ColumnComment { get; private set; }

    /// <summary>
    /// ColumnTypeShort of the ReportExtraParametersDetail
    /// ColumnTypeShort الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public string ColumnTypeShort { get; private set; }

    /// <summary>
    /// OperatorShort of the ReportExtraParametersDetail
    /// OperatorShort الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public string OperatorShort { get; private set; }

    /// <summary>
    /// NoValue of the ReportExtraParametersDetail
    /// NoValue الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public decimal? NoValue { get; private set; }

    /// <summary>
    /// Value1 of the ReportExtraParametersDetail
    /// Value1 الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public string Value1 { get; private set; }

    /// <summary>
    /// Value2 of the ReportExtraParametersDetail
    /// Value2 الخاص بـ ReportExtraParametersDetail
    /// </summary>
    public string Value2 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ReportExtraParametersMaster ReportExtraParametersMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
