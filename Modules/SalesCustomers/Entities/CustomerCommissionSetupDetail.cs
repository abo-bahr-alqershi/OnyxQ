using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCommissionSetupDetail Entity
/// </summary>
public class CustomerCommissionSetupDetail : Entity<CustomerCommissionSetupDetailId>
{
    private CustomerCommissionSetupDetail() { }

    /// <summary>
    /// The unique identifier for the CustomerCommissionSetupDetail
    /// المعرف الفريد لـ CustomerCommissionSetupDetail
    /// </summary>
    public CustomerCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the CustomerCommissionSetupDetail
    /// CommissionTypeShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// CCode of the CustomerCommissionSetupDetail
    /// CCode الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CGroupCode of the CustomerCommissionSetupDetail
    /// CGroupCode الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the CustomerCommissionSetupDetail
    /// CClass الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CDegree of the CustomerCommissionSetupDetail
    /// CDegree الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CDegree { get; private set; }

    /// <summary>
    /// RegionCode of the CustomerCommissionSetupDetail
    /// RegionCode الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// ItemCode of the CustomerCommissionSetupDetail
    /// ItemCode الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// GuarantorCode of the CustomerCommissionSetupDetail
    /// GuarantorCode الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the CustomerCommissionSetupDetail
    /// ItemType الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// BillDocumentType of the CustomerCommissionSetupDetail
    /// BillDocumentType الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// FValue of the CustomerCommissionSetupDetail
    /// FValue الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the CustomerCommissionSetupDetail
    /// TValue الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the CustomerCommissionSetupDetail
    /// CommissionAmountTypeShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the CustomerCommissionSetupDetail
    /// CommissionAmount الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the CustomerCommissionSetupDetail
    /// SliceDescription الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the CustomerCommissionSetupDetail
    /// CommissionSliceNumber الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the CustomerCommissionSetupDetail
    /// ItemUnit الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the CustomerCommissionSetupDetail
    /// PSize الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the CustomerCommissionSetupDetail
    /// NetSalesQuantity الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// FPayPercentShort of the CustomerCommissionSetupDetail
    /// FPayPercentShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? FPayPercentShort { get; private set; }

    /// <summary>
    /// TPayPercentShort of the CustomerCommissionSetupDetail
    /// TPayPercentShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? TPayPercentShort { get; private set; }

    /// <summary>
    /// PaymentAmount of the CustomerCommissionSetupDetail
    /// PaymentAmount الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? PaymentAmount { get; private set; }

    /// <summary>
    /// GroupNumber of the CustomerCommissionSetupDetail
    /// GroupNumber الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// CClassTyp of the CustomerCommissionSetupDetail
    /// CClassTyp الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CClassTyp { get; private set; }

    /// <summary>
    /// PaymentPercentShort of the CustomerCommissionSetupDetail
    /// PaymentPercentShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? PaymentPercentShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerCommissionSetupMaster
    /// </summary>
    public CustomerCommissionSetupMaster CustomerCommissionSetupMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerDegree
    /// </summary>
    public CustomerDegree CustomerDegree { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerGroup
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemType
    /// </summary>
    public ItemType ItemType { get; private set; }
    #endregion
}
}
