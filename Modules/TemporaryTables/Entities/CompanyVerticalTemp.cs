using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// CompanyVerticalTemp Entity
/// </summary>
public class CompanyVerticalTemp : Entity<CompanyVerticalTempId>
{
    private CompanyVerticalTemp() { }

    /// <summary>
    /// The unique identifier for the CompanyVerticalTemp
    /// المعرف الفريد لـ CompanyVerticalTemp
    /// </summary>
    public CompanyVerticalTempId Id { get; private set; }

    /// <summary>
    /// Field of the CompanyVerticalTemp
    /// Field الخاص بـ CompanyVerticalTemp
    /// </summary>
    public string Field { get; private set; }

    /// <summary>
    /// Amount of the CompanyVerticalTemp
    /// Amount الخاص بـ CompanyVerticalTemp
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CompanyVerticalTemp
    /// CompanyNumberShort الخاص بـ CompanyVerticalTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CompanyVerticalTemp
    /// BranchNumber الخاص بـ CompanyVerticalTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CompanyVerticalTemp
    /// BranchYear الخاص بـ CompanyVerticalTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CompanyVerticalTemp
    /// BranchUser الخاص بـ CompanyVerticalTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
