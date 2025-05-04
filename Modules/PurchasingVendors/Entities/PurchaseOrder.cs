using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseOrder Entity
/// </summary>
public class PurchaseOrder : Entity<PurchaseOrderId>
{
    private PurchaseOrder() { }

    /// <summary>
    /// The unique identifier for the PurchaseOrder
    /// المعرف الفريد لـ PurchaseOrder
    /// </summary>
    public PurchaseOrderId Id { get; private set; }

    /// <summary>
    /// PurchaseOrderType of the PurchaseOrder
    /// PurchaseOrderType الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderType { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the PurchaseOrder
    /// PurchaseOrderNumber الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderSerial of the PurchaseOrder
    /// PurchaseOrderSerial الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderSerial { get; private set; }

    /// <summary>
    /// PurchaseOrderDate of the PurchaseOrder
    /// PurchaseOrderDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? PurchaseOrderDate { get; private set; }

    /// <summary>
    /// VendorCode of the PurchaseOrder
    /// VendorCode الخاص بـ PurchaseOrder
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the PurchaseOrder
    /// VendorName الخاص بـ PurchaseOrder
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// CurCode of the PurchaseOrder
    /// CurCode الخاص بـ PurchaseOrder
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchaseOrder
    /// CostCenterCode الخاص بـ PurchaseOrder
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchaseOrder
    /// ProjectNumber الخاص بـ PurchaseOrder
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchaseOrder
    /// ActivityNumber الخاص بـ PurchaseOrder
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderProcessed of the PurchaseOrder
    /// PurchaseOrderProcessed الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderProcessed { get; private set; }

    /// <summary>
    /// PurchaseOrderDescription of the PurchaseOrder
    /// PurchaseOrderDescription الخاص بـ PurchaseOrder
    /// </summary>
    public string PurchaseOrderDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PurchaseOrder
    /// ReferenceNumber الخاص بـ PurchaseOrder
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderPartial of the PurchaseOrder
    /// PurchaseOrderPartial الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderPartial { get; private set; }

    /// <summary>
    /// PurchaseOrderClosed of the PurchaseOrder
    /// PurchaseOrderClosed الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderClosed { get; private set; }

    /// <summary>
    /// DiscAmt of the PurchaseOrder
    /// DiscAmt الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// InspectFlag of the PurchaseOrder
    /// InspectFlag الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? InspectFlag { get; private set; }

    /// <summary>
    /// EntryNumber of the PurchaseOrder
    /// EntryNumber الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? EntryNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the PurchaseOrder
    /// InactiveFlag الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the PurchaseOrder
    /// InactivatedByUserId الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the PurchaseOrder
    /// InactiveDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the PurchaseOrder
    /// InactiveReason الخاص بـ PurchaseOrder
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ApprovedFlag of the PurchaseOrder
    /// ApprovedFlag الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the PurchaseOrder
    /// ApprovalUserId الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the PurchaseOrder
    /// ApprovalDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the PurchaseOrder
    /// ApprovalDescription الخاص بـ PurchaseOrder
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// ReservationInactive of the PurchaseOrder
    /// ReservationInactive الخاص بـ PurchaseOrder
    /// </summary>
    public string ReservationInactive { get; private set; }

    /// <summary>
    /// PurchaseType of the PurchaseOrder
    /// PurchaseType الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseType { get; private set; }

    /// <summary>
    /// InsuranceTerms of the PurchaseOrder
    /// InsuranceTerms الخاص بـ PurchaseOrder
    /// </summary>
    public string InsuranceTerms { get; private set; }

    /// <summary>
    /// InsuranceNumberFull of the PurchaseOrder
    /// InsuranceNumberFull الخاص بـ PurchaseOrder
    /// </summary>
    public string InsuranceNumberFull { get; private set; }

    /// <summary>
    /// InsuranceCompany of the PurchaseOrder
    /// InsuranceCompany الخاص بـ PurchaseOrder
    /// </summary>
    public string InsuranceCompany { get; private set; }

    /// <summary>
    /// InsuranceDate of the PurchaseOrder
    /// InsuranceDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? InsuranceDate { get; private set; }

