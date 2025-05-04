using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerTransactionGps Entity
/// </summary>
public class CustomerTransactionGps : Entity<CustomerTransactionGpsId>
{
    private CustomerTransactionGps() { }

    /// <summary>
    /// The unique identifier for the CustomerTransactionGps
    /// المعرف الفريد لـ CustomerTransactionGps
    /// </summary>
    public CustomerTransactionGpsId Id { get; private set; }

    /// <summary>
    /// DocTyp of the CustomerTransactionGps
    /// DocTyp الخاص بـ CustomerTransactionGps
    /// </summary>
    public decimal? DocTyp { get; private set; }

    /// <summary>
    /// DocSrl of the CustomerTransactionGps
    /// DocSrl الخاص بـ CustomerTransactionGps
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// CCode of the CustomerTransactionGps
    /// CCode الخاص بـ CustomerTransactionGps
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// GpsLongitudeXShort of the CustomerTransactionGps
    /// GpsLongitudeXShort الخاص بـ CustomerTransactionGps
    /// </summary>
    public string GpsLongitudeXShort { get; private set; }

    /// <summary>
    /// GpsLatitudeYShort of the CustomerTransactionGps
    /// GpsLatitudeYShort الخاص بـ CustomerTransactionGps
    /// </summary>
    public string GpsLatitudeYShort { get; private set; }
}
}
