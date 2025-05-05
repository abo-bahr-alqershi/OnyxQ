using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;
namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// TelecomSetup Entity
/// </summary>
public class TelecomSetup : Entity<TelecomSetupId>
{

    private TelecomSetup() { }

    public TelecomSetup(TelecomSetupId id, decimal? companyNumber)
    {
        Id = id;
        CompanyNumber = companyNumber;
    }

    /// <summary>
    /// The unique identifier for the TelecomSetup
    /// المعرف الفريد لـ TelecomSetup
    /// </summary>
    public TelecomSetupId Id { get; private set; }

    /// <summary>
    /// CompanyNumber of the TelecomSetup
    /// CompanyNumber الخاص بـ TelecomSetup
    /// </summary>
    public decimal? CompanyNumber { get; private set; }

    /// <summary>
    /// CompanyLastName of the TelecomSetup
    /// CompanyLastName الخاص بـ TelecomSetup
    /// </summary>
    public string CompanyLastName { get; private set; }

    /// <summary>
    /// CompanyFirstName of the TelecomSetup
    /// CompanyFirstName الخاص بـ TelecomSetup
    /// </summary>
    public string CompanyFirstName { get; private set; }

    /// <summary>
    /// CompanyPrefix of the TelecomSetup
    /// CompanyPrefix الخاص بـ TelecomSetup
    /// </summary>
    public string CompanyPrefix { get; private set; }

    /// <summary>
    /// CompanyCode of the TelecomSetup
    /// CompanyCode الخاص بـ TelecomSetup
    /// </summary>
    public string CompanyCode { get; private set; }

    /// <summary>
    /// UserCode of the TelecomSetup
    /// UserCode الخاص بـ TelecomSetup
    /// </summary>
    public string UserCode { get; private set; }

    /// <summary>
    /// UserPasswordShort of the TelecomSetup
    /// UserPasswordShort الخاص بـ TelecomSetup
    /// </summary>
    public string UserPasswordShort { get; private set; }

    /// <summary>
    /// UserTag of the TelecomSetup
    /// UserTag الخاص بـ TelecomSetup
    /// </summary>
    public string UserTag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

