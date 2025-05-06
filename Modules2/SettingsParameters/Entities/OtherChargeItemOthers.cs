using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;
namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// OtherChargeItemOthers Entity
/// </summary>
public class OtherChargeItemOthers : Entity<OtherChargeItemOthersId>
{

    private OtherChargeItemOthers() { }

    public OtherChargeItemOthers(OtherChargeItemOthersId id, decimal? billSerial, decimal? recordNumber)
    {
        Id = id;
        BillSerial = billSerial;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the OtherChargeItemOthers
    /// المعرف الفريد لـ OtherChargeItemOthers
    /// </summary>
    public OtherChargeItemOthersId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the OtherChargeItemOthers
    /// BillTypeFull الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the OtherChargeItemOthers
    /// BillDocumentTypeFull الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the OtherChargeItemOthers
    /// BillNumber الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the OtherChargeItemOthers
    /// BillSerial الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the OtherChargeItemOthers
    /// DocDate الخاص بـ OtherChargeItemOthers
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountRate of the OtherChargeItemOthers
    /// AccountRate الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the OtherChargeItemOthers
    /// Period الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the OtherChargeItemOthers
    /// Amount الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// WarehouseCode of the OtherChargeItemOthers
    /// WarehouseCode الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the OtherChargeItemOthers
    /// CostCenterCode الخاص بـ OtherChargeItemOthers
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// RecordNumber of the OtherChargeItemOthers
    /// RecordNumber الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the OtherChargeItemOthers
    /// SalesInvoiceType الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// PSize of the OtherChargeItemOthers
    /// PSize الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BillPaymentYear of the OtherChargeItemOthers
    /// BillPaymentYear الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OtherChargeItemOthers
    /// ExternalPostFlag الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// UnitAmount of the OtherChargeItemOthers
    /// UnitAmount الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? UnitAmount { get; private set; }

    /// <summary>
    /// PostCode of the OtherChargeItemOthers
    /// PostCode الخاص بـ OtherChargeItemOthers
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OtherChargeItemOthers
    /// CompanyNumberShort الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OtherChargeItemOthers
    /// BranchNumber الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OtherChargeItemOthers
    /// BranchYear الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OtherChargeItemOthers
    /// BranchUser الخاص بـ OtherChargeItemOthers
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemUnit of the OtherChargeItemOthers
    /// ItemUnit الخاص بـ OtherChargeItemOthers
    /// </summary>
    public string ItemUnit { get; private set; }

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
    public SalesCharge SalesCharge { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

