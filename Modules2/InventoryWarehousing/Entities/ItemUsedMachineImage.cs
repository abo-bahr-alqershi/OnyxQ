using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemUsedMachineImage Entity
/// </summary>
public class ItemUsedMachineImage : Entity<ItemUsedMachineImageId>
{

    private ItemUsedMachineImage() { }

    public ItemUsedMachineImage(ItemUsedMachineImageId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the ItemUsedMachineImage
    /// المعرف الفريد لـ ItemUsedMachineImage
    /// </summary>
    public ItemUsedMachineImageId Id { get; private set; }

    /// <summary>
    /// ImageName of the ItemUsedMachineImage
    /// ImageName الخاص بـ ItemUsedMachineImage
    /// </summary>
    public string ImageName { get; private set; }

    /// <summary>
    /// RecordNumber of the ItemUsedMachineImage
    /// RecordNumber الخاص بـ ItemUsedMachineImage
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemUsedMachine ItemUsedMachine { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

