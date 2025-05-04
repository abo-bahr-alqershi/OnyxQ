using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// Branch Entity
/// </summary>
public class Branch : Entity<BranchId>
{
    private Branch() { }

    /// <summary>
    /// The unique identifier for the Branch
    /// المعرف الفريد لـ Branch
    /// </summary>
    public BranchId Id { get; private set; }

    /// <summary>
    /// CompanyGroup of the Branch
    /// CompanyGroup الخاص بـ Branch
    /// </summary>
    public decimal? CompanyGroup { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Branch
    /// CompanyNumberShort الخاص بـ Branch
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the Branch
    /// BranchNumber الخاص بـ Branch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the Branch
    /// BranchYear الخاص بـ Branch
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the Branch
    /// BranchUser الخاص بـ Branch
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchLastName of the Branch
    /// BranchLastName الخاص بـ Branch
    /// </summary>
    public string BranchLastName { get; private set; }

    /// <summary>
    /// BranchFirstName of the Branch
    /// BranchFirstName الخاص بـ Branch
    /// </summary>
    public string BranchFirstName { get; private set; }
}
}
