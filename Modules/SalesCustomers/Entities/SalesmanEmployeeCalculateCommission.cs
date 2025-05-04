using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanEmployeeCalculateCommission Entity
/// </summary>
public class SalesmanEmployeeCalculateCommission : Entity<SalesmanEmployeeCalculateCommissionId>
{
    private SalesmanEmployeeCalculateCommission() { }

    /// <summary>
    /// The unique identifier for the SalesmanEmployeeCalculateCommission
    /// المعرف الفريد لـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public SalesmanEmployeeCalculateCommissionId Id { get; private set; }

    /// <summary>
    /// CommissionNumber of the SalesmanEmployeeCalculateCommission
    /// CommissionNumber الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? CommissionNumber { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanEmployeeCalculateCommission
    /// RepCode الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ItemCode of the SalesmanEmployeeCalculateCommission
    /// ItemCode الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesmanEmployeeCalculateCommission
    /// ItemUnit الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the SalesmanEmployeeCalculateCommission
    /// PSize الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// EmpNo of the SalesmanEmployeeCalculateCommission
    /// EmpNo الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// SalesAmount of the SalesmanEmployeeCalculateCommission
    /// SalesAmount الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? SalesAmount { get; private set; }

    /// <summary>
    /// CommissionPercent of the SalesmanEmployeeCalculateCommission
    /// CommissionPercent الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanEmployeeCalculateCommission
    /// CommissionAmount الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionSerial of the SalesmanEmployeeCalculateCommission
    /// CommissionSerial الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? CommissionSerial { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesmanEmployeeCalculateCommission
    /// BranchNumber الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesmanEmployeeCalculateCommission
    /// BranchYear الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesmanEmployeeCalculateCommission
    /// CompanyNumberShort الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the SalesmanEmployeeCalculateCommission
    /// BranchUser الخاص بـ SalesmanEmployeeCalculateCommission
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
