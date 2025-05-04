using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// TransferPriority Entity
/// </summary>
public class TransferPriority : Entity<TransferPriorityId>
{
    private TransferPriority() { }

    /// <summary>
    /// The unique identifier for the TransferPriority
    /// المعرف الفريد لـ TransferPriority
    /// </summary>
    public TransferPriorityId Id { get; private set; }

    /// <summary>
    /// PriceTypeFull of the TransferPriority
    /// PriceTypeFull الخاص بـ TransferPriority
    /// </summary>
    public decimal? PriceTypeFull { get; private set; }

    /// <summary>
    /// PriceCode of the TransferPriority
    /// PriceCode الخاص بـ TransferPriority
    /// </summary>
    public string PriceCode { get; private set; }

    /// <summary>
    /// PriceOrder of the TransferPriority
    /// PriceOrder الخاص بـ TransferPriority
    /// </summary>
    public decimal? PriceOrder { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TransferPriority
    /// CompanyNumberShort الخاص بـ TransferPriority
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TransferPriority
    /// BranchNumber الخاص بـ TransferPriority
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TransferPriority
    /// BranchYear الخاص بـ TransferPriority
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TransferPriority
    /// BranchUser الخاص بـ TransferPriority
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
