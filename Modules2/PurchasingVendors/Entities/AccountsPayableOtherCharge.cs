using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableOtherCharge Entity
/// </summary>
public class AccountsPayableOtherCharge : Entity<AccountsPayableOtherChargeId>
{

    private AccountsPayableOtherCharge() { }

    public AccountsPayableOtherCharge(AccountsPayableOtherChargeId id, decimal? billTypeFull, decimal? billSerial)
    {
        Id = id;
        BillTypeFull = billTypeFull;
        BillSerial = billSerial;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableOtherCharge
    /// المعرف الفريد لـ AccountsPayableOtherCharge
    /// </summary>
    public AccountsPayableOtherChargeId Id { get; private set; }

    /// <summary>
    /// BillTypeFull of the AccountsPayableOtherCharge
    /// BillTypeFull الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BillTypeFull { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the AccountsPayableOtherCharge
    /// BillDocumentTypeFull الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// BillNumber of the AccountsPayableOtherCharge
    /// BillNumber الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the AccountsPayableOtherCharge
    /// BillSerial الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// DocDate of the AccountsPayableOtherCharge
    /// DocDate الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountRate of the AccountsPayableOtherCharge
    /// AccountRate الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// Period of the AccountsPayableOtherCharge
    /// Period الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableOtherCharge
    /// Amount الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// ChargeBillType of the AccountsPayableOtherCharge
    /// ChargeBillType الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? ChargeBillType { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableOtherCharge
    /// RecordNumber الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BillPaymentYear of the AccountsPayableOtherCharge
    /// BillPaymentYear الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BillPaymentYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AccountsPayableOtherCharge
    /// ExternalPostFlag الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// VatAmount of the AccountsPayableOtherCharge
    /// VatAmount الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the AccountsPayableOtherCharge
    /// VatPercent الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// UseVat of the AccountsPayableOtherCharge
    /// UseVat الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AccountsPayableOtherCharge
    /// AccountDetailCode الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AccountsPayableOtherCharge
    /// AccountDetailType الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableOtherCharge
    /// CompanyNumberShort الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableOtherCharge
    /// BranchNumber الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableOtherCharge
    /// BranchYear الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableOtherCharge
    /// BranchUser الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// UseTds of the AccountsPayableOtherCharge
    /// UseTds الخاص بـ AccountsPayableOtherCharge
    /// </summary>
    public decimal? UseTds { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsPayableCharge AccountsPayableCharge { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