    /// <summary>
    /// PurchaseOrderWithoutOtherAmount of the PurchaseOrder
    /// PurchaseOrderWithoutOtherAmount الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderWithoutOtherAmount { get; private set; }

    /// <summary>
    /// DeliveryDate of the PurchaseOrder
    /// DeliveryDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? DeliveryDate { get; private set; }

    /// <summary>
    /// PlaceDelivery of the PurchaseOrder
    /// PlaceDelivery الخاص بـ PurchaseOrder
    /// </summary>
    public string PlaceDelivery { get; private set; }

    /// <summary>
    /// PaymentTerms of the PurchaseOrder
    /// PaymentTerms الخاص بـ PurchaseOrder
    /// </summary>
    public string PaymentTerms { get; private set; }

    /// <summary>
    /// ModeDispatch of the PurchaseOrder
    /// ModeDispatch الخاص بـ PurchaseOrder
    /// </summary>
    public string ModeDispatch { get; private set; }

    /// <summary>
    /// FreightCurrency of the PurchaseOrder
    /// FreightCurrency الخاص بـ PurchaseOrder
    /// </summary>
    public string FreightCurrency { get; private set; }

    /// <summary>
    /// ContactPerson of the PurchaseOrder
    /// ContactPerson الخاص بـ PurchaseOrder
    /// </summary>
    public string ContactPerson { get; private set; }

    /// <summary>
    /// NeedCheckQuantity of the PurchaseOrder
    /// NeedCheckQuantity الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? NeedCheckQuantity { get; private set; }

    /// <summary>
    /// VendorPurchaseInvoiceNumber of the PurchaseOrder
    /// VendorPurchaseInvoiceNumber الخاص بـ PurchaseOrder
    /// </summary>
    public string VendorPurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// ReceiveDate of the PurchaseOrder
    /// ReceiveDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? ReceiveDate { get; private set; }

    /// <summary>
    /// PurchaseOrderDocumentType of the PurchaseOrder
    /// PurchaseOrderDocumentType الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderDocumentType { get; private set; }

    /// <summary>
    /// DescInsTearms of the PurchaseOrder
    /// DescInsTearms الخاص بـ PurchaseOrder
    /// </summary>
    public string DescInsTearms { get; private set; }

    /// <summary>
    /// DiscAmtMst of the PurchaseOrder
    /// DiscAmtMst الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? DiscAmtMst { get; private set; }

    /// <summary>
    /// DiscAmtDtl of the PurchaseOrder
    /// DiscAmtDtl الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? DiscAmtDtl { get; private set; }

    /// <summary>
    /// PurchaseOrderChecked of the PurchaseOrder
    /// PurchaseOrderChecked الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderChecked { get; private set; }

    /// <summary>
    /// PurchaseOrderLocked of the PurchaseOrder
    /// PurchaseOrderLocked الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? PurchaseOrderLocked { get; private set; }

    /// <summary>
    /// BillNumberVoucherCode of the PurchaseOrder
    /// BillNumberVoucherCode الخاص بـ PurchaseOrder
    /// </summary>
    public string BillNumberVoucherCode { get; private set; }

    /// <summary>
    /// BillDateVoucherCode of the PurchaseOrder
    /// BillDateVoucherCode الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? BillDateVoucherCode { get; private set; }

    /// <summary>
    /// CalcVatPriceType of the PurchaseOrder
    /// CalcVatPriceType الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? CalcVatPriceType { get; private set; }

    /// <summary>
    /// Field1 of the PurchaseOrder
    /// Field1 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the PurchaseOrder
    /// Field2 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the PurchaseOrder
    /// Field3 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the PurchaseOrder
    /// Field4 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the PurchaseOrder
    /// Field5 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the PurchaseOrder
    /// Field6 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the PurchaseOrder
    /// Field7 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the PurchaseOrder
    /// Field8 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the PurchaseOrder
    /// Field9 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the PurchaseOrder
    /// Field10 الخاص بـ PurchaseOrder
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ContractNumber of the PurchaseOrder
    /// ContractNumber الخاص بـ PurchaseOrder
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerial of the PurchaseOrder
    /// ContractSerial الخاص بـ PurchaseOrder
    /// </summary>
    public string ContractSerial { get; private set; }

