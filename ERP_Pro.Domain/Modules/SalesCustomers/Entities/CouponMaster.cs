using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CouponMaster Entity
/// </summary>
public class CouponMaster : Entity<CouponMasterId>
{

    private CouponMaster() { }

    public CouponMaster(CouponMasterId id, decimal? docNo)
    {
        Id = id;
        DocNo = docNo;
    }

    /// <summary>
    /// The unique identifier for the CouponMaster
    /// المعرف الفريد لـ CouponMaster
    /// </summary>
    public CouponMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the CouponMaster
    /// DocNo الخاص بـ CouponMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the CouponMaster
    /// DocDate الخاص بـ CouponMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CouponCount of the CouponMaster
    /// CouponCount الخاص بـ CouponMaster
    /// </summary>
    public decimal? CouponCount { get; private set; }

    /// <summary>
    /// CouponBookNumber of the CouponMaster
    /// CouponBookNumber الخاص بـ CouponMaster
    /// </summary>
    public string CouponBookNumber { get; private set; }

    /// <summary>
    /// FCouponNumber of the CouponMaster
    /// FCouponNumber الخاص بـ CouponMaster
    /// </summary>
    public string FCouponNumber { get; private set; }

    /// <summary>
    /// TCouponNumber of the CouponMaster
    /// TCouponNumber الخاص بـ CouponMaster
    /// </summary>
    public string TCouponNumber { get; private set; }

    /// <summary>
    /// DocDsc of the CouponMaster
    /// DocDsc الخاص بـ CouponMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CouponMaster
    /// ReferenceNumber الخاص بـ CouponMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// BookNumber of the CouponMaster
    /// BookNumber الخاص بـ CouponMaster
    /// </summary>
    public decimal? BookNumber { get; private set; }

    /// <summary>
    /// BookItemPrice of the CouponMaster
    /// BookItemPrice الخاص بـ CouponMaster
    /// </summary>
    public decimal? BookItemPrice { get; private set; }

    /// <summary>
    /// DstrFlg of the CouponMaster
    /// DstrFlg الخاص بـ CouponMaster
    /// </summary>
    public decimal? DstrFlg { get; private set; }

    /// <summary>
    /// SalaryFlag of the CouponMaster
    /// SalaryFlag الخاص بـ CouponMaster
    /// </summary>
    public decimal? SalaryFlag { get; private set; }

    /// <summary>
    /// ProcessedFlag of the CouponMaster
    /// ProcessedFlag الخاص بـ CouponMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// Field1 of the CouponMaster
    /// Field1 الخاص بـ CouponMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the CouponMaster
    /// Field2 الخاص بـ CouponMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the CouponMaster
    /// Field3 الخاص بـ CouponMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the CouponMaster
    /// Field4 الخاص بـ CouponMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the CouponMaster
    /// Field5 الخاص بـ CouponMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the CouponMaster
    /// Field6 الخاص بـ CouponMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the CouponMaster
    /// Field7 الخاص بـ CouponMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the CouponMaster
    /// Field8 الخاص بـ CouponMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the CouponMaster
    /// Field9 الخاص بـ CouponMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the CouponMaster
    /// Field10 الخاص بـ CouponMaster
    /// </summary>
    public string Field10 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CouponTypeMaster CouponTypeMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
