using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryRequestAssemblyMaster Entity
/// </summary>
public class InventoryRequestAssemblyMaster : AggregateRoot<InventoryRequestAssemblyMasterId>
{

    private InventoryRequestAssemblyMaster() { }

    public InventoryRequestAssemblyMaster(InventoryRequestAssemblyMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the InventoryRequestAssemblyMaster
    /// المعرف الفريد لـ InventoryRequestAssemblyMaster
    /// </summary>
    public InventoryRequestAssemblyMasterId Id { get; private set; }

    /// <summary>
    /// TypeNumberShort of the InventoryRequestAssemblyMaster
    /// TypeNumberShort الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// DocNo of the InventoryRequestAssemblyMaster
    /// DocNo الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the InventoryRequestAssemblyMaster
    /// DocSer الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the InventoryRequestAssemblyMaster
    /// DocDate الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// WarehouseCode of the InventoryRequestAssemblyMaster
    /// WarehouseCode الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the InventoryRequestAssemblyMaster
    /// CostCenterCode الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the InventoryRequestAssemblyMaster
    /// ProjectNumber الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the InventoryRequestAssemblyMaster
    /// ActivityNumber الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DocDesc of the InventoryRequestAssemblyMaster
    /// DocDesc الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the InventoryRequestAssemblyMaster
    /// ReferenceNumber الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// Field1 of the InventoryRequestAssemblyMaster
    /// Field1 الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the InventoryRequestAssemblyMaster
    /// Field2 الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the InventoryRequestAssemblyMaster
    /// Field3 الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// ProcessFlag of the InventoryRequestAssemblyMaster
    /// ProcessFlag الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? ProcessFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the InventoryRequestAssemblyMaster
    /// ExternalPostFlag الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the InventoryRequestAssemblyMaster
    /// InactiveFlag الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the InventoryRequestAssemblyMaster
    /// InactivatedByUserId الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the InventoryRequestAssemblyMaster
    /// InactiveDate الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the InventoryRequestAssemblyMaster
    /// InactiveReason الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the InventoryRequestAssemblyMaster
    /// ApprovedFlag الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the InventoryRequestAssemblyMaster
    /// ApprovalUserId الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the InventoryRequestAssemblyMaster
    /// ApprovalDate الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the InventoryRequestAssemblyMaster
    /// ApprovalDescription الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InventoryRequestAssemblyMaster
    /// CompanyNumberShort الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the InventoryRequestAssemblyMaster
    /// BranchNumber الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the InventoryRequestAssemblyMaster
    /// BranchYear الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the InventoryRequestAssemblyMaster
    /// BranchUser الخاص بـ InventoryRequestAssemblyMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

