using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryItemExceedLimitCostPrivilege Entity
/// </summary>
public class InventoryItemExceedLimitCostPrivilege : Entity<InventoryItemExceedLimitCostPrivilegeId>
{
    private InventoryItemExceedLimitCostPrivilege() { }

    /// <summary>
    /// The unique identifier for the InventoryItemExceedLimitCostPrivilege
    /// المعرف الفريد لـ InventoryItemExceedLimitCostPrivilege
    /// </summary>
    public InventoryItemExceedLimitCostPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the InventoryItemExceedLimitCostPrivilege
    /// UserId الخاص بـ InventoryItemExceedLimitCostPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// ItemCode of the InventoryItemExceedLimitCostPrivilege
    /// ItemCode الخاص بـ InventoryItemExceedLimitCostPrivilege
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ExceedPercent of the InventoryItemExceedLimitCostPrivilege
    /// ExceedPercent الخاص بـ InventoryItemExceedLimitCostPrivilege
    /// </summary>
    public decimal? ExceedPercent { get; private set; }
}
}
