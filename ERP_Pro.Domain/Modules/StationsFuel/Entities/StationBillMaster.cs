using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;
namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationBillMaster Entity
/// </summary>
public class StationBillMaster : AggregateRoot<StationBillMasterId>
{

    private StationBillMaster() { }

    public StationBillMaster(StationBillMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the StationBillMaster
    /// المعرف الفريد لـ StationBillMaster
    /// </summary>
    public StationBillMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationBillMaster
    /// DocNo الخاص بـ StationBillMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StationBillMaster
    /// DocSer الخاص بـ StationBillMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountCode of the StationBillMaster
    /// AccountCode الخاص بـ StationBillMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// IncomeAccountCode of the StationBillMaster
    /// IncomeAccountCode الخاص بـ StationBillMaster
    /// </summary>
    public string IncomeAccountCode { get; private set; }

    /// <summary>
    /// CurRate of the StationBillMaster
    /// CurRate الخاص بـ StationBillMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// EmpNo of the StationBillMaster
    /// EmpNo الخاص بـ StationBillMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// ReferenceNumber of the StationBillMaster
    /// ReferenceNumber الخاص بـ StationBillMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the StationBillMaster
    /// DocDsc الخاص بـ StationBillMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// Field1 of the StationBillMaster
    /// Field1 الخاص بـ StationBillMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the StationBillMaster
    /// Field2 الخاص بـ StationBillMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the StationBillMaster
    /// Field3 الخاص بـ StationBillMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the StationBillMaster
    /// Field4 الخاص بـ StationBillMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the StationBillMaster
    /// Field5 الخاص بـ StationBillMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the StationBillMaster
    /// Field6 الخاص بـ StationBillMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the StationBillMaster
    /// Field7 الخاص بـ StationBillMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the StationBillMaster
    /// Field8 الخاص بـ StationBillMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the StationBillMaster
    /// Field9 الخاص بـ StationBillMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the StationBillMaster
    /// Field10 الخاص بـ StationBillMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CashAmount of the StationBillMaster
    /// CashAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? CashAmount { get; private set; }

    /// <summary>
    /// CreditAmount of the StationBillMaster
    /// CreditAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// CouponAmount of the StationBillMaster
    /// CouponAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? CouponAmount { get; private set; }

    /// <summary>
    /// BillAmount of the StationBillMaster
    /// BillAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// DecAmt of the StationBillMaster
    /// DecAmt الخاص بـ StationBillMaster
    /// </summary>
    public decimal? DecAmt { get; private set; }

    /// <summary>
    /// IncomeAmount of the StationBillMaster
    /// IncomeAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? IncomeAmount { get; private set; }

    /// <summary>
    /// WarehouseCode of the StationBillMaster
    /// WarehouseCode الخاص بـ StationBillMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// StandByFlag of the StationBillMaster
    /// StandByFlag الخاص بـ StationBillMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// DiscAmt of the StationBillMaster
    /// DiscAmt الخاص بـ StationBillMaster
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// VatAmount of the StationBillMaster
    /// VatAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the StationBillMaster
    /// CalcTypeNumberTax الخاص بـ StationBillMaster
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// WarehouseTransferAmount of the StationBillMaster
    /// WarehouseTransferAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? WarehouseTransferAmount { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationBillMaster
    /// CompanyNumberShort الخاص بـ StationBillMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationBillMaster
    /// BranchNumber الخاص بـ StationBillMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationBillMaster
    /// BranchYear الخاص بـ StationBillMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationBillMaster
    /// BranchUser الخاص بـ StationBillMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocDate of the StationBillMaster
    /// DocDate الخاص بـ StationBillMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AuditReference of the StationBillMaster
    /// AuditReference الخاص بـ StationBillMaster
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the StationBillMaster
    /// AuditReferenceDescription الخاص بـ StationBillMaster
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the StationBillMaster
    /// AuditReferenceUserId الخاص بـ StationBillMaster
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the StationBillMaster
    /// AuditReferenceDate الخاص بـ StationBillMaster
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the StationBillMaster
    /// SalesInvoiceType الخاص بـ StationBillMaster
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// IncomeAccountCodeDetail of the StationBillMaster
    /// IncomeAccountCodeDetail الخاص بـ StationBillMaster
    /// </summary>
    public string IncomeAccountCodeDetail { get; private set; }

    /// <summary>
    /// IncomeAccountDetailType of the StationBillMaster
    /// IncomeAccountDetailType الخاص بـ StationBillMaster
    /// </summary>
    public decimal? IncomeAccountDetailType { get; private set; }

    /// <summary>
    /// DocPst of the StationBillMaster
    /// DocPst الخاص بـ StationBillMaster
    /// </summary>
    public decimal? DocPst { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the StationBillMaster
    /// PeriodNumberShort الخاص بـ StationBillMaster
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationBillMaster
    /// CostCenterCode الخاص بـ StationBillMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationBillMaster
    /// ProjectNumber الخاص بـ StationBillMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationBillMaster
    /// ActivityNumber الخاص بـ StationBillMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// RepCode of the StationBillMaster
    /// RepCode الخاص بـ StationBillMaster
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// OutgoingAmount of the StationBillMaster
    /// OutgoingAmount الخاص بـ StationBillMaster
    /// </summary>
    public decimal? OutgoingAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CashInHandDetail CashInHandDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

