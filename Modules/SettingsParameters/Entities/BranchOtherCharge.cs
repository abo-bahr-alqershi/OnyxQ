using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Entities
{
/// <summary>
/// BranchOtherCharge Entity
/// </summary>
public class BranchOtherCharge : Entity<BranchOtherChargeId>
{
    private BranchOtherCharge() { }

    /// <summary>
    /// The unique identifier for the BranchOtherCharge
    /// المعرف الفريد لـ BranchOtherCharge
    /// </summary>
    public BranchOtherChargeId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the BranchOtherCharge
    /// BillTypeFull الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the BranchOtherCharge
    /// BillDocumentTypeFull الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the BranchOtherCharge
    /// BillNumber الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the BranchOtherCharge
    /// BillSerial الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the BranchOtherCharge
    /// DocDate الخاص بـ BranchOtherCharge
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ServiceNumber of the BranchOtherCharge
    /// ServiceNumber الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// AccountCode of the BranchOtherCharge
    /// AccountCode الخاص بـ BranchOtherCharge
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchOtherCharge
    /// AccountCurrency الخاص بـ BranchOtherCharge
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the BranchOtherCharge
    /// AccountRate الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the BranchOtherCharge
    /// Period الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the BranchOtherCharge
    /// Amount الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// InvoiceItem of the BranchOtherCharge
    /// InvoiceItem الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? InvoiceItem { get; private set; }

    /// <summary>
    /// RecordNumber of the BranchOtherCharge
    /// RecordNumber الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BillPaymentYear of the BranchOtherCharge
    /// BillPaymentYear الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ServiceAmount of the BranchOtherCharge
    /// ServiceAmount الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? ServiceAmount { get; private set; }

    /// <summary>
    /// ServiceAccountRate of the BranchOtherCharge
    /// ServiceAccountRate الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? ServiceAccountRate { get; private set; }

    /// <summary>
    /// ServiceAccountCurrency of the BranchOtherCharge
    /// ServiceAccountCurrency الخاص بـ BranchOtherCharge
    /// </summary>
    public string ServiceAccountCurrency { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchOtherCharge
    /// ExternalPostFlag الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// VatAmount of the BranchOtherCharge
    /// VatAmount الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the BranchOtherCharge
    /// VatPercent الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchOtherCharge
    /// CompanyNumberShort الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchOtherCharge
    /// BranchNumber الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchOtherCharge
    /// BranchYear الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchOtherCharge
    /// BranchUser الخاص بـ BranchOtherCharge
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    #endregion
}
}
