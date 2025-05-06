using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;
using ERP_Pro.Domain.ERP.ProductionManufacturing.Entities;
using ERP_Pro.Domain.ERP.ServicesMaintenance.Entities;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemDetail Entity
/// </summary>
public class ItemDetail : Entity<ItemDetailId>
{

    private ItemDetail() { }

    public ItemDetail(ItemDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemDetail
    /// المعرف الفريد لـ ItemDetail
    /// </summary>
    public ItemDetailId Id { get; private set; }

    /// <summary>
    /// PSize of the ItemDetail
    /// PSize الخاص بـ ItemDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// MainUnit of the ItemDetail
    /// MainUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? MainUnit { get; private set; }

    /// <summary>
    /// SaleUnit of the ItemDetail
    /// SaleUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? SaleUnit { get; private set; }

    /// <summary>
    /// PurchaseUnit of the ItemDetail
    /// PurchaseUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? PurchaseUnit { get; private set; }

    /// <summary>
    /// StockUnit of the ItemDetail
    /// StockUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? StockUnit { get; private set; }

    /// <summary>
    /// PriceUnit of the ItemDetail
    /// PriceUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? PriceUnit { get; private set; }

    /// <summary>
    /// NoSaleFlag of the ItemDetail
    /// NoSaleFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? NoSaleFlag { get; private set; }

    /// <summary>
    /// Barcode of the ItemDetail
    /// Barcode الخاص بـ ItemDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// LevelUnit of the ItemDetail
    /// LevelUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? LevelUnit { get; private set; }

    /// <summary>
    /// ExceptionDiscountCreditFlag of the ItemDetail
    /// ExceptionDiscountCreditFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? ExceptionDiscountCreditFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the ItemDetail
    /// InactiveFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the ItemDetail
    /// InactiveReason الخاص بـ ItemDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the ItemDetail
    /// InactivatedByUserId الخاص بـ ItemDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the ItemDetail
    /// InactiveDate الخاص بـ ItemDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// QrCodeMethodNumber of the ItemDetail
    /// QrCodeMethodNumber الخاص بـ ItemDetail
    /// </summary>
    public decimal? QrCodeMethodNumber { get; private set; }

    /// <summary>
    /// UseSerialNumberShort of the ItemDetail
    /// UseSerialNumberShort الخاص بـ ItemDetail
    /// </summary>
    public decimal? UseSerialNumberShort { get; private set; }

    /// <summary>
    /// ChiefUnitFlag of the ItemDetail
    /// ChiefUnitFlag الخاص بـ ItemDetail
    /// </summary>
    public decimal? ChiefUnitFlag { get; private set; }

    /// <summary>
    /// ItemUnitLastDescription of the ItemDetail
    /// ItemUnitLastDescription الخاص بـ ItemDetail
    /// </summary>
    public string ItemUnitLastDescription { get; private set; }

    /// <summary>
    /// ItemUnitFullDescription of the ItemDetail
    /// ItemUnitFullDescription الخاص بـ ItemDetail
    /// </summary>
    public string ItemUnitFullDescription { get; private set; }

    /// <summary>
    /// StoreUnit of the ItemDetail
    /// StoreUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? StoreUnit { get; private set; }

    /// <summary>
    /// WeightUnit of the ItemDetail
    /// WeightUnit الخاص بـ ItemDetail
    /// </summary>
    public decimal? WeightUnit { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Measurement Measurement { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

