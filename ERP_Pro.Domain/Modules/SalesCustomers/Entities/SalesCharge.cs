using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesCharge Entity
/// </summary>
public class SalesCharge : Entity<SalesChargeId>
{

    private SalesCharge() { }

    public SalesCharge(SalesChargeId id, decimal? serviceNumber)
    {
        Id = id;
        ServiceNumber = serviceNumber;
    }

    /// <summary>
    /// The unique identifier for the SalesCharge
    /// المعرف الفريد لـ SalesCharge
    /// </summary>
    public SalesChargeId Id { get; private set; }

    /// <summary>
    /// ServiceNumber of the SalesCharge
    /// ServiceNumber الخاص بـ SalesCharge
    /// </summary>
    public decimal? ServiceNumber { get; private set; }

    /// <summary>
    /// ServiceName of the SalesCharge
    /// ServiceName الخاص بـ SalesCharge
    /// </summary>
    public string ServiceName { get; private set; }

    /// <summary>
    /// AccountCurrency of the SalesCharge
    /// AccountCurrency الخاص بـ SalesCharge
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the SalesCharge
    /// AccountRate الخاص بـ SalesCharge
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// AmountType of the SalesCharge
    /// AmountType الخاص بـ SalesCharge
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// ServiceType of the SalesCharge
    /// ServiceType الخاص بـ SalesCharge
    /// </summary>
    public decimal? ServiceType { get; private set; }

    /// <summary>
    /// Amount of the SalesCharge
    /// Amount الخاص بـ SalesCharge
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// FillAuto of the SalesCharge
    /// FillAuto الخاص بـ SalesCharge
    /// </summary>
    public decimal? FillAuto { get; private set; }

    /// <summary>
    /// CalculationType of the SalesCharge
    /// CalculationType الخاص بـ SalesCharge
    /// </summary>
    public decimal? CalculationType { get; private set; }

    /// <summary>
    /// InvoiceItem of the SalesCharge
    /// InvoiceItem الخاص بـ SalesCharge
    /// </summary>
    public decimal? InvoiceItem { get; private set; }

    /// <summary>
    /// AllowReturn of the SalesCharge
    /// AllowReturn الخاص بـ SalesCharge
    /// </summary>
    public decimal? AllowReturn { get; private set; }

    /// <summary>
    /// ServiceQuantityType of the SalesCharge
    /// ServiceQuantityType الخاص بـ SalesCharge
    /// </summary>
    public decimal? ServiceQuantityType { get; private set; }

    /// <summary>
    /// PostedToSalesFlag of the SalesCharge
    /// PostedToSalesFlag الخاص بـ SalesCharge
    /// </summary>
    public decimal? PostedToSalesFlag { get; private set; }

    /// <summary>
    /// ServiceReturnWithoutBillNumber of the SalesCharge
    /// ServiceReturnWithoutBillNumber الخاص بـ SalesCharge
    /// </summary>
    public decimal? ServiceReturnWithoutBillNumber { get; private set; }

    /// <summary>
    /// AddToBillDiscount of the SalesCharge
    /// AddToBillDiscount الخاص بـ SalesCharge
    /// </summary>
    public decimal? AddToBillDiscount { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the SalesCharge
    /// BillDocumentTypeFull الخاص بـ SalesCharge
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// VatPercent of the SalesCharge
    /// VatPercent الخاص بـ SalesCharge
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// UseVat of the SalesCharge
    /// UseVat الخاص بـ SalesCharge
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// AmountTypeValue of the SalesCharge
    /// AmountTypeValue الخاص بـ SalesCharge
    /// </summary>
    public decimal? AmountTypeValue { get; private set; }

    /// <summary>
    /// ServicePostWithAccountCurrency of the SalesCharge
    /// ServicePostWithAccountCurrency الخاص بـ SalesCharge
    /// </summary>
    public decimal? ServicePostWithAccountCurrency { get; private set; }

    /// <summary>
    /// ServiceAddForceInvoice of the SalesCharge
    /// ServiceAddForceInvoice الخاص بـ SalesCharge
    /// </summary>
    public decimal? ServiceAddForceInvoice { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

