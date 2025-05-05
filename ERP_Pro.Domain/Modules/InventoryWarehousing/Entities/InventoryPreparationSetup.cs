using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryPreparationSetup Entity
/// </summary>
public class InventoryPreparationSetup : Entity<InventoryPreparationSetupId>
{

    private InventoryPreparationSetup() { }

    public InventoryPreparationSetup(InventoryPreparationSetupId id, decimal? typeNumberShort)
    {
        Id = id;
        TypeNumberShort = typeNumberShort;
    }

    /// <summary>
    /// The unique identifier for the InventoryPreparationSetup
    /// المعرف الفريد لـ InventoryPreparationSetup
    /// </summary>
    public InventoryPreparationSetupId Id { get; private set; }

    /// <summary>
    /// DocType of the InventoryPreparationSetup
    /// DocType الخاص بـ InventoryPreparationSetup
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// TypeNumberShort of the InventoryPreparationSetup
    /// TypeNumberShort الخاص بـ InventoryPreparationSetup
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// LabelNumberShort of the InventoryPreparationSetup
    /// LabelNumberShort الخاص بـ InventoryPreparationSetup
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }

    /// <summary>
    /// TypeName of the InventoryPreparationSetup
    /// TypeName الخاص بـ InventoryPreparationSetup
    /// </summary>
    public string TypeName { get; private set; }

    /// <summary>
    /// PriceTypeFull of the InventoryPreparationSetup
    /// PriceTypeFull الخاص بـ InventoryPreparationSetup
    /// </summary>
    public decimal? PriceTypeFull { get; private set; }

    /// <summary>
    /// OrderNumberShort of the InventoryPreparationSetup
    /// OrderNumberShort الخاص بـ InventoryPreparationSetup
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// UseCheckBeforeApproved of the InventoryPreparationSetup
    /// UseCheckBeforeApproved الخاص بـ InventoryPreparationSetup
    /// </summary>
    public decimal? UseCheckBeforeApproved { get; private set; }

    /// <summary>
    /// AllowPreparationPartly of the InventoryPreparationSetup
    /// AllowPreparationPartly الخاص بـ InventoryPreparationSetup
    /// </summary>
    public decimal? AllowPreparationPartly { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

