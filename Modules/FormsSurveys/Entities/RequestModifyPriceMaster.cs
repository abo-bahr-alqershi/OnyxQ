using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestModifyPriceMaster Entity
/// </summary>
public class RequestModifyPriceMaster : Entity<RequestModifyPriceMasterId>
{
    private RequestModifyPriceMaster() { }

    /// <summary>
    /// The unique identifier for the RequestModifyPriceMaster
    /// المعرف الفريد لـ RequestModifyPriceMaster
    /// </summary>
    public RequestModifyPriceMasterId Id { get; private set; }

    /// <summary>
    /// RequestNumber of the RequestModifyPriceMaster
    /// RequestNumber الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public decimal? RequestNumber { get; private set; }

    /// <summary>
    /// RequestSerialShort of the RequestModifyPriceMaster
    /// RequestSerialShort الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public decimal? RequestSerialShort { get; private set; }

    /// <summary>
    /// RequestDate of the RequestModifyPriceMaster
    /// RequestDate الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public DateTime? RequestDate { get; private set; }

    /// <summary>
    /// RequestDescription of the RequestModifyPriceMaster
    /// RequestDescription الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public string RequestDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RequestModifyPriceMaster
    /// ReferenceNumber الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the RequestModifyPriceMaster
    /// ProcessedFlagFull الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestModifyPriceMaster
    /// CompanyNumberShort الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestModifyPriceMaster
    /// BranchNumber الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestModifyPriceMaster
    /// BranchYear الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestModifyPriceMaster
    /// BranchUser الخاص بـ RequestModifyPriceMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: RequestModifyPriceMaster to RequestModifyPriceDetail
    /// </summary>
    public IReadOnlyCollection<RequestModifyPriceDetail> RequestModifyPriceDetails { get; private set; }
    #endregion
}
}
