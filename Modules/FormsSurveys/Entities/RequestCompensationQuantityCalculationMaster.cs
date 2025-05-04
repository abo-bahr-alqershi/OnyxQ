using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestCompensationQuantityCalculationMaster Entity
/// </summary>
public class RequestCompensationQuantityCalculationMaster : Entity<RequestCompensationQuantityCalculationMasterId>
{
    private RequestCompensationQuantityCalculationMaster() { }

    /// <summary>
    /// The unique identifier for the RequestCompensationQuantityCalculationMaster
    /// المعرف الفريد لـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public RequestCompensationQuantityCalculationMasterId Id { get; private set; }

    /// <summary>
    /// DocSrl of the RequestCompensationQuantityCalculationMaster
    /// DocSrl الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the RequestCompensationQuantityCalculationMaster
    /// DocNo الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the RequestCompensationQuantityCalculationMaster
    /// DocDate الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// FDate of the RequestCompensationQuantityCalculationMaster
    /// FDate الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the RequestCompensationQuantityCalculationMaster
    /// TDate الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CompensationType of the RequestCompensationQuantityCalculationMaster
    /// CompensationType الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? CompensationType { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RequestCompensationQuantityCalculationMaster
    /// ReferenceNumber الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the RequestCompensationQuantityCalculationMaster
    /// DocDsc الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CCode of the RequestCompensationQuantityCalculationMaster
    /// CCode الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the RequestCompensationQuantityCalculationMaster
    /// AccountCurrency الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// FDocumentNumber of the RequestCompensationQuantityCalculationMaster
    /// FDocumentNumber الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? FDocumentNumber { get; private set; }

    /// <summary>
    /// TDocumentNumber of the RequestCompensationQuantityCalculationMaster
    /// TDocumentNumber الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? TDocumentNumber { get; private set; }

    /// <summary>
    /// ProcessedFlag of the RequestCompensationQuantityCalculationMaster
    /// ProcessedFlag الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the RequestCompensationQuantityCalculationMaster
    /// ApprovedFlag الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalDate of the RequestCompensationQuantityCalculationMaster
    /// ApprovalDate الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalUserId of the RequestCompensationQuantityCalculationMaster
    /// ApprovalUserId الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDescription of the RequestCompensationQuantityCalculationMaster
    /// ApprovalDescription الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestCompensationQuantityCalculationMaster
    /// CompanyNumberShort الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestCompensationQuantityCalculationMaster
    /// BranchNumber الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestCompensationQuantityCalculationMaster
    /// BranchYear الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestCompensationQuantityCalculationMaster
    /// BranchUser الخاص بـ RequestCompensationQuantityCalculationMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: RequestCompensationQuantityCalculationMaster to RequestCompensationQuantityCalculationDetail
    /// </summary>
    public IReadOnlyCollection<RequestCompensationQuantityCalculationDetail> RequestCompensationQuantityCalculationDetails { get; private set; }
    #endregion
}
}
