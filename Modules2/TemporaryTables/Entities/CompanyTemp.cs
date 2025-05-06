using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// CompanyTemp Entity
/// </summary>
public class CompanyTemp : Entity<CompanyTempId>
{

    private CompanyTemp() { }

    public CompanyTemp(CompanyTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CompanyTemp
    /// المعرف الفريد لـ CompanyTemp
    /// </summary>
    public CompanyTempId Id { get; private set; }

    /// <summary>
    /// Column1 of the CompanyTemp
    /// Column1 الخاص بـ CompanyTemp
    /// </summary>
    public string Column1 { get; private set; }

    /// <summary>
    /// Column2 of the CompanyTemp
    /// Column2 الخاص بـ CompanyTemp
    /// </summary>
    public string Column2 { get; private set; }

    /// <summary>
    /// Column3 of the CompanyTemp
    /// Column3 الخاص بـ CompanyTemp
    /// </summary>
    public string Column3 { get; private set; }

    /// <summary>
    /// Column4 of the CompanyTemp
    /// Column4 الخاص بـ CompanyTemp
    /// </summary>
    public string Column4 { get; private set; }

    /// <summary>
    /// Column5 of the CompanyTemp
    /// Column5 الخاص بـ CompanyTemp
    /// </summary>
    public string Column5 { get; private set; }

    /// <summary>
    /// Column6 of the CompanyTemp
    /// Column6 الخاص بـ CompanyTemp
    /// </summary>
    public string Column6 { get; private set; }

    /// <summary>
    /// Column7 of the CompanyTemp
    /// Column7 الخاص بـ CompanyTemp
    /// </summary>
    public string Column7 { get; private set; }

    /// <summary>
    /// Column8 of the CompanyTemp
    /// Column8 الخاص بـ CompanyTemp
    /// </summary>
    public string Column8 { get; private set; }

    /// <summary>
    /// RnoFlag of the CompanyTemp
    /// RnoFlag الخاص بـ CompanyTemp
    /// </summary>
    public decimal? RnoFlag { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CompanyTemp
    /// CompanyNumberShort الخاص بـ CompanyTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CompanyTemp
    /// BranchNumber الخاص بـ CompanyTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CompanyTemp
    /// BranchYear الخاص بـ CompanyTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CompanyTemp
    /// BranchUser الخاص بـ CompanyTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

