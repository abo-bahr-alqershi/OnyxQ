using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// ReceiptWatch Entity
/// </summary>
public class ReceiptWatch : Entity<ReceiptWatchId>
{

    private ReceiptWatch() { }

    public ReceiptWatch(ReceiptWatchId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the ReceiptWatch
    /// المعرف الفريد لـ ReceiptWatch
    /// </summary>
    public ReceiptWatchId Id { get; private set; }

    /// <summary>
    /// DocNo of the ReceiptWatch
    /// DocNo الخاص بـ ReceiptWatch
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// RecordNumber of the ReceiptWatch
    /// RecordNumber الخاص بـ ReceiptWatch
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// WatchDate of the ReceiptWatch
    /// WatchDate الخاص بـ ReceiptWatch
    /// </summary>
    public DateTime? WatchDate { get; private set; }

    /// <summary>
    /// WatchDescription of the ReceiptWatch
    /// WatchDescription الخاص بـ ReceiptWatch
    /// </summary>
    public string WatchDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReceiptWatch
    /// CompanyNumberShort الخاص بـ ReceiptWatch
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ReceiptWatch
    /// BranchNumber الخاص بـ ReceiptWatch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ReceiptWatch
    /// BranchYear الخاص بـ ReceiptWatch
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ReceiptWatch
    /// BranchUser الخاص بـ ReceiptWatch
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ReceiptDocument ReceiptDocument { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

