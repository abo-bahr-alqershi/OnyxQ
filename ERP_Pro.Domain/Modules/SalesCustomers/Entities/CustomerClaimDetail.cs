using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerClaimDetail Entity
/// </summary>
public class CustomerClaimDetail : Entity<CustomerClaimDetailId>
{

    private CustomerClaimDetail() { }

    public CustomerClaimDetail(CustomerClaimDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerClaimDetail
    /// المعرف الفريد لـ CustomerClaimDetail
    /// </summary>
    public CustomerClaimDetailId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerClaimDetail
    /// BranchNumber الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the CustomerClaimDetail
    /// DocNo الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// BillNumber of the CustomerClaimDetail
    /// BillNumber الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the CustomerClaimDetail
    /// BillSerial الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillType of the CustomerClaimDetail
    /// BillType الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? BillType { get; private set; }

    /// <summary>
    /// BillDate of the CustomerClaimDetail
    /// BillDate الخاص بـ CustomerClaimDetail
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// InsurancePersonName of the CustomerClaimDetail
    /// InsurancePersonName الخاص بـ CustomerClaimDetail
    /// </summary>
    public string InsurancePersonName { get; private set; }

    /// <summary>
    /// InsuranceCardNumber of the CustomerClaimDetail
    /// InsuranceCardNumber الخاص بـ CustomerClaimDetail
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// BillAmount of the CustomerClaimDetail
    /// BillAmount الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// InsuranceLoadAmount of the CustomerClaimDetail
    /// InsuranceLoadAmount الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? InsuranceLoadAmount { get; private set; }

    /// <summary>
    /// InsuranceAdditionalLimit of the CustomerClaimDetail
    /// InsuranceAdditionalLimit الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? InsuranceAdditionalLimit { get; private set; }

    /// <summary>
    /// DiscAmt of the CustomerClaimDetail
    /// DiscAmt الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? DiscAmt { get; private set; }

    /// <summary>
    /// NetAmount of the CustomerClaimDetail
    /// NetAmount الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? NetAmount { get; private set; }

    /// <summary>
    /// InsuranceBenefitNumber of the CustomerClaimDetail
    /// InsuranceBenefitNumber الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// InsuranceMedicalNumber of the CustomerClaimDetail
    /// InsuranceMedicalNumber الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? InsuranceMedicalNumber { get; private set; }

    /// <summary>
    /// InsuranceApprovedCode of the CustomerClaimDetail
    /// InsuranceApprovedCode الخاص بـ CustomerClaimDetail
    /// </summary>
    public string InsuranceApprovedCode { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the CustomerClaimDetail
    /// InsuranceCompanyNumber الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// VatAmount of the CustomerClaimDetail
    /// VatAmount الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// OtherAmount of the CustomerClaimDetail
    /// OtherAmount الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? OtherAmount { get; private set; }

    /// <summary>
    /// NetBillAmount of the CustomerClaimDetail
    /// NetBillAmount الخاص بـ CustomerClaimDetail
    /// </summary>
    public decimal? NetBillAmount { get; private set; }

    /// <summary>
    /// RepCode of the CustomerClaimDetail
    /// RepCode الخاص بـ CustomerClaimDetail
    /// </summary>
    public string RepCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CustomerClaimMaster CustomerClaimMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
