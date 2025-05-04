using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// Signature Entity
/// </summary>
public class Signature : Entity<SignatureId>
{

    private Signature() { }

    public Signature(SignatureId id, decimal? languageNumber, decimal? formNumber, decimal? journalVoucherTypeFull)
    {
        Id = id;
        LanguageNumber = languageNumber;
        FormNumber = formNumber;
        JournalVoucherTypeFull = journalVoucherTypeFull;
    }

    /// <summary>
    /// The unique identifier for the Signature
    /// المعرف الفريد لـ Signature
    /// </summary>
    public SignatureId Id { get; private set; }

    /// <summary>
    /// LanguageNumber of the Signature
    /// LanguageNumber الخاص بـ Signature
    /// </summary>
    public decimal? LanguageNumber { get; private set; }

    /// <summary>
    /// FormNumber of the Signature
    /// FormNumber الخاص بـ Signature
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// DocType of the Signature
    /// DocType الخاص بـ Signature
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the Signature
    /// JournalVoucherTypeFull الخاص بـ Signature
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocTypeAName of the Signature
    /// DocTypeAName الخاص بـ Signature
    /// </summary>
    public string DocTypeAName { get; private set; }

    /// <summary>
    /// DocTypeEName of the Signature
    /// DocTypeEName الخاص بـ Signature
    /// </summary>
    public string DocTypeEName { get; private set; }

    /// <summary>
    /// Signature1 of the Signature
    /// Signature1 الخاص بـ Signature
    /// </summary>
    public string Signature1 { get; private set; }

    /// <summary>
    /// Signature2 of the Signature
    /// Signature2 الخاص بـ Signature
    /// </summary>
    public string Signature2 { get; private set; }

    /// <summary>
    /// Signature3 of the Signature
    /// Signature3 الخاص بـ Signature
    /// </summary>
    public string Signature3 { get; private set; }

    /// <summary>
    /// Signature4 of the Signature
    /// Signature4 الخاص بـ Signature
    /// </summary>
    public string Signature4 { get; private set; }

    /// <summary>
    /// Signature5 of the Signature
    /// Signature5 الخاص بـ Signature
    /// </summary>
    public string Signature5 { get; private set; }

    /// <summary>
    /// Signature6 of the Signature
    /// Signature6 الخاص بـ Signature
    /// </summary>
    public string Signature6 { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
