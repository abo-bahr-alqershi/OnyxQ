using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// DebtorDetailTemp Entity
/// </summary>
public class DebtorDetailTemp : Entity<DebtorDetailTempId>
{
    private DebtorDetailTemp() { }

    /// <summary>
    /// The unique identifier for the DebtorDetailTemp
    /// المعرف الفريد لـ DebtorDetailTemp
    /// </summary>
    public DebtorDetailTempId Id { get; private set; }

    /// <summary>
    /// CCode of the DebtorDetailTemp
    /// CCode الخاص بـ DebtorDetailTemp
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the DebtorDetailTemp
    /// AccountCurrency الخاص بـ DebtorDetailTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocNo of the DebtorDetailTemp
    /// DocNo الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the DebtorDetailTemp
    /// DocType الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocJvType of the DebtorDetailTemp
    /// DocJvType الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocSer of the DebtorDetailTemp
    /// DocSer الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the DebtorDetailTemp
    /// DocDate الخاص بـ DebtorDetailTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemNumber of the DebtorDetailTemp
    /// ItemNumber الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// InvoiceAmount of the DebtorDetailTemp
    /// InvoiceAmount الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// InvoiceAmountLocation of the DebtorDetailTemp
    /// InvoiceAmountLocation الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? InvoiceAmountLocation { get; private set; }

    /// <summary>
    /// PaidAmount of the DebtorDetailTemp
    /// PaidAmount الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// PaidAmountLocal of the DebtorDetailTemp
    /// PaidAmountLocal الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? PaidAmountLocal { get; private set; }

    /// <summary>
    /// BillRate of the DebtorDetailTemp
    /// BillRate الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? BillRate { get; private set; }

    /// <summary>
    /// PaidDate of the DebtorDetailTemp
    /// PaidDate الخاص بـ DebtorDetailTemp
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// PaidFlag of the DebtorDetailTemp
    /// PaidFlag الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? PaidFlag { get; private set; }

    /// <summary>
    /// CostCenterCode of the DebtorDetailTemp
    /// CostCenterCode الخاص بـ DebtorDetailTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// PaidDocumentType of the DebtorDetailTemp
    /// PaidDocumentType الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? PaidDocumentType { get; private set; }

    /// <summary>
    /// PaidDocumentNumber of the DebtorDetailTemp
    /// PaidDocumentNumber الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? PaidDocumentNumber { get; private set; }

    /// <summary>
    /// PaidDocumentSerial of the DebtorDetailTemp
    /// PaidDocumentSerial الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? PaidDocumentSerial { get; private set; }

    /// <summary>
    /// BillDate of the DebtorDetailTemp
    /// BillDate الخاص بـ DebtorDetailTemp
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// DocSequence of the DebtorDetailTemp
    /// DocSequence الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// RecordNumber of the DebtorDetailTemp
    /// RecordNumber الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the DebtorDetailTemp
    /// ProjectNumber الخاص بـ DebtorDetailTemp
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the DebtorDetailTemp
    /// ActivityNumber الخاص بـ DebtorDetailTemp
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RepCode of the DebtorDetailTemp
    /// RepCode الخاص بـ DebtorDetailTemp
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the DebtorDetailTemp
    /// ColumnNumberShort الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// TerminalName of the DebtorDetailTemp
    /// TerminalName الخاص بـ DebtorDetailTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DebtorDetailTemp
    /// CompanyNumberShort الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DebtorDetailTemp
    /// BranchNumber الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DebtorDetailTemp
    /// BranchYear الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DebtorDetailTemp
    /// BranchUser الخاص بـ DebtorDetailTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
