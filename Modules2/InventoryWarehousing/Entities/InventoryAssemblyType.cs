using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryAssemblyType Entity
/// </summary>
public class InventoryAssemblyType : Entity<InventoryAssemblyTypeId>
{

    private InventoryAssemblyType() { }

    public InventoryAssemblyType(InventoryAssemblyTypeId id, decimal? typeNumberShort)
    {
        Id = id;
        TypeNumberShort = typeNumberShort;
    }

    /// <summary>
    /// The unique identifier for the InventoryAssemblyType
    /// المعرف الفريد لـ InventoryAssemblyType
    /// </summary>
    public InventoryAssemblyTypeId Id { get; private set; }

    /// <summary>
    /// TypeNumberShort of the InventoryAssemblyType
    /// TypeNumberShort الخاص بـ InventoryAssemblyType
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// TypeLastNameShort of the InventoryAssemblyType
    /// TypeLastNameShort الخاص بـ InventoryAssemblyType
    /// </summary>
    public string TypeLastNameShort { get; private set; }

    /// <summary>
    /// TypeFirstNameShort of the InventoryAssemblyType
    /// TypeFirstNameShort الخاص بـ InventoryAssemblyType
    /// </summary>
    public string TypeFirstNameShort { get; private set; }

    /// <summary>
    /// TypeSerial of the InventoryAssemblyType
    /// TypeSerial الخاص بـ InventoryAssemblyType
    /// </summary>
    public decimal? TypeSerial { get; private set; }

    /// <summary>
    /// AssembleFlag of the InventoryAssemblyType
    /// AssembleFlag الخاص بـ InventoryAssemblyType
    /// </summary>
    public decimal? AssembleFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

