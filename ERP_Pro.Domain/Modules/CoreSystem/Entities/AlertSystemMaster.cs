using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// AlertSystemMaster Entity
/// </summary>
public class AlertSystemMaster : Entity<AlertSystemMasterId>
{

    private AlertSystemMaster() { }

    public AlertSystemMaster(AlertSystemMasterId id, decimal? alertNumber)
    {
        Id = id;
        AlertNumber = alertNumber;
    }

    /// <summary>
    /// The unique identifier for the AlertSystemMaster
    /// المعرف الفريد لـ AlertSystemMaster
    /// </summary>
    public AlertSystemMasterId Id { get; private set; }

    /// <summary>
    /// AlertNumber of the AlertSystemMaster
    /// AlertNumber الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? AlertNumber { get; private set; }

    /// <summary>
    /// AlertType of the AlertSystemMaster
    /// AlertType الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? AlertType { get; private set; }

    /// <summary>
    /// LabelNumberShort of the AlertSystemMaster
    /// LabelNumberShort الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }

    /// <summary>
    /// OrderNumberShort of the AlertSystemMaster
    /// OrderNumberShort الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// AlertDay of the AlertSystemMaster
    /// AlertDay الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? AlertDay { get; private set; }

    /// <summary>
    /// MessageNumber of the AlertSystemMaster
    /// MessageNumber الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? MessageNumber { get; private set; }

    /// <summary>
    /// SystemNumber of the AlertSystemMaster
    /// SystemNumber الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? SystemNumber { get; private set; }

    /// <summary>
    /// AlertSelect of the AlertSystemMaster
    /// AlertSelect الخاص بـ AlertSystemMaster
    /// </summary>
    public string AlertSelect { get; private set; }

    /// <summary>
    /// AlertAction of the AlertSystemMaster
    /// AlertAction الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? AlertAction { get; private set; }

    /// <summary>
    /// AlertPeriodType of the AlertSystemMaster
    /// AlertPeriodType الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? AlertPeriodType { get; private set; }

    /// <summary>
    /// AlertSelectWhere of the AlertSystemMaster
    /// AlertSelectWhere الخاص بـ AlertSystemMaster
    /// </summary>
    public string AlertSelectWhere { get; private set; }

    /// <summary>
    /// AlertSelectOrder of the AlertSystemMaster
    /// AlertSelectOrder الخاص بـ AlertSystemMaster
    /// </summary>
    public string AlertSelectOrder { get; private set; }

    /// <summary>
    /// InactiveFlag of the AlertSystemMaster
    /// InactiveFlag الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the AlertSystemMaster
    /// InactiveDate الخاص بـ AlertSystemMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AlertSystemMaster
    /// InactiveReason الخاص بـ AlertSystemMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AlertSystemMaster
    /// InactivatedByUserId الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// AlertStatus of the AlertSystemMaster
    /// AlertStatus الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? AlertStatus { get; private set; }

    /// <summary>
    /// AlertGroupBy of the AlertSystemMaster
    /// AlertGroupBy الخاص بـ AlertSystemMaster
    /// </summary>
    public string AlertGroupBy { get; private set; }

    /// <summary>
    /// AlertHide of the AlertSystemMaster
    /// AlertHide الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? AlertHide { get; private set; }

    /// <summary>
    /// AlertHideWhere of the AlertSystemMaster
    /// AlertHideWhere الخاص بـ AlertSystemMaster
    /// </summary>
    public string AlertHideWhere { get; private set; }

    /// <summary>
    /// ReportNameShort of the AlertSystemMaster
    /// ReportNameShort الخاص بـ AlertSystemMaster
    /// </summary>
    public string ReportNameShort { get; private set; }

    /// <summary>
    /// FormNumber of the AlertSystemMaster
    /// FormNumber الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// ShowAlertAfterLogin of the AlertSystemMaster
    /// ShowAlertAfterLogin الخاص بـ AlertSystemMaster
    /// </summary>
    public decimal? ShowAlertAfterLogin { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
