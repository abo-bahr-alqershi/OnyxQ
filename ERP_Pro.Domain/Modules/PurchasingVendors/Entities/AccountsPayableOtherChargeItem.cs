using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableOtherChargeItem Entity
/// </summary>
public class AccountsPayableOtherChargeItem : Entity<AccountsPayableOtherChargeItemId>
{

    private AccountsPayableOtherChargeItem() { }

    public AccountsPayableOtherChargeItem(AccountsPayableOtherChargeItemId id, decimal? billSerial, decimal? recordNumber)
    {
        Id = id;
        BillSerial = billSerial;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableOtherChargeItem
    /// المعرف الفريد لـ AccountsPayableOtherChargeItem
    /// </summary>
    public AccountsPayableOtherChargeItemId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the AccountsPayableOtherChargeItem
    /// BillTypeFull الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the AccountsPayableOtherChargeItem
    /// BillDocumentTypeFull الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the AccountsPayableOtherChargeItem
    /// BillNumber الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the AccountsPayableOtherChargeItem
    /// BillSerial الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the AccountsPayableOtherChargeItem
    /// DocDate الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AccountsPayableOtherChargeItem
    /// AccountDetailCode الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AccountsPayableOtherChargeItem
    /// AccountDetailType الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountRate of the AccountsPayableOtherChargeItem
    /// AccountRate الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the AccountsPayableOtherChargeItem
    /// Period الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableOtherChargeItem
    /// Amount الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// WarehouseCode of the AccountsPayableOtherChargeItem
    /// WarehouseCode الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableOtherChargeItem
    /// CostCenterCode الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableOtherChargeItem
    /// RecordNumber الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BillTypeNumber of the AccountsPayableOtherChargeItem
    /// BillTypeNumber الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BillTypeNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the AccountsPayableOtherChargeItem
    /// ItemUnit الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the AccountsPayableOtherChargeItem
    /// PSize الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BillPaymentYear of the AccountsPayableOtherChargeItem
    /// BillPaymentYear الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AccountsPayableOtherChargeItem
    /// ExternalPostFlag الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// UnitAmount of the AccountsPayableOtherChargeItem
    /// UnitAmount الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? UnitAmount { get; private set; }

    /// <summary>
    /// PostCode of the AccountsPayableOtherChargeItem
    /// PostCode الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableOtherChargeItem
    /// CompanyNumberShort الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableOtherChargeItem
    /// BranchNumber الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableOtherChargeItem
    /// BranchYear الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableOtherChargeItem
    /// BranchUser الخاص بـ AccountsPayableOtherChargeItem
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsPayableCharge AccountsPayableCharge { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
