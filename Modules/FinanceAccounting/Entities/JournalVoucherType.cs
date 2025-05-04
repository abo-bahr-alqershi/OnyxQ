using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// JournalVoucherType Entity
/// </summary>
public class JournalVoucherType : Entity<JournalVoucherTypeId>
{
    private JournalVoucherType() { }

    /// <summary>
    /// The unique identifier for the JournalVoucherType
    /// المعرف الفريد لـ JournalVoucherType
    /// </summary>
    public JournalVoucherTypeId Id { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the JournalVoucherType
    /// JournalVoucherTypeFull الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalVoucherName of the JournalVoucherType
    /// JournalVoucherName الخاص بـ JournalVoucherType
    /// </summary>
    public string JournalVoucherName { get; private set; }

    /// <summary>
    /// JournalVoucherNameEnglish of the JournalVoucherType
    /// JournalVoucherNameEnglish الخاص بـ JournalVoucherType
    /// </summary>
    public string JournalVoucherNameEnglish { get; private set; }

    /// <summary>
    /// SequencedFlag of the JournalVoucherType
    /// SequencedFlag الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? SequencedFlag { get; private set; }

    /// <summary>
    /// PaymentReceipt of the JournalVoucherType
    /// PaymentReceipt الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? PaymentReceipt { get; private set; }

    /// <summary>
    /// GroupTypeFull of the JournalVoucherType
    /// GroupTypeFull الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? GroupTypeFull { get; private set; }

    /// <summary>
    /// RepSample of the JournalVoucherType
    /// RepSample الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? RepSample { get; private set; }

    /// <summary>
    /// ConnectionJournalVoucherRequest of the JournalVoucherType
    /// ConnectionJournalVoucherRequest الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? ConnectionJournalVoucherRequest { get; private set; }

    /// <summary>
    /// KimbType of the JournalVoucherType
    /// KimbType الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? KimbType { get; private set; }

    /// <summary>
    /// VatCorrection of the JournalVoucherType
    /// VatCorrection الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? VatCorrection { get; private set; }

    /// <summary>
    /// VatDeferredProvider of the JournalVoucherType
    /// VatDeferredProvider الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? VatDeferredProvider { get; private set; }

    /// <summary>
    /// VatProviderReverse of the JournalVoucherType
    /// VatProviderReverse الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? VatProviderReverse { get; private set; }

    /// <summary>
    /// ExpenseTaxFlag of the JournalVoucherType
    /// ExpenseTaxFlag الخاص بـ JournalVoucherType
    /// </summary>
    public decimal? ExpenseTaxFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: JournalVoucherType to JournalVoucherTypeDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherTypeDetail> JournalVoucherTypeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: JournalVoucherType to JournalVoucherMaster
    /// </summary>
    public IReadOnlyCollection<JournalVoucherMaster> JournalVoucherMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: JournalVoucherType to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
