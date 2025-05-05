using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;
namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxInputMovement Entity
/// </summary>
public class TaxInputMovement : Entity<TaxInputMovementId>
{

    private TaxInputMovement() { }

    public TaxInputMovement(TaxInputMovementId id, decimal? docType, decimal? docSer, decimal? agencyNumber, decimal? inputType, string inputCode, decimal? recordNumber, decimal? docSequence)
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
    /// The unique identifier for the TaxInputMovement
    /// المعرف الفريد لـ TaxInputMovement
    /// </summary>
    public TaxInputMovementId Id { get; private set; }

    /// <summary>
    /// DocType of the TaxInputMovement
    /// DocType الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the TaxInputMovement
    /// BillDocumentTypeFull الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// DocJvType of the TaxInputMovement
    /// DocJvType الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the TaxInputMovement
    /// DocNo الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the TaxInputMovement
    /// DocSer الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the TaxInputMovement
    /// DocDate الخاص بـ TaxInputMovement
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AgencyNumber of the TaxInputMovement
    /// AgencyNumber الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? AgencyNumber { get; private set; }

    /// <summary>
    /// InputType of the TaxInputMovement
    /// InputType الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? InputType { get; private set; }

    /// <summary>
    /// InputCode of the TaxInputMovement
    /// InputCode الخاص بـ TaxInputMovement
    /// </summary>
    public string InputCode { get; private set; }

    /// <summary>
    /// AccountCode of the TaxInputMovement
    /// AccountCode الخاص بـ TaxInputMovement
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the TaxInputMovement
    /// AccountCurrency الخاص بـ TaxInputMovement
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the TaxInputMovement
    /// AccountRate الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// InputAmount of the TaxInputMovement
    /// InputAmount الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? InputAmount { get; private set; }

    /// <summary>
    /// TaxPercent of the TaxInputMovement
    /// TaxPercent الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// TaxAmount of the TaxInputMovement
    /// TaxAmount الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// TaxAmountLocal of the TaxInputMovement
    /// TaxAmountLocal الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? TaxAmountLocal { get; private set; }

    /// <summary>
    /// ReferenceNumber of the TaxInputMovement
    /// ReferenceNumber الخاص بـ TaxInputMovement
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the TaxInputMovement
    /// RecordNumber الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the TaxInputMovement
    /// DocSequence الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the TaxInputMovement
    /// ExternalPostFlag الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TaxInputMovement
    /// CompanyNumberShort الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TaxInputMovement
    /// BranchNumber الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TaxInputMovement
    /// BranchYear الخاص بـ TaxInputMovement
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TaxInputMovement
    /// BranchUser الخاص بـ TaxInputMovement
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

