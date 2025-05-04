using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerBankIdentificationDetail Entity
/// </summary>
public class GeneralLedgerBankIdentificationDetail : Entity<GeneralLedgerBankIdentificationDetailId>
{
    private GeneralLedgerBankIdentificationDetail() { }

    /// <summary>
    /// The unique identifier for the GeneralLedgerBankIdentificationDetail
    /// المعرف الفريد لـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public GeneralLedgerBankIdentificationDetailId Id { get; private set; }

    /// <summary>
    /// StatementType of the GeneralLedgerBankIdentificationDetail
    /// StatementType الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? StatementType { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerBankIdentificationDetail
    /// DocNo الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the GeneralLedgerBankIdentificationDetail
    /// DocSrl الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocMSq of the GeneralLedgerBankIdentificationDetail
    /// DocMSq الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// DocDSq of the GeneralLedgerBankIdentificationDetail
    /// DocDSq الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocDSq { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerBankIdentificationDetail
    /// RecordNumber الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerBankIdentificationDetail
    /// AccountCode الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationDetail
    /// 30 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerBankIdentificationDetail
    /// AccountDetailCode الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationDetail
    /// 30 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerBankIdentificationDetail
    /// AccountDetailType الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CurCode of the GeneralLedgerBankIdentificationDetail
    /// CurCode الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// 7 of the GeneralLedgerBankIdentificationDetail
    /// 7 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 7 { get; private set; }

    /// <summary>
    /// ChequeNumber of the GeneralLedgerBankIdentificationDetail
    /// ChequeNumber الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ChequeDate of the GeneralLedgerBankIdentificationDetail
    /// ChequeDate الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public DateTime? ChequeDate { get; private set; }

    /// <summary>
    /// DrAmt of the GeneralLedgerBankIdentificationDetail
    /// DrAmt الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// CreditAmount of the GeneralLedgerBankIdentificationDetail
    /// CreditAmount الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// NoteNumberBank of the GeneralLedgerBankIdentificationDetail
    /// NoteNumberBank الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string NoteNumberBank { get; private set; }

    /// <summary>
    /// 20 of the GeneralLedgerBankIdentificationDetail
    /// 20 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 20 { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerBankIdentificationDetail
    /// ReferenceNumber الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationDetail
    /// 30 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// DocDDsc of the GeneralLedgerBankIdentificationDetail
    /// DocDDsc الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string DocDDsc { get; private set; }

    /// <summary>
    /// 500 of the GeneralLedgerBankIdentificationDetail
    /// 500 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 500 { get; private set; }

    /// <summary>
    /// IdentifyFlag of the GeneralLedgerBankIdentificationDetail
    /// IdentifyFlag الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? IdentifyFlag { get; private set; }

    /// <summary>
    /// IdentifyManualFlag of the GeneralLedgerBankIdentificationDetail
    /// IdentifyManualFlag الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? IdentifyManualFlag { get; private set; }

    /// <summary>
    /// 50 of the GeneralLedgerBankIdentificationDetail
    /// 50 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 50 { get; private set; }

    /// <summary>
    /// 50 of the GeneralLedgerBankIdentificationDetail
    /// 50 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 50 { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerBankIdentificationDetail
    /// BranchNumber الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerBankIdentificationDetail
    /// BranchYear الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerBankIdentificationDetail
    /// BranchUser الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerBankIdentificationDetail
    /// CostCenterCode الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationDetail
    /// 30 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerBankIdentificationDetail
    /// ProjectNumber الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// 15 of the GeneralLedgerBankIdentificationDetail
    /// 15 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 15 { get; private set; }

    /// <summary>
    /// ActivityNumber of the GeneralLedgerBankIdentificationDetail
    /// ActivityNumber الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// 15 of the GeneralLedgerBankIdentificationDetail
    /// 15 الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public string 15 { get; private set; }

    /// <summary>
    /// DocTypRef of the GeneralLedgerBankIdentificationDetail
    /// DocTypRef الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerBankIdentificationDetail
    /// DocNoRef الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the GeneralLedgerBankIdentificationDetail
    /// DocSrlRef الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocDSqRef of the GeneralLedgerBankIdentificationDetail
    /// DocDSqRef الخاص بـ GeneralLedgerBankIdentificationDetail
    /// </summary>
    public decimal? DocDSqRef { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerBankIdentificationMaster
    /// </summary>
    public GeneralLedgerBankIdentificationMaster GeneralLedgerBankIdentificationMaster { get; private set; }
    #endregion
}
}
