using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// LowLimitPeriodStock Entity
/// </summary>
public class LowLimitPeriodStock : Entity<LowLimitPeriodStockId>
{
    private LowLimitPeriodStock() { }

    /// <summary>
    /// The unique identifier for the LowLimitPeriodStock
    /// المعرف الفريد لـ LowLimitPeriodStock
    /// </summary>
    public LowLimitPeriodStockId Id { get; private set; }

    /// <summary>
    /// PeriodType of the LowLimitPeriodStock
    /// PeriodType الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? PeriodType { get; private set; }

    /// <summary>
    /// PeriodCode of the LowLimitPeriodStock
    /// PeriodCode الخاص بـ LowLimitPeriodStock
    /// </summary>
    public string PeriodCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the LowLimitPeriodStock
    /// WarehouseCode الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// PeriodDay of the LowLimitPeriodStock
    /// PeriodDay الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? PeriodDay { get; private set; }

    /// <summary>
    /// AverageDay of the LowLimitPeriodStock
    /// AverageDay الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? AverageDay { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the LowLimitPeriodStock
    /// CompanyNumberShort الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the LowLimitPeriodStock
    /// BranchNumber الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the LowLimitPeriodStock
    /// BranchYear الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the LowLimitPeriodStock
    /// BranchUser الخاص بـ LowLimitPeriodStock
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
