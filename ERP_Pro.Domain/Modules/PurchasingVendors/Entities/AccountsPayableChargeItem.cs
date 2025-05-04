using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableChargeItem Entity
/// </summary>
public class AccountsPayableChargeItem : Entity<AccountsPayableChargeItemId>
{

    private AccountsPayableChargeItem() { }

    public AccountsPayableChargeItem(AccountsPayableChargeItemId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableChargeItem
    /// المعرف الفريد لـ AccountsPayableChargeItem
    /// </summary>
    public AccountsPayableChargeItemId Id { get; private set; }

    /// <summary>
    /// ChargeNumber of the AccountsPayableChargeItem
    /// ChargeNumber الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public decimal? ChargeNumber { get; private set; }

    /// <summary>
    /// VendorClass of the AccountsPayableChargeItem
    /// VendorClass الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public decimal? VendorClass { get; private set; }

    /// <summary>
    /// VendorCode of the AccountsPayableChargeItem
    /// VendorCode الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ItemCode of the AccountsPayableChargeItem
    /// ItemCode الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// GuarantorCode of the AccountsPayableChargeItem
    /// GuarantorCode الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsPayableChargeItem
    /// ItemUnit الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AccountsPayableChargeItem
    /// PSize الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableChargeItem
    /// Amount الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// PeriodAmount of the AccountsPayableChargeItem
    /// PeriodAmount الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public decimal? PeriodAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsPayableChargeItem
    /// WarehouseCode الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BillTypeNumber of the AccountsPayableChargeItem
    /// BillTypeNumber الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public decimal? BillTypeNumber { get; private set; }

    /// <summary>
    /// FDate of the AccountsPayableChargeItem
    /// FDate الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the AccountsPayableChargeItem
    /// TDate الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ManagerCode of the AccountsPayableChargeItem
    /// ManagerCode الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string ManagerCode { get; private set; }

    /// <summary>
    /// SubGroupCode of the AccountsPayableChargeItem
    /// SubGroupCode الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string SubGroupCode { get; private set; }

    /// <summary>
    /// GroupNumber of the AccountsPayableChargeItem
    /// GroupNumber الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string GroupNumber { get; private set; }

    /// <summary>
    /// AssistantNumber of the AccountsPayableChargeItem
    /// AssistantNumber الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string AssistantNumber { get; private set; }

    /// <summary>
    /// DetailNo of the AccountsPayableChargeItem
    /// DetailNo الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string DetailNo { get; private set; }

    /// <summary>
    /// GroupClassCode of the AccountsPayableChargeItem
    /// GroupClassCode الخاص بـ AccountsPayableChargeItem
    /// </summary>
    public string GroupClassCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
