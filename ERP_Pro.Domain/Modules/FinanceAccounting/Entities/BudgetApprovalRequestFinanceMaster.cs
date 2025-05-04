using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BudgetApprovalRequestFinanceMaster Entity
/// </summary>
public class BudgetApprovalRequestFinanceMaster : Entity<BudgetApprovalRequestFinanceMasterId>
{

    private BudgetApprovalRequestFinanceMaster() { }

    public BudgetApprovalRequestFinanceMaster(BudgetApprovalRequestFinanceMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the BudgetApprovalRequestFinanceMaster
    /// المعرف الفريد لـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public BudgetApprovalRequestFinanceMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the BudgetApprovalRequestFinanceMaster
    /// DocNo الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the BudgetApprovalRequestFinanceMaster
    /// DocSrl الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocDate of the BudgetApprovalRequestFinanceMaster
    /// DocDate الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDsc of the BudgetApprovalRequestFinanceMaster
    /// DocDsc الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// BeneficiaryName of the BudgetApprovalRequestFinanceMaster
    /// BeneficiaryName الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ReceiverName of the BudgetApprovalRequestFinanceMaster
    /// ReceiverName الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BudgetApprovalRequestFinanceMaster
    /// ReferenceNumber الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountCode of the BudgetApprovalRequestFinanceMaster
    /// AccountCode الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BudgetApprovalRequestFinanceMaster
    /// AccountDetailCode الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BudgetApprovalRequestFinanceMaster
    /// AccountDetailType الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// TypeNumberShort of the BudgetApprovalRequestFinanceMaster
    /// TypeNumberShort الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// CurCode of the BudgetApprovalRequestFinanceMaster
    /// CurCode الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurRate of the BudgetApprovalRequestFinanceMaster
    /// CurRate الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// AmountLocal of the BudgetApprovalRequestFinanceMaster
    /// AmountLocal الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the BudgetApprovalRequestFinanceMaster
    /// AmountForeign الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// CostCenterCode of the BudgetApprovalRequestFinanceMaster
    /// CostCenterCode الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BudgetApprovalRequestFinanceMaster
    /// ProjectNumber الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BudgetApprovalRequestFinanceMaster
    /// ActivityNumber الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AttachmentNumber of the BudgetApprovalRequestFinanceMaster
    /// AttachmentNumber الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// PaymentMethod of the BudgetApprovalRequestFinanceMaster
    /// PaymentMethod الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? PaymentMethod { get; private set; }

    /// <summary>
    /// ApprovedFlag of the BudgetApprovalRequestFinanceMaster
    /// ApprovedFlag الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the BudgetApprovalRequestFinanceMaster
    /// ApprovalUserId الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the BudgetApprovalRequestFinanceMaster
    /// ApprovalDate الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the BudgetApprovalRequestFinanceMaster
    /// ApprovalDescription الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the BudgetApprovalRequestFinanceMaster
    /// InactiveFlag الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the BudgetApprovalRequestFinanceMaster
    /// InactiveReason الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the BudgetApprovalRequestFinanceMaster
    /// InactivatedByUserId الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the BudgetApprovalRequestFinanceMaster
    /// InactiveDate الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// ProcessedFlag of the BudgetApprovalRequestFinanceMaster
    /// ProcessedFlag الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// RepCode of the BudgetApprovalRequestFinanceMaster
    /// RepCode الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// StandByFlag of the BudgetApprovalRequestFinanceMaster
    /// StandByFlag الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// PostedFlag of the BudgetApprovalRequestFinanceMaster
    /// PostedFlag الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? PostedFlag { get; private set; }

    /// <summary>
    /// Field1 of the BudgetApprovalRequestFinanceMaster
    /// Field1 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BudgetApprovalRequestFinanceMaster
    /// Field2 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BudgetApprovalRequestFinanceMaster
    /// Field3 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BudgetApprovalRequestFinanceMaster
    /// Field4 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BudgetApprovalRequestFinanceMaster
    /// Field5 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BudgetApprovalRequestFinanceMaster
    /// Field6 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BudgetApprovalRequestFinanceMaster
    /// Field7 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BudgetApprovalRequestFinanceMaster
    /// Field8 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BudgetApprovalRequestFinanceMaster
    /// Field9 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BudgetApprovalRequestFinanceMaster
    /// Field10 الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BudgetApprovalRequestFinanceMaster
    /// CompanyNumberShort الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BudgetApprovalRequestFinanceMaster
    /// BranchNumber الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BudgetApprovalRequestFinanceMaster
    /// BranchYear الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BudgetApprovalRequestFinanceMaster
    /// BranchUser الخاص بـ BudgetApprovalRequestFinanceMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
