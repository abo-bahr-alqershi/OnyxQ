using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// JournalFileMaster Entity
/// </summary>
public class JournalFileMaster : Entity<JournalFileMasterId>
{
    private JournalFileMaster() { }

    /// <summary>
    /// The unique identifier for the JournalFileMaster
    /// المعرف الفريد لـ JournalFileMaster
    /// </summary>
    public JournalFileMasterId Id { get; private set; }

    /// <summary>
    /// FileType of the JournalFileMaster
    /// FileType الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? FileType { get; private set; }

    /// <summary>
    /// DocType of the JournalFileMaster
    /// DocType الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the JournalFileMaster
    /// JournalVoucherTypeFull الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the JournalFileMaster
    /// JournalDocumentNumber الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the JournalFileMaster
    /// JournalSerial الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// JournalDate of the JournalFileMaster
    /// JournalDate الخاص بـ JournalFileMaster
    /// </summary>
    public DateTime? JournalDate { get; private set; }

    /// <summary>
    /// BatchValue of the JournalFileMaster
    /// BatchValue الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? BatchValue { get; private set; }

    /// <summary>
    /// ReferenceNumber of the JournalFileMaster
    /// ReferenceNumber الخاص بـ JournalFileMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AttachmentNumber of the JournalFileMaster
    /// AttachmentNumber الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// TDescription of the JournalFileMaster
    /// TDescription الخاص بـ JournalFileMaster
    /// </summary>
    public string TDescription { get; private set; }

    /// <summary>
    /// StandByFlag of the JournalFileMaster
    /// StandByFlag الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// ClassZeroAccountBalance of the JournalFileMaster
    /// ClassZeroAccountBalance الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? ClassZeroAccountBalance { get; private set; }

    /// <summary>
    /// AuditReference of the JournalFileMaster
    /// AuditReference الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the JournalFileMaster
    /// AuditReferenceDescription الخاص بـ JournalFileMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the JournalFileMaster
    /// AuditReferenceUserId الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the JournalFileMaster
    /// AuditReferenceDate الخاص بـ JournalFileMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// JournalPostFlag of the JournalFileMaster
    /// JournalPostFlag الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? JournalPostFlag { get; private set; }

    /// <summary>
    /// PostUserId of the JournalFileMaster
    /// PostUserId الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the JournalFileMaster
    /// PostDate الخاص بـ JournalFileMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the JournalFileMaster
    /// UnpostUserId الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the JournalFileMaster
    /// UnpostDate الخاص بـ JournalFileMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the JournalFileMaster
    /// ProcessedFlagAlt الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// ApprovedFlag of the JournalFileMaster
    /// ApprovedFlag الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the JournalFileMaster
    /// ApprovalUserId الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the JournalFileMaster
    /// ApprovalDate الخاص بـ JournalFileMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the JournalFileMaster
    /// ApprovalDescription الخاص بـ JournalFileMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the JournalFileMaster
    /// InactiveFlag الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the JournalFileMaster
    /// InactiveReason الخاص بـ JournalFileMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the JournalFileMaster
    /// InactivatedByUserId الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the JournalFileMaster
    /// InactiveDate الخاص بـ JournalFileMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the JournalFileMaster
    /// CompanyNumberShort الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the JournalFileMaster
    /// BranchNumber الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the JournalFileMaster
    /// BranchYear الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the JournalFileMaster
    /// BranchUser الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocTypRef of the JournalFileMaster
    /// DocTypRef الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the JournalFileMaster
    /// DocNoRef الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the JournalFileMaster
    /// DocSrlRef الخاص بـ JournalFileMaster
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// Field1 of the JournalFileMaster
    /// Field1 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the JournalFileMaster
    /// Field2 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the JournalFileMaster
    /// Field3 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the JournalFileMaster
    /// Field4 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the JournalFileMaster
    /// Field5 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the JournalFileMaster
    /// Field6 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the JournalFileMaster
    /// Field7 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the JournalFileMaster
    /// Field8 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the JournalFileMaster
    /// Field9 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the JournalFileMaster
    /// Field10 الخاص بـ JournalFileMaster
    /// </summary>
    public string Field10 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: JournalFileMaster to JournalFileDetail
    /// </summary>
    public IReadOnlyCollection<JournalFileDetail> JournalFileDetails { get; private set; }
    #endregion
}
}
