using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// MissingEquityMasterTemp Entity
/// </summary>
public class MissingEquityMasterTemp : Entity<MissingEquityMasterTempId>
{

    private MissingEquityMasterTemp() { }

    public MissingEquityMasterTemp(MissingEquityMasterTempId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the MissingEquityMasterTemp
    /// المعرف الفريد لـ MissingEquityMasterTemp
    /// </summary>
    public MissingEquityMasterTempId Id { get; private set; }

    /// <summary>
    /// DocNo of the MissingEquityMasterTemp
    /// DocNo الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the MissingEquityMasterTemp
    /// DocType الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocSer of the MissingEquityMasterTemp
    /// DocSer الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the MissingEquityMasterTemp
    /// DocDate الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDesc of the MissingEquityMasterTemp
    /// DocDesc الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the MissingEquityMasterTemp
    /// ProcessedFlagFull الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the MissingEquityMasterTemp
    /// CompanyNumberShort الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the MissingEquityMasterTemp
    /// BranchNumber الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the MissingEquityMasterTemp
    /// BranchYear الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the MissingEquityMasterTemp
    /// BranchUser الخاص بـ MissingEquityMasterTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
