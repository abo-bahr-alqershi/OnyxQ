using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesDiscount Entity
/// </summary>
public class SalesDiscount : Entity<SalesDiscountId>
{

    private SalesDiscount() { }

    public SalesDiscount(SalesDiscountId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesDiscount
    /// المعرف الفريد لـ SalesDiscount
    /// </summary>
    public SalesDiscountId Id { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SalesDiscount
    /// BillDocumentTypeFull الخاص بـ SalesDiscount
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// PSize of the SalesDiscount
    /// PSize الخاص بـ SalesDiscount
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// AmountType of the SalesDiscount
    /// AmountType الخاص بـ SalesDiscount
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// Amount of the SalesDiscount
    /// Amount الخاص بـ SalesDiscount
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AccountCurrency of the SalesDiscount
    /// AccountCurrency الخاص بـ SalesDiscount
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the SalesDiscount
    /// AccountRate الخاص بـ SalesDiscount
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// FDate of the SalesDiscount
    /// FDate الخاص بـ SalesDiscount
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesDiscount
    /// TDate الخاص بـ SalesDiscount
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// LevelNumber of the SalesDiscount
    /// LevelNumber الخاص بـ SalesDiscount
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// FQuantity of the SalesDiscount
    /// FQuantity الخاص بـ SalesDiscount
    /// </summary>
    public decimal? FQuantity { get; private set; }

    /// <summary>
    /// TQuantity of the SalesDiscount
    /// TQuantity الخاص بـ SalesDiscount
    /// </summary>
    public decimal? TQuantity { get; private set; }

    /// <summary>
    /// BatchNumber of the SalesDiscount
    /// BatchNumber الخاص بـ SalesDiscount
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemPriceShort of the SalesDiscount
    /// ItemPriceShort الخاص بـ SalesDiscount
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// StockCost of the SalesDiscount
    /// StockCost الخاص بـ SalesDiscount
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// AvailableQuantity of the SalesDiscount
    /// AvailableQuantity الخاص بـ SalesDiscount
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// DocDesc of the SalesDiscount
    /// DocDesc الخاص بـ SalesDiscount
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesDiscount
    /// BranchNumber الخاص بـ SalesDiscount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// Amount2 of the SalesDiscount
    /// Amount2 الخاص بـ SalesDiscount
    /// </summary>
    public decimal? Amount2 { get; private set; }

    /// <summary>
    /// Amount3 of the SalesDiscount
    /// Amount3 الخاص بـ SalesDiscount
    /// </summary>
    public decimal? Amount3 { get; private set; }

    /// <summary>
    /// CustomerGroupCode of the SalesDiscount
    /// CustomerGroupCode الخاص بـ SalesDiscount
    /// </summary>
    public decimal? CustomerGroupCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public WarehouseGroup WarehouseGroup { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

