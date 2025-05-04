using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// VendorBank Entity
/// </summary>
public class VendorBank : Entity<VendorBankId>
{
    private VendorBank() { }

    /// <summary>
    /// The unique identifier for the VendorBank
    /// المعرف الفريد لـ VendorBank
    /// </summary>
    public VendorBankId Id { get; private set; }

    /// <summary>
    /// VendorCode of the VendorBank
    /// VendorCode الخاص بـ VendorBank
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// BankNumber of the VendorBank
    /// BankNumber الخاص بـ VendorBank
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// BankAccountShort of the VendorBank
    /// BankAccountShort الخاص بـ VendorBank
    /// </summary>
    public string BankAccountShort { get; private set; }

    /// <summary>
    /// BankName of the VendorBank
    /// BankName الخاص بـ VendorBank
    /// </summary>
    public string BankName { get; private set; }

    /// <summary>
    /// SwiftCode of the VendorBank
    /// SwiftCode الخاص بـ VendorBank
    /// </summary>
    public string SwiftCode { get; private set; }

    /// <summary>
    /// CountryNumber of the VendorBank
    /// CountryNumber الخاص بـ VendorBank
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the VendorBank
    /// CityNumber الخاص بـ VendorBank
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// BeneficiaryName of the VendorBank
    /// BeneficiaryName الخاص بـ VendorBank
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// BankKey of the VendorBank
    /// BankKey الخاص بـ VendorBank
    /// </summary>
    public string BankKey { get; private set; }

    /// <summary>
    /// IbanNumber of the VendorBank
    /// IbanNumber الخاص بـ VendorBank
    /// </summary>
    public string IbanNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the VendorBank
    /// AccountCurrency الخاص بـ VendorBank
    /// </summary>
    public string AccountCurrency { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    #endregion
}
}