    /// <summary>
    /// ServiceBill of the PurchaseOrder
    /// ServiceBill الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? ServiceBill { get; private set; }

    /// <summary>
    /// AssignedToUserId of the PurchaseOrder
    /// AssignedToUserId الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? AssignedToUserId { get; private set; }

    /// <summary>
    /// AssignedUserId of the PurchaseOrder
    /// AssignedUserId الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? AssignedUserId { get; private set; }

    /// <summary>
    /// AssignedDate of the PurchaseOrder
    /// AssignedDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? AssignedDate { get; private set; }

    /// <summary>
    /// UseVat of the PurchaseOrder
    /// UseVat الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? UseVat { get; private set; }

    /// <summary>
    /// RequiredFreightData of the PurchaseOrder
    /// RequiredFreightData الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? RequiredFreightData { get; private set; }

    /// <summary>
    /// OtherAmount of the PurchaseOrder
    /// OtherAmount الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// VatAmount of the PurchaseOrder
    /// VatAmount الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// ContainerNumber of the PurchaseOrder
    /// ContainerNumber الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? ContainerNumber { get; private set; }

    /// <summary>
    /// FreightListDate of the PurchaseOrder
    /// FreightListDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? FreightListDate { get; private set; }

    /// <summary>
    /// CostingTypeNumber of the PurchaseOrder
    /// CostingTypeNumber الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? CostingTypeNumber { get; private set; }

    /// <summary>
    /// PortOfFreight of the PurchaseOrder
    /// PortOfFreight الخاص بـ PurchaseOrder
    /// </summary>
    public string PortOfFreight { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseOrder
    /// CompanyNumberShort الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseOrder
    /// BranchNumber الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseOrder
    /// BranchYear الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseOrder
    /// BranchUser الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the PurchaseOrder
    /// CalcTypeNumberTax الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// LevelNumberPrice of the PurchaseOrder
    /// LevelNumberPrice الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? LevelNumberPrice { get; private set; }

    /// <summary>
    /// PurchaseOrderCompany of the PurchaseOrder
    /// PurchaseOrderCompany الخاص بـ PurchaseOrder
    /// </summary>
    public string PurchaseOrderCompany { get; private set; }

    /// <summary>
    /// CalcTaxFreeQuantityFlag of the PurchaseOrder
    /// CalcTaxFreeQuantityFlag الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? CalcTaxFreeQuantityFlag { get; private set; }

    /// <summary>
    /// DocMSq of the PurchaseOrder
    /// DocMSq الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? DocMSq { get; private set; }

    /// <summary>
    /// PurchaseOrderExpireDate of the PurchaseOrder
    /// PurchaseOrderExpireDate الخاص بـ PurchaseOrder
    /// </summary>
    public DateTime? PurchaseOrderExpireDate { get; private set; }

    /// <summary>
    /// PurchaseOrderTenderNumber of the PurchaseOrder
    /// PurchaseOrderTenderNumber الخاص بـ PurchaseOrder
    /// </summary>
    public string PurchaseOrderTenderNumber { get; private set; }

    /// <summary>
    /// CurRate of the PurchaseOrder
    /// CurRate الخاص بـ PurchaseOrder
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// PersonManagerCode of the PurchaseOrder
    /// PersonManagerCode الخاص بـ PurchaseOrder
    /// </summary>
    public string PersonManagerCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PurchaseOrderType
    /// </summary>
    public PurchaseOrderType PurchaseOrderType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeRate
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to VoucherDetails
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: PurchaseOrder to PurchaseOrderDetail
    /// </summary>
    public IReadOnlyCollection<PurchaseOrderDetail> PurchaseOrderDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: PurchaseOrder to PurchaseOrderFollowUp
    /// </summary>
    public IReadOnlyCollection<PurchaseOrderFollowUp> PurchaseOrderFollowUps { get; private set; }
    #endregion
}
}
