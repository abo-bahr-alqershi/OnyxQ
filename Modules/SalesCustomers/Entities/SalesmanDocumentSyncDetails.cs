using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanDocumentSyncDetails Entity
/// </summary>
public class SalesmanDocumentSyncDetails : Entity<SalesmanDocumentSyncDetailsId>
{
    private SalesmanDocumentSyncDetails() { }

    /// <summary>
    /// The unique identifier for the SalesmanDocumentSyncDetails
    /// المعرف الفريد لـ SalesmanDocumentSyncDetails
    /// </summary>
    public SalesmanDocumentSyncDetailsId Id { get; private set; }

    /// <summary>
    /// DocType of the SalesmanDocumentSyncDetails
    /// DocType الخاص بـ SalesmanDocumentSyncDetails
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// SyncMethod of the SalesmanDocumentSyncDetails
    /// SyncMethod الخاص بـ SalesmanDocumentSyncDetails
    /// </summary>
    public decimal? SyncMethod { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanDocumentSyncDetails
    /// RepCode الخاص بـ SalesmanDocumentSyncDetails
    /// </summary>
    public string RepCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion
}
}
