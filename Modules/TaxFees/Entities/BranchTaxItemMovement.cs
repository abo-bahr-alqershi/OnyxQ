using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// BranchTaxItemMovement Entity
/// </summary>
public class BranchTaxItemMovement : Entity<BranchTaxItemMovementId>
{
    private BranchTaxItemMovement() { }

    /// <summary>
    /// The unique identifier for the BranchTaxItemMovement
    /// المعرف الفريد لـ BranchTaxItemMovement
    /// </summary>
    public BranchTaxItemMovementId Id { get; private set; }

    /// <summary>
    /// DocType of the BranchTaxItemMovement
    /// DocType الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchTaxItemMovement
    /// BillDocumentTypeFull الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocJvType of the BranchTaxItemMovement
    /// DocJvType الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the BranchTaxItemMovement
    /// DocNo الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BranchTaxItemMovement
    /// DocSer الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BranchTaxItemMovement
    /// DocDate الخاص بـ BranchTaxItemMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// TaxNumber of the BranchTaxItemMovement
    /// TaxNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? TaxNumber { get; private set; }

    /// <summary>
    /// CalcTypeNumber of the BranchTaxItemMovement
    /// CalcTypeNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? CalcTypeNumber { get; private set; }

    /// <summary>
    /// AgencyNumber of the BranchTaxItemMovement
    /// AgencyNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// ItemCode of the BranchTaxItemMovement
    /// ItemCode الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchTaxItemMovement
    /// ItemUnit الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchTaxItemMovement
    /// PSize الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchTaxItemMovement
    /// ItemPriceShort الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DiscAmt of the BranchTaxItemMovement
    /// DiscAmt الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// AccountCode of the BranchTaxItemMovement
    /// AccountCode الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchTaxItemMovement
    /// AccountCurrency الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchTaxItemMovement
    /// AccountRate الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// TaxPercent of the BranchTaxItemMovement
    /// TaxPercent الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the BranchTaxItemMovement
    /// TaxAmount الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchTaxItemMovement
    /// WarehouseCode الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchTaxItemMovement
    /// CostCenterCode الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchTaxItemMovement
    /// ProjectNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchTaxItemMovement
    /// ActivityNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchTaxItemMovement
    /// RecordNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// TaxAmountLocal of the BranchTaxItemMovement
    /// TaxAmountLocal الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? TaxAmountLocal { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchTaxItemMovement
    /// ItemQuantity الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchTaxItemMovement
    /// FreeQuantity الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchTaxItemMovement
    /// ReferenceNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// StockCost of the BranchTaxItemMovement
    /// StockCost الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// StockRate of the BranchTaxItemMovement
    /// StockRate الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// DocSequence of the BranchTaxItemMovement
    /// DocSequence الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchTaxItemMovement
    /// ExternalPostFlag الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchTaxItemMovement
    /// CompanyNumberShort الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchTaxItemMovement
    /// BranchNumber الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchTaxItemMovement
    /// BranchYear الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchTaxItemMovement
    /// BranchUser الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the BranchTaxItemMovement
    /// CalcTaxFreeQuantityFlag الخاص بـ BranchTaxItemMovement
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to TaxCodeMaster
    /// </summary>
    public TaxCodeMaster TaxCodeMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to TaxTypeCalculationMaster
    /// </summary>
    public TaxTypeCalculationMaster TaxTypeCalculationMaster { get; private set; }
    #endregion
}
}
