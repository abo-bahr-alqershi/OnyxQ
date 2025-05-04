using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// MoveDataYearErrorLog Entity
/// </summary>
public class MoveDataYearErrorLog : Entity<MoveDataYearErrorLogId>
{
    private MoveDataYearErrorLog() { }

    /// <summary>
    /// The unique identifier for the MoveDataYearErrorLog
    /// المعرف الفريد لـ MoveDataYearErrorLog
    /// </summary>
    public MoveDataYearErrorLogId Id { get; private set; }

    /// <summary>
    /// TableNameLabel of the MoveDataYearErrorLog
    /// TableNameLabel الخاص بـ MoveDataYearErrorLog
    /// </summary>
    public string TableNameLabel { get; private set; }

    /// <summary>
    /// ColumnsName of the MoveDataYearErrorLog
    /// ColumnsName الخاص بـ MoveDataYearErrorLog
    /// </summary>
    public string ColumnsName { get; private set; }

    /// <summary>
    /// SqlSelect of the MoveDataYearErrorLog
    /// SqlSelect الخاص بـ MoveDataYearErrorLog
    /// </summary>
    public string SqlSelect { get; private set; }

    /// <summary>
    /// SqlWhere of the MoveDataYearErrorLog
    /// SqlWhere الخاص بـ MoveDataYearErrorLog
    /// </summary>
    public string SqlWhere { get; private set; }

    /// <summary>
    /// SqlError of the MoveDataYearErrorLog
    /// SqlError الخاص بـ MoveDataYearErrorLog
    /// </summary>
    public string SqlError { get; private set; }
}
}
