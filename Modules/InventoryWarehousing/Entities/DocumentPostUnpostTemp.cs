using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// DocumentPostUnpostTemp Entity
/// </summary>
public class DocumentPostUnpostTemp : Entity<DocumentPostUnpostTempId>
{
    private DocumentPostUnpostTemp() { }

    /// <summary>
    /// The unique identifier for the DocumentPostUnpostTemp
    /// المعرف الفريد لـ DocumentPostUnpostTemp
    /// </summary>
    public DocumentPostUnpostTempId Id { get; private set; }

    /// <summary>
    /// DocType of the DocumentPostUnpostTemp
    /// DocType الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocJvType of the DocumentPostUnpostTemp
    /// DocJvType الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocNo of the DocumentPostUnpostTemp
    /// DocNo الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DocumentPostUnpostTemp
    /// DocSer الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the DocumentPostUnpostTemp
    /// DocDate الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the DocumentPostUnpostTemp
    /// AccountCurrency الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the DocumentPostUnpostTemp
    /// CostCenterCode الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the DocumentPostUnpostTemp
    /// WarehouseCode الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CashNumber of the DocumentPostUnpostTemp
    /// CashNumber الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// DocPost of the DocumentPostUnpostTemp
    /// DocPost الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the DocumentPostUnpostTemp
    /// PostUserId الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the DocumentPostUnpostTemp
    /// PostDate الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the DocumentPostUnpostTemp
    /// UnpostUserId الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the DocumentPostUnpostTemp
    /// UnpostDate الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// StandByFlag of the DocumentPostUnpostTemp
    /// StandByFlag الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AuditReference of the DocumentPostUnpostTemp
    /// AuditReference الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the DocumentPostUnpostTemp
    /// AuditReferenceDescription الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the DocumentPostUnpostTemp
    /// AuditReferenceUserId الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the DocumentPostUnpostTemp
    /// AuditReferenceDate الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the DocumentPostUnpostTemp
    /// ReferenceNumber الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DocumentPostUnpostTemp
    /// CompanyNumberShort الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DocumentPostUnpostTemp
    /// BranchNumber الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DocumentPostUnpostTemp
    /// BranchYear الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DocumentPostUnpostTemp
    /// BranchUser الخاص بـ DocumentPostUnpostTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
