using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// JournalVoucherMaster Entity
/// </summary>
public class JournalVoucherMaster : Entity<JournalVoucherMasterId>
{

    private JournalVoucherMaster() { }

    public JournalVoucherMaster(JournalVoucherMasterId id, decimal? journalSerial)
    {
        Id = id;
        JournalSerial = journalSerial;
    }

    /// <summary>
    /// The unique identifier for the JournalVoucherMaster
    /// المعرف الفريد لـ JournalVoucherMaster
    /// </summary>
    public JournalVoucherMasterId Id { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the JournalVoucherMaster
    /// JournalDocumentNumber الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the JournalVoucherMaster
    /// JournalSerial الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// JournalPostFlag of the JournalVoucherMaster
    /// JournalPostFlag الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? JournalPostFlag { get; private set; }

    /// <summary>
    /// JournalDate of the JournalVoucherMaster
    /// JournalDate الخاص بـ JournalVoucherMaster
    /// </summary>
    public DateTime? JournalDate { get; private set; }

    /// <summary>
    /// BatchValue of the JournalVoucherMaster
    /// BatchValue الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? BatchValue { get; private set; }

    /// <summary>
    /// ReferenceNumber of the JournalVoucherMaster
    /// ReferenceNumber الخاص بـ JournalVoucherMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReverseJournal of the JournalVoucherMaster
    /// ReverseJournal الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? ReverseJournal { get; private set; }

    /// <summary>
    /// PeriodicalJournal of the JournalVoucherMaster
    /// PeriodicalJournal الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? PeriodicalJournal { get; private set; }

    /// <summary>
    /// CashReserve of the JournalVoucherMaster
    /// CashReserve الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? CashReserve { get; private set; }

    /// <summary>
    /// StandByFlag of the JournalVoucherMaster
    /// StandByFlag الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// LinkUseFlag of the JournalVoucherMaster
    /// LinkUseFlag الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? LinkUseFlag { get; private set; }

    /// <summary>
    /// AttachmentNumber of the JournalVoucherMaster
    /// AttachmentNumber الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// BeneficiaryName of the JournalVoucherMaster
    /// BeneficiaryName الخاص بـ JournalVoucherMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ReceiverName of the JournalVoucherMaster
    /// ReceiverName الخاص بـ JournalVoucherMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// TDescription of the JournalVoucherMaster
    /// TDescription الخاص بـ JournalVoucherMaster
    /// </summary>
    public string TDescription { get; private set; }

    /// <summary>
    /// AuditReference of the JournalVoucherMaster
    /// AuditReference الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the JournalVoucherMaster
    /// AuditReferenceDescription الخاص بـ JournalVoucherMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the JournalVoucherMaster
    /// AuditReferenceUserId الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the JournalVoucherMaster
    /// AuditReferenceDate الخاص بـ JournalVoucherMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ClassZeroAccountBalance of the JournalVoucherMaster
    /// ClassZeroAccountBalance الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? ClassZeroAccountBalance { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the JournalVoucherMaster
    /// ExternalPostFlag الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// PostUserId of the JournalVoucherMaster
    /// PostUserId الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the JournalVoucherMaster
    /// PostDate الخاص بـ JournalVoucherMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the JournalVoucherMaster
    /// UnpostUserId الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the JournalVoucherMaster
    /// UnpostDate الخاص بـ JournalVoucherMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// Field1 of the JournalVoucherMaster
    /// Field1 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the JournalVoucherMaster
    /// Field2 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the JournalVoucherMaster
    /// Field3 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the JournalVoucherMaster
    /// Field4 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the JournalVoucherMaster
    /// Field5 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the JournalVoucherMaster
    /// Field6 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the JournalVoucherMaster
    /// Field7 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the JournalVoucherMaster
    /// Field8 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the JournalVoucherMaster
    /// Field9 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the JournalVoucherMaster
    /// Field10 الخاص بـ JournalVoucherMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the JournalVoucherMaster
    /// CompanyNumberShort الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the JournalVoucherMaster
    /// BranchNumber الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the JournalVoucherMaster
    /// BranchYear الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the JournalVoucherMaster
    /// BranchUser الخاص بـ JournalVoucherMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public JournalVoucherType JournalVoucherType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
