using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerItemLimitSale Entity
/// </summary>
public class CustomerItemLimitSale : Entity<CustomerItemLimitSaleId>
{

    private CustomerItemLimitSale() { }

    public CustomerItemLimitSale(CustomerItemLimitSaleId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerItemLimitSale
    /// المعرف الفريد لـ CustomerItemLimitSale
    /// </summary>
    public CustomerItemLimitSaleId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the CustomerItemLimitSale
    /// RecordNumber الخاص بـ CustomerItemLimitSale
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PSize of the CustomerItemLimitSale
    /// PSize الخاص بـ CustomerItemLimitSale
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the CustomerItemLimitSale
    /// ItemQuantity الخاص بـ CustomerItemLimitSale
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ReportQuantityCount of the CustomerItemLimitSale
    /// ReportQuantityCount الخاص بـ CustomerItemLimitSale
    /// </summary>
    public decimal? ReportQuantityCount { get; private set; }

    /// <summary>
    /// LimitDescriptionShort of the CustomerItemLimitSale
    /// LimitDescriptionShort الخاص بـ CustomerItemLimitSale
    /// </summary>
    public string LimitDescriptionShort { get; private set; }

    /// <summary>
    /// PeriodDay of the CustomerItemLimitSale
    /// PeriodDay الخاص بـ CustomerItemLimitSale
    /// </summary>
    public decimal? PeriodDay { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
