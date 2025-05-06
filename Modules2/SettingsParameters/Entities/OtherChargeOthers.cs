using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;
namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// OtherChargeOthers Entity
/// </summary>
public class OtherChargeOthers : Entity<OtherChargeOthersId>
{

    private OtherChargeOthers() { }

    public OtherChargeOthers(OtherChargeOthersId id, decimal? billSerial)
    {
        Id = id;
        BillSerial = billSerial;
    }

    /// <summary>
    /// The unique identifier for the OtherChargeOthers
    /// المعرف الفريد لـ OtherChargeOthers
    /// </summary>
    public OtherChargeOthersId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the OtherChargeOthers
    /// BillTypeFull الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the OtherChargeOthers
    /// BillDocumentTypeFull الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the OtherChargeOthers
    /// BillNumber الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the OtherChargeOthers
    /// BillSerial الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the OtherChargeOthers
    /// DocDate الخاص بـ OtherChargeOthers
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountRate of the OtherChargeOthers
    /// AccountRate الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the OtherChargeOthers
    /// Period الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the OtherChargeOthers
    /// Amount الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// InvoiceItem of the OtherChargeOthers
    /// InvoiceItem الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? InvoiceItem { get; private set; }

    /// <summary>
    /// RecordNumber of the OtherChargeOthers
    /// RecordNumber الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BillPaymentYear of the OtherChargeOthers
    /// BillPaymentYear الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OtherChargeOthers
    /// ExternalPostFlag الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OtherChargeOthers
    /// CompanyNumberShort الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OtherChargeOthers
    /// BranchNumber الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OtherChargeOthers
    /// BranchYear الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OtherChargeOthers
    /// BranchUser الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// VatPercent of the OtherChargeOthers
    /// VatPercent الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the OtherChargeOthers
    /// VatAmount الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ServiceAmount of the OtherChargeOthers
    /// ServiceAmount الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? ServiceAmount { get; private set; }

    /// <summary>
    /// ServiceAccountRate of the OtherChargeOthers
    /// ServiceAccountRate الخاص بـ OtherChargeOthers
    /// </summary>
    public decimal? ServiceAccountRate { get; private set; }

    /// <summary>
    /// ServiceAccountCurrency of the OtherChargeOthers
    /// ServiceAccountCurrency الخاص بـ OtherChargeOthers
    /// </summary>
    public string ServiceAccountCurrency { get; private set; }

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

