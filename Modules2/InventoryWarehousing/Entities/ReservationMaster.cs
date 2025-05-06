using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ReservationMaster Entity
/// </summary>
public class ReservationMaster : Entity<ReservationMasterId>
{

    private ReservationMaster() { }

    public ReservationMaster(ReservationMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the ReservationMaster
    /// المعرف الفريد لـ ReservationMaster
    /// </summary>
    public ReservationMasterId Id { get; private set; }

    /// <summary>
    /// DocType of the ReservationMaster
    /// DocType الخاص بـ ReservationMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the ReservationMaster
    /// DocNo الخاص بـ ReservationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ReservationMaster
    /// DocSer الخاص بـ ReservationMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// CCode of the ReservationMaster
    /// CCode الخاص بـ ReservationMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the ReservationMaster
    /// CostCenterCode الخاص بـ ReservationMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ReservationMaster
    /// ProjectNumber الخاص بـ ReservationMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ReservationMaster
    /// ActivityNumber الخاص بـ ReservationMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DocTypeRef of the ReservationMaster
    /// DocTypeRef الخاص بـ ReservationMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ReservationMaster
    /// DocNoRef الخاص بـ ReservationMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ReservationMaster
    /// DocSerRef الخاص بـ ReservationMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ReservationMaster
    /// ExternalPostFlag الخاص بـ ReservationMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// BranchNumber of the ReservationMaster
    /// BranchNumber الخاص بـ ReservationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ReservationMaster
    /// CompanyNumberShort الخاص بـ ReservationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the ReservationMaster
    /// BranchUser الخاص بـ ReservationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the ReservationMaster
    /// BranchYear الخاص بـ ReservationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

