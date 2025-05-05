using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CashCustomerPointTrace Entity
/// </summary>
public class CashCustomerPointTrace : Entity<CashCustomerPointTraceId>
{

    private CashCustomerPointTrace() { }

    public CashCustomerPointTrace(CashCustomerPointTraceId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CashCustomerPointTrace
    /// المعرف الفريد لـ CashCustomerPointTrace
    /// </summary>
    public CashCustomerPointTraceId Id { get; private set; }

    /// <summary>
    /// CustCode of the CashCustomerPointTrace
    /// CustCode الخاص بـ CashCustomerPointTrace
    /// </summary>
    public string CustCode { get; private set; }

    /// <summary>
    /// PointTypeNumber of the CashCustomerPointTrace
    /// PointTypeNumber الخاص بـ CashCustomerPointTrace
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// PointTypeActiveDate of the CashCustomerPointTrace
    /// PointTypeActiveDate الخاص بـ CashCustomerPointTrace
    /// </summary>
    public DateTime? PointTypeActiveDate { get; private set; }

    /// <summary>
    /// CreditNoDiscount of the CashCustomerPointTrace
    /// CreditNoDiscount الخاص بـ CashCustomerPointTrace
    /// </summary>
    public string CreditNoDiscount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

