using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerLimitSale Entity
/// </summary>
public class CustomerLimitSale : Entity<CustomerLimitSaleId>
{

    private CustomerLimitSale() { }

    public CustomerLimitSale(CustomerLimitSaleId id, DateTime? fDate, DateTime? tDate)
    {
        Id = id;
        FDate = fDate;
        TDate = tDate;
    }

    /// <summary>
    /// The unique identifier for the CustomerLimitSale
    /// المعرف الفريد لـ CustomerLimitSale
    /// </summary>
    public CustomerLimitSaleId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the CustomerLimitSale
    /// RecordNumber الخاص بـ CustomerLimitSale
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// FDate of the CustomerLimitSale
    /// FDate الخاص بـ CustomerLimitSale
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CustomerLimitSale
    /// TDate الخاص بـ CustomerLimitSale
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// Amount of the CustomerLimitSale
    /// Amount الخاص بـ CustomerLimitSale
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// LimitDescriptionShort of the CustomerLimitSale
    /// LimitDescriptionShort الخاص بـ CustomerLimitSale
    /// </summary>
    public string LimitDescriptionShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerCurrency CustomerCurrency { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

