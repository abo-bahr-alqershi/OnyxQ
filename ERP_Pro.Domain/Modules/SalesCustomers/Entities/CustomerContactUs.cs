using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerContactUs Entity
/// </summary>
public class CustomerContactUs : Entity<CustomerContactUsId>
{

    private CustomerContactUs() { }

    public CustomerContactUs(CustomerContactUsId id, decimal? docNo)
    {
        Id = id;
        DocNo = docNo;
    }

    /// <summary>
    /// The unique identifier for the CustomerContactUs
    /// المعرف الفريد لـ CustomerContactUs
    /// </summary>
    public CustomerContactUsId Id { get; private set; }

    /// <summary>
    /// DocNo of the CustomerContactUs
    /// DocNo الخاص بـ CustomerContactUs
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the CustomerContactUs
    /// DocDate الخاص بـ CustomerContactUs
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocSubjct of the CustomerContactUs
    /// DocSubjct الخاص بـ CustomerContactUs
    /// </summary>
    public string DocSubjct { get; private set; }

    /// <summary>
    /// DocDsc of the CustomerContactUs
    /// DocDsc الخاص بـ CustomerContactUs
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// CustCode of the CustomerContactUs
    /// CustCode الخاص بـ CustomerContactUs
    /// </summary>
    public string CustCode { get; private set; }

    /// <summary>
    /// CustLNm of the CustomerContactUs
    /// CustLNm الخاص بـ CustomerContactUs
    /// </summary>
    public string CustLNm { get; private set; }

    /// <summary>
    /// MobileNumber of the CustomerContactUs
    /// MobileNumber الخاص بـ CustomerContactUs
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// TelephoneNumber of the CustomerContactUs
    /// TelephoneNumber الخاص بـ CustomerContactUs
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// Email of the CustomerContactUs
    /// Email الخاص بـ CustomerContactUs
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Address of the CustomerContactUs
    /// Address الخاص بـ CustomerContactUs
    /// </summary>
    public string Address { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
