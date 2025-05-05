using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;
namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestModifyPriceDetail Entity
/// </summary>
public class RequestModifyPriceDetail : Entity<RequestModifyPriceDetailId>
{

    private RequestModifyPriceDetail() { }

    public RequestModifyPriceDetail(RequestModifyPriceDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the RequestModifyPriceDetail
    /// المعرف الفريد لـ RequestModifyPriceDetail
    /// </summary>
    public RequestModifyPriceDetailId Id { get; private set; }

    /// <summary>
    /// RequestNumber of the RequestModifyPriceDetail
    /// RequestNumber الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? RequestNumber { get; private set; }

    /// <summary>
    /// ItemCode of the RequestModifyPriceDetail
    /// ItemCode الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the RequestModifyPriceDetail
    /// ItemUnit الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the RequestModifyPriceDetail
    /// PSize الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// LevelNumber of the RequestModifyPriceDetail
    /// LevelNumber الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the RequestModifyPriceDetail
    /// WarehouseCode الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// PreviousPrice of the RequestModifyPriceDetail
    /// PreviousPrice الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? PreviousPrice { get; private set; }

    /// <summary>
    /// SuggestedPrice of the RequestModifyPriceDetail
    /// SuggestedPrice الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? SuggestedPrice { get; private set; }

    /// <summary>
    /// ApprovalPrice of the RequestModifyPriceDetail
    /// ApprovalPrice الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? ApprovalPrice { get; private set; }

    /// <summary>
    /// FromQuantity of the RequestModifyPriceDetail
    /// FromQuantity الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? FromQuantity { get; private set; }

    /// <summary>
    /// ToQuantity of the RequestModifyPriceDetail
    /// ToQuantity الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? ToQuantity { get; private set; }

    /// <summary>
    /// ApprovedFlag of the RequestModifyPriceDetail
    /// ApprovedFlag الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the RequestModifyPriceDetail
    /// ApprovalUserId الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the RequestModifyPriceDetail
    /// ApprovalDate الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the RequestModifyPriceDetail
    /// ApprovalDescription الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ItemDescription of the RequestModifyPriceDetail
    /// ItemDescription الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// RecordNumber of the RequestModifyPriceDetail
    /// RecordNumber الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestModifyPriceDetail
    /// CompanyNumberShort الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestModifyPriceDetail
    /// BranchNumber الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestModifyPriceDetail
    /// BranchYear الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestModifyPriceDetail
    /// BranchUser الخاص بـ RequestModifyPriceDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public RequestModifyPriceMaster RequestModifyPriceMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

