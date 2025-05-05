using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// InterfaceAccount Entity
/// </summary>
public class InterfaceAccount : Entity<InterfaceAccountId>
{

    private InterfaceAccount() { }

    public InterfaceAccount(InterfaceAccountId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InterfaceAccount
    /// المعرف الفريد لـ InterfaceAccount
    /// </summary>
    public InterfaceAccountId Id { get; private set; }

    /// <summary>
    /// InterfaceNumber of the InterfaceAccount
    /// InterfaceNumber الخاص بـ InterfaceAccount
    /// </summary>
    public decimal? InterfaceNumber { get; private set; }

    /// <summary>
    /// CurrDiff of the InterfaceAccount
    /// CurrDiff الخاص بـ InterfaceAccount
    /// </summary>
    public string CurrDiff { get; private set; }

    /// <summary>
    /// CommissionACode of the InterfaceAccount
    /// CommissionACode الخاص بـ InterfaceAccount
    /// </summary>
    public string CommissionACode { get; private set; }

    /// <summary>
    /// DiffPrACode of the InterfaceAccount
    /// DiffPrACode الخاص بـ InterfaceAccount
    /// </summary>
    public string DiffPrACode { get; private set; }

    /// <summary>
    /// DiffKitItmACode of the InterfaceAccount
    /// DiffKitItmACode الخاص بـ InterfaceAccount
    /// </summary>
    public string DiffKitItmACode { get; private set; }

    /// <summary>
    /// ForceDifferenceCostCenter of the InterfaceAccount
    /// ForceDifferenceCostCenter الخاص بـ InterfaceAccount
    /// </summary>
    public string ForceDifferenceCostCenter { get; private set; }

    /// <summary>
    /// DiscAmtNotEffectAc of the InterfaceAccount
    /// DiscAmtNotEffectAc الخاص بـ InterfaceAccount
    /// </summary>
    public string DiscAmtNotEffectAc { get; private set; }

    /// <summary>
    /// AccountBalancedCostCenter of the InterfaceAccount
    /// AccountBalancedCostCenter الخاص بـ InterfaceAccount
    /// </summary>
    public string AccountBalancedCostCenter { get; private set; }

    /// <summary>
    /// AccountBalancedBranch of the InterfaceAccount
    /// AccountBalancedBranch الخاص بـ InterfaceAccount
    /// </summary>
    public string AccountBalancedBranch { get; private set; }

    /// <summary>
    /// DiffPurStkACode of the InterfaceAccount
    /// DiffPurStkACode الخاص بـ InterfaceAccount
    /// </summary>
    public string DiffPurStkACode { get; private set; }

    /// <summary>
    /// DiffWhtrnsACode of the InterfaceAccount
    /// DiffWhtrnsACode الخاص بـ InterfaceAccount
    /// </summary>
    public string DiffWhtrnsACode { get; private set; }

    /// <summary>
    /// DiffOutgoingACode of the InterfaceAccount
    /// DiffOutgoingACode الخاص بـ InterfaceAccount
    /// </summary>
    public string DiffOutgoingACode { get; private set; }

    /// <summary>
    /// PaymentKimbAccountCode of the InterfaceAccount
    /// PaymentKimbAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string PaymentKimbAccountCode { get; private set; }

    /// <summary>
    /// DefctCshrACode of the InterfaceAccount
    /// DefctCshrACode الخاص بـ InterfaceAccount
    /// </summary>
    public string DefctCshrACode { get; private set; }

    /// <summary>
    /// ExcessCashierAccountCode of the InterfaceAccount
    /// ExcessCashierAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string ExcessCashierAccountCode { get; private set; }

    /// <summary>
    /// FixedAssetIncreaseAccountCode of the InterfaceAccount
    /// FixedAssetIncreaseAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetIncreaseAccountCode { get; private set; }

    /// <summary>
    /// FixedAssetDecreaseAccountCode of the InterfaceAccount
    /// FixedAssetDecreaseAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetDecreaseAccountCode { get; private set; }

    /// <summary>
    /// FixedAssetTransferImmediate of the InterfaceAccount
    /// FixedAssetTransferImmediate الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetTransferImmediate { get; private set; }

    /// <summary>
    /// FixedAssetCostCenterCode of the InterfaceAccount
    /// FixedAssetCostCenterCode الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetCostCenterCode { get; private set; }

    /// <summary>
    /// FixedAssetActivityNumber of the InterfaceAccount
    /// FixedAssetActivityNumber الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetActivityNumber { get; private set; }

    /// <summary>
    /// FixedAssetProjectNumber of the InterfaceAccount
    /// FixedAssetProjectNumber الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetProjectNumber { get; private set; }

    /// <summary>
    /// StockAdjustAccountCode of the InterfaceAccount
    /// StockAdjustAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string StockAdjustAccountCode { get; private set; }

    /// <summary>
    /// CouponAccountCode of the InterfaceAccount
    /// CouponAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string CouponAccountCode { get; private set; }

    /// <summary>
    /// RemarkAccountCodeReal of the InterfaceAccount
    /// RemarkAccountCodeReal الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodeReal { get; private set; }

    /// <summary>
    /// RemarkAccountCodeIncomeSale of the InterfaceAccount
    /// RemarkAccountCodeIncomeSale الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodeIncomeSale { get; private set; }

    /// <summary>
    /// RemarkAccountCodeIncomeRental of the InterfaceAccount
    /// RemarkAccountCodeIncomeRental الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodeIncomeRental { get; private set; }

    /// <summary>
    /// RemarkAccountCodeRentPrepaid of the InterfaceAccount
    /// RemarkAccountCodeRentPrepaid الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodeRentPrepaid { get; private set; }

    /// <summary>
    /// RemarkAccountCodeIncomeDeferred of the InterfaceAccount
    /// RemarkAccountCodeIncomeDeferred الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodeIncomeDeferred { get; private set; }

    /// <summary>
    /// RemarkAccountCodeInsurance of the InterfaceAccount
    /// RemarkAccountCodeInsurance الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodeInsurance { get; private set; }

    /// <summary>
    /// RemarkAccountCodeDiscount of the InterfaceAccount
    /// RemarkAccountCodeDiscount الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodeDiscount { get; private set; }

    /// <summary>
    /// RemarkAccountCodePurchases of the InterfaceAccount
    /// RemarkAccountCodePurchases الخاص بـ InterfaceAccount
    /// </summary>
    public string RemarkAccountCodePurchases { get; private set; }

    /// <summary>
    /// RmsAccountCodeInsurance of the InterfaceAccount
    /// RmsAccountCodeInsurance الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeInsurance { get; private set; }

    /// <summary>
    /// RmsAccountCodeExpense of the InterfaceAccount
    /// RmsAccountCodeExpense الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeExpense { get; private set; }

    /// <summary>
    /// RmsAccountCodeItemDamaged of the InterfaceAccount
    /// RmsAccountCodeItemDamaged الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeItemDamaged { get; private set; }

    /// <summary>
    /// RmsAccountCodeReadyItemFood of the InterfaceAccount
    /// RmsAccountCodeReadyItemFood الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeReadyItemFood { get; private set; }

    /// <summary>
    /// RmsAccountCodeRent of the InterfaceAccount
    /// RmsAccountCodeRent الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeRent { get; private set; }

    /// <summary>
    /// RmsAccountCodeReceipt of the InterfaceAccount
    /// RmsAccountCodeReceipt الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeReceipt { get; private set; }

    /// <summary>
    /// RepresentativeCommissionAccount of the InterfaceAccount
    /// RepresentativeCommissionAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string RepresentativeCommissionAccount { get; private set; }

    /// <summary>
    /// HoursDeserveEmployeeAccountCode of the InterfaceAccount
    /// HoursDeserveEmployeeAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string HoursDeserveEmployeeAccountCode { get; private set; }

    /// <summary>
    /// ShippingDiscountAccount of the InterfaceAccount
    /// ShippingDiscountAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string ShippingDiscountAccount { get; private set; }

    /// <summary>
    /// ShippingSalesAccount of the InterfaceAccount
    /// ShippingSalesAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string ShippingSalesAccount { get; private set; }

    /// <summary>
    /// ShippingOtherAccount of the InterfaceAccount
    /// ShippingOtherAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string ShippingOtherAccount { get; private set; }

    /// <summary>
    /// ShippingVatAccount of the InterfaceAccount
    /// ShippingVatAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string ShippingVatAccount { get; private set; }

    /// <summary>
    /// DlySalesAc of the InterfaceAccount
    /// DlySalesAc الخاص بـ InterfaceAccount
    /// </summary>
    public string DlySalesAc { get; private set; }

    /// <summary>
    /// EmpCommAc of the InterfaceAccount
    /// EmpCommAc الخاص بـ InterfaceAccount
    /// </summary>
    public string EmpCommAc { get; private set; }

    /// <summary>
    /// VatPurchaseAccountCode of the InterfaceAccount
    /// VatPurchaseAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string VatPurchaseAccountCode { get; private set; }

    /// <summary>
    /// PointReplaceAccountCode of the InterfaceAccount
    /// PointReplaceAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string PointReplaceAccountCode { get; private set; }

    /// <summary>
    /// FixedAssetLostAccountCode of the InterfaceAccount
    /// FixedAssetLostAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetLostAccountCode { get; private set; }

    /// <summary>
    /// FixedAssetProfitAccountCode of the InterfaceAccount
    /// FixedAssetProfitAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetProfitAccountCode { get; private set; }

    /// <summary>
    /// ForceDifferenceDiscountAfterVatAccount of the InterfaceAccount
    /// ForceDifferenceDiscountAfterVatAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string ForceDifferenceDiscountAfterVatAccount { get; private set; }

    /// <summary>
    /// HospitalAdmissionAccountCode of the InterfaceAccount
    /// HospitalAdmissionAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string HospitalAdmissionAccountCode { get; private set; }

    /// <summary>
    /// HospitalAdmissionAccountCodeDetail of the InterfaceAccount
    /// HospitalAdmissionAccountCodeDetail الخاص بـ InterfaceAccount
    /// </summary>
    public string HospitalAdmissionAccountCodeDetail { get; private set; }

    /// <summary>
    /// HospitalDoctorPercentAccountCode of the InterfaceAccount
    /// HospitalDoctorPercentAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string HospitalDoctorPercentAccountCode { get; private set; }

    /// <summary>
    /// HospitalAdmissionDiscountAccountCode of the InterfaceAccount
    /// HospitalAdmissionDiscountAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string HospitalAdmissionDiscountAccountCode { get; private set; }

    /// <summary>
    /// HospitalRentRevenuesAccountCode of the InterfaceAccount
    /// HospitalRentRevenuesAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string HospitalRentRevenuesAccountCode { get; private set; }

    /// <summary>
    /// PurchaseIncomeAccountCode of the InterfaceAccount
    /// PurchaseIncomeAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string PurchaseIncomeAccountCode { get; private set; }

    /// <summary>
    /// TaxDueAccountCode of the InterfaceAccount
    /// TaxDueAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string TaxDueAccountCode { get; private set; }

    /// <summary>
    /// RmsAccountCodeHospitality of the InterfaceAccount
    /// RmsAccountCodeHospitality الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeHospitality { get; private set; }

    /// <summary>
    /// RmsAccountCodeNutrition of the InterfaceAccount
    /// RmsAccountCodeNutrition الخاص بـ InterfaceAccount
    /// </summary>
    public string RmsAccountCodeNutrition { get; private set; }

    /// <summary>
    /// HoursMedicalCareTaxAccount of the InterfaceAccount
    /// HoursMedicalCareTaxAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string HoursMedicalCareTaxAccount { get; private set; }

    /// <summary>
    /// FmsAccountCodeAllowDiscount of the InterfaceAccount
    /// FmsAccountCodeAllowDiscount الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsAccountCodeAllowDiscount { get; private set; }

    /// <summary>
    /// FmsAccountCodeCommission of the InterfaceAccount
    /// FmsAccountCodeCommission الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsAccountCodeCommission { get; private set; }

    /// <summary>
    /// FixedAssetMaintenanceImmediateAccountCode of the InterfaceAccount
    /// FixedAssetMaintenanceImmediateAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string FixedAssetMaintenanceImmediateAccountCode { get; private set; }

    /// <summary>
    /// AmsAccountCodeExpense of the InterfaceAccount
    /// AmsAccountCodeExpense الخاص بـ InterfaceAccount
    /// </summary>
    public string AmsAccountCodeExpense { get; private set; }

    /// <summary>
    /// AmsAccountCodeLabor of the InterfaceAccount
    /// AmsAccountCodeLabor الخاص بـ InterfaceAccount
    /// </summary>
    public string AmsAccountCodeLabor { get; private set; }

    /// <summary>
    /// AmsCostCenterCodeLabor of the InterfaceAccount
    /// AmsCostCenterCodeLabor الخاص بـ InterfaceAccount
    /// </summary>
    public string AmsCostCenterCodeLabor { get; private set; }

    /// <summary>
    /// AmsPartExpenseAccount of the InterfaceAccount
    /// AmsPartExpenseAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string AmsPartExpenseAccount { get; private set; }

    /// <summary>
    /// FmsAccountCodeSaleRevenue of the InterfaceAccount
    /// FmsAccountCodeSaleRevenue الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsAccountCodeSaleRevenue { get; private set; }

    /// <summary>
    /// FmsAccountCodeInternalTransport of the InterfaceAccount
    /// FmsAccountCodeInternalTransport الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsAccountCodeInternalTransport { get; private set; }

    /// <summary>
    /// FmsTransferVendorExpenseAccount of the InterfaceAccount
    /// FmsTransferVendorExpenseAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsTransferVendorExpenseAccount { get; private set; }

    /// <summary>
    /// FmsDriverCommissionAccount of the InterfaceAccount
    /// FmsDriverCommissionAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsDriverCommissionAccount { get; private set; }

    /// <summary>
    /// FmsDriverCustodyAccount of the InterfaceAccount
    /// FmsDriverCustodyAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsDriverCustodyAccount { get; private set; }

    /// <summary>
    /// GlassBankDepositAccount of the InterfaceAccount
    /// GlassBankDepositAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string GlassBankDepositAccount { get; private set; }

    /// <summary>
    /// LetterCreditAccountCode of the InterfaceAccount
    /// LetterCreditAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string LetterCreditAccountCode { get; private set; }

    /// <summary>
    /// FmsCustomerAccount of the InterfaceAccount
    /// FmsCustomerAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsCustomerAccount { get; private set; }

    /// <summary>
    /// FmsRevenueAccount of the InterfaceAccount
    /// FmsRevenueAccount الخاص بـ InterfaceAccount
    /// </summary>
    public string FmsRevenueAccount { get; private set; }

    /// <summary>
    /// ReturnReplaceAccountCode of the InterfaceAccount
    /// ReturnReplaceAccountCode الخاص بـ InterfaceAccount
    /// </summary>
    public string ReturnReplaceAccountCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: OneToOne
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountLossOfg { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountPayLetter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountRecLetter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountVatAc { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountFrcDiffAc { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountEmptyAc { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountVatProfitCrdt { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountVatProfitDebt { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

