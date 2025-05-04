using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// ItemsTransferQuantityTemp Entity
/// </summary>
public class ItemsTransferQuantityTemp : Entity<ItemsTransferQuantityTempId>
{
    private ItemsTransferQuantityTemp() { }

    /// <summary>
    /// The unique identifier for the ItemsTransferQuantityTemp
    /// المعرف الفريد لـ ItemsTransferQuantityTemp
    /// </summary>
    public ItemsTransferQuantityTempId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemsTransferQuantityTemp
    /// ItemCode الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// FWarehouseCode of the ItemsTransferQuantityTemp
    /// FWarehouseCode الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? FWarehouseCode { get; private set; }

    /// <summary>
    /// TWarehouseCode of the ItemsTransferQuantityTemp
    /// TWarehouseCode الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? TWarehouseCode { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemsTransferQuantityTemp
    /// BatchNumber الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemOrder of the ItemsTransferQuantityTemp
    /// ItemOrder الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? ItemOrder { get; private set; }

    /// <summary>
    /// DistDay of the ItemsTransferQuantityTemp
    /// DistDay الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? DistDay { get; private set; }

    /// <summary>
    /// FQuantity of the ItemsTransferQuantityTemp
    /// FQuantity الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? FQuantity { get; private set; }

    /// <summary>
    /// TQuantity of the ItemsTransferQuantityTemp
    /// TQuantity الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? TQuantity { get; private set; }

    /// <summary>
    /// AverageSaleDay of the ItemsTransferQuantityTemp
    /// AverageSaleDay الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? AverageSaleDay { get; private set; }

    /// <summary>
    /// PeriodSaleQuantity of the ItemsTransferQuantityTemp
    /// PeriodSaleQuantity الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? PeriodSaleQuantity { get; private set; }

    /// <summary>
    /// PeriodDay of the ItemsTransferQuantityTemp
    /// PeriodDay الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? PeriodDay { get; private set; }

    /// <summary>
    /// Speed of the ItemsTransferQuantityTemp
    /// Speed الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? Speed { get; private set; }

    /// <summary>
    /// DocNo of the ItemsTransferQuantityTemp
    /// DocNo الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemsTransferQuantityTemp
    /// CompanyNumberShort الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemsTransferQuantityTemp
    /// BranchNumber الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemsTransferQuantityTemp
    /// BranchYear الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemsTransferQuantityTemp
    /// BranchUser الخاص بـ ItemsTransferQuantityTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
