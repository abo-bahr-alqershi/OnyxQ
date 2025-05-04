using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseManager Entity
/// </summary>
public class PurchaseManager : Entity<PurchaseManagerId>
{
    private PurchaseManager() { }

    /// <summary>
    /// The unique identifier for the PurchaseManager
    /// المعرف الفريد لـ PurchaseManager
    /// </summary>
    public PurchaseManagerId Id { get; private set; }

    /// <summary>
    /// PersonManagerCode of the PurchaseManager
    /// PersonManagerCode الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerCode { get; private set; }

    /// <summary>
    /// PersonManagerNameArabic of the PurchaseManager
    /// PersonManagerNameArabic الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerNameArabic { get; private set; }

    /// <summary>
    /// PersonManagerNameEnglish of the PurchaseManager
    /// PersonManagerNameEnglish الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerNameEnglish { get; private set; }

    /// <summary>
    /// PersonManagerAccountCode of the PurchaseManager
    /// PersonManagerAccountCode الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerAccountCode { get; private set; }

    /// <summary>
    /// CountryNumber of the PurchaseManager
    /// CountryNumber الخاص بـ PurchaseManager
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the PurchaseManager
    /// CityNumber الخاص بـ PurchaseManager
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// PersonManagerPhone of the PurchaseManager
    /// PersonManagerPhone الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerPhone { get; private set; }

    /// <summary>
    /// InactiveFlag of the PurchaseManager
    /// InactiveFlag الخاص بـ PurchaseManager
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// PersonManagerBox of the PurchaseManager
    /// PersonManagerBox الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerBox { get; private set; }

    /// <summary>
    /// PersonManagerFax of the PurchaseManager
    /// PersonManagerFax الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerFax { get; private set; }

    /// <summary>
    /// PersonManagerNote of the PurchaseManager
    /// PersonManagerNote الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerNote { get; private set; }

    /// <summary>
    /// PersonManagerMobile of the PurchaseManager
    /// PersonManagerMobile الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerMobile { get; private set; }

    /// <summary>
    /// PersonManagerAddress of the PurchaseManager
    /// PersonManagerAddress الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerAddress { get; private set; }

    /// <summary>
    /// GuarantorName of the PurchaseManager
    /// GuarantorName الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorName { get; private set; }

    /// <summary>
    /// GuarantorAddress of the PurchaseManager
    /// GuarantorAddress الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorAddress { get; private set; }

    /// <summary>
    /// GuarantorStartDate of the PurchaseManager
    /// GuarantorStartDate الخاص بـ PurchaseManager
    /// </summary>
    public DateTime? GuarantorStartDate { get; private set; }

    /// <summary>
    /// GuarantorExpireDate of the PurchaseManager
    /// GuarantorExpireDate الخاص بـ PurchaseManager
    /// </summary>
    public DateTime? GuarantorExpireDate { get; private set; }

    /// <summary>
    /// GuarantorType of the PurchaseManager
    /// GuarantorType الخاص بـ PurchaseManager
    /// </summary>
    public decimal? GuarantorType { get; private set; }

    /// <summary>
    /// GuarantorAmount of the PurchaseManager
    /// GuarantorAmount الخاص بـ PurchaseManager
    /// </summary>
    public decimal? GuarantorAmount { get; private set; }

    /// <summary>
    /// GuarantorStatus of the PurchaseManager
    /// GuarantorStatus الخاص بـ PurchaseManager
    /// </summary>
    public decimal? GuarantorStatus { get; private set; }

    /// <summary>
    /// GuarantorFinancialCenter of the PurchaseManager
    /// GuarantorFinancialCenter الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorFinancialCenter { get; private set; }

    /// <summary>
    /// GuarantorWork of the PurchaseManager
    /// GuarantorWork الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorWork { get; private set; }

    /// <summary>
    /// GuarantorDocumentDate of the PurchaseManager
    /// GuarantorDocumentDate الخاص بـ PurchaseManager
    /// </summary>
    public DateTime? GuarantorDocumentDate { get; private set; }

    /// <summary>
    /// GuarantorRegisterCourt of the PurchaseManager
    /// GuarantorRegisterCourt الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorRegisterCourt { get; private set; }

    /// <summary>
    /// GuarantorRegisterTrade of the PurchaseManager
    /// GuarantorRegisterTrade الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorRegisterTrade { get; private set; }

    /// <summary>
    /// GuarantorFileTrade of the PurchaseManager
    /// GuarantorFileTrade الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorFileTrade { get; private set; }

    /// <summary>
    /// GuarantorTelephone of the PurchaseManager
    /// GuarantorTelephone الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorTelephone { get; private set; }

    /// <summary>
    /// GuarantorFax of the PurchaseManager
    /// GuarantorFax الخاص بـ PurchaseManager
    /// </summary>
    public string GuarantorFax { get; private set; }

    /// <summary>
    /// PersonManagerCodeParent of the PurchaseManager
    /// PersonManagerCodeParent الخاص بـ PurchaseManager
    /// </summary>
    public string PersonManagerCodeParent { get; private set; }

    /// <summary>
    /// RegionCode of the PurchaseManager
    /// RegionCode الخاص بـ PurchaseManager
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the PurchaseManager
    /// InactivatedByUserId الخاص بـ PurchaseManager
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the PurchaseManager
    /// InactiveDate الخاص بـ PurchaseManager
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the PurchaseManager
    /// InactiveReason الخاص بـ PurchaseManager
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: PurchaseManager to PurchaseBillMaster
    /// </summary>
    public IReadOnlyCollection<PurchaseBillMaster> PurchaseBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: PurchaseManager to PurchasePlanDetail
    /// </summary>
    public IReadOnlyCollection<PurchasePlanDetail> PurchasePlanDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: PurchaseManager to PerformaInvoiceBillMaster
    /// </summary>
    public IReadOnlyCollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMasters { get; private set; }
    #endregion
}
}
