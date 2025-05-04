using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.TransportationShipping.Entities
{
/// <summary>
/// Driver Entity
/// </summary>
public class Driver : Entity<DriverId>
{
    private Driver() { }

    /// <summary>
    /// The unique identifier for the Driver
    /// المعرف الفريد لـ Driver
    /// </summary>
    public DriverId Id { get; private set; }

    /// <summary>
    /// DriverNo of the Driver
    /// DriverNo الخاص بـ Driver
    /// </summary>
    public decimal? DriverNo { get; private set; }

    /// <summary>
    /// DriverAName of the Driver
    /// DriverAName الخاص بـ Driver
    /// </summary>
    public string DriverAName { get; private set; }

    /// <summary>
    /// DriverEName of the Driver
    /// DriverEName الخاص بـ Driver
    /// </summary>
    public string DriverEName { get; private set; }

    /// <summary>
    /// RegionCode of the Driver
    /// RegionCode الخاص بـ Driver
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// InactiveFlag of the Driver
    /// InactiveFlag الخاص بـ Driver
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the Driver
    /// InactiveDate الخاص بـ Driver
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Driver
    /// InactiveReason الخاص بـ Driver
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// DriverNotes of the Driver
    /// DriverNotes الخاص بـ Driver
    /// </summary>
    public string DriverNotes { get; private set; }

    /// <summary>
    /// DriverTel of the Driver
    /// DriverTel الخاص بـ Driver
    /// </summary>
    public string DriverTel { get; private set; }

    /// <summary>
    /// DriverMobile of the Driver
    /// DriverMobile الخاص بـ Driver
    /// </summary>
    public string DriverMobile { get; private set; }

    /// <summary>
    /// DriverAddress of the Driver
    /// DriverAddress الخاص بـ Driver
    /// </summary>
    public string DriverAddress { get; private set; }

    /// <summary>
    /// DriverEMail of the Driver
    /// DriverEMail الخاص بـ Driver
    /// </summary>
    public string DriverEMail { get; private set; }

    /// <summary>
    /// RouteNumber of the Driver
    /// RouteNumber الخاص بـ Driver
    /// </summary>
    public decimal? RouteNumber { get; private set; }

    /// <summary>
    /// SortInRoute of the Driver
    /// SortInRoute الخاص بـ Driver
    /// </summary>
    public decimal? SortInRoute { get; private set; }

    /// <summary>
    /// RepCode of the Driver
    /// RepCode الخاص بـ Driver
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CarNumber of the Driver
    /// CarNumber الخاص بـ Driver
    /// </summary>
    public string CarNumber { get; private set; }

    /// <summary>
    /// CityNumber of the Driver
    /// CityNumber الخاص بـ Driver
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// StandardWeight of the Driver
    /// StandardWeight الخاص بـ Driver
    /// </summary>
    public decimal? StandardWeight { get; private set; }

    /// <summary>
    /// CarOwner of the Driver
    /// CarOwner الخاص بـ Driver
    /// </summary>
    public string CarOwner { get; private set; }

    /// <summary>
    /// DrvrUId of the Driver
    /// DrvrUId الخاص بـ Driver
    /// </summary>
    public decimal? DrvrUId { get; private set; }

    /// <summary>
    /// NationalityNumber of the Driver
    /// NationalityNumber الخاص بـ Driver
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Driver to ScaleMovement
    /// </summary>
    public IReadOnlyCollection<ScaleMovement> ScaleMovements { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// One-to-many relationship: Driver to DriverIdentification
    /// </summary>
    public IReadOnlyCollection<DriverIdentification> DriverIdentifications { get; private set; }
    #endregion
}
}
