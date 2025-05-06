using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableCharge Entity
/// </summary>
public class AccountsPayableCharge : Entity<AccountsPayableChargeId>
{

    private AccountsPayableCharge() { }

    public AccountsPayableCharge(AccountsPayableChargeId id, decimal? chargeNumber)
    {
        Id = id;
        ChargeNumber = chargeNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableCharge
    /// المعرف الفريد لـ AccountsPayableCharge
    /// </summary>
    public AccountsPayableChargeId Id { get; private set; }

    /// <summary>
    /// ChargeNumber of the AccountsPayableCharge
    /// ChargeNumber الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? ChargeNumber { get; private set; }

    /// <summary>
    /// ChargeName of the AccountsPayableCharge
    /// ChargeName الخاص بـ AccountsPayableCharge
    /// </summary>
    public string ChargeName { get; private set; }

    /// <summary>
    /// AccountCurrency of the AccountsPayableCharge
    /// AccountCurrency الخاص بـ AccountsPayableCharge
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the AccountsPayableCharge
    /// AccountRate الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// ChargeBillType of the AccountsPayableCharge
    /// ChargeBillType الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? ChargeBillType { get; private set; }

    /// <summary>
    /// AmountType of the AccountsPayableCharge
    /// AmountType الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// ChargeType of the AccountsPayableCharge
    /// ChargeType الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? ChargeType { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableCharge
    /// Amount الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// FillAuto of the AccountsPayableCharge
    /// FillAuto الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? FillAuto { get; private set; }

    /// <summary>
    /// CalculationType of the AccountsPayableCharge
    /// CalculationType الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? CalculationType { get; private set; }

    /// <summary>
    /// AllowReturn of the AccountsPayableCharge
    /// AllowReturn الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? AllowReturn { get; private set; }

    /// <summary>
    /// ReturnWithoutBillNumber of the AccountsPayableCharge
    /// ReturnWithoutBillNumber الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? ReturnWithoutBillNumber { get; private set; }

    /// <summary>
    /// VatPercent of the AccountsPayableCharge
    /// VatPercent الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// UseVat of the AccountsPayableCharge
    /// UseVat الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// EfctItmCst of the AccountsPayableCharge
    /// EfctItmCst الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? EfctItmCst { get; private set; }

    /// <summary>
    /// PostToVendorCashBank of the AccountsPayableCharge
    /// PostToVendorCashBank الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? PostToVendorCashBank { get; private set; }

    /// <summary>
    /// UseTdsFlag of the AccountsPayableCharge
    /// UseTdsFlag الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? UseTdsFlag { get; private set; }

    /// <summary>
    /// AddForceInvoicePurchaseInvoice of the AccountsPayableCharge
    /// AddForceInvoicePurchaseInvoice الخاص بـ AccountsPayableCharge
    /// </summary>
    public decimal? AddForceInvoicePurchaseInvoice { get; private set; }

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

