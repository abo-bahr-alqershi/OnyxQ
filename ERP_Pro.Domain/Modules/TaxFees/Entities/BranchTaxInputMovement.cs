using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// BranchTaxInputMovement Entity
/// </summary>
public class BranchTaxInputMovement : Entity<BranchTaxInputMovementId>
{

    private BranchTaxInputMovement() { }

    public BranchTaxInputMovement(BranchTaxInputMovementId id, decimal? docType, decimal? docSer, decimal? agencyNumber, decimal? inputType, string inputCode, decimal? recordNumber, decimal? docSequence)
    {
        Id = id;
        DocType = docType;
        DocSer = docSer;
        AgencyNumber = agencyNumber;
        InputType = inputType;
        InputCode = inputCode;
        RecordNumber = recordNumber;
        DocSequence = docSequence;
    }

    /// <summary>
    /// The unique identifier for the BranchTaxInputMovement
    /// المعرف الفريد لـ BranchTaxInputMovement
    /// </summary>
    public BranchTaxInputMovementId Id { get; private set; }

    /// <summary>
    /// DocType of the BranchTaxInputMovement
    /// DocType الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchTaxInputMovement
    /// BillDocumentTypeFull الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocJvType of the BranchTaxInputMovement
    /// DocJvType الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the BranchTaxInputMovement
    /// DocNo الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BranchTaxInputMovement
    /// DocSer الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the BranchTaxInputMovement
    /// DocDate الخاص بـ BranchTaxInputMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AgencyNumber of the BranchTaxInputMovement
    /// AgencyNumber الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// InputType of the BranchTaxInputMovement
    /// InputType الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? InputType { get; private set; }

    /// <summary>
    /// InputCode of the BranchTaxInputMovement
    /// InputCode الخاص بـ BranchTaxInputMovement
    /// </summary>
    public string InputCode { get; private set; }

    /// <summary>
    /// AccountCode of the BranchTaxInputMovement
    /// AccountCode الخاص بـ BranchTaxInputMovement
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchTaxInputMovement
    /// AccountCurrency الخاص بـ BranchTaxInputMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchTaxInputMovement
    /// AccountRate الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// InputAmount of the BranchTaxInputMovement
    /// InputAmount الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? InputAmount { get; private set; }

    /// <summary>
    /// TaxPercent of the BranchTaxInputMovement
    /// TaxPercent الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the BranchTaxInputMovement
    /// TaxAmount الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// TaxAmountLocal of the BranchTaxInputMovement
    /// TaxAmountLocal الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? TaxAmountLocal { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchTaxInputMovement
    /// ReferenceNumber الخاص بـ BranchTaxInputMovement
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchTaxInputMovement
    /// RecordNumber الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the BranchTaxInputMovement
    /// DocSequence الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchTaxInputMovement
    /// ExternalPostFlag الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchTaxInputMovement
    /// CompanyNumberShort الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchTaxInputMovement
    /// BranchNumber الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchTaxInputMovement
    /// BranchYear الخاص بـ BranchTaxInputMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchTaxInputMovement
    /// BranchUser الخاص بـ BranchTaxInputMovement
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
