using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// WarehouseGroup Entity
/// </summary>
public class WarehouseGroup : Entity<WarehouseGroupId>
{

    private WarehouseGroup() { }

    public WarehouseGroup(WarehouseGroupId id, decimal? warehouseGroupCode)
    {
        Id = id;
        WarehouseGroupCode = warehouseGroupCode;
    }

    /// <summary>
    /// The unique identifier for the WarehouseGroup
    /// المعرف الفريد لـ WarehouseGroup
    /// </summary>
    public WarehouseGroupId Id { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the WarehouseGroup
    /// WarehouseGroupCode الخاص بـ WarehouseGroup
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// WarehouseGroupNameArabic of the WarehouseGroup
    /// WarehouseGroupNameArabic الخاص بـ WarehouseGroup
    /// </summary>
    public string WarehouseGroupNameArabic { get; private set; }

    /// <summary>
    /// WarehouseGroupNameEnglish of the WarehouseGroup
    /// WarehouseGroupNameEnglish الخاص بـ WarehouseGroup
    /// </summary>
    public string WarehouseGroupNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
