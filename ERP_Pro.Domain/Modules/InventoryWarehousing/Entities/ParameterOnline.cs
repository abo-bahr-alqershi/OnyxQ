using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ParameterOnline Entity
/// </summary>
public class ParameterOnline : Entity<ParameterOnlineId>
{

    private ParameterOnline() { }

    public ParameterOnline(ParameterOnlineId id, decimal? parameterNumber, decimal? showSystemType)
    {
        Id = id;
        ParameterNumber = parameterNumber;
        ShowSystemType = showSystemType;
    }

    /// <summary>
    /// The unique identifier for the ParameterOnline
    /// المعرف الفريد لـ ParameterOnline
    /// </summary>
    public ParameterOnlineId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParameterOnline
    /// ParameterNumber الخاص بـ ParameterOnline
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// CurCode of the ParameterOnline
    /// CurCode الخاص بـ ParameterOnline
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// SalesOrderExpireAfterDay of the ParameterOnline
    /// SalesOrderExpireAfterDay الخاص بـ ParameterOnline
    /// </summary>
    public decimal? SalesOrderExpireAfterDay { get; private set; }

    /// <summary>
    /// ShowOldPrice of the ParameterOnline
    /// ShowOldPrice الخاص بـ ParameterOnline
    /// </summary>
    public decimal? ShowOldPrice { get; private set; }

    /// <summary>
    /// AutoApproved of the ParameterOnline
    /// AutoApproved الخاص بـ ParameterOnline
    /// </summary>
    public decimal? AutoApproved { get; private set; }

    /// <summary>
    /// ReservedPeriodDay of the ParameterOnline
    /// ReservedPeriodDay الخاص بـ ParameterOnline
    /// </summary>
    public decimal? ReservedPeriodDay { get; private set; }

    /// <summary>
    /// ConnectionWarehouseMethod of the ParameterOnline
    /// ConnectionWarehouseMethod الخاص بـ ParameterOnline
    /// </summary>
    public decimal? ConnectionWarehouseMethod { get; private set; }

    /// <summary>
    /// WebServiceKey of the ParameterOnline
    /// WebServiceKey الخاص بـ ParameterOnline
    /// </summary>
    public string WebServiceKey { get; private set; }

    /// <summary>
    /// ShowSystemType of the ParameterOnline
    /// ShowSystemType الخاص بـ ParameterOnline
    /// </summary>
    public decimal? ShowSystemType { get; private set; }

    /// <summary>
    /// UpdateApiUrl of the ParameterOnline
    /// UpdateApiUrl الخاص بـ ParameterOnline
    /// </summary>
    public string UpdateApiUrl { get; private set; }

    /// <summary>
    /// UseAutoUpdate of the ParameterOnline
    /// UseAutoUpdate الخاص بـ ParameterOnline
    /// </summary>
    public decimal? UseAutoUpdate { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
