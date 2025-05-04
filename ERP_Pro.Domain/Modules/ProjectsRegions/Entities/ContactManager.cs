using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// ContactManager Entity
/// </summary>
public class ContactManager : Entity<ContactManagerId>
{

    private ContactManager() { }

    public ContactManager(ContactManagerId id, decimal? contactNumber)
    {
        Id = id;
        ContactNumber = contactNumber;
    }

    /// <summary>
    /// The unique identifier for the ContactManager
    /// المعرف الفريد لـ ContactManager
    /// </summary>
    public ContactManagerId Id { get; private set; }

    /// <summary>
    /// ContactNumber of the ContactManager
    /// ContactNumber الخاص بـ ContactManager
    /// </summary>
    public decimal? ContactNumber { get; private set; }

    /// <summary>
    /// ContactNameArabic of the ContactManager
    /// ContactNameArabic الخاص بـ ContactManager
    /// </summary>
    public string ContactNameArabic { get; private set; }

    /// <summary>
    /// ContactNameEnglish of the ContactManager
    /// ContactNameEnglish الخاص بـ ContactManager
    /// </summary>
    public string ContactNameEnglish { get; private set; }

    /// <summary>
    /// CountryNumber of the ContactManager
    /// CountryNumber الخاص بـ ContactManager
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the ContactManager
    /// CityNumber الخاص بـ ContactManager
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the ContactManager
    /// RegionCode الخاص بـ ContactManager
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// ContactPhone of the ContactManager
    /// ContactPhone الخاص بـ ContactManager
    /// </summary>
    public string ContactPhone { get; private set; }

    /// <summary>
    /// InactiveFlag of the ContactManager
    /// InactiveFlag الخاص بـ ContactManager
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// ContactBox of the ContactManager
    /// ContactBox الخاص بـ ContactManager
    /// </summary>
    public string ContactBox { get; private set; }

    /// <summary>
    /// ContactFax of the ContactManager
    /// ContactFax الخاص بـ ContactManager
    /// </summary>
    public string ContactFax { get; private set; }

    /// <summary>
    /// ContactNote of the ContactManager
    /// ContactNote الخاص بـ ContactManager
    /// </summary>
    public string ContactNote { get; private set; }

    /// <summary>
    /// ContactMobile of the ContactManager
    /// ContactMobile الخاص بـ ContactManager
    /// </summary>
    public string ContactMobile { get; private set; }

    /// <summary>
    /// ContactAddress of the ContactManager
    /// ContactAddress الخاص بـ ContactManager
    /// </summary>
    public string ContactAddress { get; private set; }

    /// <summary>
    /// ContactWebsite of the ContactManager
    /// ContactWebsite الخاص بـ ContactManager
    /// </summary>
    public string ContactWebsite { get; private set; }

    /// <summary>
    /// ContactEmail of the ContactManager
    /// ContactEmail الخاص بـ ContactManager
    /// </summary>
    public string ContactEmail { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
