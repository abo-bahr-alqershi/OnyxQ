using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;
namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestJournalMaster Entity
/// </summary>
public class RequestJournalMaster : Entity<RequestJournalMasterId>
{

    private RequestJournalMaster() { }

    public RequestJournalMaster(RequestJournalMasterId id, decimal? journalSerial)
    {
        Id = id;
        JournalSerial = journalSerial;
    }

    /// <summary>
    /// The unique identifier for the RequestJournalMaster
    /// المعرف الفريد لـ RequestJournalMaster
    /// </summary>
    public RequestJournalMasterId Id { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the RequestJournalMaster
    /// JournalDocumentNumber الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the RequestJournalMaster
    /// JournalSerial الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// JournalDate of the RequestJournalMaster
    /// JournalDate الخاص بـ RequestJournalMaster
    /// </summary>
    public DateTime? JournalDate { get; private set; }

    /// <summary>
    /// BatchValue of the RequestJournalMaster
    /// BatchValue الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? BatchValue { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RequestJournalMaster
    /// ReferenceNumber الخاص بـ RequestJournalMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReverseJournal of the RequestJournalMaster
    /// ReverseJournal الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? ReverseJournal { get; private set; }

    /// <summary>
    /// PeriodicalJournal of the RequestJournalMaster
    /// PeriodicalJournal الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? PeriodicalJournal { get; private set; }

    /// <summary>
    /// CashReserve of the RequestJournalMaster
    /// CashReserve الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? CashReserve { get; private set; }

    /// <summary>
    /// StandByFlag of the RequestJournalMaster
    /// StandByFlag الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// LinkUseFlag of the RequestJournalMaster
    /// LinkUseFlag الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? LinkUseFlag { get; private set; }

    /// <summary>
    /// AttachmentNumber of the RequestJournalMaster
    /// AttachmentNumber الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// TDescription of the RequestJournalMaster
    /// TDescription الخاص بـ RequestJournalMaster
    /// </summary>
    public string TDescription { get; private set; }

    /// <summary>
    /// ClassZeroAccountBalance of the RequestJournalMaster
    /// ClassZeroAccountBalance الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? ClassZeroAccountBalance { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the RequestJournalMaster
    /// ProcessedFlagAlt الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// ApprovedFlag of the RequestJournalMaster
    /// ApprovedFlag الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the RequestJournalMaster
    /// ApprovalUserId الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the RequestJournalMaster
    /// ApprovalDate الخاص بـ RequestJournalMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the RequestJournalMaster
    /// ApprovalDescription الخاص بـ RequestJournalMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the RequestJournalMaster
    /// InactiveFlag الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the RequestJournalMaster
    /// InactiveReason الخاص بـ RequestJournalMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the RequestJournalMaster
    /// InactivatedByUserId الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the RequestJournalMaster
    /// InactiveDate الخاص بـ RequestJournalMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// BeneficiaryName of the RequestJournalMaster
    /// BeneficiaryName الخاص بـ RequestJournalMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ReceiverName of the RequestJournalMaster
    /// ReceiverName الخاص بـ RequestJournalMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// RequestSide of the RequestJournalMaster
    /// RequestSide الخاص بـ RequestJournalMaster
    /// </summary>
    public string RequestSide { get; private set; }

    /// <summary>
    /// RequestReason of the RequestJournalMaster
    /// RequestReason الخاص بـ RequestJournalMaster
    /// </summary>
    public string RequestReason { get; private set; }

    /// <summary>
    /// Field1 of the RequestJournalMaster
    /// Field1 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the RequestJournalMaster
    /// Field2 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the RequestJournalMaster
    /// Field3 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the RequestJournalMaster
    /// Field4 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the RequestJournalMaster
    /// Field5 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the RequestJournalMaster
    /// Field6 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the RequestJournalMaster
    /// Field7 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the RequestJournalMaster
    /// Field8 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the RequestJournalMaster
    /// Field9 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the RequestJournalMaster
    /// Field10 الخاص بـ RequestJournalMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestJournalMaster
    /// CompanyNumberShort الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestJournalMaster
    /// BranchNumber الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestJournalMaster
    /// BranchYear الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestJournalMaster
    /// BranchUser الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocNoYr of the RequestJournalMaster
    /// DocNoYr الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? DocNoYr { get; private set; }

    /// <summary>
    /// DocSrlYr of the RequestJournalMaster
    /// DocSrlYr الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? DocSrlYr { get; private set; }

    /// <summary>
    /// MovedYear of the RequestJournalMaster
    /// MovedYear الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? MovedYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the RequestJournalMaster
    /// ExternalPostFlag الخاص بـ RequestJournalMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerRequestTypes GeneralLedgerRequestTypes { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

