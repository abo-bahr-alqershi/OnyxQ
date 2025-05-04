using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesOrderType Entity
/// </summary>
public class SalesOrderType : Entity<SalesOrderTypeId>
{
    private SalesOrderType() { }

    /// <summary>
    /// The unique identifier for the SalesOrderType
    /// المعرف الفريد لـ SalesOrderType
    /// </summary>
    public SalesOrderTypeId Id { get; private set; }

    /// <summary>
    /// SalesOrderType of the SalesOrderType
    /// SalesOrderType الخاص بـ SalesOrderType
    /// </summary>
    public decimal? SalesOrderType { get; private set; }

    /// <summary>
    /// SalesOrderNameArabic of the SalesOrderType
    /// SalesOrderNameArabic الخاص بـ SalesOrderType
    /// </summary>
    public string SalesOrderNameArabic { get; private set; }

    /// <summary>
    /// SalesOrderNameEnglish of the SalesOrderType
    /// SalesOrderNameEnglish الخاص بـ SalesOrderType
    /// </summary>
    public string SalesOrderNameEnglish { get; private set; }

    /// <summary>
    /// SalesOrderSerial of the SalesOrderType
    /// SalesOrderSerial الخاص بـ SalesOrderType
    /// </summary>
    public decimal? SalesOrderSerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: SalesOrderType to SalesOrder
    /// </summary>
    public IReadOnlyCollection<SalesOrder> SalesOrders { get; private set; }
    /// <summary>
    /// One-to-many relationship: SalesOrderType to DefaultDataOnline
    /// </summary>
    public IReadOnlyCollection<DefaultDataOnline> DefaultDataOnlines { get; private set; }
    #endregion
}
}
