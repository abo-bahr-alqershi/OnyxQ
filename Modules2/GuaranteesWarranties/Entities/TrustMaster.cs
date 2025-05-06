using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;
namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// TrustMaster Entity
/// </summary>
public class TrustMaster : Entity<TrustMasterId>
{

    private TrustMaster() { }

    public TrustMaster(TrustMasterId id, decimal? trustSerial)
    {
        Id = id;
        TrustSerial = trustSerial;
    }

    /// <summary>
    /// The unique identifier for the TrustMaster
    /// المعرف الفريد لـ TrustMaster
    /// </summary>
    public TrustMasterId Id { get; private set; }

    /// <summary>
    /// TrustNumber of the TrustMaster
    /// TrustNumber الخاص بـ TrustMaster
    /// </summary>
    public decimal? TrustNumber { get; private set; }

    /// <summary>
    /// TrustSerial of the TrustMaster
    /// TrustSerial الخاص بـ TrustMaster
    /// </summary>
    public decimal? TrustSerial { get; private set; }

    /// <summary>
    /// TrustDate of the TrustMaster
    /// TrustDate الخاص بـ TrustMaster
    /// </summary>
    public DateTime? TrustDate { get; private set; }

    /// <summary>
    /// AccountDescription of the TrustMaster
    /// AccountDescription الخاص بـ TrustMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the TrustMaster
    /// ReferenceNumber الخاص بـ TrustMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// EmpNo of the TrustMaster
    /// EmpNo الخاص بـ TrustMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// WarehouseCode of the TrustMaster
    /// WarehouseCode الخاص بـ TrustMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the TrustMaster
    /// ProcessedFlagFull الخاص بـ TrustMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TrustMaster
    /// CompanyNumberShort الخاص بـ TrustMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TrustMaster
    /// BranchNumber الخاص بـ TrustMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TrustMaster
    /// BranchYear الخاص بـ TrustMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TrustMaster
    /// BranchUser الخاص بـ TrustMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

