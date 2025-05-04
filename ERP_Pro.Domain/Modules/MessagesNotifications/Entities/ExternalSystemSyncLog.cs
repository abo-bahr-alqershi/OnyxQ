using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// ExternalSystemSyncLog Entity
/// </summary>
public class ExternalSystemSyncLog : Entity<ExternalSystemSyncLogId>
{

    private ExternalSystemSyncLog() { }

    public ExternalSystemSyncLog(ExternalSystemSyncLogId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ExternalSystemSyncLog
    /// المعرف الفريد لـ ExternalSystemSyncLog
    /// </summary>
    public ExternalSystemSyncLogId Id { get; private set; }

    /// <summary>
    /// SequenceNumber of the ExternalSystemSyncLog
    /// SequenceNumber الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public decimal? SequenceNumber { get; private set; }

    /// <summary>
    /// FSystemNumber of the ExternalSystemSyncLog
    /// FSystemNumber الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public decimal? FSystemNumber { get; private set; }

    /// <summary>
    /// Url of the ExternalSystemSyncLog
    /// Url الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public string Url { get; private set; }

    /// <summary>
    /// CallScreen of the ExternalSystemSyncLog
    /// CallScreen الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public string CallScreen { get; private set; }

    /// <summary>
    /// RequestBody of the ExternalSystemSyncLog
    /// RequestBody الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public string RequestBody { get; private set; }

    /// <summary>
    /// ResponseBody of the ExternalSystemSyncLog
    /// ResponseBody الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public string ResponseBody { get; private set; }

    /// <summary>
    /// HttpCode of the ExternalSystemSyncLog
    /// HttpCode الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public decimal? HttpCode { get; private set; }

    /// <summary>
    /// LogDate of the ExternalSystemSyncLog
    /// LogDate الخاص بـ ExternalSystemSyncLog
    /// </summary>
    public DateTime? LogDate { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
