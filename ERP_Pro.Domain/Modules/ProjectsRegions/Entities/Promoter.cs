using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.ProjectsRegions.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Promoter Entity
/// </summary>
public class Promoter : Entity<PromoterId>
{

    private Promoter() { }

    public Promoter(PromoterId id, string promoterCode)
    {
        Id = id;
        PromoterCode = promoterCode;
    }

    /// <summary>
    /// The unique identifier for the Promoter
    /// المعرف الفريد لـ Promoter
    /// </summary>
    public PromoterId Id { get; private set; }

    /// <summary>
    /// PromoterCode of the Promoter
    /// PromoterCode الخاص بـ Promoter
    /// </summary>
    public string PromoterCode { get; private set; }

    /// <summary>
    /// PromoterLastName of the Promoter
    /// PromoterLastName الخاص بـ Promoter
    /// </summary>
    public string PromoterLastName { get; private set; }

    /// <summary>
    /// PromoterFirstName of the Promoter
    /// PromoterFirstName الخاص بـ Promoter
    /// </summary>
    public string PromoterFirstName { get; private set; }

    /// <summary>
    /// PromoterPhone of the Promoter
    /// PromoterPhone الخاص بـ Promoter
    /// </summary>
    public string PromoterPhone { get; private set; }

    /// <summary>
    /// PromoterMobile of the Promoter
    /// PromoterMobile الخاص بـ Promoter
    /// </summary>
    public string PromoterMobile { get; private set; }

    /// <summary>
    /// PromoterBox of the Promoter
    /// PromoterBox الخاص بـ Promoter
    /// </summary>
    public string PromoterBox { get; private set; }

    /// <summary>
    /// PromoterFax of the Promoter
    /// PromoterFax الخاص بـ Promoter
    /// </summary>
    public string PromoterFax { get; private set; }

    /// <summary>
    /// PromoterAddress of the Promoter
    /// PromoterAddress الخاص بـ Promoter
    /// </summary>
    public string PromoterAddress { get; private set; }

    /// <summary>
    /// PromoterNote of the Promoter
    /// PromoterNote الخاص بـ Promoter
    /// </summary>
    public string PromoterNote { get; private set; }

    /// <summary>
    /// RouteNumber of the Promoter
    /// RouteNumber الخاص بـ Promoter
    /// </summary>
    public decimal? RouteNumber { get; private set; }

    /// <summary>
    /// SortInRoute of the Promoter
    /// SortInRoute الخاص بـ Promoter
    /// </summary>
    public decimal? SortInRoute { get; private set; }

    /// <summary>
    /// InactiveFlag of the Promoter
    /// InactiveFlag الخاص بـ Promoter
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the Promoter
    /// InactiveDate الخاص بـ Promoter
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Promoter
    /// InactiveReason الخاص بـ Promoter
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// Field1 of the Promoter
    /// Field1 الخاص بـ Promoter
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Promoter
    /// Field2 الخاص بـ Promoter
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Promoter
    /// Field3 الخاص بـ Promoter
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Promoter
    /// Field4 الخاص بـ Promoter
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Promoter
    /// Field5 الخاص بـ Promoter
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Promoter
    /// Field6 الخاص بـ Promoter
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Promoter
    /// Field7 الخاص بـ Promoter
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Promoter
    /// Field8 الخاص بـ Promoter
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Promoter
    /// Field9 الخاص بـ Promoter
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Promoter
    /// Field10 الخاص بـ Promoter
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// SecretKey of the Promoter
    /// SecretKey الخاص بـ Promoter
    /// </summary>
    public string SecretKey { get; private set; }

    /// <summary>
    /// BankNumber of the Promoter
    /// BankNumber الخاص بـ Promoter
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the Promoter
    /// WarehouseCode الخاص بـ Promoter
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CashNumber of the Promoter
    /// CashNumber الخاص بـ Promoter
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// GroupCode of the Promoter
    /// GroupCode الخاص بـ Promoter
    /// </summary>
    public string GroupCode { get; private set; }

    /// <summary>
    /// SalesmanPassword of the Promoter
    /// SalesmanPassword الخاص بـ Promoter
    /// </summary>
    public string SalesmanPassword { get; private set; }

    /// <summary>
    /// UseInvoiceDetails of the Promoter
    /// UseInvoiceDetails الخاص بـ Promoter
    /// </summary>
    public decimal? UseInvoiceDetails { get; private set; }

    /// <summary>
    /// ConnectionSpecialSalesman of the Promoter
    /// ConnectionSpecialSalesman الخاص بـ Promoter
    /// </summary>
    public decimal? ConnectionSpecialSalesman { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public City City { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Country Country { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

