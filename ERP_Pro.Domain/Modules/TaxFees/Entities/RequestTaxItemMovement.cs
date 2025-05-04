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
/// RequestTaxItemMovement Entity
/// </summary>
public class RequestTaxItemMovement : Entity<RequestTaxItemMovementId>
{

    private RequestTaxItemMovement() { }

    public RequestTaxItemMovement(RequestTaxItemMovementId id, decimal? docType, decimal? docSer, decimal? agencyNumber, decimal? recordNumber, decimal? docSequence)
    {
        Id = id;
        DocType = docType;
        DocSer = docSer;
        AgencyNumber = agencyNumber;
        RecordNumber = recordNumber;
        DocSequence = docSequence;
    }

    /// <summary>
    /// The unique identifier for the RequestTaxItemMovement
    /// المعرف الفريد لـ RequestTaxItemMovement
    /// </summary>
    public RequestTaxItemMovementId Id { get; private set; }

    /// <summary>
    /// DocType of the RequestTaxItemMovement
    /// DocType الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the RequestTaxItemMovement
    /// BillDocumentTypeFull الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocJvType of the RequestTaxItemMovement
    /// DocJvType الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the RequestTaxItemMovement
    /// DocNo الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the RequestTaxItemMovement
    /// DocSer الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the RequestTaxItemMovement
    /// DocDate الخاص بـ RequestTaxItemMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AgencyNumber of the RequestTaxItemMovement
    /// AgencyNumber الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the RequestTaxItemMovement
    /// ItemUnit الخاص بـ RequestTaxItemMovement
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the RequestTaxItemMovement
    /// PSize الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemPriceShort of the RequestTaxItemMovement
    /// ItemPriceShort الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DiscAmt of the RequestTaxItemMovement
    /// DiscAmt الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// AccountCode of the RequestTaxItemMovement
    /// AccountCode الخاص بـ RequestTaxItemMovement
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the RequestTaxItemMovement
    /// AccountCurrency الخاص بـ RequestTaxItemMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the RequestTaxItemMovement
    /// AccountRate الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// TaxPercent of the RequestTaxItemMovement
    /// TaxPercent الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the RequestTaxItemMovement
    /// TaxAmount الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the RequestTaxItemMovement
    /// WarehouseCode الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// RecordNumber of the RequestTaxItemMovement
    /// RecordNumber الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// TaxAmountLocal of the RequestTaxItemMovement
    /// TaxAmountLocal الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? TaxAmountLocal { get; private set; }

    /// <summary>
    /// ItemQuantity of the RequestTaxItemMovement
    /// ItemQuantity الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// FreeQuantity of the RequestTaxItemMovement
    /// FreeQuantity الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RequestTaxItemMovement
    /// ReferenceNumber الخاص بـ RequestTaxItemMovement
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// StockCost of the RequestTaxItemMovement
    /// StockCost الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? StockCost { get; private set; }

    /// <summary>
    /// StockRate of the RequestTaxItemMovement
    /// StockRate الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// DocSequence of the RequestTaxItemMovement
    /// DocSequence الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the RequestTaxItemMovement
    /// ExternalPostFlag الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestTaxItemMovement
    /// CompanyNumberShort الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestTaxItemMovement
    /// BranchNumber الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestTaxItemMovement
    /// BranchYear الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestTaxItemMovement
    /// BranchUser الخاص بـ RequestTaxItemMovement
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the RequestTaxItemMovement
    /// CalcTaxFreeQuantityFlag الخاص بـ RequestTaxItemMovement
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
