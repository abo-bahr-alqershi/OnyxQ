using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// WarehouseGroup Entity
/// </summary>
public class WarehouseGroup : Entity<WarehouseGroupId>
{
    private WarehouseGroup() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to OutgoingAccount
    /// </summary>
    public IReadOnlyCollection<OutgoingAccount> OutgoingAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to SalesDiscount
    /// </summary>
    public IReadOnlyCollection<SalesDiscount> SalesDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to SalesFreeQuantity
    /// </summary>
    public IReadOnlyCollection<SalesFreeQuantity> SalesFreeQuantities { get; private set; }
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to ItemDetail
    /// </summary>
    public IReadOnlyCollection<ItemDetail> ItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to CustomerClass
    /// </summary>
    public IReadOnlyCollection<CustomerClass> CustomerClasses { get; private set; }
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: WarehouseGroup to GroupDetail
    /// </summary>
    public IReadOnlyCollection<GroupDetail> GroupDetails { get; private set; }
    #endregion
}
}
