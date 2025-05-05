using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerAdvanceExpenseRevenueDetail Entity
/// </summary>
public class GeneralLedgerAdvanceExpenseRevenueDetail : Entity<GeneralLedgerAdvanceExpenseRevenueDetailId>
{

    private GeneralLedgerAdvanceExpenseRevenueDetail() { }

    public GeneralLedgerAdvanceExpenseRevenueDetail(GeneralLedgerAdvanceExpenseRevenueDetailId id, decimal? docDSq)
    {
        Id = id;
        DocDSq = docDSq;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerAdvanceExpenseRevenueDetail
    /// المعرف الفريد لـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public GeneralLedgerAdvanceExpenseRevenueDetailId Id { get; private set; }

    /// <summary>
    /// DocTyp of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// DocTyp الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// DocNo الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDSq of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// DocDSq الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? DocDSq { get; private set; }

    /// <summary>
    /// ItemNumber of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// ItemNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// InvoiceAmountLocal of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// InvoiceAmountLocal الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? InvoiceAmountLocal { get; private set; }

    /// <summary>
    /// InvoiceAmountForeign of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// InvoiceAmountForeign الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? InvoiceAmountForeign { get; private set; }

    /// <summary>
    /// DueDate of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// DueDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public DateTime? DueDate { get; private set; }

    /// <summary>
    /// DueFlg of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// DueFlg الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? DueFlg { get; private set; }

    /// <summary>
    /// DocDDsc of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// DocDDsc الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string DocDDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// ReferenceNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// Field1Alt of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// Field1Alt الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string Field1Alt { get; private set; }

    /// <summary>
    /// Field2Alt of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// Field2Alt الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string Field2Alt { get; private set; }

    /// <summary>
    /// Field3Alt of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// Field3Alt الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string Field3Alt { get; private set; }

    /// <summary>
    /// Field4Alt of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// Field4Alt الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string Field4Alt { get; private set; }

    /// <summary>
    /// Field5Alt of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// Field5Alt الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string Field5Alt { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// ExternalPostFlag الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// AuditReference of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// AuditReference الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// AuditReferenceDescription الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// AuditReferenceUserId الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// AuditReferenceDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// DocPost of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// DocPost الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// PostUserId الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// PostDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// UnpostUserId الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// UnpostDate الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// CompanyNumberShort الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// BranchNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// BranchYear الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// BranchUser الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerAdvanceExpenseRevenueDetail
    /// RecordNumber الخاص بـ GeneralLedgerAdvanceExpenseRevenueDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerAdvanceExpenseRevenueMaster GeneralLedgerAdvanceExpenseRevenueMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

