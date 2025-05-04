using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BudgetApprovalRequestFinanceDetail Entity
/// </summary>
public class BudgetApprovalRequestFinanceDetail : Entity<BudgetApprovalRequestFinanceDetailId>
{
    private BudgetApprovalRequestFinanceDetail() { }

    /// <summary>
    /// The unique identifier for the BudgetApprovalRequestFinanceDetail
    /// المعرف الفريد لـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public BudgetApprovalRequestFinanceDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the BudgetApprovalRequestFinanceDetail
    /// RecordNumber الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocNo of the BudgetApprovalRequestFinanceDetail
    /// DocNo الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the BudgetApprovalRequestFinanceDetail
    /// DocSrl الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// AccountCode of the BudgetApprovalRequestFinanceDetail
    /// AccountCode الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BudgetApprovalRequestFinanceDetail
    /// AccountDetailCode الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BudgetApprovalRequestFinanceDetail
    /// AccountDetailType الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CurCode of the BudgetApprovalRequestFinanceDetail
    /// CurCode الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurRate of the BudgetApprovalRequestFinanceDetail
    /// CurRate الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// AmountLocal of the BudgetApprovalRequestFinanceDetail
    /// AmountLocal الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the BudgetApprovalRequestFinanceDetail
    /// AmountForeign الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// ActualBalance of the BudgetApprovalRequestFinanceDetail
    /// ActualBalance الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? ActualBalance { get; private set; }

    /// <summary>
    /// IssueAmount of the BudgetApprovalRequestFinanceDetail
    /// IssueAmount الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? IssueAmount { get; private set; }

    /// <summary>
    /// NotIssueAmount of the BudgetApprovalRequestFinanceDetail
    /// NotIssueAmount الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? NotIssueAmount { get; private set; }

    /// <summary>
    /// RepCode of the BudgetApprovalRequestFinanceDetail
    /// RepCode الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// DocDsc of the BudgetApprovalRequestFinanceDetail
    /// DocDsc الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CostCenterCode of the BudgetApprovalRequestFinanceDetail
    /// CostCenterCode الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BudgetApprovalRequestFinanceDetail
    /// ProjectNumber الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BudgetApprovalRequestFinanceDetail
    /// ActivityNumber الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DocSeq of the BudgetApprovalRequestFinanceDetail
    /// DocSeq الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// DocBrnNo of the BudgetApprovalRequestFinanceDetail
    /// DocBrnNo الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BudgetApprovalRequestFinanceDetail
    /// CompanyNumberShort الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BudgetApprovalRequestFinanceDetail
    /// BranchNumber الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BudgetApprovalRequestFinanceDetail
    /// BranchYear الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BudgetApprovalRequestFinanceDetail
    /// BranchUser الخاص بـ BudgetApprovalRequestFinanceDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BudgetApprovalRequestFinanceMaster
    /// </summary>
    public BudgetApprovalRequestFinanceMaster BudgetApprovalRequestFinanceMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion
}
}
