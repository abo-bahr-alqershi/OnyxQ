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
/// BranchRequestTaxItemMovement Entity
/// </summary>
public class BranchRequestTaxItemMovement : Entity<BranchRequestTaxItemMovementId>
{

    private BranchRequestTaxItemMovement() { }

    public BranchRequestTaxItemMovement(BranchRequestTaxItemMovementId id, decimal? docType, decimal? docSer, decimal? agencyNumber, decimal? recordNumber, decimal? docSequence)
    {
        Id = id;
        DocType = docType;
        DocSer = docSer;
        AgencyNumber = agencyNumber;
        RecordNumber = recordNumber;
        DocSequence = docSequence;
    }

    /// <summary>
    /// The unique identifier for the BranchRequestTaxItemMovement
    /// المعرف الفريد لـ BranchRequestTaxItemMovement
    /// </summary>
    public BranchRequestTaxItemMovementId Id { get; private set; }

    /// <summary>
    /// DocType of the BranchRequestTaxItemMovement
    /// DocType الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchRequestTaxItemMovement
    /// BillDocumentTypeFull الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocJvType of the BranchRequestTaxItemMovement
    /// DocJvType الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the BranchRequestTaxItemMovement
    /// DocNo الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BranchRequestTaxItemMovement
    /// DocSer الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BranchRequestTaxItemMovement
    /// DocDate الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AgencyNumber of the BranchRequestTaxItemMovement
    /// AgencyNumber الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the BranchRequestTaxItemMovement
    /// ItemUnit الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the BranchRequestTaxItemMovement
    /// PSize الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemPriceShort of the BranchRequestTaxItemMovement
    /// ItemPriceShort الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DiscAmt of the BranchRequestTaxItemMovement
    /// DiscAmt الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// AccountCode of the BranchRequestTaxItemMovement
    /// AccountCode الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchRequestTaxItemMovement
    /// AccountCurrency الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchRequestTaxItemMovement
    /// AccountRate الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// TaxPercent of the BranchRequestTaxItemMovement
    /// TaxPercent الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the BranchRequestTaxItemMovement
    /// TaxAmount الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the BranchRequestTaxItemMovement
    /// WarehouseCode الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchRequestTaxItemMovement
    /// RecordNumber الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// TaxAmountLocal of the BranchRequestTaxItemMovement
    /// TaxAmountLocal الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? TaxAmountLocal { get; private set; }

    /// <summary>
    /// ItemQuantity of the BranchRequestTaxItemMovement
    /// ItemQuantity الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the BranchRequestTaxItemMovement
    /// FreeQuantity الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchRequestTaxItemMovement
    /// ReferenceNumber الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// StockCost of the BranchRequestTaxItemMovement
    /// StockCost الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// StockRate of the BranchRequestTaxItemMovement
    /// StockRate الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// DocSequence of the BranchRequestTaxItemMovement
    /// DocSequence الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchRequestTaxItemMovement
    /// ExternalPostFlag الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchRequestTaxItemMovement
    /// CompanyNumberShort الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchRequestTaxItemMovement
    /// BranchNumber الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchRequestTaxItemMovement
    /// BranchYear الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchRequestTaxItemMovement
    /// BranchUser الخاص بـ BranchRequestTaxItemMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the BranchRequestTaxItemMovement
    /// CalcTaxFreeQuantityFlag الخاص بـ BranchRequestTaxItemMovement
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
