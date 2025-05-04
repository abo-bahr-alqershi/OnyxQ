using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// AlertDataTemp Entity
/// </summary>
public class AlertDataTemp : Entity<AlertDataTempId>
{

    private AlertDataTemp() { }

    public AlertDataTemp(AlertDataTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AlertDataTemp
    /// المعرف الفريد لـ AlertDataTemp
    /// </summary>
    public AlertDataTempId Id { get; private set; }

    /// <summary>
    /// AlertNumber of the AlertDataTemp
    /// AlertNumber الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? AlertNumber { get; private set; }

    /// <summary>
    /// MessageNumber of the AlertDataTemp
    /// MessageNumber الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? MessageNumber { get; private set; }

    /// <summary>
    /// LabelNumberShort of the AlertDataTemp
    /// LabelNumberShort الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }

    /// <summary>
    /// OrderNumberShort of the AlertDataTemp
    /// OrderNumberShort الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// UserId of the AlertDataTemp
    /// UserId الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// SystemNumber of the AlertDataTemp
    /// SystemNumber الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// AlertSelectDetail of the AlertDataTemp
    /// AlertSelectDetail الخاص بـ AlertDataTemp
    /// </summary>
    public string AlertSelectDetail { get; private set; }

    /// <summary>
    /// AlertSelectWhere of the AlertDataTemp
    /// AlertSelectWhere الخاص بـ AlertDataTemp
    /// </summary>
    public string AlertSelectWhere { get; private set; }

    /// <summary>
    /// AlertSelectOrder of the AlertDataTemp
    /// AlertSelectOrder الخاص بـ AlertDataTemp
    /// </summary>
    public string AlertSelectOrder { get; private set; }

    /// <summary>
    /// AlertHide of the AlertDataTemp
    /// AlertHide الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? AlertHide { get; private set; }

    /// <summary>
    /// AlertHideWhere of the AlertDataTemp
    /// AlertHideWhere الخاص بـ AlertDataTemp
    /// </summary>
    public string AlertHideWhere { get; private set; }

    /// <summary>
    /// ReportNameShort of the AlertDataTemp
    /// ReportNameShort الخاص بـ AlertDataTemp
    /// </summary>
    public string ReportNameShort { get; private set; }

    /// <summary>
    /// FieldCount of the AlertDataTemp
    /// FieldCount الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? FieldCount { get; private set; }

    /// <summary>
    /// FieldLabel of the AlertDataTemp
    /// FieldLabel الخاص بـ AlertDataTemp
    /// </summary>
    public string FieldLabel { get; private set; }

    /// <summary>
    /// FieldWidth of the AlertDataTemp
    /// FieldWidth الخاص بـ AlertDataTemp
    /// </summary>
    public string FieldWidth { get; private set; }

    /// <summary>
    /// FieldDirection of the AlertDataTemp
    /// FieldDirection الخاص بـ AlertDataTemp
    /// </summary>
    public string FieldDirection { get; private set; }

    /// <summary>
    /// AlertDay of the AlertDataTemp
    /// AlertDay الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? AlertDay { get; private set; }

    /// <summary>
    /// AlertCount of the AlertDataTemp
    /// AlertCount الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? AlertCount { get; private set; }

    /// <summary>
    /// AlertPeriodType of the AlertDataTemp
    /// AlertPeriodType الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? AlertPeriodType { get; private set; }

    /// <summary>
    /// MessageDescription of the AlertDataTemp
    /// MessageDescription الخاص بـ AlertDataTemp
    /// </summary>
    public string MessageDescription { get; private set; }

    /// <summary>
    /// DocTyp of the AlertDataTemp
    /// DocTyp الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// FormNumber of the AlertDataTemp
    /// FormNumber الخاص بـ AlertDataTemp
    /// </summary>
    public decimal? FormNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
