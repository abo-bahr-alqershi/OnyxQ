using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationBillCredit Entity
/// </summary>
public class StationBillCredit : Entity<StationBillCreditId>
{
    private StationBillCredit() { }

    /// <summary>
    /// The unique identifier for the StationBillCredit
    /// المعرف الفريد لـ StationBillCredit
    /// </summary>
    public StationBillCreditId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationBillCredit
    /// DocNo الخاص بـ StationBillCredit
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StationBillCredit
    /// DocSer الخاص بـ StationBillCredit
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// BillNumber of the StationBillCredit
    /// BillNumber الخاص بـ StationBillCredit
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationBillCredit
    /// FuelTypeNumber الخاص بـ StationBillCredit
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// CCode of the StationBillCredit
    /// CCode الخاص بـ StationBillCredit
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the StationBillCredit
    /// ItemQuantity الخاص بـ StationBillCredit
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the StationBillCredit
    /// ItemPriceShort الخاص بـ StationBillCredit
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// IssueDate of the StationBillCredit
    /// IssueDate الخاص بـ StationBillCredit
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// ExpireDate of the StationBillCredit
    /// ExpireDate الخاص بـ StationBillCredit
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BillDescription of the StationBillCredit
    /// BillDescription الخاص بـ StationBillCredit
    /// </summary>
    public string BillDescription { get; private set; }

    /// <summary>
    /// EmpNo of the StationBillCredit
    /// EmpNo الخاص بـ StationBillCredit
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationBillCredit
    /// CostCenterCode الخاص بـ StationBillCredit
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationBillCredit
    /// ProjectNumber الخاص بـ StationBillCredit
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationBillCredit
    /// ActivityNumber الخاص بـ StationBillCredit
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ItemCode of the StationBillCredit
    /// ItemCode الخاص بـ StationBillCredit
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the StationBillCredit
    /// WarehouseCode الخاص بـ StationBillCredit
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CuntrNo of the StationBillCredit
    /// CuntrNo الخاص بـ StationBillCredit
    /// </summary>
    public decimal? CuntrNo { get; private set; }

    /// <summary>
    /// RecordNumber of the StationBillCredit
    /// RecordNumber الخاص بـ StationBillCredit
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// BatchNumber of the StationBillCredit
    /// BatchNumber الخاص بـ StationBillCredit
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DisPer of the StationBillCredit
    /// DisPer الخاص بـ StationBillCredit
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the StationBillCredit
    /// DisAmt الخاص بـ StationBillCredit
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the StationBillCredit
    /// DiscAmtMst الخاص بـ StationBillCredit
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// VatAmount of the StationBillCredit
    /// VatAmount الخاص بـ StationBillCredit
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the StationBillCredit
    /// VatPercent الخاص بـ StationBillCredit
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationBillCredit
    /// CompanyNumberShort الخاص بـ StationBillCredit
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationBillCredit
    /// BranchNumber الخاص بـ StationBillCredit
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationBillCredit
    /// BranchYear الخاص بـ StationBillCredit
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationBillCredit
    /// BranchUser الخاص بـ StationBillCredit
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to StationBillMaster
    /// </summary>
    public StationBillMaster StationBillMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to StationFuelType
    /// </summary>
    public StationFuelType StationFuelType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
