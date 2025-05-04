using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeIncreaseMaster Entity
/// </summary>
public class GuaranteeIncreaseMaster : Entity<GuaranteeIncreaseMasterId>
{

    private GuaranteeIncreaseMaster() { }

    public GuaranteeIncreaseMaster(GuaranteeIncreaseMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the GuaranteeIncreaseMaster
    /// المعرف الفريد لـ GuaranteeIncreaseMaster
    /// </summary>
    public GuaranteeIncreaseMasterId Id { get; private set; }

    /// <summary>
    /// GroupTypeFull of the GuaranteeIncreaseMaster
    /// GroupTypeFull الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? GroupTypeFull { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GuaranteeIncreaseMaster
    /// GroupNumberFull الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// DocNo of the GuaranteeIncreaseMaster
    /// DocNo الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the GuaranteeIncreaseMaster
    /// DocSrl الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// CurCode of the GuaranteeIncreaseMaster
    /// CurCode الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurRate of the GuaranteeIncreaseMaster
    /// CurRate الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// DocDate of the GuaranteeIncreaseMaster
    /// DocDate الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDsc of the GuaranteeIncreaseMaster
    /// DocDsc الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GuaranteeIncreaseMaster
    /// ReferenceNumber الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// GuaranteedName of the GuaranteeIncreaseMaster
    /// GuaranteedName الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string GuaranteedName { get; private set; }

    /// <summary>
    /// GroupAmount of the GuaranteeIncreaseMaster
    /// GroupAmount الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? GroupAmount { get; private set; }

    /// <summary>
    /// IssueDate of the GuaranteeIncreaseMaster
    /// IssueDate الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// EndDate of the GuaranteeIncreaseMaster
    /// EndDate الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// GroupStatus of the GuaranteeIncreaseMaster
    /// GroupStatus الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? GroupStatus { get; private set; }

    /// <summary>
    /// GroupTypeNumber of the GuaranteeIncreaseMaster
    /// GroupTypeNumber الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? GroupTypeNumber { get; private set; }

    /// <summary>
    /// GroupTypeOther of the GuaranteeIncreaseMaster
    /// GroupTypeOther الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string GroupTypeOther { get; private set; }

    /// <summary>
    /// GroupFunctionNumber of the GuaranteeIncreaseMaster
    /// GroupFunctionNumber الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? GroupFunctionNumber { get; private set; }

    /// <summary>
    /// GroupFunctionOthers of the GuaranteeIncreaseMaster
    /// GroupFunctionOthers الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string GroupFunctionOthers { get; private set; }

    /// <summary>
    /// GroupReason of the GuaranteeIncreaseMaster
    /// GroupReason الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string GroupReason { get; private set; }

    /// <summary>
    /// GroupPurpose of the GuaranteeIncreaseMaster
    /// GroupPurpose الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string GroupPurpose { get; private set; }

    /// <summary>
    /// BankNumber of the GuaranteeIncreaseMaster
    /// BankNumber الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// BankName of the GuaranteeIncreaseMaster
    /// BankName الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string BankName { get; private set; }

    /// <summary>
    /// GroupCloseFlag of the GuaranteeIncreaseMaster
    /// GroupCloseFlag الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? GroupCloseFlag { get; private set; }

    /// <summary>
    /// ReceiveGuarantor of the GuaranteeIncreaseMaster
    /// ReceiveGuarantor الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string ReceiveGuarantor { get; private set; }

    /// <summary>
    /// GroupIncreaseType of the GuaranteeIncreaseMaster
    /// GroupIncreaseType الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? GroupIncreaseType { get; private set; }

    /// <summary>
    /// DocPy of the GuaranteeIncreaseMaster
    /// DocPy الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocPy { get; private set; }

    /// <summary>
    /// DocSq of the GuaranteeIncreaseMaster
    /// DocSq الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// Field1 of the GuaranteeIncreaseMaster
    /// Field1 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GuaranteeIncreaseMaster
    /// Field2 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GuaranteeIncreaseMaster
    /// Field3 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the GuaranteeIncreaseMaster
    /// Field4 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the GuaranteeIncreaseMaster
    /// Field5 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the GuaranteeIncreaseMaster
    /// Field6 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the GuaranteeIncreaseMaster
    /// Field7 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the GuaranteeIncreaseMaster
    /// Field8 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the GuaranteeIncreaseMaster
    /// Field9 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the GuaranteeIncreaseMaster
    /// Field10 الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// StandByFlag of the GuaranteeIncreaseMaster
    /// StandByFlag الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GuaranteeIncreaseMaster
    /// ExternalPostFlag الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// AuditReference of the GuaranteeIncreaseMaster
    /// AuditReference الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the GuaranteeIncreaseMaster
    /// AuditReferenceDescription الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the GuaranteeIncreaseMaster
    /// AuditReferenceUserId الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the GuaranteeIncreaseMaster
    /// AuditReferenceDate الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// OptionalPostFlag of the GuaranteeIncreaseMaster
    /// OptionalPostFlag الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? OptionalPostFlag { get; private set; }

    /// <summary>
    /// DocPost of the GuaranteeIncreaseMaster
    /// DocPost الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the GuaranteeIncreaseMaster
    /// PostUserId الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the GuaranteeIncreaseMaster
    /// PostDate الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the GuaranteeIncreaseMaster
    /// UnpostUserId الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the GuaranteeIncreaseMaster
    /// UnpostDate الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// DocTypRef of the GuaranteeIncreaseMaster
    /// DocTypRef الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the GuaranteeIncreaseMaster
    /// DocJvTypRef الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the GuaranteeIncreaseMaster
    /// DocNoRef الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the GuaranteeIncreaseMaster
    /// DocSrlRef الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GuaranteeIncreaseMaster
    /// CompanyNumberShort الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GuaranteeIncreaseMaster
    /// BranchNumber الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GuaranteeIncreaseMaster
    /// BranchYear الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GuaranteeIncreaseMaster
    /// BranchUser الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// UseSystemAccountType of the GuaranteeIncreaseMaster
    /// UseSystemAccountType الخاص بـ GuaranteeIncreaseMaster
    /// </summary>
    public decimal? UseSystemAccountType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
