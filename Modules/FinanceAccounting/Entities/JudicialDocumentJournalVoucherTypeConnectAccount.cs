using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// JudicialDocumentJournalVoucherTypeConnectAccount Entity
/// </summary>
public class JudicialDocumentJournalVoucherTypeConnectAccount : Entity<JudicialDocumentJournalVoucherTypeConnectAccountId>
{
    private JudicialDocumentJournalVoucherTypeConnectAccount() { }

    /// <summary>
    /// The unique identifier for the JudicialDocumentJournalVoucherTypeConnectAccount
    /// المعرف الفريد لـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public JudicialDocumentJournalVoucherTypeConnectAccountId Id { get; private set; }

    /// <summary>
    /// DocTyp of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// DocTyp الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// JournalVoucherType of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// JournalVoucherType الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? JournalVoucherType { get; private set; }

    /// <summary>
    /// AccountCode of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// AccountCode الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// AccountDetailCode الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// AccountDetailType الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCodeStatus of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// AccountCodeStatus الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? AccountCodeStatus { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// CompanyNumberShort الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// BranchNumber الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// BranchYear الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the JudicialDocumentJournalVoucherTypeConnectAccount
    /// BranchUser الخاص بـ JudicialDocumentJournalVoucherTypeConnectAccount
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
