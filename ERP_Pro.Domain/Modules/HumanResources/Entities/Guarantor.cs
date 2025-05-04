using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// Guarantor Entity
/// </summary>
public class Guarantor : Entity<GuarantorId>
{

    private Guarantor() { }

    public Guarantor(GuarantorId id, decimal? guarantorNumber)
    {
        Id = id;
        GuarantorNumber = guarantorNumber;
    }

    /// <summary>
    /// The unique identifier for the Guarantor
    /// المعرف الفريد لـ Guarantor
    /// </summary>
    public GuarantorId Id { get; private set; }

    /// <summary>
    /// GuarantorNumber of the Guarantor
    /// GuarantorNumber الخاص بـ Guarantor
    /// </summary>
    public decimal? GuarantorNumber { get; private set; }

    /// <summary>
    /// GuarantorLastName of the Guarantor
    /// GuarantorLastName الخاص بـ Guarantor
    /// </summary>
    public string GuarantorLastName { get; private set; }

    /// <summary>
    /// GuarantorFirstName of the Guarantor
    /// GuarantorFirstName الخاص بـ Guarantor
    /// </summary>
    public string GuarantorFirstName { get; private set; }

    /// <summary>
    /// CommercialNumber of the Guarantor
    /// CommercialNumber الخاص بـ Guarantor
    /// </summary>
    public string CommercialNumber { get; private set; }

    /// <summary>
    /// Email of the Guarantor
    /// Email الخاص بـ Guarantor
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Website of the Guarantor
    /// Website الخاص بـ Guarantor
    /// </summary>
    public string Website { get; private set; }

    /// <summary>
    /// FaxNumber of the Guarantor
    /// FaxNumber الخاص بـ Guarantor
    /// </summary>
    public string FaxNumber { get; private set; }

    /// <summary>
    /// TelephoneNumber of the Guarantor
    /// TelephoneNumber الخاص بـ Guarantor
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// MobileNumber of the Guarantor
    /// MobileNumber الخاص بـ Guarantor
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderBoxNumber of the Guarantor
    /// PurchaseOrderBoxNumber الخاص بـ Guarantor
    /// </summary>
    public string PurchaseOrderBoxNumber { get; private set; }

    /// <summary>
    /// AddressShort of the Guarantor
    /// AddressShort الخاص بـ Guarantor
    /// </summary>
    public string AddressShort { get; private set; }

    /// <summary>
    /// Field1 of the Guarantor
    /// Field1 الخاص بـ Guarantor
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Guarantor
    /// Field2 الخاص بـ Guarantor
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Guarantor
    /// Field3 الخاص بـ Guarantor
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Guarantor
    /// Field4 الخاص بـ Guarantor
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Guarantor
    /// Field5 الخاص بـ Guarantor
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Guarantor
    /// Field6 الخاص بـ Guarantor
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Guarantor
    /// Field7 الخاص بـ Guarantor
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Guarantor
    /// Field8 الخاص بـ Guarantor
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Guarantor
    /// Field9 الخاص بـ Guarantor
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Guarantor
    /// Field10 الخاص بـ Guarantor
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveFlag of the Guarantor
    /// InactiveFlag الخاص بـ Guarantor
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Guarantor
    /// InactivatedByUserId الخاص بـ Guarantor
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Guarantor
    /// InactiveDate الخاص بـ Guarantor
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Guarantor
    /// InactiveReason الخاص بـ Guarantor
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
