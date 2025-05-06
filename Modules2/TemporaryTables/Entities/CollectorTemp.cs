using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// CollectorTemp Entity
/// </summary>
public class CollectorTemp : Entity<CollectorTempId>
{

    private CollectorTemp() { }

    public CollectorTemp(CollectorTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CollectorTemp
    /// المعرف الفريد لـ CollectorTemp
    /// </summary>
    public CollectorTempId Id { get; private set; }

    /// <summary>
    /// CCode of the CollectorTemp
    /// CCode الخاص بـ CollectorTemp
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CollectorTemp
    /// AccountCurrency الخاص بـ CollectorTemp
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocType of the CollectorTemp
    /// DocType الخاص بـ CollectorTemp
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocDate of the CollectorTemp
    /// DocDate الخاص بـ CollectorTemp
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CreditAmount of the CollectorTemp
    /// CreditAmount الخاص بـ CollectorTemp
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// CreditAmountForeign of the CollectorTemp
    /// CreditAmountForeign الخاص بـ CollectorTemp
    /// </summary>
    public decimal? CreditAmountForeign { get; private set; }

    /// <summary>
    /// RepCode of the CollectorTemp
    /// RepCode الخاص بـ CollectorTemp
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// TerminalName of the CollectorTemp
    /// TerminalName الخاص بـ CollectorTemp
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CollectorTemp
    /// CompanyNumberShort الخاص بـ CollectorTemp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CollectorTemp
    /// BranchNumber الخاص بـ CollectorTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CollectorTemp
    /// BranchYear الخاص بـ CollectorTemp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CollectorTemp
    /// BranchUser الخاص بـ CollectorTemp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

