using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCommissionCalculationDetail Entity
/// </summary>
public class CustomerCommissionCalculationDetail : Entity<CustomerCommissionCalculationDetailId>
{
    private CustomerCommissionCalculationDetail() { }

    /// <summary>
    /// The unique identifier for the CustomerCommissionCalculationDetail
    /// المعرف الفريد لـ CustomerCommissionCalculationDetail
    /// </summary>
    public CustomerCommissionCalculationDetailId Id { get; private set; }

    /// <summary>
    /// DocSrl of the CustomerCommissionCalculationDetail
    /// DocSrl الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// DocNo of the CustomerCommissionCalculationDetail
    /// DocNo الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CCode of the CustomerCommissionCalculationDetail
    /// CCode الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// ItemCode of the CustomerCommissionCalculationDetail
    /// ItemCode الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the CustomerCommissionCalculationDetail
    /// ItemUnit الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the CustomerCommissionCalculationDetail
    /// PSize الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// BillDocumentType of the CustomerCommissionCalculationDetail
    /// BillDocumentType الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// CommissionAmount of the CustomerCommissionCalculationDetail
    /// CommissionAmount الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the CustomerCommissionCalculationDetail
    /// CommissionDescriptionShort الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CustomerCommissionCalculationDetail
    /// CompanyNumberShort الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerCommissionCalculationDetail
    /// BranchNumber الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerCommissionCalculationDetail
    /// BranchYear الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CustomerCommissionCalculationDetail
    /// BranchUser الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CommissionPercent of the CustomerCommissionCalculationDetail
    /// CommissionPercent الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// NetSalesAmount of the CustomerCommissionCalculationDetail
    /// NetSalesAmount الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the CustomerCommissionCalculationDetail
    /// RecordNumber الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the CustomerCommissionCalculationDetail
    /// GuarantorCode الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// CommissionICode of the CustomerCommissionCalculationDetail
    /// CommissionICode الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public string CommissionICode { get; private set; }

    /// <summary>
    /// ItemType of the CustomerCommissionCalculationDetail
    /// ItemType الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// GroupNumber of the CustomerCommissionCalculationDetail
    /// GroupNumber الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// CClassTyp of the CustomerCommissionCalculationDetail
    /// CClassTyp الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? CClassTyp { get; private set; }

    /// <summary>
    /// DocSeq of the CustomerCommissionCalculationDetail
    /// DocSeq الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// CommissionIQuantity of the CustomerCommissionCalculationDetail
    /// CommissionIQuantity الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionIQuantity { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the CustomerCommissionCalculationDetail
    /// NetSalesQuantity الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// PaymentPercentShort of the CustomerCommissionCalculationDetail
    /// PaymentPercentShort الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? PaymentPercentShort { get; private set; }

    /// <summary>
    /// PaymentAmount of the CustomerCommissionCalculationDetail
    /// PaymentAmount الخاص بـ CustomerCommissionCalculationDetail
    /// </summary>
    public decimal? PaymentAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerCommissionCalculationMaster
    /// </summary>
    public CustomerCommissionCalculationMaster CustomerCommissionCalculationMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
