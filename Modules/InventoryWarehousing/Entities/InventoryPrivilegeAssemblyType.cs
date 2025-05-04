using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryPrivilegeAssemblyType Entity
/// </summary>
public class InventoryPrivilegeAssemblyType : Entity<InventoryPrivilegeAssemblyTypeId>
{
    private InventoryPrivilegeAssemblyType() { }

    /// <summary>
    /// The unique identifier for the InventoryPrivilegeAssemblyType
    /// المعرف الفريد لـ InventoryPrivilegeAssemblyType
    /// </summary>
    public InventoryPrivilegeAssemblyTypeId Id { get; private set; }

    /// <summary>
    /// UserId of the InventoryPrivilegeAssemblyType
    /// UserId الخاص بـ InventoryPrivilegeAssemblyType
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// TypeNumberShort of the InventoryPrivilegeAssemblyType
    /// TypeNumberShort الخاص بـ InventoryPrivilegeAssemblyType
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// AdditionalFlagShort of the InventoryPrivilegeAssemblyType
    /// AdditionalFlagShort الخاص بـ InventoryPrivilegeAssemblyType
    /// </summary>
    public decimal? AdditionalFlagShort { get; private set; }

    /// <summary>
    /// ViewFlagShort of the InventoryPrivilegeAssemblyType
    /// ViewFlagShort الخاص بـ InventoryPrivilegeAssemblyType
    /// </summary>
    public decimal? ViewFlagShort { get; private set; }
}
}
