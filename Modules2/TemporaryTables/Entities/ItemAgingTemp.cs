using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// ItemAgingTemp Entity
/// </summary>
public class ItemAgingTemp : Entity<ItemAgingTempId>
{

    private ItemAgingTemp() { }

    public ItemAgingTemp(ItemAgingTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemAgingTemp
    /// المعرف الفريد لـ ItemAgingTemp
    /// </summary>
    public ItemAgingTempId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemAgingTemp
    /// ItemCode الخاص بـ ItemAgingTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// DocNo of the ItemAgingTemp
    /// DocNo الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the ItemAgingTemp
    /// DocType الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocJvType of the ItemAgingTemp
    /// DocJvType الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocSer of the ItemAgingTemp
    /// DocSer الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the ItemAgingTemp
    /// DocDate الخاص بـ ItemAgingTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the ItemAgingTemp
    /// ItemQuantity الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// DocDesc of the ItemAgingTemp
    /// DocDesc الخاص بـ ItemAgingTemp
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ItemAgingTemp
    /// ReferenceNumber الخاص بـ ItemAgingTemp
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ItemAgingTemp
    /// RecordNumber الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemAgingTemp
    /// WarehouseCode الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the ItemAgingTemp
    /// CostCenterCode الخاص بـ ItemAgingTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// PeriodNumber of the ItemAgingTemp
    /// PeriodNumber الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? PeriodNumber { get; private set; }

    /// <summary>
    /// TerminalName of the ItemAgingTemp
    /// TerminalName الخاص بـ ItemAgingTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemAgingTemp
    /// CompanyNumberShort الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemAgingTemp
    /// BranchNumber الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemAgingTemp
    /// BranchYear الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemAgingTemp
    /// BranchUser الخاص بـ ItemAgingTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

