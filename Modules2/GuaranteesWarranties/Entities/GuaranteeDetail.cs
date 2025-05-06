using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;
namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeDetail Entity
/// </summary>
public class GuaranteeDetail : Entity<GuaranteeDetailId>
{

    private GuaranteeDetail() { }

    public GuaranteeDetail(GuaranteeDetailId id, decimal? docSq)
    {
        Id = id;
        DocSq = docSq;
    }

    /// <summary>
    /// The unique identifier for the GuaranteeDetail
    /// المعرف الفريد لـ GuaranteeDetail
    /// </summary>
    public GuaranteeDetailId Id { get; private set; }

    /// <summary>
    /// GroupTypeFull of the GuaranteeDetail
    /// GroupTypeFull الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? GroupTypeFull { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GuaranteeDetail
    /// GroupNumberFull الخاص بـ GuaranteeDetail
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// DocNo of the GuaranteeDetail
    /// DocNo الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the GuaranteeDetail
    /// DocSrl الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocTyp of the GuaranteeDetail
    /// DocTyp الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// GroupAccountType of the GuaranteeDetail
    /// GroupAccountType الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? GroupAccountType { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GuaranteeDetail
    /// AccountDetailCode الخاص بـ GuaranteeDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GuaranteeDetail
    /// AccountDetailSubCode الخاص بـ GuaranteeDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GuaranteeDetail
    /// AccountDetailType الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// DocDsc of the GuaranteeDetail
    /// DocDsc الخاص بـ GuaranteeDetail
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CurRate of the GuaranteeDetail
    /// CurRate الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// AmountLocal of the GuaranteeDetail
    /// AmountLocal الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the GuaranteeDetail
    /// AmountForeign الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GuaranteeDetail
    /// ReferenceNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the GuaranteeDetail
    /// RecordNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocDueDate of the GuaranteeDetail
    /// DocDueDate الخاص بـ GuaranteeDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// BillNumber of the GuaranteeDetail
    /// BillNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the GuaranteeDetail
    /// BillSerial الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemNumber of the GuaranteeDetail
    /// ItemNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the GuaranteeDetail
    /// WorkOrderNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the GuaranteeDetail
    /// WorkOrderSerial الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// ChequeNumber of the GuaranteeDetail
    /// ChequeNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the GuaranteeDetail
    /// NoteNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GuaranteeDetail
    /// ExternalPostFlag الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocBrnNo of the GuaranteeDetail
    /// DocBrnNo الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// DocSq of the GuaranteeDetail
    /// DocSq الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// DocTypRef of the GuaranteeDetail
    /// DocTypRef الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the GuaranteeDetail
    /// DocJvTypRef الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the GuaranteeDetail
    /// DocNoRef الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the GuaranteeDetail
    /// DocSrlRef الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocSqRef of the GuaranteeDetail
    /// DocSqRef الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? DocSqRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GuaranteeDetail
    /// CompanyNumberShort الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GuaranteeDetail
    /// BranchNumber الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GuaranteeDetail
    /// BranchYear الخاص بـ GuaranteeDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GuaranteeDetail
    /// BranchUser الخاص بـ GuaranteeDetail
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
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

