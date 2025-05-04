using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// Company Entity
/// </summary>
public class Company : Entity<CompanyId>
{
    private Company() { }

    /// <summary>
    /// The unique identifier for the Company
    /// المعرف الفريد لـ Company
    /// </summary>
    public CompanyId Id { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Company
    /// CompanyNumberShort الخاص بـ Company
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// CompanyLastNameFull of the Company
    /// CompanyLastNameFull الخاص بـ Company
    /// </summary>
    public string CompanyLastNameFull { get; private set; }

    /// <summary>
    /// CompanyFirstNameFull of the Company
    /// CompanyFirstNameFull الخاص بـ Company
    /// </summary>
    public string CompanyFirstNameFull { get; private set; }

    /// <summary>
    /// CompanyShortLastName of the Company
    /// CompanyShortLastName الخاص بـ Company
    /// </summary>
    public string CompanyShortLastName { get; private set; }

    /// <summary>
    /// CompanyShortNameFull of the Company
    /// CompanyShortNameFull الخاص بـ Company
    /// </summary>
    public string CompanyShortNameFull { get; private set; }

    /// <summary>
    /// CompanyDescription of the Company
    /// CompanyDescription الخاص بـ Company
    /// </summary>
    public string CompanyDescription { get; private set; }

    /// <summary>
    /// CompanyImage of the Company
    /// CompanyImage الخاص بـ Company
    /// </summary>
    public string CompanyImage { get; private set; }

    /// <summary>
    /// CompanyGroup of the Company
    /// CompanyGroup الخاص بـ Company
    /// </summary>
    public decimal? CompanyGroup { get; private set; }

    /// <summary>
    /// CompanyWebsite of the Company
    /// CompanyWebsite الخاص بـ Company
    /// </summary>
    public string CompanyWebsite { get; private set; }

    /// <summary>
    /// CompanyEmail of the Company
    /// CompanyEmail الخاص بـ Company
    /// </summary>
    public string CompanyEmail { get; private set; }

    /// <summary>
    /// Gps of the Company
    /// Gps الخاص بـ Company
    /// </summary>
    public string Gps { get; private set; }

    /// <summary>
    /// CountryNumber of the Company
    /// CountryNumber الخاص بـ Company
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// WebConnection of the Company
    /// WebConnection الخاص بـ Company
    /// </summary>
    public decimal? WebConnection { get; private set; }

    /// <summary>
    /// FinscanUrl of the Company
    /// FinscanUrl الخاص بـ Company
    /// </summary>
    public string FinscanUrl { get; private set; }

    /// <summary>
    /// FinscanOrganizationName of the Company
    /// FinscanOrganizationName الخاص بـ Company
    /// </summary>
    public string FinscanOrganizationName { get; private set; }

    /// <summary>
    /// FinscanUserName of the Company
    /// FinscanUserName الخاص بـ Company
    /// </summary>
    public string FinscanUserName { get; private set; }

    /// <summary>
    /// FinscanUserPassword of the Company
    /// FinscanUserPassword الخاص بـ Company
    /// </summary>
    public string FinscanUserPassword { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Company to Branch
    /// </summary>
    public IReadOnlyCollection<Branch> Branches { get; private set; }
    #endregion
}
}
