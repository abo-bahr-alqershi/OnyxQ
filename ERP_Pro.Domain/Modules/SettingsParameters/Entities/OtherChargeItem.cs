using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// OtherChargeItem Entity
/// </summary>
public class OtherChargeItem : Entity<OtherChargeItemId>
{

    private OtherChargeItem() { }

    public OtherChargeItem(OtherChargeItemId id, decimal? billSerial, decimal? recordNumber)
    {
        Id = id;
        BillSerial = billSerial;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the OtherChargeItem
    /// المعرف الفريد لـ OtherChargeItem
    /// </summary>
    public OtherChargeItemId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the OtherChargeItem
    /// BillTypeFull الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the OtherChargeItem
    /// BillDocumentTypeFull الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the OtherChargeItem
    /// BillNumber الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the OtherChargeItem
    /// BillSerial الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the OtherChargeItem
    /// DocDate الخاص بـ OtherChargeItem
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountRate of the OtherChargeItem
    /// AccountRate الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the OtherChargeItem
    /// Period الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the OtherChargeItem
    /// Amount الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// WarehouseCode of the OtherChargeItem
    /// WarehouseCode الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the OtherChargeItem
    /// CostCenterCode الخاص بـ OtherChargeItem
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// RecordNumber of the OtherChargeItem
    /// RecordNumber الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the OtherChargeItem
    /// SalesInvoiceType الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// PSize of the OtherChargeItem
    /// PSize الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BillPaymentYear of the OtherChargeItem
    /// BillPaymentYear الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OtherChargeItem
    /// ExternalPostFlag الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// UnitAmount of the OtherChargeItem
    /// UnitAmount الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? UnitAmount { get; private set; }

    /// <summary>
    /// PostCode of the OtherChargeItem
    /// PostCode الخاص بـ OtherChargeItem
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OtherChargeItem
    /// CompanyNumberShort الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OtherChargeItem
    /// BranchNumber الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OtherChargeItem
    /// BranchYear الخاص بـ OtherChargeItem
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OtherChargeItem
    /// BranchUser الخاص بـ OtherChargeItem
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
    public ItemDetail ItemDetail { get; private set; }
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
    public SalesCharge SalesCharge { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
