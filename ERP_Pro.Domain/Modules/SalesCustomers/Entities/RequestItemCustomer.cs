using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// RequestItemCustomer Entity
/// </summary>
public class RequestItemCustomer : Entity<RequestItemCustomerId>
{

    private RequestItemCustomer() { }

    public RequestItemCustomer(RequestItemCustomerId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the RequestItemCustomer
    /// المعرف الفريد لـ RequestItemCustomer
    /// </summary>
    public RequestItemCustomerId Id { get; private set; }

    /// <summary>
    /// DocDate of the RequestItemCustomer
    /// DocDate الخاص بـ RequestItemCustomer
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemCode of the RequestItemCustomer
    /// ItemCode الخاص بـ RequestItemCustomer
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the RequestItemCustomer
    /// ItemUnit الخاص بـ RequestItemCustomer
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the RequestItemCustomer
    /// PSize الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the RequestItemCustomer
    /// PQuantity الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the RequestItemCustomer
    /// WarehouseCode الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CCode of the RequestItemCustomer
    /// CCode الخاص بـ RequestItemCustomer
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the RequestItemCustomer
    /// CName الخاص بـ RequestItemCustomer
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// ExpireDate of the RequestItemCustomer
    /// ExpireDate الخاص بـ RequestItemCustomer
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the RequestItemCustomer
    /// BatchNumber الخاص بـ RequestItemCustomer
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ItemQuantity of the RequestItemCustomer
    /// ItemQuantity الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// AvailableQuantity of the RequestItemCustomer
    /// AvailableQuantity الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the RequestItemCustomer
    /// RecordNumber الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestItemCustomer
    /// BranchNumber الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocSequence of the RequestItemCustomer
    /// DocSequence الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocNoRef of the RequestItemCustomer
    /// DocNoRef الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the RequestItemCustomer
    /// DocSerRef الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocTypeRef of the RequestItemCustomer
    /// DocTypeRef الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the RequestItemCustomer
    /// ProcessedFlagAlt الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// CancelFlag of the RequestItemCustomer
    /// CancelFlag الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? CancelFlag { get; private set; }

    /// <summary>
    /// CancelReason of the RequestItemCustomer
    /// CancelReason الخاص بـ RequestItemCustomer
    /// </summary>
    public string CancelReason { get; private set; }

    /// <summary>
    /// CancelDate of the RequestItemCustomer
    /// CancelDate الخاص بـ RequestItemCustomer
    /// </summary>
    public DateTime? CancelDate { get; private set; }

    /// <summary>
    /// CancelUserId of the RequestItemCustomer
    /// CancelUserId الخاص بـ RequestItemCustomer
    /// </summary>
    public decimal? CancelUserId { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
