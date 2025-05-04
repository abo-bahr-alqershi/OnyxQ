using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// AutoSalesOrderMaster Entity
/// </summary>
public class AutoSalesOrderMaster : Entity<AutoSalesOrderMasterId>
{
    private AutoSalesOrderMaster() { }

    /// <summary>
    /// The unique identifier for the AutoSalesOrderMaster
    /// المعرف الفريد لـ AutoSalesOrderMaster
    /// </summary>
    public AutoSalesOrderMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the AutoSalesOrderMaster
    /// DocNo الخاص بـ AutoSalesOrderMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the AutoSalesOrderMaster
    /// DocSrl الخاص بـ AutoSalesOrderMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// CCode of the AutoSalesOrderMaster
    /// CCode الخاص بـ AutoSalesOrderMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// DocSrlRef of the AutoSalesOrderMaster
    /// DocSrlRef الخاص بـ AutoSalesOrderMaster
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// ProcessFlag of the AutoSalesOrderMaster
    /// ProcessFlag الخاص بـ AutoSalesOrderMaster
    /// </summary>
    public decimal? ProcessFlag { get; private set; }

    /// <summary>
    /// DocDate of the AutoSalesOrderMaster
    /// DocDate الخاص بـ AutoSalesOrderMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocNoRef of the AutoSalesOrderMaster
    /// DocNoRef الخاص بـ AutoSalesOrderMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AutoSalesOrderMaster to AutoSalesOrderDetail
    /// </summary>
    public IReadOnlyCollection<AutoSalesOrderDetail> AutoSalesOrderDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
