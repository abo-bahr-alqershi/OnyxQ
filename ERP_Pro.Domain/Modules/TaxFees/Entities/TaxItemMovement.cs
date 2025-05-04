using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxItemMovement Entity
/// </summary>
public class TaxItemMovement : Entity<TaxItemMovementId>
{

    private TaxItemMovement() { }

    public TaxItemMovement(TaxItemMovementId id, decimal? docType, decimal? docSer, decimal? agencyNumber, decimal? recordNumber, decimal? docSequence)
    {
        Id = id;
        DocType = docType;
        DocSer = docSer;
        AgencyNumber = agencyNumber;
        RecordNumber = recordNumber;
        DocSequence = docSequence;
    }

    /// <summary>
    /// The unique identifier for the TaxItemMovement
    /// المعرف الفريد لـ TaxItemMovement
    /// </summary>
    public TaxItemMovementId Id { get; private set; }

    /// <summary>
    /// DocType of the TaxItemMovement
    /// DocType الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the TaxItemMovement
    /// BillDocumentTypeFull الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocJvType of the TaxItemMovement
    /// DocJvType الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the TaxItemMovement
    /// DocNo الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the TaxItemMovement
    /// DocSer الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the TaxItemMovement
    /// DocDate الخاص بـ TaxItemMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AgencyNumber of the TaxItemMovement
    /// AgencyNumber الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the TaxItemMovement
    /// ItemUnit الخاص بـ TaxItemMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the TaxItemMovement
    /// PSize الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemPriceShort of the TaxItemMovement
    /// ItemPriceShort الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DiscAmt of the TaxItemMovement
    /// DiscAmt الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// AccountCode of the TaxItemMovement
    /// AccountCode الخاص بـ TaxItemMovement
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the TaxItemMovement
    /// AccountCurrency الخاص بـ TaxItemMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the TaxItemMovement
    /// AccountRate الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// TaxPercent of the TaxItemMovement
    /// TaxPercent الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the TaxItemMovement
    /// TaxAmount الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the TaxItemMovement
    /// WarehouseCode الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RecordNumber of the TaxItemMovement
    /// RecordNumber الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// TaxAmountLocal of the TaxItemMovement
    /// TaxAmountLocal الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? TaxAmountLocal { get; private set; }

    /// <summary>
    /// ItemQuantity of the TaxItemMovement
    /// ItemQuantity الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the TaxItemMovement
    /// FreeQuantity الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ReferenceNumber of the TaxItemMovement
    /// ReferenceNumber الخاص بـ TaxItemMovement
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// StockCost of the TaxItemMovement
    /// StockCost الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// StockRate of the TaxItemMovement
    /// StockRate الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// DocSequence of the TaxItemMovement
    /// DocSequence الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the TaxItemMovement
    /// ExternalPostFlag الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TaxItemMovement
    /// CompanyNumberShort الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TaxItemMovement
    /// BranchNumber الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TaxItemMovement
    /// BranchYear الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TaxItemMovement
    /// BranchUser الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the TaxItemMovement
    /// CalcTaxFreeQuantityFlag الخاص بـ TaxItemMovement
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

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
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public TaxCodeMaster TaxCodeMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public TaxTypeCalculationMaster TaxTypeCalculationMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
