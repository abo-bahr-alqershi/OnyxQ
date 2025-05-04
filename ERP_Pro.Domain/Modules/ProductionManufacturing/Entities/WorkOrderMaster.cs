using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// WorkOrderMaster Entity
/// </summary>
public class WorkOrderMaster : Entity<WorkOrderMasterId>
{

    private WorkOrderMaster() { }

    public WorkOrderMaster(WorkOrderMasterId id, decimal? workOrderSerial)
    {
        Id = id;
        WorkOrderSerial = workOrderSerial;
    }

    /// <summary>
    /// The unique identifier for the WorkOrderMaster
    /// المعرف الفريد لـ WorkOrderMaster
    /// </summary>
    public WorkOrderMasterId Id { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the WorkOrderMaster
    /// WorkOrderNumber الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the WorkOrderMaster
    /// WorkOrderSerial الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// WorkOrderDate of the WorkOrderMaster
    /// WorkOrderDate الخاص بـ WorkOrderMaster
    /// </summary>
    public DateTime? WorkOrderDate { get; private set; }

    /// <summary>
    /// AccountRate of the WorkOrderMaster
    /// AccountRate الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// StockRate of the WorkOrderMaster
    /// StockRate الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// CCode of the WorkOrderMaster
    /// CCode الخاص بـ WorkOrderMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the WorkOrderMaster
    /// CName الخاص بـ WorkOrderMaster
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// CostCenterCode of the WorkOrderMaster
    /// CostCenterCode الخاص بـ WorkOrderMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// DocDesc of the WorkOrderMaster
    /// DocDesc الخاص بـ WorkOrderMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the WorkOrderMaster
    /// ReferenceNumber الخاص بـ WorkOrderMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReceiverNumber of the WorkOrderMaster
    /// ReceiverNumber الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? ReceiverNumber { get; private set; }

    /// <summary>
    /// EngineerCode of the WorkOrderMaster
    /// EngineerCode الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? EngineerCode { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the WorkOrderMaster
    /// ProcessedFlagFull الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// Field1 of the WorkOrderMaster
    /// Field1 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the WorkOrderMaster
    /// Field2 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the WorkOrderMaster
    /// Field3 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the WorkOrderMaster
    /// Field4 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the WorkOrderMaster
    /// Field5 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the WorkOrderMaster
    /// Field6 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the WorkOrderMaster
    /// Field7 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the WorkOrderMaster
    /// Field8 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the WorkOrderMaster
    /// Field9 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the WorkOrderMaster
    /// Field10 الخاص بـ WorkOrderMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ReceiveSerial of the WorkOrderMaster
    /// ReceiveSerial الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? ReceiveSerial { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WorkOrderMaster
    /// CompanyNumberShort الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WorkOrderMaster
    /// BranchNumber الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WorkOrderMaster
    /// BranchYear الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WorkOrderMaster
    /// BranchUser الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the WorkOrderMaster
    /// CalcTaxFreeQuantityFlag الخاص بـ WorkOrderMaster
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// CreatedDateClock of the WorkOrderMaster
    /// CreatedDateClock الخاص بـ WorkOrderMaster
    /// </summary>
    public DateTime? CreatedDateClock { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public WorkOrderType WorkOrderType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
