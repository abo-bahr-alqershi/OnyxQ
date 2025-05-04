using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryContractDetail Entity
/// </summary>
public class InventoryContractDetail : Entity<InventoryContractDetailId>
{

    private InventoryContractDetail() { }

    public InventoryContractDetail(InventoryContractDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InventoryContractDetail
    /// المعرف الفريد لـ InventoryContractDetail
    /// </summary>
    public InventoryContractDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the InventoryContractDetail
    /// DocNo الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocJvType of the InventoryContractDetail
    /// DocJvType الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// PumpOperatorNumber of the InventoryContractDetail
    /// PumpOperatorNumber الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? PumpOperatorNumber { get; private set; }

    /// <summary>
    /// PouringType of the InventoryContractDetail
    /// PouringType الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? PouringType { get; private set; }

    /// <summary>
    /// PumpNumber of the InventoryContractDetail
    /// PumpNumber الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? PumpNumber { get; private set; }

    /// <summary>
    /// LabService of the InventoryContractDetail
    /// LabService الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? LabService { get; private set; }

    /// <summary>
    /// LocationNumber of the InventoryContractDetail
    /// LocationNumber الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? LocationNumber { get; private set; }

    /// <summary>
    /// AgricultureType of the InventoryContractDetail
    /// AgricultureType الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? AgricultureType { get; private set; }

    /// <summary>
    /// WaterProofNumber of the InventoryContractDetail
    /// WaterProofNumber الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? WaterProofNumber { get; private set; }

    /// <summary>
    /// ScreedFlag of the InventoryContractDetail
    /// ScreedFlag الخاص بـ InventoryContractDetail
    /// </summary>
    public string ScreedFlag { get; private set; }

    /// <summary>
    /// StationNumber of the InventoryContractDetail
    /// StationNumber الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? StationNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryContractDetail
    /// CompanyNumberShort الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryContractDetail
    /// BranchNumber الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryContractDetail
    /// BranchYear الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryContractDetail
    /// BranchUser الخاص بـ InventoryContractDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CarNumber of the InventoryContractDetail
    /// CarNumber الخاص بـ InventoryContractDetail
    /// </summary>
    public string CarNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: OneToOne
    /// </summary>
    public OutgoingMaster OutgoingMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
