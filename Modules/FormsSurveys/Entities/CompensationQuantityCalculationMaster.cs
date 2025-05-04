using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// CompensationQuantityCalculationMaster Entity
/// </summary>
public class CompensationQuantityCalculationMaster : Entity<CompensationQuantityCalculationMasterId>
{
    private CompensationQuantityCalculationMaster() { }

    /// <summary>
    /// The unique identifier for the CompensationQuantityCalculationMaster
    /// المعرف الفريد لـ CompensationQuantityCalculationMaster
    /// </summary>
    public CompensationQuantityCalculationMasterId Id { get; private set; }

    /// <summary>
    /// DocSrl of the CompensationQuantityCalculationMaster
    /// DocSrl الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the CompensationQuantityCalculationMaster
    /// DocNo الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the CompensationQuantityCalculationMaster
    /// DocDate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the CompensationQuantityCalculationMaster
    /// FDate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CompensationQuantityCalculationMaster
    /// TDate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CompensationType of the CompensationQuantityCalculationMaster
    /// CompensationType الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? CompensationType { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CompensationQuantityCalculationMaster
    /// ReferenceNumber الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the CompensationQuantityCalculationMaster
    /// DocDsc الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlag of the CompensationQuantityCalculationMaster
    /// ProcessedFlag الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the CompensationQuantityCalculationMaster
    /// ApprovedFlag الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the CompensationQuantityCalculationMaster
    /// ApprovalDate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the CompensationQuantityCalculationMaster
    /// ApprovalUserId الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the CompensationQuantityCalculationMaster
    /// ApprovalDescription الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// FDocumentNumber of the CompensationQuantityCalculationMaster
    /// FDocumentNumber الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? FDocumentNumber { get; private set; }

    /// <summary>
    /// TDocumentNumber of the CompensationQuantityCalculationMaster
    /// TDocumentNumber الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? TDocumentNumber { get; private set; }

    /// <summary>
    /// CCode of the CompensationQuantityCalculationMaster
    /// CCode الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// RequestNumberShort of the CompensationQuantityCalculationMaster
    /// RequestNumberShort الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? RequestNumberShort { get; private set; }

    /// <summary>
    /// RequestSerial of the CompensationQuantityCalculationMaster
    /// RequestSerial الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? RequestSerial { get; private set; }

    /// <summary>
    /// AccountCode of the CompensationQuantityCalculationMaster
    /// AccountCode الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CompensationQuantityCalculationMaster
    /// AccountCurrency الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocRate of the CompensationQuantityCalculationMaster
    /// DocRate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// StockRateShort of the CompensationQuantityCalculationMaster
    /// StockRateShort الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? StockRateShort { get; private set; }

    /// <summary>
    /// DocPost of the CompensationQuantityCalculationMaster
    /// DocPost الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// AuditReference of the CompensationQuantityCalculationMaster
    /// AuditReference الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// StandByFlag of the CompensationQuantityCalculationMaster
    /// StandByFlag الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the CompensationQuantityCalculationMaster
    /// AuditReferenceDescription الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the CompensationQuantityCalculationMaster
    /// AuditReferenceUserId الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the CompensationQuantityCalculationMaster
    /// AuditReferenceDate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the CompensationQuantityCalculationMaster
    /// UnpostUserId الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the CompensationQuantityCalculationMaster
    /// UnpostDate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// DocBrnNo of the CompensationQuantityCalculationMaster
    /// DocBrnNo الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// PostDate of the CompensationQuantityCalculationMaster
    /// PostDate الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// PostUserId of the CompensationQuantityCalculationMaster
    /// PostUserId الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CompensationQuantityCalculationMaster
    /// CompanyNumberShort الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CompensationQuantityCalculationMaster
    /// BranchNumber الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CompensationQuantityCalculationMaster
    /// BranchYear الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CompensationQuantityCalculationMaster
    /// BranchUser الخاص بـ CompensationQuantityCalculationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CompensationQuantityCalculationMaster to CompensationQuantityCalculationDetail
    /// </summary>
    public IReadOnlyCollection<CompensationQuantityCalculationDetail> CompensationQuantityCalculationDetails { get; private set; }
    #endregion
}
}
