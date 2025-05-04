using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// OtherCharge Entity
/// </summary>
public class OtherCharge : Entity<OtherChargeId>
{

    private OtherCharge() { }

    public OtherCharge(OtherChargeId id, decimal? billSerial)
    {
        Id = id;
        BillSerial = billSerial;
    }

    /// <summary>
    /// The unique identifier for the OtherCharge
    /// المعرف الفريد لـ OtherCharge
    /// </summary>
    public OtherChargeId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the OtherCharge
    /// BillTypeFull الخاص بـ OtherCharge
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the OtherCharge
    /// BillDocumentTypeFull الخاص بـ OtherCharge
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the OtherCharge
    /// BillNumber الخاص بـ OtherCharge
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the OtherCharge
    /// BillSerial الخاص بـ OtherCharge
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the OtherCharge
    /// DocDate الخاص بـ OtherCharge
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountRate of the OtherCharge
    /// AccountRate الخاص بـ OtherCharge
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the OtherCharge
    /// Period الخاص بـ OtherCharge
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the OtherCharge
    /// Amount الخاص بـ OtherCharge
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// InvoiceItem of the OtherCharge
    /// InvoiceItem الخاص بـ OtherCharge
    /// </summary>
    public decimal? InvoiceItem { get; private set; }

    /// <summary>
    /// RecordNumber of the OtherCharge
    /// RecordNumber الخاص بـ OtherCharge
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BillPaymentYear of the OtherCharge
    /// BillPaymentYear الخاص بـ OtherCharge
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OtherCharge
    /// ExternalPostFlag الخاص بـ OtherCharge
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// VatAmount of the OtherCharge
    /// VatAmount الخاص بـ OtherCharge
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the OtherCharge
    /// VatPercent الخاص بـ OtherCharge
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// ServiceAmount of the OtherCharge
    /// ServiceAmount الخاص بـ OtherCharge
    /// </summary>
    public decimal? ServiceAmount { get; private set; }

    /// <summary>
    /// ServiceAccountRate of the OtherCharge
    /// ServiceAccountRate الخاص بـ OtherCharge
    /// </summary>
    public decimal? ServiceAccountRate { get; private set; }

    /// <summary>
    /// ServiceAccountCurrency of the OtherCharge
    /// ServiceAccountCurrency الخاص بـ OtherCharge
    /// </summary>
    public string ServiceAccountCurrency { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OtherCharge
    /// CompanyNumberShort الخاص بـ OtherCharge
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OtherCharge
    /// BranchNumber الخاص بـ OtherCharge
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OtherCharge
    /// BranchYear الخاص بـ OtherCharge
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OtherCharge
    /// BranchUser الخاص بـ OtherCharge
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public SalesCharge SalesCharge { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
