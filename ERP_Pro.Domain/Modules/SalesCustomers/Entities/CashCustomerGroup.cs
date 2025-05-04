using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CashCustomerGroup Entity
/// </summary>
public class CashCustomerGroup : Entity<CashCustomerGroupId>
{

    private CashCustomerGroup() { }

    public CashCustomerGroup(CashCustomerGroupId id, decimal? custGrpCode)
    {
        Id = id;
        CustGrpCode = custGrpCode;
    }

    /// <summary>
    /// The unique identifier for the CashCustomerGroup
    /// المعرف الفريد لـ CashCustomerGroup
    /// </summary>
    public CashCustomerGroupId Id { get; private set; }

    /// <summary>
    /// CustGrpCode of the CashCustomerGroup
    /// CustGrpCode الخاص بـ CashCustomerGroup
    /// </summary>
    public decimal? CustGrpCode { get; private set; }

    /// <summary>
    /// CustGrpLNm of the CashCustomerGroup
    /// CustGrpLNm الخاص بـ CashCustomerGroup
    /// </summary>
    public string CustGrpLNm { get; private set; }

    /// <summary>
    /// CustGrpFNm of the CashCustomerGroup
    /// CustGrpFNm الخاص بـ CashCustomerGroup
    /// </summary>
    public string CustGrpFNm { get; private set; }

    /// <summary>
    /// SendMessageFlag of the CashCustomerGroup
    /// SendMessageFlag الخاص بـ CashCustomerGroup
    /// </summary>
    public decimal? SendMessageFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
