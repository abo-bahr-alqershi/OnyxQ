using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerSalesman Entity
/// </summary>
public class CustomerSalesman : Entity<CustomerSalesmanId>
{
    private CustomerSalesman() { }

    /// <summary>
    /// The unique identifier for the CustomerSalesman
    /// المعرف الفريد لـ CustomerSalesman
    /// </summary>
    public CustomerSalesmanId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerSalesman
    /// CCode الخاص بـ CustomerSalesman
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// RepCode of the CustomerSalesman
    /// RepCode الخاص بـ CustomerSalesman
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// FieldDay1 of the CustomerSalesman
    /// FieldDay1 الخاص بـ CustomerSalesman
    /// </summary>
    public decimal? FieldDay1 { get; private set; }

    /// <summary>
    /// FieldDay2 of the CustomerSalesman
    /// FieldDay2 الخاص بـ CustomerSalesman
    /// </summary>
    public decimal? FieldDay2 { get; private set; }

    /// <summary>
    /// FieldDay3 of the CustomerSalesman
    /// FieldDay3 الخاص بـ CustomerSalesman
    /// </summary>
    public decimal? FieldDay3 { get; private set; }

    /// <summary>
    /// FieldDay4 of the CustomerSalesman
    /// FieldDay4 الخاص بـ CustomerSalesman
    /// </summary>
    public decimal? FieldDay4 { get; private set; }

    /// <summary>
    /// FieldDay5 of the CustomerSalesman
    /// FieldDay5 الخاص بـ CustomerSalesman
    /// </summary>
    public decimal? FieldDay5 { get; private set; }

    /// <summary>
    /// FieldDay6 of the CustomerSalesman
    /// FieldDay6 الخاص بـ CustomerSalesman
    /// </summary>
    public decimal? FieldDay6 { get; private set; }

    /// <summary>
    /// FieldDay7 of the CustomerSalesman
    /// FieldDay7 الخاص بـ CustomerSalesman
    /// </summary>
    public decimal? FieldDay7 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion
}
}
