using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// GroupDetail Entity
/// </summary>
public class GroupDetail : Entity<GroupDetailId>
{
    private GroupDetail() { }

    /// <summary>
    /// The unique identifier for the GroupDetail
    /// المعرف الفريد لـ GroupDetail
    /// </summary>
    public GroupDetailId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the GroupDetail
    /// GuarantorCode الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GuarantorNameArabic of the GroupDetail
    /// GuarantorNameArabic الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorNameArabic { get; private set; }

    /// <summary>
    /// GuarantorNameEnglish of the GroupDetail
    /// GuarantorNameEnglish الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorNameEnglish { get; private set; }

    /// <summary>
    /// GuarantorItemCode of the GroupDetail
    /// GuarantorItemCode الخاص بـ GroupDetail
    /// </summary>
    public string GuarantorItemCode { get; private set; }

    /// <summary>
    /// BranchYear of the GroupDetail
    /// BranchYear الخاص بـ GroupDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GroupDetail
    /// BranchUser الخاص بـ GroupDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// TaxPercentDefault of the GroupDetail
    /// TaxPercentDefault الخاص بـ GroupDetail
    /// </summary>
    public decimal? TaxPercentDefault { get; private set; }

    /// <summary>
    /// SynchronizeToWebFlag of the GroupDetail
    /// SynchronizeToWebFlag الخاص بـ GroupDetail
    /// </summary>
    public decimal? SynchronizeToWebFlag { get; private set; }

    /// <summary>
    /// UseSalePriceAsPurchasePrice of the GroupDetail
    /// UseSalePriceAsPurchasePrice الخاص بـ GroupDetail
    /// </summary>
    public decimal? UseSalePriceAsPurchasePrice { get; private set; }

    /// <summary>
    /// RollLimitQuantity of the GroupDetail
    /// RollLimitQuantity الخاص بـ GroupDetail
    /// </summary>
    public decimal? RollLimitQuantity { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: GroupDetail to GeneralPermission
    /// </summary>
    public IReadOnlyCollection<GeneralPermission> GeneralPermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to OutgoingAccount
    /// </summary>
    public IReadOnlyCollection<OutgoingAccount> OutgoingAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to SalesChargeItem
    /// </summary>
    public IReadOnlyCollection<SalesChargeItem> SalesChargeItems { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to SalesDiscount
    /// </summary>
    public IReadOnlyCollection<SalesDiscount> SalesDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to SalesFreeQuantity
    /// </summary>
    public IReadOnlyCollection<SalesFreeQuantity> SalesFreeQuantities { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to CustomerCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CustomerCommissionSetupDetail> CustomerCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to SalesmanCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCommissionSetupDetail> SalesmanCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to PromotionCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<PromotionCommissionSetupDetail> PromotionCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to EmployeeCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<EmployeeCommissionSetupDetail> EmployeeCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to GroupItemLevel
    /// </summary>
    public IReadOnlyCollection<GroupItemLevel> GroupItemLevels { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to ItemMaster
    /// </summary>
    public IReadOnlyCollection<ItemMaster> ItemMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to MainSubGroupDetail
    /// </summary>
    public IReadOnlyCollection<MainSubGroupDetail> MainSubGroupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to ItemDetail
    /// </summary>
    public IReadOnlyCollection<ItemDetail> ItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to SalesCharge
    /// </summary>
    public IReadOnlyCollection<SalesCharge> SalesCharges { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to CustomerClass
    /// </summary>
    public IReadOnlyCollection<CustomerClass> CustomerClasses { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupDetail to WarehouseGroup
    /// </summary>
    public IReadOnlyCollection<WarehouseGroup> WarehouseGroups { get; private set; }
    #endregion
}
}
