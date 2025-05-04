using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// VendorCoverageTemp Entity
/// </summary>
public class VendorCoverageTemp : Entity<VendorCoverageTempId>
{
    private VendorCoverageTemp() { }

    /// <summary>
    /// The unique identifier for the VendorCoverageTemp
    /// المعرف الفريد لـ VendorCoverageTemp
    /// </summary>
    public VendorCoverageTempId Id { get; private set; }

    /// <summary>
    /// VendorCode of the VendorCoverageTemp
    /// VendorCode الخاص بـ VendorCoverageTemp
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorCoverageTemp
    /// AccountCurrency الخاص بـ VendorCoverageTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocNo of the VendorCoverageTemp
    /// DocNo الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the VendorCoverageTemp
    /// DocType الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocJvType of the VendorCoverageTemp
    /// DocJvType الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocSer of the VendorCoverageTemp
    /// DocSer الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the VendorCoverageTemp
    /// DocDate الخاص بـ VendorCoverageTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CreditAmount of the VendorCoverageTemp
    /// CreditAmount الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// CreditAmountForeign of the VendorCoverageTemp
    /// CreditAmountForeign الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? CreditAmountForeign { get; private set; }

    /// <summary>
    /// DocDesc of the VendorCoverageTemp
    /// DocDesc الخاص بـ VendorCoverageTemp
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the VendorCoverageTemp
    /// ReferenceNumber الخاص بـ VendorCoverageTemp
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the VendorCoverageTemp
    /// RecordNumber الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the VendorCoverageTemp
    /// CostCenterCode الخاص بـ VendorCoverageTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ChequeValuedFlag of the VendorCoverageTemp
    /// ChequeValuedFlag الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// PeriodNumber of the VendorCoverageTemp
    /// PeriodNumber الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? PeriodNumber { get; private set; }

    /// <summary>
    /// TerminalName of the VendorCoverageTemp
    /// TerminalName الخاص بـ VendorCoverageTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the VendorCoverageTemp
    /// CompanyNumberShort الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the VendorCoverageTemp
    /// BranchNumber الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the VendorCoverageTemp
    /// BranchYear الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the VendorCoverageTemp
    /// BranchUser الخاص بـ VendorCoverageTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BillNumberVoucherCode of the VendorCoverageTemp
    /// BillNumberVoucherCode الخاص بـ VendorCoverageTemp
    /// </summary>
    public string BillNumberVoucherCode { get; private set; }

    /// <summary>
    /// BillDateVoucherCode of the VendorCoverageTemp
    /// BillDateVoucherCode الخاص بـ VendorCoverageTemp
    /// </summary>
    public DateTime? BillDateVoucherCode { get; private set; }
}
}
