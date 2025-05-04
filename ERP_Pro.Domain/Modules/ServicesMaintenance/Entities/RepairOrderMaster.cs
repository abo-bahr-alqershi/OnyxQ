using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Entities
{
/// <summary>
/// RepairOrderMaster Entity
/// </summary>
public class RepairOrderMaster : Entity<RepairOrderMasterId>
{

    private RepairOrderMaster() { }

    public RepairOrderMaster(RepairOrderMasterId id, decimal? regionSerial)
    {
        Id = id;
        RegionSerial = regionSerial;
    }

    /// <summary>
    /// The unique identifier for the RepairOrderMaster
    /// المعرف الفريد لـ RepairOrderMaster
    /// </summary>
    public RepairOrderMasterId Id { get; private set; }

    /// <summary>
    /// RegionNumberShort of the RepairOrderMaster
    /// RegionNumberShort الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? RegionNumberShort { get; private set; }

    /// <summary>
    /// RegionSerial of the RepairOrderMaster
    /// RegionSerial الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? RegionSerial { get; private set; }

    /// <summary>
    /// RegionDate of the RepairOrderMaster
    /// RegionDate الخاص بـ RepairOrderMaster
    /// </summary>
    public DateTime? RegionDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RepairOrderMaster
    /// ReferenceNumber الخاص بـ RepairOrderMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RegionDescription of the RepairOrderMaster
    /// RegionDescription الخاص بـ RepairOrderMaster
    /// </summary>
    public string RegionDescription { get; private set; }

    /// <summary>
    /// VendorCode of the RepairOrderMaster
    /// VendorCode الخاص بـ RepairOrderMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ExitFlag of the RepairOrderMaster
    /// ExitFlag الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? ExitFlag { get; private set; }

    /// <summary>
    /// EntryFlag of the RepairOrderMaster
    /// EntryFlag الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? EntryFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RepairOrderMaster
    /// CompanyNumberShort الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RepairOrderMaster
    /// BranchNumber الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RepairOrderMaster
    /// BranchYear الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RepairOrderMaster
    /// BranchUser الخاص بـ RepairOrderMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
