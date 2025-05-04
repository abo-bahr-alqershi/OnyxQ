using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationBillDetail Entity
/// </summary>
public class StationBillDetail : Entity<StationBillDetailId>
{
    private StationBillDetail() { }

    /// <summary>
    /// The unique identifier for the StationBillDetail
    /// المعرف الفريد لـ StationBillDetail
    /// </summary>
    public StationBillDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the StationBillDetail
    /// DocNo الخاص بـ StationBillDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the StationBillDetail
    /// DocSer الخاص بـ StationBillDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// RecordNumber of the StationBillDetail
    /// RecordNumber الخاص بـ StationBillDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CuntrNo of the StationBillDetail
    /// CuntrNo الخاص بـ StationBillDetail
    /// </summary>
    public decimal? CuntrNo { get; private set; }

    /// <summary>
    /// CuntrReadPrev of the StationBillDetail
    /// CuntrReadPrev الخاص بـ StationBillDetail
    /// </summary>
    public decimal? CuntrReadPrev { get; private set; }

    /// <summary>
    /// CuntrReadCrnt of the StationBillDetail
    /// CuntrReadCrnt الخاص بـ StationBillDetail
    /// </summary>
    public decimal? CuntrReadCrnt { get; private set; }

    /// <summary>
    /// ItemQuantity of the StationBillDetail
    /// ItemQuantity الخاص بـ StationBillDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the StationBillDetail
    /// ItemPriceShort الخاص بـ StationBillDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// LastReadDate of the StationBillDetail
    /// LastReadDate الخاص بـ StationBillDetail
    /// </summary>
    public DateTime? LastReadDate { get; private set; }

    /// <summary>
    /// CuntrDsc of the StationBillDetail
    /// CuntrDsc الخاص بـ StationBillDetail
    /// </summary>
    public string CuntrDsc { get; private set; }

    /// <summary>
    /// BatchNumber of the StationBillDetail
    /// BatchNumber الخاص بـ StationBillDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// DisPer of the StationBillDetail
    /// DisPer الخاص بـ StationBillDetail
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// DisAmt of the StationBillDetail
    /// DisAmt الخاص بـ StationBillDetail
    /// </summary>
    public decimal? DisAmt { get; private set; }

    /// <summary>
    /// DiscAmtMst of the StationBillDetail
    /// DiscAmtMst الخاص بـ StationBillDetail
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// CurrentReadDate of the StationBillDetail
    /// CurrentReadDate الخاص بـ StationBillDetail
    /// </summary>
    public DateTime? CurrentReadDate { get; private set; }

    /// <summary>
    /// SalesInvoiceType of the StationBillDetail
    /// SalesInvoiceType الخاص بـ StationBillDetail
    /// </summary>
    public decimal? SalesInvoiceType { get; private set; }

    /// <summary>
    /// ItemCode of the StationBillDetail
    /// ItemCode الخاص بـ StationBillDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the StationBillDetail
    /// WarehouseCode الخاص بـ StationBillDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationBillDetail
    /// FuelTypeNumber الخاص بـ StationBillDetail
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    /// <summary>
    /// EmpNo of the StationBillDetail
    /// EmpNo الخاص بـ StationBillDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// CostCenterCode of the StationBillDetail
    /// CostCenterCode الخاص بـ StationBillDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the StationBillDetail
    /// ProjectNumber الخاص بـ StationBillDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the StationBillDetail
    /// ActivityNumber الخاص بـ StationBillDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// VatAmount of the StationBillDetail
    /// VatAmount الخاص بـ StationBillDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// VatPercent of the StationBillDetail
    /// VatPercent الخاص بـ StationBillDetail
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationBillDetail
    /// CompanyNumberShort الخاص بـ StationBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationBillDetail
    /// BranchNumber الخاص بـ StationBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationBillDetail
    /// BranchYear الخاص بـ StationBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationBillDetail
    /// BranchUser الخاص بـ StationBillDetail
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
    #endregion
}
}
