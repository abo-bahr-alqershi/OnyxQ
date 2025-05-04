using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// ReturnSalesReason Entity
/// </summary>
public class ReturnSalesReason : Entity<ReturnSalesReasonId>
{
    private ReturnSalesReason() { }

    /// <summary>
    /// The unique identifier for the ReturnSalesReason
    /// المعرف الفريد لـ ReturnSalesReason
    /// </summary>
    public ReturnSalesReasonId Id { get; private set; }

    /// <summary>
    /// ReservationType of the ReturnSalesReason
    /// ReservationType الخاص بـ ReturnSalesReason
    /// </summary>
    public decimal? ReservationType { get; private set; }

    /// <summary>
    /// ReservationLastName of the ReturnSalesReason
    /// ReservationLastName الخاص بـ ReturnSalesReason
    /// </summary>
    public string ReservationLastName { get; private set; }

    /// <summary>
    /// ReservationFirstName of the ReturnSalesReason
    /// ReservationFirstName الخاص بـ ReturnSalesReason
    /// </summary>
    public string ReservationFirstName { get; private set; }
}
}
