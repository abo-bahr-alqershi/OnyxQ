using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerMeasure Entity
/// </summary>
public class CustomerMeasure : Entity<CustomerMeasureId>
{
    private CustomerMeasure() { }

    /// <summary>
    /// The unique identifier for the CustomerMeasure
    /// المعرف الفريد لـ CustomerMeasure
    /// </summary>
    public CustomerMeasureId Id { get; private set; }

    /// <summary>
    /// CDegree of the CustomerMeasure
    /// CDegree الخاص بـ CustomerMeasure
    /// </summary>
    public decimal? CDegree { get; private set; }

    /// <summary>
    /// FlagValue of the CustomerMeasure
    /// FlagValue الخاص بـ CustomerMeasure
    /// </summary>
    public decimal? FlagValue { get; private set; }

    /// <summary>
    /// FlagCode of the CustomerMeasure
    /// FlagCode الخاص بـ CustomerMeasure
    /// </summary>
    public string FlagCode { get; private set; }

    /// <summary>
    /// CompanyType of the CustomerMeasure
    /// CompanyType الخاص بـ CustomerMeasure
    /// </summary>
    public decimal? CompanyType { get; private set; }

    /// <summary>
    /// ArgumentType of the CustomerMeasure
    /// ArgumentType الخاص بـ CustomerMeasure
    /// </summary>
    public decimal? ArgumentType { get; private set; }

    /// <summary>
    /// FromAmountPercent of the CustomerMeasure
    /// FromAmountPercent الخاص بـ CustomerMeasure
    /// </summary>
    public decimal? FromAmountPercent { get; private set; }

    /// <summary>
    /// ToAmountPercent of the CustomerMeasure
    /// ToAmountPercent الخاص بـ CustomerMeasure
    /// </summary>
    public decimal? ToAmountPercent { get; private set; }
}
}
