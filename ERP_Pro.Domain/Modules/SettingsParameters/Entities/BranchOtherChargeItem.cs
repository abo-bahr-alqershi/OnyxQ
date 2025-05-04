using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// BranchOtherChargeItem Entity
/// </summary>
public class BranchOtherChargeItem : Entity<BranchOtherChargeItemId>
{

    private BranchOtherChargeItem() { }

    public BranchOtherChargeItem(BranchOtherChargeItemId id, decimal? billSerial, decimal? serviceNumber, decimal? recordNumber, string itemCode)
    {
        Id = id;
        BillSerial = billSerial;
        ServiceNumber = serviceNumber;
        RecordNumber = recordNumber;
        ItemCode = itemCode;
    }

    /// <summary>
    /// The unique identifier for the BranchOtherChargeItem
    /// المعرف الفريد لـ BranchOtherChargeItem
    /// </summary>
    public BranchOtherChargeItemId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the BranchOtherChargeItem
    /// BillTypeFull الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchOtherChargeItem
    /// BillDocumentTypeFull الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BranchOtherChargeItem
    /// BillNumber الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BranchOtherChargeItem
    /// BillSerial الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the BranchOtherChargeItem
    /// DocDate الخاص بـ BranchOtherChargeItem
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ServiceNumber of the BranchOtherChargeItem
    /// ServiceNumber الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// AccountRate of the BranchOtherChargeItem
    /// AccountRate الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the BranchOtherChargeItem
    /// Period الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the BranchOtherChargeItem
    /// Amount الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchOtherChargeItem
    /// WarehouseCode الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchOtherChargeItem
    /// CostCenterCode الخاص بـ BranchOtherChargeItem
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchOtherChargeItem
    /// ProjectNumber الخاص بـ BranchOtherChargeItem
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchOtherChargeItem
    /// ActivityNumber الخاص بـ BranchOtherChargeItem
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchOtherChargeItem
    /// RecordNumber الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemCode of the BranchOtherChargeItem
    /// ItemCode الخاص بـ BranchOtherChargeItem
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchOtherChargeItem
    /// ItemUnit الخاص بـ BranchOtherChargeItem
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchOtherChargeItem
    /// PSize الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BillPaymentYear of the BranchOtherChargeItem
    /// BillPaymentYear الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchOtherChargeItem
    /// ExternalPostFlag الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// UnitAmount of the BranchOtherChargeItem
    /// UnitAmount الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? UnitAmount { get; private set; }

    /// <summary>
    /// PostCode of the BranchOtherChargeItem
    /// PostCode الخاص بـ BranchOtherChargeItem
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the BranchOtherChargeItem
    /// SalesInvoiceType الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchOtherChargeItem
    /// CompanyNumberShort الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchOtherChargeItem
    /// BranchNumber الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchOtherChargeItem
    /// BranchYear الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchOtherChargeItem
    /// BranchUser الخاص بـ BranchOtherChargeItem
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
