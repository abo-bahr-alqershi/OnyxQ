using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerBankChequeDetail Entity
/// </summary>
public class GeneralLedgerBankChequeDetail : Entity<GeneralLedgerBankChequeDetailId>
{

    private GeneralLedgerBankChequeDetail() { }

    public GeneralLedgerBankChequeDetail(GeneralLedgerBankChequeDetailId id, decimal? chequeNumber)
    {
        Id = id;
        ChequeNumber = chequeNumber;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerBankChequeDetail
    /// المعرف الفريد لـ GeneralLedgerBankChequeDetail
    /// </summary>
    public GeneralLedgerBankChequeDetailId Id { get; private set; }

    /// <summary>
    /// ChequeNumber of the GeneralLedgerBankChequeDetail
    /// ChequeNumber الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeStatus of the GeneralLedgerBankChequeDetail
    /// ChequeStatus الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? ChequeStatus { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerBankChequeDetail
    /// DocNoRef الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the GeneralLedgerBankChequeDetail
    /// DocSrlRef الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocDateRef of the GeneralLedgerBankChequeDetail
    /// DocDateRef الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public DateTime? DocDateRef { get; private set; }

    /// <summary>
    /// Notes of the GeneralLedgerBankChequeDetail
    /// Notes الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// ChequeSignatory of the GeneralLedgerBankChequeDetail
    /// ChequeSignatory الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? ChequeSignatory { get; private set; }

    /// <summary>
    /// SignatureDate of the GeneralLedgerBankChequeDetail
    /// SignatureDate الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public DateTime? SignatureDate { get; private set; }

    /// <summary>
    /// SignaturePerson of the GeneralLedgerBankChequeDetail
    /// SignaturePerson الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public string SignaturePerson { get; private set; }

    /// <summary>
    /// ReceivedPerson of the GeneralLedgerBankChequeDetail
    /// ReceivedPerson الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public string ReceivedPerson { get; private set; }

    /// <summary>
    /// NotesChequeStatus of the GeneralLedgerBankChequeDetail
    /// NotesChequeStatus الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public string NotesChequeStatus { get; private set; }

    /// <summary>
    /// DocTypRef of the GeneralLedgerBankChequeDetail
    /// DocTypRef الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the GeneralLedgerBankChequeDetail
    /// DocJvTypRef الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// UserNoChequeStatus of the GeneralLedgerBankChequeDetail
    /// UserNoChequeStatus الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public decimal? UserNoChequeStatus { get; private set; }

    /// <summary>
    /// DateChqSt of the GeneralLedgerBankChequeDetail
    /// DateChqSt الخاص بـ GeneralLedgerBankChequeDetail
    /// </summary>
    public DateTime? DateChqSt { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CashAtBankDetail CashAtBankDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerBankChequeMaster GeneralLedgerBankChequeMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
