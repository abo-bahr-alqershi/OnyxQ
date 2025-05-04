using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerFines Entity
/// </summary>
public class CustomerFines : Entity<CustomerFinesId>
{

    private CustomerFines() { }

    public CustomerFines(CustomerFinesId id, decimal? finesNumber)
    {
        Id = id;
        FinesNumber = finesNumber;
    }

    /// <summary>
    /// The unique identifier for the CustomerFines
    /// المعرف الفريد لـ CustomerFines
    /// </summary>
    public CustomerFinesId Id { get; private set; }

    /// <summary>
    /// FinesNumber of the CustomerFines
    /// FinesNumber الخاص بـ CustomerFines
    /// </summary>
    public decimal? FinesNumber { get; private set; }

    /// <summary>
    /// FinesLastName of the CustomerFines
    /// FinesLastName الخاص بـ CustomerFines
    /// </summary>
    public string FinesLastName { get; private set; }

    /// <summary>
    /// FinesFirstName of the CustomerFines
    /// FinesFirstName الخاص بـ CustomerFines
    /// </summary>
    public string FinesFirstName { get; private set; }

    /// <summary>
    /// Notes of the CustomerFines
    /// Notes الخاص بـ CustomerFines
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// TypeCalculation of the CustomerFines
    /// TypeCalculation الخاص بـ CustomerFines
    /// </summary>
    public decimal? TypeCalculation { get; private set; }

    /// <summary>
    /// FinesAmount of the CustomerFines
    /// FinesAmount الخاص بـ CustomerFines
    /// </summary>
    public decimal? FinesAmount { get; private set; }

    /// <summary>
    /// AllowDay of the CustomerFines
    /// AllowDay الخاص بـ CustomerFines
    /// </summary>
    public decimal? AllowDay { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
