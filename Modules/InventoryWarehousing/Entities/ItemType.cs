using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemType Entity
/// </summary>
public class ItemType : Entity<ItemTypeId>
{
    private ItemType() { }

    /// <summary>
    /// The unique identifier for the ItemType
    /// المعرف الفريد لـ ItemType
    /// </summary>
    public ItemTypeId Id { get; private set; }

    /// <summary>
    /// TypeOfItem of the ItemType
    /// TypeOfItem الخاص بـ ItemType
    /// </summary>
    public decimal? TypeOfItem { get; private set; }

    /// <summary>
    /// ItemTypeNameArabic of the ItemType
    /// ItemTypeNameArabic الخاص بـ ItemType
    /// </summary>
    public string ItemTypeNameArabic { get; private set; }

    /// <summary>
    /// ItemTypeNameEnglish of the ItemType
    /// ItemTypeNameEnglish الخاص بـ ItemType
    /// </summary>
    public string ItemTypeNameEnglish { get; private set; }

    /// <summary>
    /// ItemTypeCode of the ItemType
    /// ItemTypeCode الخاص بـ ItemType
    /// </summary>
    public string ItemTypeCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ItemType to CustomerCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CustomerCommissionSetupDetail> CustomerCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemType to SalesmanCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCommissionSetupDetail> SalesmanCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemType to PromotionCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<PromotionCommissionSetupDetail> PromotionCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemType to EmployeeCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<EmployeeCommissionSetupDetail> EmployeeCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemType to ItemMaster
    /// </summary>
    public IReadOnlyCollection<ItemMaster> ItemMasters { get; private set; }
    #endregion
}
}
