using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SubCustomer Entity
/// </summary>
public class SubCustomer : Entity<SubCustomerId>
{

    private SubCustomer() { }

    public SubCustomer(SubCustomerId id, string cCode, string subCustomerCode)
    {
        Id = id;
        CCode = cCode;
        SubCustomerCode = subCustomerCode;
    }

    /// <summary>
    /// The unique identifier for the SubCustomer
    /// المعرف الفريد لـ SubCustomer
    /// </summary>
    public SubCustomerId Id { get; private set; }

    /// <summary>
    /// CCode of the SubCustomer
    /// CCode الخاص بـ SubCustomer
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// SubCustomerCode of the SubCustomer
    /// SubCustomerCode الخاص بـ SubCustomer
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// SubCustomerLastName of the SubCustomer
    /// SubCustomerLastName الخاص بـ SubCustomer
    /// </summary>
    public string SubCustomerLastName { get; private set; }

    /// <summary>
    /// SubCustomerFirstName of the SubCustomer
    /// SubCustomerFirstName الخاص بـ SubCustomer
    /// </summary>
    public string SubCustomerFirstName { get; private set; }

    /// <summary>
    /// DprtmntNm of the SubCustomer
    /// DprtmntNm الخاص بـ SubCustomer
    /// </summary>
    public string DprtmntNm { get; private set; }

    /// <summary>
    /// JobName of the SubCustomer
    /// JobName الخاص بـ SubCustomer
    /// </summary>
    public string JobName { get; private set; }

    /// <summary>
    /// CAddress of the SubCustomer
    /// CAddress الخاص بـ SubCustomer
    /// </summary>
    public string CAddress { get; private set; }

    /// <summary>
    /// CBox of the SubCustomer
    /// CBox الخاص بـ SubCustomer
    /// </summary>
    public string CBox { get; private set; }

    /// <summary>
    /// CFax of the SubCustomer
    /// CFax الخاص بـ SubCustomer
    /// </summary>
    public string CFax { get; private set; }

    /// <summary>
    /// CPhone of the SubCustomer
    /// CPhone الخاص بـ SubCustomer
    /// </summary>
    public string CPhone { get; private set; }

    /// <summary>
    /// CMobile of the SubCustomer
    /// CMobile الخاص بـ SubCustomer
    /// </summary>
    public string CMobile { get; private set; }

    /// <summary>
    /// CountryNumber of the SubCustomer
    /// CountryNumber الخاص بـ SubCustomer
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// CityNumber of the SubCustomer
    /// CityNumber الخاص بـ SubCustomer
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the SubCustomer
    /// RegionCode الخاص بـ SubCustomer
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// InactiveFlag of the SubCustomer
    /// InactiveFlag الخاص بـ SubCustomer
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the SubCustomer
    /// InactiveDate الخاص بـ SubCustomer
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the SubCustomer
    /// InactiveReason الخاص بـ SubCustomer
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the SubCustomer
    /// InactivatedByUserId الخاص بـ SubCustomer
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CardNumber of the SubCustomer
    /// CardNumber الخاص بـ SubCustomer
    /// </summary>
    public string CardNumber { get; private set; }

    /// <summary>
    /// CardType of the SubCustomer
    /// CardType الخاص بـ SubCustomer
    /// </summary>
    public decimal? CardType { get; private set; }

    /// <summary>
    /// CardJobNumberAlt of the SubCustomer
    /// CardJobNumberAlt الخاص بـ SubCustomer
    /// </summary>
    public string CardJobNumberAlt { get; private set; }

    /// <summary>
    /// MeasureDate of the SubCustomer
    /// MeasureDate الخاص بـ SubCustomer
    /// </summary>
    public DateTime? MeasureDate { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the SubCustomer
    /// ImportExcelFlag الخاص بـ SubCustomer
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
