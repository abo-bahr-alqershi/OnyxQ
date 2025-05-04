using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// PostMaster Entity
/// </summary>
public class PostMaster : Entity<PostMasterId>
{

    private PostMaster() { }

    public PostMaster(PostMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the PostMaster
    /// المعرف الفريد لـ PostMaster
    /// </summary>
    public PostMasterId Id { get; private set; }

    /// <summary>
    /// DocType of the PostMaster
    /// DocType الخاص بـ PostMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the PostMaster
    /// JournalVoucherTypeFull الخاص بـ PostMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the PostMaster
    /// DocNo الخاص بـ PostMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the PostMaster
    /// DocSer الخاص بـ PostMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the PostMaster
    /// DocDate الخاص بـ PostMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDueDate of the PostMaster
    /// DocDueDate الخاص بـ PostMaster
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// ProjectNumber of the PostMaster
    /// ProjectNumber الخاص بـ PostMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// CashNumber of the PostMaster
    /// CashNumber الخاص بـ PostMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// HierarchyNumber of the PostMaster
    /// HierarchyNumber الخاص بـ PostMaster
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// DocPost of the PostMaster
    /// DocPost الخاص بـ PostMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// DocClose of the PostMaster
    /// DocClose الخاص بـ PostMaster
    /// </summary>
    public decimal? DocClose { get; private set; }

    /// <summary>
    /// InvoiceCloseFlag of the PostMaster
    /// InvoiceCloseFlag الخاص بـ PostMaster
    /// </summary>
    public decimal? InvoiceCloseFlag { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PostMaster
    /// ReferenceNumber الخاص بـ PostMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocTypeRef of the PostMaster
    /// DocTypeRef الخاص بـ PostMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the PostMaster
    /// DocJvTypeRef الخاص بـ PostMaster
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the PostMaster
    /// DocNoRef الخاص بـ PostMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PostMaster
    /// DocSerRef الخاص بـ PostMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the PostMaster
    /// ExternalPostFlag الخاص بـ PostMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// TerminalName of the PostMaster
    /// TerminalName الخاص بـ PostMaster
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// AuditReference of the PostMaster
    /// AuditReference الخاص بـ PostMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the PostMaster
    /// AuditReferenceDescription الخاص بـ PostMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the PostMaster
    /// AuditReferenceUserId الخاص بـ PostMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the PostMaster
    /// AuditReferenceDate الخاص بـ PostMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// DocBrnNo of the PostMaster
    /// DocBrnNo الخاص بـ PostMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// PostUserId of the PostMaster
    /// PostUserId الخاص بـ PostMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the PostMaster
    /// PostDate الخاص بـ PostMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the PostMaster
    /// UnpostUserId الخاص بـ PostMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the PostMaster
    /// UnpostDate الخاص بـ PostMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PostMaster
    /// CompanyNumberShort الخاص بـ PostMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PostMaster
    /// BranchNumber الخاص بـ PostMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PostMaster
    /// BranchYear الخاص بـ PostMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PostMaster
    /// BranchUser الخاص بـ PostMaster
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
    public Branch Branch { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PeriodDetail PeriodDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
