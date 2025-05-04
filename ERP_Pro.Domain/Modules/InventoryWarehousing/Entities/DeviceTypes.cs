using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// DeviceTypes Entity
/// </summary>
public class DeviceTypes : Entity<DeviceTypesId>
{

    private DeviceTypes() { }

    public DeviceTypes(DeviceTypesId id, decimal? dvTypeNo)
    {
        Id = id;
        DvTypeNo = dvTypeNo;
    }

    /// <summary>
    /// The unique identifier for the DeviceTypes
    /// المعرف الفريد لـ DeviceTypes
    /// </summary>
    public DeviceTypesId Id { get; private set; }

    /// <summary>
    /// DvTypeNo of the DeviceTypes
    /// DvTypeNo الخاص بـ DeviceTypes
    /// </summary>
    public decimal? DvTypeNo { get; private set; }

    /// <summary>
    /// DvAName of the DeviceTypes
    /// DvAName الخاص بـ DeviceTypes
    /// </summary>
    public string DvAName { get; private set; }

    /// <summary>
    /// DvEName of the DeviceTypes
    /// DvEName الخاص بـ DeviceTypes
    /// </summary>
    public string DvEName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
