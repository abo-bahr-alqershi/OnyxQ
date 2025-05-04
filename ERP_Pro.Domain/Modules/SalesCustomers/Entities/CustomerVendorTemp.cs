using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerVendorTemp Entity
/// </summary>
public class CustomerVendorTemp : Entity<CustomerVendorTempId>
{
    private CustomerVendorTemp() { }

    /// <summary>
    /// The unique identifier for the CustomerVendorTemp
    /// المعرف الفريد لـ CustomerVendorTemp
    /// </summary>
    public CustomerVendorTempId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerVendorTemp
    /// CCode الخاص بـ CustomerVendorTemp
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerVendorTemp
    /// AccountCurrency الخاص بـ CustomerVendorTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocNo of the CustomerVendorTemp
    /// DocNo الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocType of the CustomerVendorTemp
    /// DocType الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocJvType of the CustomerVendorTemp
    /// DocJvType الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? DocJvType { get; private set; }

    /// <summary>
    /// DocSer of the CustomerVendorTemp
    /// DocSer الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the CustomerVendorTemp
    /// DocDate الخاص بـ CustomerVendorTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DrAmt of the CustomerVendorTemp
    /// DrAmt الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// CreditAmount of the CustomerVendorTemp
    /// CreditAmount الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// DrAmtf of the CustomerVendorTemp
    /// DrAmtf الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? DrAmtf { get; private set; }

    /// <summary>
    /// CreditAmountForeign of the CustomerVendorTemp
    /// CreditAmountForeign الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? CreditAmountForeign { get; private set; }

    /// <summary>
    /// DocDesc of the CustomerVendorTemp
    /// DocDesc الخاص بـ CustomerVendorTemp
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// CashNumber of the CustomerVendorTemp
    /// CashNumber الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the CustomerVendorTemp
    /// CostCenterCode الخاص بـ CustomerVendorTemp
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the CustomerVendorTemp
    /// WarehouseCode الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CustomerVendorTemp
    /// ColumnNumberShort الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// DocPost of the CustomerVendorTemp
    /// DocPost الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CustomerVendorTemp
    /// ReferenceNumber الخاص بـ CustomerVendorTemp
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ChequeValuedFlag of the CustomerVendorTemp
    /// ChequeValuedFlag الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// DocDueDate of the CustomerVendorTemp
    /// DocDueDate الخاص بـ CustomerVendorTemp
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the CustomerVendorTemp
    /// ExternalPostFlag الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// RecordNumber of the CustomerVendorTemp
    /// RecordNumber الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// SerialNumberShort of the CustomerVendorTemp
    /// SerialNumberShort الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? SerialNumberShort { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CustomerVendorTemp
    /// CompanyNumberShort الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerVendorTemp
    /// BranchNumber الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerVendorTemp
    /// BranchYear الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CustomerVendorTemp
    /// BranchUser الخاص بـ CustomerVendorTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
