using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionSlice Entity
/// </summary>
public class SalesmanCommissionSlice : Entity<SalesmanCommissionSliceId>
{
    private SalesmanCommissionSlice() { }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionSlice
    /// المعرف الفريد لـ SalesmanCommissionSlice
    /// </summary>
    public SalesmanCommissionSliceId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the SalesmanCommissionSlice
    /// RecordNumber الخاص بـ SalesmanCommissionSlice
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// FAmount of the SalesmanCommissionSlice
    /// FAmount الخاص بـ SalesmanCommissionSlice
    /// </summary>
    public decimal? FAmount { get; private set; }

    /// <summary>
    /// TAmount of the SalesmanCommissionSlice
    /// TAmount الخاص بـ SalesmanCommissionSlice
    /// </summary>
    public decimal? TAmount { get; private set; }

    /// <summary>
    /// CommissionPercent of the SalesmanCommissionSlice
    /// CommissionPercent الخاص بـ SalesmanCommissionSlice
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanCommissionSlice
    /// RepCode الخاص بـ SalesmanCommissionSlice
    /// </summary>
    public string RepCode { get; private set; }
}
}
