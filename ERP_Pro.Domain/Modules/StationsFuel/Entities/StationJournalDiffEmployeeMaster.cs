using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationJournalDiffEmployeeMaster Entity
/// </summary>
public class StationJournalDiffEmployeeMaster : Entity<StationJournalDiffEmployeeMasterId>
{

    private StationJournalDiffEmployeeMaster() { }

    public StationJournalDiffEmployeeMaster(StationJournalDiffEmployeeMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the StationJournalDiffEmployeeMaster
    /// المعرف الفريد لـ StationJournalDiffEmployeeMaster
    /// </summary>
    public StationJournalDiffEmployeeMasterId Id { get; private set; }

    /// <summary>
    /// DocSer of the StationJournalDiffEmployeeMaster
    /// DocSer الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocNo of the StationJournalDiffEmployeeMaster
    /// DocNo الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the StationJournalDiffEmployeeMaster
    /// DocDate الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ProcessedFlag of the StationJournalDiffEmployeeMaster
    /// ProcessedFlag الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationJournalDiffEmployeeMaster
    /// CompanyNumberShort الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationJournalDiffEmployeeMaster
    /// BranchNumber الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationJournalDiffEmployeeMaster
    /// BranchYear الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationJournalDiffEmployeeMaster
    /// BranchUser الخاص بـ StationJournalDiffEmployeeMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
