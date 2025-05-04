using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Entities
{
/// <summary>
/// ParaCss Entity
/// </summary>
public class ParaCss : Entity<ParaCssId>
{

    private ParaCss() { }

    public ParaCss(ParaCssId id, decimal? parameterNumber)
    {
        Id = id;
        ParameterNumber = parameterNumber;
    }

    /// <summary>
    /// The unique identifier for the ParaCss
    /// المعرف الفريد لـ ParaCss
    /// </summary>
    public ParaCssId Id { get; private set; }

    /// <summary>
    /// ParameterNumber of the ParaCss
    /// ParameterNumber الخاص بـ ParaCss
    /// </summary>
    public decimal? ParameterNumber { get; private set; }

    /// <summary>
    /// ShowPostedOnlyCustomerStatement of the ParaCss
    /// ShowPostedOnlyCustomerStatement الخاص بـ ParaCss
    /// </summary>
    public decimal? ShowPostedOnlyCustomerStatement { get; private set; }

    /// <summary>
    /// AutoApproved of the ParaCss
    /// AutoApproved الخاص بـ ParaCss
    /// </summary>
    public decimal? AutoApproved { get; private set; }

    /// <summary>
    /// CurCode of the ParaCss
    /// CurCode الخاص بـ ParaCss
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// SalesOrderExpireAfterDay of the ParaCss
    /// SalesOrderExpireAfterDay الخاص بـ ParaCss
    /// </summary>
    public decimal? SalesOrderExpireAfterDay { get; private set; }

    /// <summary>
    /// QuotationExpireAfterDays of the ParaCss
    /// QuotationExpireAfterDays الخاص بـ ParaCss
    /// </summary>
    public decimal? QuotationExpireAfterDays { get; private set; }

    /// <summary>
    /// ReservedPeriodDay of the ParaCss
    /// ReservedPeriodDay الخاص بـ ParaCss
    /// </summary>
    public decimal? ReservedPeriodDay { get; private set; }

    /// <summary>
    /// SalesOrderType of the ParaCss
    /// SalesOrderType الخاص بـ ParaCss
    /// </summary>
    public decimal? SalesOrderType { get; private set; }

    /// <summary>
    /// SalesOrderDescription of the ParaCss
    /// SalesOrderDescription الخاص بـ ParaCss
    /// </summary>
    public string SalesOrderDescription { get; private set; }

    /// <summary>
    /// QuotationType of the ParaCss
    /// QuotationType الخاص بـ ParaCss
    /// </summary>
    public decimal? QuotationType { get; private set; }

    /// <summary>
    /// QuotationDescription of the ParaCss
    /// QuotationDescription الخاص بـ ParaCss
    /// </summary>
    public string QuotationDescription { get; private set; }

    /// <summary>
    /// CostCenterCode of the ParaCss
    /// CostCenterCode الخاص بـ ParaCss
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ParaCss
    /// ProjectNumber الخاص بـ ParaCss
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ParaCss
    /// ActivityNumber الخاص بـ ParaCss
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the ParaCss
    /// WarehouseCode الخاص بـ ParaCss
    /// </summary>
    public string WarehouseCode { get; private set; }

    /// <summary>
    /// BranchUser of the ParaCss
    /// BranchUser الخاص بـ ParaCss
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ParaCss
    /// CompanyNumberShort الخاص بـ ParaCss
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchYear of the ParaCss
    /// BranchYear الخاص بـ ParaCss
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchNumber of the ParaCss
    /// BranchNumber الخاص بـ ParaCss
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// NewItemPeriodDay of the ParaCss
    /// NewItemPeriodDay الخاص بـ ParaCss
    /// </summary>
    public decimal? NewItemPeriodDay { get; private set; }

    /// <summary>
    /// ItemNotStorePeriodDay of the ParaCss
    /// ItemNotStorePeriodDay الخاص بـ ParaCss
    /// </summary>
    public decimal? ItemNotStorePeriodDay { get; private set; }

    /// <summary>
    /// ConnectionCustomerItemActivity of the ParaCss
    /// ConnectionCustomerItemActivity الخاص بـ ParaCss
    /// </summary>
    public decimal? ConnectionCustomerItemActivity { get; private set; }

    /// <summary>
    /// SalesOrderQuantityStoreMethod of the ParaCss
    /// SalesOrderQuantityStoreMethod الخاص بـ ParaCss
    /// </summary>
    public decimal? SalesOrderQuantityStoreMethod { get; private set; }

    /// <summary>
    /// CustomerLimitSalesOrderUnprocessed of the ParaCss
    /// CustomerLimitSalesOrderUnprocessed الخاص بـ ParaCss
    /// </summary>
    public decimal? CustomerLimitSalesOrderUnprocessed { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
