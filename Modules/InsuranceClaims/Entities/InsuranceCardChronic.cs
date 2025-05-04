using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceCardChronic Entity
/// </summary>
public class InsuranceCardChronic : Entity<InsuranceCardChronicId>
{
    private InsuranceCardChronic() { }

    /// <summary>
    /// The unique identifier for the InsuranceCardChronic
    /// المعرف الفريد لـ InsuranceCardChronic
    /// </summary>
    public InsuranceCardChronicId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceCardChronic
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

    /// <summary>
    /// BeneficiaryNumber of the InsuranceCardChronic
    /// BeneficiaryNumber الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? BeneficiaryNumber { get; private set; }

    /// <summary>
    /// PersonSerial of the InsuranceCardChronic
    /// PersonSerial الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? PersonSerial { get; private set; }

    /// <summary>
    /// PersonNumberAlt of the InsuranceCardChronic
    /// PersonNumberAlt الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? PersonNumberAlt { get; private set; }

    /// <summary>
    /// ItemCode of the InsuranceCardChronic
    /// ItemCode الخاص بـ InsuranceCardChronic
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemQuantityDay of the InsuranceCardChronic
    /// ItemQuantityDay الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? ItemQuantityDay { get; private set; }

    /// <summary>
    /// ItemQuantityMonth of the InsuranceCardChronic
    /// ItemQuantityMonth الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? ItemQuantityMonth { get; private set; }

    /// <summary>
    /// ItemUnit of the InsuranceCardChronic
    /// ItemUnit الخاص بـ InsuranceCardChronic
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// RecordNumber of the InsuranceCardChronic
    /// RecordNumber الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PersonCardNumber of the InsuranceCardChronic
    /// PersonCardNumber الخاص بـ InsuranceCardChronic
    /// </summary>
    public string PersonCardNumber { get; private set; }

    /// <summary>
    /// PSize of the InsuranceCardChronic
    /// PSize الخاص بـ InsuranceCardChronic
    /// </summary>
    public decimal? PSize { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to InsuranceCard
    /// </summary>
    public InsuranceCard InsuranceCard { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    #endregion
}
}
