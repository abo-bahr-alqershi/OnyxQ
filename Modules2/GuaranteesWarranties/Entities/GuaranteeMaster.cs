using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;
namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeMaster Entity
/// </summary>
public class GuaranteeMaster : Entity<GuaranteeMasterId>
{

    private GuaranteeMaster() { }

    public GuaranteeMaster(GuaranteeMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the GuaranteeMaster
    /// المعرف الفريد لـ GuaranteeMaster
    /// </summary>
    public GuaranteeMasterId Id { get; private set; }

    /// <summary>
    /// GroupTypeFull of the GuaranteeMaster
    /// GroupTypeFull الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? GroupTypeFull { get; private set; }

    /// <summary>
    /// GroupNumberFull of the GuaranteeMaster
    /// GroupNumberFull الخاص بـ GuaranteeMaster
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// DocNo of the GuaranteeMaster
    /// DocNo الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the GuaranteeMaster
    /// DocSrl الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// CurCode of the GuaranteeMaster
    /// CurCode الخاص بـ GuaranteeMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CurRate of the GuaranteeMaster
    /// CurRate الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// DocDate of the GuaranteeMaster
    /// DocDate الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDsc of the GuaranteeMaster
    /// DocDsc الخاص بـ GuaranteeMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GuaranteeMaster
    /// ReferenceNumber الخاص بـ GuaranteeMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// GuaranteedName of the GuaranteeMaster
    /// GuaranteedName الخاص بـ GuaranteeMaster
    /// </summary>
    public string GuaranteedName { get; private set; }

    /// <summary>
    /// GroupAmount of the GuaranteeMaster
    /// GroupAmount الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? GroupAmount { get; private set; }

    /// <summary>
    /// IssueDate of the GuaranteeMaster
    /// IssueDate الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// EndDate of the GuaranteeMaster
    /// EndDate الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// GroupStatus of the GuaranteeMaster
    /// GroupStatus الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? GroupStatus { get; private set; }

    /// <summary>
    /// GroupTypeNumber of the GuaranteeMaster
    /// GroupTypeNumber الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? GroupTypeNumber { get; private set; }

    /// <summary>
    /// GroupTypeOther of the GuaranteeMaster
    /// GroupTypeOther الخاص بـ GuaranteeMaster
    /// </summary>
    public string GroupTypeOther { get; private set; }

    /// <summary>
    /// GroupFunctionNumber of the GuaranteeMaster
    /// GroupFunctionNumber الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? GroupFunctionNumber { get; private set; }

    /// <summary>
    /// GroupFunctionOthers of the GuaranteeMaster
    /// GroupFunctionOthers الخاص بـ GuaranteeMaster
    /// </summary>
    public string GroupFunctionOthers { get; private set; }

    /// <summary>
    /// GroupReason of the GuaranteeMaster
    /// GroupReason الخاص بـ GuaranteeMaster
    /// </summary>
    public string GroupReason { get; private set; }

    /// <summary>
    /// GroupPurpose of the GuaranteeMaster
    /// GroupPurpose الخاص بـ GuaranteeMaster
    /// </summary>
    public string GroupPurpose { get; private set; }

    /// <summary>
    /// BankNumber of the GuaranteeMaster
    /// BankNumber الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// BankName of the GuaranteeMaster
    /// BankName الخاص بـ GuaranteeMaster
    /// </summary>
    public string BankName { get; private set; }

    /// <summary>
    /// UseSystemAccountType of the GuaranteeMaster
    /// UseSystemAccountType الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? UseSystemAccountType { get; private set; }

    /// <summary>
    /// GroupCloseFlag of the GuaranteeMaster
    /// GroupCloseFlag الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? GroupCloseFlag { get; private set; }

    /// <summary>
    /// GroupCloseDate of the GuaranteeMaster
    /// GroupCloseDate الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? GroupCloseDate { get; private set; }

    /// <summary>
    /// ReceiveGuarantor of the GuaranteeMaster
    /// ReceiveGuarantor الخاص بـ GuaranteeMaster
    /// </summary>
    public string ReceiveGuarantor { get; private set; }

    /// <summary>
    /// DocPy of the GuaranteeMaster
    /// DocPy الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocPy { get; private set; }

    /// <summary>
    /// DocSq of the GuaranteeMaster
    /// DocSq الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// Field1 of the GuaranteeMaster
    /// Field1 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GuaranteeMaster
    /// Field2 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GuaranteeMaster
    /// Field3 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the GuaranteeMaster
    /// Field4 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the GuaranteeMaster
    /// Field5 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the GuaranteeMaster
    /// Field6 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the GuaranteeMaster
    /// Field7 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the GuaranteeMaster
    /// Field8 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the GuaranteeMaster
    /// Field9 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the GuaranteeMaster
    /// Field10 الخاص بـ GuaranteeMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// StandByFlag of the GuaranteeMaster
    /// StandByFlag الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GuaranteeMaster
    /// ExternalPostFlag الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// AuditReference of the GuaranteeMaster
    /// AuditReference الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the GuaranteeMaster
    /// AuditReferenceDescription الخاص بـ GuaranteeMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the GuaranteeMaster
    /// AuditReferenceUserId الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the GuaranteeMaster
    /// AuditReferenceDate الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// OptionalPostFlag of the GuaranteeMaster
    /// OptionalPostFlag الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? OptionalPostFlag { get; private set; }

    /// <summary>
    /// DocPost of the GuaranteeMaster
    /// DocPost الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the GuaranteeMaster
    /// PostUserId الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the GuaranteeMaster
    /// PostDate الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the GuaranteeMaster
    /// UnpostUserId الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the GuaranteeMaster
    /// UnpostDate الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// DocTypRef of the GuaranteeMaster
    /// DocTypRef الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the GuaranteeMaster
    /// DocJvTypRef الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the GuaranteeMaster
    /// DocNoRef الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the GuaranteeMaster
    /// DocSrlRef الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocPostRef of the GuaranteeMaster
    /// DocPostRef الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? DocPostRef { get; private set; }

    /// <summary>
    /// PostUserIdReference of the GuaranteeMaster
    /// PostUserIdReference الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? PostUserIdReference { get; private set; }

    /// <summary>
    /// PostDateReference of the GuaranteeMaster
    /// PostDateReference الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? PostDateReference { get; private set; }

    /// <summary>
    /// UnpostUserIdReference of the GuaranteeMaster
    /// UnpostUserIdReference الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? UnpostUserIdReference { get; private set; }

    /// <summary>
    /// UnpostDateReference of the GuaranteeMaster
    /// UnpostDateReference الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? UnpostDateReference { get; private set; }

    /// <summary>
    /// ChangeFlag of the GuaranteeMaster
    /// ChangeFlag الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? ChangeFlag { get; private set; }

    /// <summary>
    /// CreatedByUserIdReference of the GuaranteeMaster
    /// CreatedByUserIdReference الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? CreatedByUserIdReference { get; private set; }

    /// <summary>
    /// CreatedDateReference of the GuaranteeMaster
    /// CreatedDateReference الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? CreatedDateReference { get; private set; }

    /// <summary>
    /// UpdateUserIdReference of the GuaranteeMaster
    /// UpdateUserIdReference الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? UpdateUserIdReference { get; private set; }

    /// <summary>
    /// UpdateDateReference of the GuaranteeMaster
    /// UpdateDateReference الخاص بـ GuaranteeMaster
    /// </summary>
    public DateTime? UpdateDateReference { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GuaranteeMaster
    /// CompanyNumberShort الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GuaranteeMaster
    /// BranchNumber الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GuaranteeMaster
    /// BranchYear الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GuaranteeMaster
    /// BranchUser الخاص بـ GuaranteeMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

