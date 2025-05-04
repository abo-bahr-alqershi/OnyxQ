using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SubCustomerMeasureDetail Entity
/// </summary>
public class SubCustomerMeasureDetail : Entity<SubCustomerMeasureDetailId>
{
    private SubCustomerMeasureDetail() { }

    /// <summary>
    /// The unique identifier for the SubCustomerMeasureDetail
    /// المعرف الفريد لـ SubCustomerMeasureDetail
    /// </summary>
    public SubCustomerMeasureDetailId Id { get; private set; }

    /// <summary>
    /// MeasureNumber of the SubCustomerMeasureDetail
    /// MeasureNumber الخاص بـ SubCustomerMeasureDetail
    /// </summary>
    public string MeasureNumber { get; private set; }

    /// <summary>
    /// MeasureValue of the SubCustomerMeasureDetail
    /// MeasureValue الخاص بـ SubCustomerMeasureDetail
    /// </summary>
    public string MeasureValue { get; private set; }

    /// <summary>
    /// MeasureDescription of the SubCustomerMeasureDetail
    /// MeasureDescription الخاص بـ SubCustomerMeasureDetail
    /// </summary>
    public string MeasureDescription { get; private set; }

    /// <summary>
    /// ItemCode of the SubCustomerMeasureDetail
    /// ItemCode الخاص بـ SubCustomerMeasureDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// CCode of the SubCustomerMeasureDetail
    /// CCode الخاص بـ SubCustomerMeasureDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// SubCustomerCode of the SubCustomerMeasureDetail
    /// SubCustomerCode الخاص بـ SubCustomerMeasureDetail
    /// </summary>
    public string SubCustomerCode { get; private set; }

    /// <summary>
    /// DocSeq of the SubCustomerMeasureDetail
    /// DocSeq الخاص بـ SubCustomerMeasureDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to SubCustomerMeasureMaster
    /// </summary>
    public SubCustomerMeasureMaster SubCustomerMeasureMaster { get; private set; }
    #endregion
}
}
