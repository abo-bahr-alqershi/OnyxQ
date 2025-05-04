using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// OutgoingType Entity
/// </summary>
public class OutgoingType : Entity<OutgoingTypeId>
{

    private OutgoingType() { }

    public OutgoingType(OutgoingTypeId id, decimal? outgoingTypeFull)
    {
        Id = id;
        OutgoingTypeFull = outgoingTypeFull;
    }

    /// <summary>
    /// The unique identifier for the OutgoingType
    /// المعرف الفريد لـ OutgoingType
    /// </summary>
    public OutgoingTypeId Id { get; private set; }

    /// <summary>
    /// OutgoingTypeFull of the OutgoingType
    /// OutgoingTypeFull الخاص بـ OutgoingType
    /// </summary>
    public decimal? OutgoingTypeFull { get; private set; }

    /// <summary>
    /// OutgoingName of the OutgoingType
    /// OutgoingName الخاص بـ OutgoingType
    /// </summary>
    public string OutgoingName { get; private set; }

    /// <summary>
    /// OutgoingNameEnglish of the OutgoingType
    /// OutgoingNameEnglish الخاص بـ OutgoingType
    /// </summary>
    public string OutgoingNameEnglish { get; private set; }

    /// <summary>
    /// OutgoingSerialReference of the OutgoingType
    /// OutgoingSerialReference الخاص بـ OutgoingType
    /// </summary>
    public decimal? OutgoingSerialReference { get; private set; }

    /// <summary>
    /// ToAssets of the OutgoingType
    /// ToAssets الخاص بـ OutgoingType
    /// </summary>
    public decimal? ToAssets { get; private set; }

    /// <summary>
    /// OutgoingReason of the OutgoingType
    /// OutgoingReason الخاص بـ OutgoingType
    /// </summary>
    public decimal? OutgoingReason { get; private set; }

    /// <summary>
    /// ConnectionWithSalesInvoice of the OutgoingType
    /// ConnectionWithSalesInvoice الخاص بـ OutgoingType
    /// </summary>
    public decimal? ConnectionWithSalesInvoice { get; private set; }

    /// <summary>
    /// OutgoingPmsFlag of the OutgoingType
    /// OutgoingPmsFlag الخاص بـ OutgoingType
    /// </summary>
    public decimal? OutgoingPmsFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
