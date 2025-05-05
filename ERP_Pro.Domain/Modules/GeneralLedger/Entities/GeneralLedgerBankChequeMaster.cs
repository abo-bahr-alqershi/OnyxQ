using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerBankChequeMaster Entity
/// </summary>
public class GeneralLedgerBankChequeMaster : AggregateRoot<GeneralLedgerBankChequeMasterId>
{

    private GeneralLedgerBankChequeMaster() { }

    public GeneralLedgerBankChequeMaster(GeneralLedgerBankChequeMasterId id, decimal? bankNumber, decimal? bookNumber, string curCode)
    {
        Id = id;
        BankNumber = bankNumber;
        BookNumber = bookNumber;
        CurCode = curCode;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerBankChequeMaster
    /// المعرف الفريد لـ GeneralLedgerBankChequeMaster
    /// </summary>
    public GeneralLedgerBankChequeMasterId Id { get; private set; }

    /// <summary>
    /// BankNumber of the GeneralLedgerBankChequeMaster
    /// BankNumber الخاص بـ GeneralLedgerBankChequeMaster
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// BookNumber of the GeneralLedgerBankChequeMaster
    /// BookNumber الخاص بـ GeneralLedgerBankChequeMaster
    /// </summary>
    public decimal? BookNumber { get; private set; }

    /// <summary>
    /// FChequeNumber of the GeneralLedgerBankChequeMaster
    /// FChequeNumber الخاص بـ GeneralLedgerBankChequeMaster
    /// </summary>
    public decimal? FChequeNumber { get; private set; }

    /// <summary>
    /// TChequeNumber of the GeneralLedgerBankChequeMaster
    /// TChequeNumber الخاص بـ GeneralLedgerBankChequeMaster
    /// </summary>
    public decimal? TChequeNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerBankChequeMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerBankChequeMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CurCode of the GeneralLedgerBankChequeMaster
    /// CurCode الخاص بـ GeneralLedgerBankChequeMaster
    /// </summary>
    public string CurCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

