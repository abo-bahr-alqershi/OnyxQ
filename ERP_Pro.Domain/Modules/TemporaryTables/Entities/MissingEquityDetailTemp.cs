using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// MissingEquityDetailTemp Entity
/// </summary>
public class MissingEquityDetailTemp : Entity<MissingEquityDetailTempId>
{

    private MissingEquityDetailTemp() { }

    public MissingEquityDetailTemp(MissingEquityDetailTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the MissingEquityDetailTemp
    /// المعرف الفريد لـ MissingEquityDetailTemp
    /// </summary>
    public MissingEquityDetailTempId Id { get; private set; }

    /// <summary>
    /// DocNo of the MissingEquityDetailTemp
    /// DocNo الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the MissingEquityDetailTemp
    /// DocType الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// ItemCode of the MissingEquityDetailTemp
    /// ItemCode الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the MissingEquityDetailTemp
    /// ItemUnit الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the MissingEquityDetailTemp
    /// PSize الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the MissingEquityDetailTemp
    /// ItemQuantity الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the MissingEquityDetailTemp
    /// PQuantity الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the MissingEquityDetailTemp
    /// CompanyNumberShort الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the MissingEquityDetailTemp
    /// BranchNumber الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the MissingEquityDetailTemp
    /// BranchYear الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the MissingEquityDetailTemp
    /// BranchUser الخاص بـ MissingEquityDetailTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public MissingEquityMasterTemp MissingEquityMasterTemp { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
