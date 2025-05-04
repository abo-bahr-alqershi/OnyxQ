using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// DeviceTypes Entity
/// </summary>
public class DeviceTypes : Entity<DeviceTypesId>
{
    private DeviceTypes() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: DeviceTypes to ReceiptDocument
    /// </summary>
    public IReadOnlyCollection<ReceiptDocument> ReceiptDocuments { get; private set; }
    #endregion
}
}
