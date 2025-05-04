using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// BranchYearsTemp Entity
/// </summary>
public class BranchYearsTemp : Entity<BranchYearsTempId>
{
    private BranchYearsTemp() { }

    /// <summary>
    /// The unique identifier for the BranchYearsTemp
    /// المعرف الفريد لـ BranchYearsTemp
    /// </summary>
    public BranchYearsTempId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchYearsTemp
    /// BranchNumber الخاص بـ BranchYearsTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchYearsTemp
    /// BranchYear الخاص بـ BranchYearsTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// Username of the BranchYearsTemp
    /// Username الخاص بـ BranchYearsTemp
    /// </summary>
    public string Username { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchYearsTemp
    /// CompanyNumberShort الخاص بـ BranchYearsTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the BranchYearsTemp
    /// BranchUser الخاص بـ BranchYearsTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
