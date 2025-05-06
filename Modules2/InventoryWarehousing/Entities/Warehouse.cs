using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.ServicesMaintenance.Entities;
using ERP_Pro.Domain.ERP.TransportationShipping.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// Warehouse Entity
/// </summary>
public class Warehouse : Entity<WarehouseId>
{

    private Warehouse() { }

    public Warehouse(WarehouseId id, decimal? warehouseCode)
    {
        Id = id;
        WarehouseCode = warehouseCode;
    }

    /// <summary>
    /// The unique identifier for the Warehouse
    /// المعرف الفريد لـ Warehouse
    /// </summary>
    public WarehouseId Id { get; private set; }

    /// <summary>
    /// WarehouseCode of the Warehouse
    /// WarehouseCode الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseName of the Warehouse
    /// WarehouseName الخاص بـ Warehouse
    /// </summary>
    public string WarehouseName { get; private set; }

    /// <summary>
    /// WarehouseNameEnglish of the Warehouse
    /// WarehouseNameEnglish الخاص بـ Warehouse
    /// </summary>
    public string WarehouseNameEnglish { get; private set; }

    /// <summary>
    /// Location of the Warehouse
    /// Location الخاص بـ Warehouse
    /// </summary>
    public string Location { get; private set; }

    /// <summary>
    /// TelephoneNumber of the Warehouse
    /// TelephoneNumber الخاص بـ Warehouse
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the Warehouse
    /// InactiveFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// WarehouseKeeper of the Warehouse
    /// WarehouseKeeper الخاص بـ Warehouse
    /// </summary>
    public string WarehouseKeeper { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the Warehouse
    /// WarehouseGroupCode الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// WarehouseType of the Warehouse
    /// WarehouseType الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseType { get; private set; }

    /// <summary>
    /// UseBillOfExchange of the Warehouse
    /// UseBillOfExchange الخاص بـ Warehouse
    /// </summary>
    public decimal? UseBillOfExchange { get; private set; }

    /// <summary>
    /// NoSaleFlag of the Warehouse
    /// NoSaleFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? NoSaleFlag { get; private set; }

    /// <summary>
    /// CheckAvailableQuantity of the Warehouse
    /// CheckAvailableQuantity الخاص بـ Warehouse
    /// </summary>
    public decimal? CheckAvailableQuantity { get; private set; }

    /// <summary>
    /// Gps of the Warehouse
    /// Gps الخاص بـ Warehouse
    /// </summary>
    public string Gps { get; private set; }

    /// <summary>
    /// WarehouseSerial of the Warehouse
    /// WarehouseSerial الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseSerial { get; private set; }

    /// <summary>
    /// ConnectionBranchNumber of the Warehouse
    /// ConnectionBranchNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? ConnectionBranchNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the Warehouse
    /// ActivityNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// MainWarehouseCode of the Warehouse
    /// MainWarehouseCode الخاص بـ Warehouse
    /// </summary>
    public decimal? MainWarehouseCode { get; private set; }

    /// <summary>
    /// DbLinkName of the Warehouse
    /// DbLinkName الخاص بـ Warehouse
    /// </summary>
    public string DbLinkName { get; private set; }

    /// <summary>
    /// UseAutoReceiveWarehouseTransfer of the Warehouse
    /// UseAutoReceiveWarehouseTransfer الخاص بـ Warehouse
    /// </summary>
    public decimal? UseAutoReceiveWarehouseTransfer { get; private set; }

    /// <summary>
    /// PriceLevel of the Warehouse
    /// PriceLevel الخاص بـ Warehouse
    /// </summary>
    public decimal? PriceLevel { get; private set; }

    /// <summary>
    /// ServiceFlag of the Warehouse
    /// ServiceFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? ServiceFlag { get; private set; }

    /// <summary>
    /// Latitude of the Warehouse
    /// Latitude الخاص بـ Warehouse
    /// </summary>
    public string Latitude { get; private set; }

    /// <summary>
    /// Longitude of the Warehouse
    /// Longitude الخاص بـ Warehouse
    /// </summary>
    public string Longitude { get; private set; }

    /// <summary>
    /// GlnCode of the Warehouse
    /// GlnCode الخاص بـ Warehouse
    /// </summary>
    public string GlnCode { get; private set; }

    /// <summary>
    /// WarehouseLastAddress of the Warehouse
    /// WarehouseLastAddress الخاص بـ Warehouse
    /// </summary>
    public string WarehouseLastAddress { get; private set; }

    /// <summary>
    /// WarehouseFullAddress of the Warehouse
    /// WarehouseFullAddress الخاص بـ Warehouse
    /// </summary>
    public string WarehouseFullAddress { get; private set; }

    /// <summary>
    /// ShowWarehouseCodeType of the Warehouse
    /// ShowWarehouseCodeType الخاص بـ Warehouse
    /// </summary>
    public decimal? ShowWarehouseCodeType { get; private set; }

    /// <summary>
    /// ProjectNumber of the Warehouse
    /// ProjectNumber الخاص بـ Warehouse
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the Warehouse
    /// ActivityNumber الخاص بـ Warehouse
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// SalesOrderDescription of the Warehouse
    /// SalesOrderDescription الخاص بـ Warehouse
    /// </summary>
    public string SalesOrderDescription { get; private set; }

    /// <summary>
    /// SalesOrderType of the Warehouse
    /// SalesOrderType الخاص بـ Warehouse
    /// </summary>
    public decimal? SalesOrderType { get; private set; }

    /// <summary>
    /// ServiceNumber of the Warehouse
    /// ServiceNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// BankNumber of the Warehouse
    /// BankNumber الخاص بـ Warehouse
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// RepCode of the Warehouse
    /// RepCode الخاص بـ Warehouse
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the Warehouse
    /// ColumnNumberShort الخاص بـ Warehouse
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CCode of the Warehouse
    /// CCode الخاص بـ Warehouse
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the Warehouse
    /// CalcTypeNumberTax الخاص بـ Warehouse
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// CGroupCode of the Warehouse
    /// CGroupCode الخاص بـ Warehouse
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// ShowSystemType of the Warehouse
    /// ShowSystemType الخاص بـ Warehouse
    /// </summary>
    public decimal? ShowSystemType { get; private set; }

    /// <summary>
    /// UsePreparationFlag of the Warehouse
    /// UsePreparationFlag الخاص بـ Warehouse
    /// </summary>
    public decimal? UsePreparationFlag { get; private set; }

    /// <summary>
    /// UseBinMovement of the Warehouse
    /// UseBinMovement الخاص بـ Warehouse
    /// </summary>
    public decimal? UseBinMovement { get; private set; }

    /// <summary>
    /// WarehouseCostLimit of the Warehouse
    /// WarehouseCostLimit الخاص بـ Warehouse
    /// </summary>
    public decimal? WarehouseCostLimit { get; private set; }

    /// <summary>
    /// ForDamagedItem of the Warehouse
    /// ForDamagedItem الخاص بـ Warehouse
    /// </summary>
    public decimal? ForDamagedItem { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Province Province { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Country Country { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

