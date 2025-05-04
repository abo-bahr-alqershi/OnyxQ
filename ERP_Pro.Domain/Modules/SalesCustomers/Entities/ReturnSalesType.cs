using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// ReturnSalesType Entity
/// </summary>
public class ReturnSalesType : Entity<ReturnSalesTypeId>
{

    private ReturnSalesType() { }

    public ReturnSalesType(ReturnSalesTypeId id, decimal? salesReturnType)
    {
        Id = id;
        SalesReturnType = salesReturnType;
    }

    /// <summary>
    /// The unique identifier for the ReturnSalesType
    /// المعرف الفريد لـ ReturnSalesType
    /// </summary>
    public ReturnSalesTypeId Id { get; private set; }

    /// <summary>
    /// SalesReturnType of the ReturnSalesType
    /// SalesReturnType الخاص بـ ReturnSalesType
    /// </summary>
    public decimal? SalesReturnType { get; private set; }

    /// <summary>
    /// SalesReturnAccountName of the ReturnSalesType
    /// SalesReturnAccountName الخاص بـ ReturnSalesType
    /// </summary>
    public string SalesReturnAccountName { get; private set; }

    /// <summary>
    /// SalesReturnNameEnglish of the ReturnSalesType
    /// SalesReturnNameEnglish الخاص بـ ReturnSalesType
    /// </summary>
    public string SalesReturnNameEnglish { get; private set; }

    /// <summary>
    /// SalesReturnSerial of the ReturnSalesType
    /// SalesReturnSerial الخاص بـ ReturnSalesType
    /// </summary>
    public decimal? SalesReturnSerial { get; private set; }

    /// <summary>
    /// PriceLevel of the ReturnSalesType
    /// PriceLevel الخاص بـ ReturnSalesType
    /// </summary>
    public decimal? PriceLevel { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
