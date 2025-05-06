using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CashCustomerLocation Entity
/// </summary>
public class CashCustomerLocation : Entity<CashCustomerLocationId>
{

    private CashCustomerLocation() { }

    public CashCustomerLocation(CashCustomerLocationId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CashCustomerLocation
    /// المعرف الفريد لـ CashCustomerLocation
    /// </summary>
    public CashCustomerLocationId Id { get; private set; }

    /// <summary>
    /// CustomerRegionNumber of the CashCustomerLocation
    /// CustomerRegionNumber الخاص بـ CashCustomerLocation
    /// </summary>
    public decimal? CustomerRegionNumber { get; private set; }

    /// <summary>
    /// CustomerBuildingNumber of the CashCustomerLocation
    /// CustomerBuildingNumber الخاص بـ CashCustomerLocation
    /// </summary>
    public string CustomerBuildingNumber { get; private set; }

    /// <summary>
    /// CustomerFloorNumber of the CashCustomerLocation
    /// CustomerFloorNumber الخاص بـ CashCustomerLocation
    /// </summary>
    public string CustomerFloorNumber { get; private set; }

    /// <summary>
    /// CustomerApartmentNumber of the CashCustomerLocation
    /// CustomerApartmentNumber الخاص بـ CashCustomerLocation
    /// </summary>
    public string CustomerApartmentNumber { get; private set; }

    /// <summary>
    /// Note of the CashCustomerLocation
    /// Note الخاص بـ CashCustomerLocation
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// Latitude of the CashCustomerLocation
    /// Latitude الخاص بـ CashCustomerLocation
    /// </summary>
    public string Latitude { get; private set; }

    /// <summary>
    /// Longitude of the CashCustomerLocation
    /// Longitude الخاص بـ CashCustomerLocation
    /// </summary>
    public string Longitude { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CashCustomer CashCustomer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

