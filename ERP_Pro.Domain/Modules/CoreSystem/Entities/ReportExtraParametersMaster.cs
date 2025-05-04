using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ReportExtraParametersMaster Entity
/// </summary>
public class ReportExtraParametersMaster : Entity<ReportExtraParametersMasterId>
{

    private ReportExtraParametersMaster() { }

    public ReportExtraParametersMaster(ReportExtraParametersMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the ReportExtraParametersMaster
    /// المعرف الفريد لـ ReportExtraParametersMaster
    /// </summary>
    public ReportExtraParametersMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the ReportExtraParametersMaster
    /// DocNo الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the ReportExtraParametersMaster
    /// DocSrl الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocDate of the ReportExtraParametersMaster
    /// DocDate الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FormNumber of the ReportExtraParametersMaster
    /// FormNumber الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// UserId of the ReportExtraParametersMaster
    /// UserId الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// DocUse of the ReportExtraParametersMaster
    /// DocUse الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public decimal? DocUse { get; private set; }

    /// <summary>
    /// DocDsc of the ReportExtraParametersMaster
    /// DocDsc الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// WhereSql of the ReportExtraParametersMaster
    /// WhereSql الخاص بـ ReportExtraParametersMaster
    /// </summary>
    public string WhereSql { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
