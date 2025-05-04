using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BranchJournalVoucherMaster Entity
/// </summary>
public class BranchJournalVoucherMaster : Entity<BranchJournalVoucherMasterId>
{

    private BranchJournalVoucherMaster() { }

    public BranchJournalVoucherMaster(BranchJournalVoucherMasterId id, decimal? journalSerial)
    {
        Id = id;
        JournalSerial = journalSerial;
    }

    /// <summary>
    /// The unique identifier for the BranchJournalVoucherMaster
    /// المعرف الفريد لـ BranchJournalVoucherMaster
    /// </summary>
    public BranchJournalVoucherMasterId Id { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the BranchJournalVoucherMaster
    /// JournalVoucherTypeFull الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the BranchJournalVoucherMaster
    /// JournalDocumentNumber الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the BranchJournalVoucherMaster
    /// JournalSerial الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// JournalPostFlag of the BranchJournalVoucherMaster
    /// JournalPostFlag الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? JournalPostFlag { get; private set; }

    /// <summary>
    /// JournalDate of the BranchJournalVoucherMaster
    /// JournalDate الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public DateTime? JournalDate { get; private set; }

    /// <summary>
    /// BatchValue of the BranchJournalVoucherMaster
    /// BatchValue الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? BatchValue { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchJournalVoucherMaster
    /// ReferenceNumber الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReverseJournal of the BranchJournalVoucherMaster
    /// ReverseJournal الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? ReverseJournal { get; private set; }

    /// <summary>
    /// PeriodicalJournal of the BranchJournalVoucherMaster
    /// PeriodicalJournal الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? PeriodicalJournal { get; private set; }

    /// <summary>
    /// CashReserve of the BranchJournalVoucherMaster
    /// CashReserve الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? CashReserve { get; private set; }

    /// <summary>
    /// StandByFlag of the BranchJournalVoucherMaster
    /// StandByFlag الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// LinkUseFlag of the BranchJournalVoucherMaster
    /// LinkUseFlag الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? LinkUseFlag { get; private set; }

    /// <summary>
    /// AttachmentNumber of the BranchJournalVoucherMaster
    /// AttachmentNumber الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// BeneficiaryName of the BranchJournalVoucherMaster
    /// BeneficiaryName الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ReceiverName of the BranchJournalVoucherMaster
    /// ReceiverName الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// TDescription of the BranchJournalVoucherMaster
    /// TDescription الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string TDescription { get; private set; }

    /// <summary>
    /// AuditReference of the BranchJournalVoucherMaster
    /// AuditReference الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchJournalVoucherMaster
    /// AuditReferenceDescription الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchJournalVoucherMaster
    /// AuditReferenceUserId الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchJournalVoucherMaster
    /// AuditReferenceDate الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ClassZeroAccountBalance of the BranchJournalVoucherMaster
    /// ClassZeroAccountBalance الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? ClassZeroAccountBalance { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchJournalVoucherMaster
    /// ExternalPostFlag الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// PostUserId of the BranchJournalVoucherMaster
    /// PostUserId الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchJournalVoucherMaster
    /// PostDate الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchJournalVoucherMaster
    /// UnpostUserId الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchJournalVoucherMaster
    /// UnpostDate الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// Field1 of the BranchJournalVoucherMaster
    /// Field1 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchJournalVoucherMaster
    /// Field2 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchJournalVoucherMaster
    /// Field3 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BranchJournalVoucherMaster
    /// Field4 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BranchJournalVoucherMaster
    /// Field5 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BranchJournalVoucherMaster
    /// Field6 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BranchJournalVoucherMaster
    /// Field7 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BranchJournalVoucherMaster
    /// Field8 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BranchJournalVoucherMaster
    /// Field9 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BranchJournalVoucherMaster
    /// Field10 الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchJournalVoucherMaster
    /// CompanyNumberShort الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchJournalVoucherMaster
    /// BranchNumber الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchJournalVoucherMaster
    /// BranchYear الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchJournalVoucherMaster
    /// BranchUser الخاص بـ BranchJournalVoucherMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
