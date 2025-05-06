using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// WorkOrderType Entity
/// </summary>
public class WorkOrderType : Entity<WorkOrderTypeId>
{

    private WorkOrderType() { }

    public WorkOrderType(WorkOrderTypeId id, decimal? workOrderTypeNumber)
    {
        Id = id;
        WorkOrderTypeNumber = workOrderTypeNumber;
    }

    /// <summary>
    /// The unique identifier for the WorkOrderType
    /// المعرف الفريد لـ WorkOrderType
    /// </summary>
    public WorkOrderTypeId Id { get; private set; }

    /// <summary>
    /// WorkOrderTypeNumber of the WorkOrderType
    /// WorkOrderTypeNumber الخاص بـ WorkOrderType
    /// </summary>
    public decimal? WorkOrderTypeNumber { get; private set; }

    /// <summary>
    /// WorkOrderNameArabic of the WorkOrderType
    /// WorkOrderNameArabic الخاص بـ WorkOrderType
    /// </summary>
    public string WorkOrderNameArabic { get; private set; }

    /// <summary>
    /// WorkOrderNameEnglish of the WorkOrderType
    /// WorkOrderNameEnglish الخاص بـ WorkOrderType
    /// </summary>
    public string WorkOrderNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

