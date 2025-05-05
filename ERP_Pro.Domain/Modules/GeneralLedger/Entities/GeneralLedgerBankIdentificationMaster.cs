using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerBankIdentificationMaster Entity
/// </summary>
public class GeneralLedgerBankIdentificationMaster : AggregateRoot<GeneralLedgerBankIdentificationMasterId>
{

    private GeneralLedgerBankIdentificationMaster() { }

    public GeneralLedgerBankIdentificationMaster(GeneralLedgerBankIdentificationMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerBankIdentificationMaster
    /// المعرف الفريد لـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public GeneralLedgerBankIdentificationMasterId Id { get; private set; }

    /// <summary>
    /// DocTyp of the GeneralLedgerBankIdentificationMaster
    /// DocTyp الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// DocJvTyp of the GeneralLedgerBankIdentificationMaster
    /// DocJvTyp الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? DocJvTyp { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerBankIdentificationMaster
    /// DocNo الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the GeneralLedgerBankIdentificationMaster
    /// DocSrl الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocMSq of the GeneralLedgerBankIdentificationMaster
    /// DocMSq الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// DocDate of the GeneralLedgerBankIdentificationMaster
    /// DocDate الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the GeneralLedgerBankIdentificationMaster
    /// FDate الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the GeneralLedgerBankIdentificationMaster
    /// TDate الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerBankIdentificationMaster
    /// AccountCode الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationMaster
    /// 30 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerBankIdentificationMaster
    /// AccountDetailCode الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationMaster
    /// 30 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GeneralLedgerBankIdentificationMaster
    /// AccountDetailSubCode الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationMaster
    /// 30 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerBankIdentificationMaster
    /// AccountDetailType الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// IdentifyChequeNumber of the GeneralLedgerBankIdentificationMaster
    /// IdentifyChequeNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? IdentifyChequeNumber { get; private set; }

    /// <summary>
    /// IdentifyNoteNumberBank of the GeneralLedgerBankIdentificationMaster
    /// IdentifyNoteNumberBank الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? IdentifyNoteNumberBank { get; private set; }

    /// <summary>
    /// IdentifyReferenceNumber of the GeneralLedgerBankIdentificationMaster
    /// IdentifyReferenceNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? IdentifyReferenceNumber { get; private set; }

    /// <summary>
    /// CurCode of the GeneralLedgerBankIdentificationMaster
    /// CurCode الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// 7 of the GeneralLedgerBankIdentificationMaster
    /// 7 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 7 { get; private set; }

    /// <summary>
    /// DocDsc of the GeneralLedgerBankIdentificationMaster
    /// DocDsc الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// 1000 of the GeneralLedgerBankIdentificationMaster
    /// 1000 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 1000 { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerBankIdentificationMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// 15 of the GeneralLedgerBankIdentificationMaster
    /// 15 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 15 { get; private set; }

    /// <summary>
    /// ManualNumber of the GeneralLedgerBankIdentificationMaster
    /// ManualNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string ManualNumber { get; private set; }

    /// <summary>
    /// 20 of the GeneralLedgerBankIdentificationMaster
    /// 20 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 20 { get; private set; }

    /// <summary>
    /// Field1Alt of the GeneralLedgerBankIdentificationMaster
    /// Field1Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field1Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field2Alt of the GeneralLedgerBankIdentificationMaster
    /// Field2Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field2Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field3Alt of the GeneralLedgerBankIdentificationMaster
    /// Field3Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field3Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field4Alt of the GeneralLedgerBankIdentificationMaster
    /// Field4Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field4Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field5Alt of the GeneralLedgerBankIdentificationMaster
    /// Field5Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field5Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field6Alt of the GeneralLedgerBankIdentificationMaster
    /// Field6Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field6Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field7Alt of the GeneralLedgerBankIdentificationMaster
    /// Field7Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field7Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field8Alt of the GeneralLedgerBankIdentificationMaster
    /// Field8Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field8Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field9Alt of the GeneralLedgerBankIdentificationMaster
    /// Field9Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field9Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// Field10Alt of the GeneralLedgerBankIdentificationMaster
    /// Field10Alt الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string Field10Alt { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// 50 of the GeneralLedgerBankIdentificationMaster
    /// 50 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 50 { get; private set; }

    /// <summary>
    /// 50 of the GeneralLedgerBankIdentificationMaster
    /// 50 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 50 { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerBankIdentificationMaster
    /// BranchNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerBankIdentificationMaster
    /// BranchUser الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerBankIdentificationMaster
    /// BranchYear الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerBankIdentificationMaster
    /// CostCenterCode الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// 30 of the GeneralLedgerBankIdentificationMaster
    /// 30 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 30 { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerBankIdentificationMaster
    /// ProjectNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// 15 of the GeneralLedgerBankIdentificationMaster
    /// 15 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 15 { get; private set; }

    /// <summary>
    /// ActivityNumber of the GeneralLedgerBankIdentificationMaster
    /// ActivityNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// 15 of the GeneralLedgerBankIdentificationMaster
    /// 15 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 15 { get; private set; }

    /// <summary>
    /// TypeSerial of the GeneralLedgerBankIdentificationMaster
    /// TypeSerial الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? TypeSerial { get; private set; }

    /// <summary>
    /// ApprovedFlag of the GeneralLedgerBankIdentificationMaster
    /// ApprovedFlag الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the GeneralLedgerBankIdentificationMaster
    /// ApprovalUserId الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the GeneralLedgerBankIdentificationMaster
    /// ApprovalDate الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the GeneralLedgerBankIdentificationMaster
    /// ApprovalDescription الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// 500 of the GeneralLedgerBankIdentificationMaster
    /// 500 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 500 { get; private set; }

    /// <summary>
    /// ProcessedFlag of the GeneralLedgerBankIdentificationMaster
    /// ProcessedFlag الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the GeneralLedgerBankIdentificationMaster
    /// InactiveFlag الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the GeneralLedgerBankIdentificationMaster
    /// InactiveReason الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// 250 of the GeneralLedgerBankIdentificationMaster
    /// 250 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 250 { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the GeneralLedgerBankIdentificationMaster
    /// InactivatedByUserId الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the GeneralLedgerBankIdentificationMaster
    /// InactiveDate الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// StandbyFlag of the GeneralLedgerBankIdentificationMaster
    /// StandbyFlag الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? StandbyFlag { get; private set; }

    /// <summary>
    /// StandbyUserId of the GeneralLedgerBankIdentificationMaster
    /// StandbyUserId الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? StandbyUserId { get; private set; }

    /// <summary>
    /// StandbyDate of the GeneralLedgerBankIdentificationMaster
    /// StandbyDate الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public DateTime? StandbyDate { get; private set; }

    /// <summary>
    /// StandbyDescription of the GeneralLedgerBankIdentificationMaster
    /// StandbyDescription الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string StandbyDescription { get; private set; }

    /// <summary>
    /// 500 of the GeneralLedgerBankIdentificationMaster
    /// 500 الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public string 500 { get; private set; }

    /// <summary>
    /// CreateDateClock of the GeneralLedgerBankIdentificationMaster
    /// CreateDateClock الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public DateTime? CreateDateClock { get; private set; }

    /// <summary>
    /// AttachmentNumber of the GeneralLedgerBankIdentificationMaster
    /// AttachmentNumber الخاص بـ GeneralLedgerBankIdentificationMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

