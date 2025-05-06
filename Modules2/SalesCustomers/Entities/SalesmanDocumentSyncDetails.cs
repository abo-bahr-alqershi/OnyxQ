using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanDocumentSyncDetails Entity
/// </summary>
public class SalesmanDocumentSyncDetails : Entity<SalesmanDocumentSyncDetailsId>
{

    private SalesmanDocumentSyncDetails() { }

    public SalesmanDocumentSyncDetails(SalesmanDocumentSyncDetailsId id, decimal? docType)
    {
        Id = id;
        DocType = docType;
    }

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

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

